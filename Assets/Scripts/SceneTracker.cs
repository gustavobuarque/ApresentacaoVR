using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SceneTracker : MonoBehaviour
{
    public GameObject _camera;
    static public bool isReturning = false;
    static public int instanceId;
    static public int instanceId2;

    //Position
    static public float _x;
    static public float _y;
    static public float _z;

    //Rotation
    static public float _rx;
    static public float _ry;
    static public float _rz;

    void Awake ()
	{
        DontDestroyOnLoad (gameObject);
        instanceId = gameObject.GetInstanceID(); // Get the ID of the SceneTracker Object when the object awake
    }

    void Start()
    {
        if (isReturning)
        {
            //Do not allow duplicate Scenetracker Objects in the scene
            if (instanceId > instanceId2)
            {
                Object obj = EditorUtility.InstanceIDToObject(instanceId2);
                if (!obj)
                    Debug.LogError("No object could be found with instance id: " + instanceId2);
                else
                    Debug.Log("Object's name: " + obj.name);
                Destroy(obj);
            }
        }
    }
    
	public void ToggleState ()
	{
        isReturning = true;
        instanceId2 = gameObject.GetInstanceID(); // Get the ID of the SceneTracker Object when change the scene
        _x = _camera.transform.position.x;
        _y = _camera.transform.position.y;
        _z = _camera.transform.position.z;
        _rx = _camera.transform.rotation.x;
        _ry = _camera.transform.rotation.y;
        _rz = _camera.transform.rotation.z;
        Debug.Log("RX: " + _rx + "RY: " + _ry + "RZ: " + _rz);
        
        
    }

}
