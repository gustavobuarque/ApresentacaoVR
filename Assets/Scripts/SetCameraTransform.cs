using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCameraTransform : MonoBehaviour
{
    //public GameObject cameraPos;
    


    void Start ()
	{
        if (SceneTracker.isReturning) {
            //Debug.Log(SceneTracker._x + " y " + SceneTracker._y + " z " + SceneTracker._z);
            transform.position = new Vector3(SceneTracker._x, SceneTracker._y, SceneTracker._z);
            transform.rotation = Quaternion.Euler(0f, 120f, 0f);
        }

    }
    
}
