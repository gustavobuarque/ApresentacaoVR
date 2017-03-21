using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCameraTransform : MonoBehaviour
{
    public GameObject _canvasInicio;

    void Start ()
	{
        if (SceneTracker.isReturning) {
            transform.position = new Vector3(SceneTracker._x, SceneTracker._y, SceneTracker._z);
            GetComponentInChildren<Transform>().transform.rotation = Quaternion.Euler(SceneTracker._rx, SceneTracker._ry, SceneTracker._rz);
            _canvasInicio.SetActive(false);
            Debug.Log("SetCameta RX: " + SceneTracker._rx + "RY: " + SceneTracker._ry + "RZ: " + SceneTracker._rz);
            Debug.Log(GetComponentInChildren<Transform>().transform.rotation);
        }

    }
    
}
