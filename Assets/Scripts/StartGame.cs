using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {
    public GameObject _canvas;

	void DisableCanvas()
    {
        _canvas.SetActive(false);
    }
}
