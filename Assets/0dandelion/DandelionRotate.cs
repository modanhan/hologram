using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DandelionRotate : MonoBehaviour
{

    public float minX, maxX, speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var r = transform.eulerAngles;
        r.x = Mathf.Lerp(minX, maxX, (Mathf.Cos(Time.time * speed) + 1) * 0.5f);
        transform.eulerAngles = r;
    }
}
