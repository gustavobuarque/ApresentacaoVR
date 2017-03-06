using UnityEngine;
using System.Collections;


public class GameSound : MonoBehaviour
{

    public GameObject _camera;
    public AudioClip[] soundFiles;

    public AudioSource soundSource;

    float posEdges = 9.87f;

    void Awake()
    {

        soundSource.clip = soundFiles[0];
        soundSource.Play();

    }

    void Update()
    {
        if (_camera.transform.position.x < posEdges)
        {
            Debug.Log("Dentro do Museu");
            soundSource.clip = soundFiles[0];
            soundSource.Play();

        } else
        {
            Debug.Log("Fora do Museu");
            soundSource.clip = soundFiles[1];
            soundSource.Play();
        }
      
    }

    
}