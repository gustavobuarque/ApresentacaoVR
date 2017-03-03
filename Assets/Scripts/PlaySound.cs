using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {
    public GameObject audioHolder;

    public void StartSound()
    {
        Debug.Log("Start");
        audioHolder.GetComponent<GvrAudioSource>().Play();
    }

    public void StopSound()
    {
        Debug.Log("Stop");
        audioHolder.GetComponent<GvrAudioSource>().Stop();
    }
}