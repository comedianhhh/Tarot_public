using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventCaster : MonoBehaviour
{
    [SerializeField] string m_Tag = "Untagged";
    [SerializeField] LayerMask m_LayerMask;
    [SerializeField] bool m_OnceOnly = false;
    [SerializeField] UnityEvent m_OnTriggerEnter = new UnityEvent();
    [SerializeField] UnityEvent m_OnTriggerExit = new UnityEvent();
    bool m_HasEnterInvoked = false;
    bool m_HasExitInvoked = false;

    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool isInLayer = m_LayerMask == (m_LayerMask | (1 << collision.gameObject.layer));

        if (collision.tag == m_Tag && isInLayer)
        {
            if (m_OnceOnly && m_HasEnterInvoked) return;

            m_OnTriggerEnter.Invoke();
            m_HasEnterInvoked = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        bool isInLayer = m_LayerMask == (m_LayerMask | (1 << collision.gameObject.layer));

        if (collision.tag == m_Tag && isInLayer)
        {
            if (m_OnceOnly && m_HasExitInvoked) return;

            m_OnTriggerExit.Invoke();
            m_HasExitInvoked = true;
        }
    }
}
