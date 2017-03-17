using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    
    void Awake ()
	{
        DontDestroyOnLoad (gameObject);
        instanceId = gameObject.GetInstanceID(); // Get the ID of the SceneTracker Object when the object awake
	}

	public void ToggleState ()
	{
        isReturning = true;
        instanceId2 = gameObject.GetInstanceID(); // Get the ID of the SceneTracker Object when change the scene
        _x = _camera.transform.position.x;
        _y = _camera.transform.position.y;
        _z = _camera.transform.position.z;
    }

}
