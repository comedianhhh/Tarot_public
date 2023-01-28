using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Buttons1;
    public GameObject Buttons2;

    public void SetButtonActive()
    {
        Buttons1.SetActive(true);
        Buttons2.SetActive(true);
    }
}
