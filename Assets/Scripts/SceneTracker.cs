using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTracker : MonoBehaviour
{

	static public bool isReturning = false;

	void Awake ()
	{
		DontDestroyOnLoad (gameObject);
	}

	public void ToggleState ()
	{
		isReturning = true;
	}

}
