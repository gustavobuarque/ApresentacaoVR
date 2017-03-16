using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTracker : MonoBehaviour
{
    public GameObject _camera;
    static public bool isReturning = false;
    static public float _x;
    static public float _y;
    static public float _z;

    void Awake ()
	{
        DontDestroyOnLoad (gameObject);
	}

	public void ToggleState ()
	{
        isReturning = true;
        
        _x = _camera.transform.position.x;
        _y = _camera.transform.position.y;
        _z = _camera.transform.position.z;
    }

}
