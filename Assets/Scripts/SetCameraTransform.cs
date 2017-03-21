using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SetCameraTransform : MonoBehaviour
{
    public GameObject _canvasInicio;

    void Start ()
	{
        if (SceneTracker.isReturning) {
            transform.position = new Vector3(SceneTracker._x, SceneTracker._y, SceneTracker._z);
            transform.rotation = Quaternion.Euler(SceneTracker._rx, SceneTracker._ry, SceneTracker._rz);
            _canvasInicio.SetActive(false);
            Debug.Log("RX: " + SceneTracker._rx + "RY: " + SceneTracker._ry + "RZ: " + SceneTracker._rz);
        }

    }
    
}
