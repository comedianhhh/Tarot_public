using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ImageFader : MonoBehaviour
{
    [SerializeField] float m_Duration = 0.5f;
    [SerializeField] float m_Alpha = 1;
    [SerializeField] bool m_FadeOutOnStart = false;
    Image m_Image;
    // Start is called before the first frame update
    void Start()
    {
        m_Image = GetComponent<Image>();

        Color oriColor = m_Image.color;
        oriColor.a = m_Alpha;
        m_Image.color = oriColor;

        if (m_FadeOutOnStart) FadeOut();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadeIn()
    {
        m_Image.DOKill();
        m_Image.DOFade(m_Alpha, m_Duration);
    }

    public void FadeOut()
    {
        m_Image.DOKill();
        m_Image.DOFade(0, m_Duration);
    }
}
