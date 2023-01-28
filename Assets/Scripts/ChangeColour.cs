using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer Sp;
    public Color Color1=new Color(255, 20, 20, 255);
    public Color Color2 = new Color(255, 20, 20, 255);
    void Start()
    {
        Sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Change1()
    {
        Sp.color =Color1;
    }

    public void Change2()
    {
        Sp.color = Color2;
    }

}
