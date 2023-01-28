using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileResizer : MonoBehaviour
{
    public float StartScale = 1;
    public float TargetScale = 2;
    public float Speed = 1;

    Vector3 initScale;
    float timer = 0;

    private void Awake()
    {
        initScale = transform.localScale;
    }

    private void OnEnable()
    {
        transform.localScale = initScale * StartScale;
        timer = 0;
    }

    private void Update()
    {
        timer += Time.deltaTime * Speed;
        transform.localScale = Vector3.Lerp(initScale * StartScale, initScale * TargetScale, timer);
    }
}
