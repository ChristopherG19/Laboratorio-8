using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectID : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        Image Boton = GameObject.FindObjectOfType<LevelManager>().BotonF;
        Text objectTag = GameObject.FindObjectOfType<LevelManager>().objectTag;
        Boton.enabled = true;
        objectTag.enabled = true;
        objectTag.text = gameObject.name;
    }
    private void OnMouseExit()
    {
        Text objectTag = GameObject.FindObjectOfType<LevelManager>().objectTag;
        Image Boton = GameObject.FindObjectOfType<LevelManager>().BotonF;
        Boton.enabled = false;
        objectTag.enabled = false;
    }

}
