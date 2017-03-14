using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTracker : MonoBehaviour
{

    //static public bool isReturning = false;
    static public string currentScene = "inicio";
    public string currentScene1;
    public string currentScene2;
    public string currentScene3;


	void Awake ()
	{
		DontDestroyOnLoad (gameObject);
	}

	/*public void ToggleState ()
	{
		isReturning = true;
	}*/

    public void SetCurrentScene1()
    {
        currentScene = currentScene1;
    }

    public void SetCurrentScene2()
    {
        currentScene = currentScene2;
    }

    public void SetCurrentScene3()
    {
        currentScene = currentScene3;
    }

}
