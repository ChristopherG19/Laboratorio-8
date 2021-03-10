using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectID : MonoBehaviour
{
    Ray myRay;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DistanciaTags();
    }

    private void DistanciaTags()
    {
        myRay = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit Choque;

        if (Physics.Raycast(myRay.origin, myRay.direction, out Choque, 3.0f)) 
        {
            if (Choque.collider.CompareTag("Chair"))
            {
                Image Boton = GameObject.FindObjectOfType<LevelManager>().BotonF;
                Text objectTag = GameObject.FindObjectOfType<LevelManager>().objectTag;
                Boton.enabled = true;
                objectTag.enabled = true;
                objectTag.text = "Chair";
            }
            else if (Choque.collider.CompareTag("Desk"))
            {
                Image Boton = GameObject.FindObjectOfType<LevelManager>().BotonF;
                Text objectTag = GameObject.FindObjectOfType<LevelManager>().objectTag;
                Boton.enabled = true;
                objectTag.enabled = true;
                objectTag.text = "Desk";
            }
            else if (Choque.collider.CompareTag("Paper"))
            {
                Image Boton = GameObject.FindObjectOfType<LevelManager>().BotonF;
                Text objectTag = GameObject.FindObjectOfType<LevelManager>().objectTag;
                Boton.enabled = true;
                objectTag.enabled = true;
                objectTag.text = "Paper";
            }
            else if (Choque.collider.CompareTag("Board"))
            {
                Image Boton = GameObject.FindObjectOfType<LevelManager>().BotonF;
                Text objectTag = GameObject.FindObjectOfType<LevelManager>().objectTag;
                Boton.enabled = true;
                objectTag.enabled = true;
                objectTag.text = "Board";
            }
            else if (Choque.collider.CompareTag("LunchBox"))
            {
                Image Boton = GameObject.FindObjectOfType<LevelManager>().BotonF;
                Text objectTag = GameObject.FindObjectOfType<LevelManager>().objectTag;
                Boton.enabled = true;
                objectTag.enabled = true;
                objectTag.text = "LunchBox";
            }
            else if (Choque.collider.CompareTag("WorldGlobe"))
            {
                Image Boton = GameObject.FindObjectOfType<LevelManager>().BotonF;
                Text objectTag = GameObject.FindObjectOfType<LevelManager>().objectTag;
                Boton.enabled = true;
                objectTag.enabled = true;
                objectTag.text = "WorldGlobe";
            }
            else if (Choque.collider.CompareTag("Battery"))
            {
                Image Boton = GameObject.FindObjectOfType<LevelManager>().BotonF;
                Text objectTag = GameObject.FindObjectOfType<LevelManager>().objectTag;
                Boton.enabled = true;
                objectTag.enabled = true;
                objectTag.text = "Battery";
            }
            else if (Choque.collider.CompareTag("Shelf"))
            {
                Image Boton = GameObject.FindObjectOfType<LevelManager>().BotonF;
                Text objectTag = GameObject.FindObjectOfType<LevelManager>().objectTag;
                Boton.enabled = true;
                objectTag.enabled = true;
                objectTag.text = "Shelf";
            }
            else if (Choque.collider.CompareTag("First Aid"))
            {
                Image Boton = GameObject.FindObjectOfType<LevelManager>().BotonF;
                Text objectTag = GameObject.FindObjectOfType<LevelManager>().objectTag;
                Boton.enabled = true;
                objectTag.enabled = true;
                objectTag.text = "First Aid";
            }
        }
        else
        {
            Text objectTag = GameObject.FindObjectOfType<LevelManager>().objectTag;
            Image Boton = GameObject.FindObjectOfType<LevelManager>().BotonF;
            Boton.enabled = false;
            objectTag.enabled = false;
        }
    }
}
