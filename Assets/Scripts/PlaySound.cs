using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {
    public GameObject audioHolder;
    public GameObject canvasHolder;

    public void StartSound()
    {
        Debug.Log("Start");
        audioHolder.GetComponent<AudioSource>().Play();
        canvasHolder.SetActive(false);
    }

    public void StopSound()
    {
        Debug.Log("Pause");
        audioHolder.GetComponent<AudioSource>().Stop();
        canvasHolder.SetActive(true);
    }
}