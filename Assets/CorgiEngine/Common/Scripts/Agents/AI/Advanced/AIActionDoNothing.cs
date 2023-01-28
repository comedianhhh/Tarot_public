using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoreMountains.CorgiEngine
{
    /// <summary>
    /// As the name implies, an action that does nothing. Just waits there.
    /// </summary>
	[AddComponentMenu("Corgi Engine/Character/AI/Actions/AI Action Do Nothing")]
    public class AIActionDoNothing : AIAction
    {
        [SerializeField] bool m_HasAnim = false;
        [SerializeField] string m_AnimatorParameterName;
        int m_AnimatorParameter;
        CharacterHorizontalMovement m_CharacterHorizontalMovement;
        Animator m_Animator;
        Character m_Character;
        AIBrain m_AIBrain;
        /// <summary>
        /// On PerformAction we do nothing
        /// </summary>
        /// 
        public override void Initialization()
        {
            if (!m_HasAnim) return;

            m_AIBrain = GetComponent<AIBrain>();
            m_Animator = GetComponentInChildren<Animator>();
            m_Character = this.gameObject.GetComponentInParent<Character>();
            m_CharacterHorizontalMovement = this.gameObject.GetComponentInParent<Character>()?.FindAbility<CharacterHorizontalMovement>();
            m_CharacterHorizontalMovement.RegisterAnimatorParameter(m_AnimatorParameterName, AnimatorControllerParameterType.Bool, out m_AnimatorParameter);
        }

        public override void OnEnterState()
        {
            ActionInProgress = true;

            if (!m_HasAnim) return;
            MMAnimatorExtensions.UpdateAnimatorBool(m_Animator, m_AnimatorParameter, true, m_Character._animatorParameters, m_Character.PerformAnimatorSanityChecks);
            //Debug.LogWarning("AnimatorParameters: " + m_Character._animatorParameters);
        }

        public override void PerformAction()
        {

        }

        public override void OnExitState()
        {
            ActionInProgress = false;

            if (!m_HasAnim) return;
            MMAnimatorExtensions.UpdateAnimatorBool(m_Animator, m_AnimatorParameter, false, m_Character._animatorParameters, m_Character.PerformAnimatorSanityChecks);
        }
    }
}
