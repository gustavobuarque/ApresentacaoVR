using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSlide : MonoBehaviour {

    bool clicked = false;

	// Update is called once per frame
	void Update () {
        if (clicked && transform.position.z < 1.64f)
        {
            transform.Translate(0, 0, 0.5f * Time.deltaTime, Space.World);
            Debug.Log(transform.position.z);
        }
    }

    public void SlideDoor()
    {
        clicked = true;
    }
}