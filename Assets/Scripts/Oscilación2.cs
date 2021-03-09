using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilación2 : MonoBehaviour
{
    Vector3 origPos;
    float amplitud = 2.1f;

    // Start is called before the first frame update
    void Start()
    {
        origPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = origPos + new Vector3(Mathf.Sin(Time.time) * amplitud, 0, 0);
    }
}
