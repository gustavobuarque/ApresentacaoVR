using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {
    public GameObject audioHolder;
    public GameObject canvasHolder;

    public void StartSound()
    {
        Debug.Log("Start");
        audioHolder.GetComponent<GvrAudioSource>().Play();
        canvasHolder.SetActive(false);
    }

    public void StopSound()
    {
        Debug.Log("Stop");
        audioHolder.GetComponent<GvrAudioSource>().Pause();
        canvasHolder.SetActive(true);
    }
}