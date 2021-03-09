using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilación : MonoBehaviour
{

    Vector3 origPos;

    // Start is called before the first frame update
    void Start()
    {
        origPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = origPos + new Vector3(0, Mathf.Sin(Time.time) * 2, 0);
    }
}
