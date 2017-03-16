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
            transform.rotation = Quaternion.Euler(0f, 120f, 0f);
            _canvasInicio.SetActive(false);

        }

    }
    
}
