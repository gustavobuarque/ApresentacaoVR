using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCameraTransform : MonoBehaviour
{
    //public GameObject cameraPos;

	void Start ()
	{
        //if (SceneTracker.isReturning) {
        if(SceneTracker.currentScene == "garden-triceratops") {
            transform.position = new Vector3(14f, 1.7f, 4f);
            transform.rotation = Quaternion.Euler(0f, 120f, 0f);
        }
        if (SceneTracker.currentScene == "titanosaur-video")
        {
            transform.position = new Vector3(13f, 1.7f, 4f);
            transform.rotation = Quaternion.Euler(0f, 120f, 0f);
        }
        if (SceneTracker.currentScene == "dianosaur-video")
        {
            transform.position = new Vector3(15f, 1.7f, 4f);
            transform.rotation = Quaternion.Euler(0f, 120f, 0f);
        }


        //}

    }

}
