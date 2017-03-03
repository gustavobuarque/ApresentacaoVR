using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
    public string _scene = "inicio";
    public GameObject FPCamera;
    Vector3 cameraPosition;
    Quaternion cameraRotation;

    public void storeCamera()
    {
        // Save coordinates:
        cameraPosition = FPCamera.gameObject.transform.position;
        cameraRotation = FPCamera.gameObject.transform.rotation;
    }

    public void retrieveCamera()
    {
        // Load coordinates:
        FPCamera.transform.position = cameraPosition;
        FPCamera.transform.rotation = cameraRotation;
    }


    public void GotoScene()
    {
        storeCamera();
        SceneManager.LoadScene(_scene);
        retrieveCamera();
    }

}