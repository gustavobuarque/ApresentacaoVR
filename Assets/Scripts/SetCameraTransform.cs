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
            transform.rotation = Quaternion.Euler(0f, 120f, 0f);
            _canvasInicio.SetActive(false);
            
            //Do not allow duplicate Scenetracker Objects in the scene
            if(SceneTracker.instanceId > SceneTracker.instanceId2)
            {
                Object obj = EditorUtility.InstanceIDToObject(SceneTracker.instanceId2);
                if (!obj)
                    Debug.LogError("No object could be found with instance id: " + SceneTracker.instanceId2);
                else
                    Debug.Log("Object's name: " + obj.name);
                    SceneTracker.Destroy(obj);
            }
            
        }

    }
    
}
