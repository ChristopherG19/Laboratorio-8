using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChange : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject MusicaF;
    public GameObject Alarms;

    void Start()
    {
        GetComponent<Light>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        AudioSource Music = MusicaF.GetComponent<AudioSource>();
        Music.Stop();

        AudioSource Alarm = Alarms.GetComponent<AudioSource>();
        Alarm.Play();

        if (other.CompareTag("Player"))
        {
            GetComponent<Light>().enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        AudioSource Alarm = Alarms.GetComponent<AudioSource>();
        Alarm.Stop();

        AudioSource Music = MusicaF.GetComponent<AudioSource>();
        Music.Play();

        if (other.CompareTag("Player"))
        {
            GetComponent<Light>().enabled = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<Light>().intensity = 1 + (Mathf.Sin(Time.time * 4) / 2);
        }
    }

}
