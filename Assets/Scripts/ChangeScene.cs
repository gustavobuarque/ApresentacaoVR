using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
    public string _scene = "inicio";
    public GameObject FPCamera;
    public bool useCamera = false;
    static Vector3 cameraPosition;
    static Quaternion cameraRotation;

    public void storeCamera()
    {
        // Save coordinates:
        cameraPosition = FPCamera.gameObject.transform.position;
        cameraRotation = FPCamera.gameObject.transform.rotation;
        Debug.Log(cameraPosition);
    }

    public void retrieveCamera()
    {
        // Load coordinates:
        Debug.Log(FPCamera.CompareTag("MainCamera"));
        FPCamera.transform.position = cameraPosition;
        FPCamera.transform.rotation = cameraRotation;
    }

    public void GotoScene()
    {
        if (useCamera)
        {

            storeCamera();
            SceneManager.LoadScene(_scene);
            Debug.Log("usecamera");
        } else
        {
            SceneManager.LoadScene(_scene);
            retrieveCamera();
            Debug.Log(cameraPosition);
        }
    }

}