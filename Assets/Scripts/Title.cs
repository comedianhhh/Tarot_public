using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator Click;
    public bool CanClick=false;

    void Start()
    {
        Click = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CanClick&& Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("Opening");
        }
    }
    public void SetCanClick()
    {
        CanClick = true;
    }
}
