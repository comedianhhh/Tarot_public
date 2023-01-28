using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PPColorAnimator : MonoBehaviour
{
    public Color DuskColor;
    public Color NightColor;
    PostProcessVolume m_Volume;
    // Start is called before the first frame update
    void Start()
    {
        m_Volume = GetComponent<PostProcessVolume>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TintDusk()
    {
        Tint(DuskColor);
    }

    public void TintNight()
    {
        Tint(NightColor);
    }

    public void Tint(Color color)
    {
        var colorGrading = m_Volume.profile.GetSetting<ColorGrading>();
        colorGrading.colorFilter.value = color;
 
    }
}
