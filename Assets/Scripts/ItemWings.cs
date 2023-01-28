using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using System.Linq;

public class ItemWings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pick()
    {
        var jump = FindObjectsOfType<Character>().ToList().Find(e => e.PlayerID == "Player1").GetComponent<CharacterJump>();
        jump.SetNumberOfJumps(2);
        jump.ResetNumberOfJumps();
    }
}
