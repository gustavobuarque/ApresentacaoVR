using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCameraTransform : MonoBehaviour
{

	void Start ()
	{

		if (SceneTracker.isReturning) {
			transform.position = new Vector3 (14f, 1.7f, 4f);
			transform.rotation = Quaternion.Euler (0f, 120f, 0f);
		}
		
	}

}
