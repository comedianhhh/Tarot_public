using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Rock;
    private float timer;
    public float Interval=4.0f;
    public float RandomImpulseMin = 5;
    public float RandomImpulseMax = 10;
    void Start()
    {
        timer = Interval;
    }

    // Update is called once per frame
    void Update()
    {
        if ((timer -= Time.deltaTime) >= 0)
        {
            return ;
        }

        var rockObj = Instantiate(Rock, transform.position, transform.rotation);
        float direction = Random.Range(0, 2) * 2 - 1;
        float impulse = direction * Random.Range(RandomImpulseMin, RandomImpulseMax);
        //Debug.LogWarning("Impulse: " + impulse);
        rockObj.GetComponent<Rigidbody2D>().AddTorque(impulse, ForceMode2D.Impulse);

        timer = Interval;
    }
}
