using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GardenSoundControl : MonoBehaviour
{
    public GameObject gardenAudioHolder;
    public GameObject museumAudioHolder;
    public GameObject _camera;

    private GvrAudioSource gardenSource;
    private GvrAudioSource museumSource;

    void Start()
    {
        gardenSource = gardenAudioHolder.GetComponent<GvrAudioSource>();
        museumSource = museumAudioHolder.GetComponent<GvrAudioSource>();
    } 

    public void GardenSound()
    {
        Debug.Log(_camera.transform.position.y);
        if (!gardenSource.isPlaying)
        {
            gardenSource.Play();
            museumSource.Stop();
        }
        
    }
    public void MuseumSound()
    {
        if (!museumSource.isPlaying)
        {
            gardenSource.Stop();
            museumSource.Play();
        }

    }
}