using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float Distance = 10;
    [SerializeField] PlayerEnabler[] playerEnablers;

    // Start is called before the first frame update
    void Start()
    {
        playerEnablers = FindObjectsOfType<PlayerEnabler>(true);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var enabler in playerEnablers)
        {
            enabler.gameObject.SetActive(Vector2.Distance(transform.position, enabler.transform.position) <= 10);
        }
    }
}
