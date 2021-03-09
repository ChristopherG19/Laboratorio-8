using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilación3 : MonoBehaviour
{
    Vector3 origPos;
    float amplitud = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        origPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = origPos + new Vector3(0, Mathf.Cos(Time.time) * amplitud, 0);
    }
}
