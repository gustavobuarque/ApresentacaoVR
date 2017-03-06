using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AmbienceSound : MonoBehaviour {
    public GameObject gardenSound;
    public GameObject museumSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Main Camera")
        {
            Debug.Log("sim");
            museumSound.GetComponent<GvrAudioSource>().Stop();
            gardenSound.GetComponent<GvrAudioSource>().Play();
        }
    }
}