using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string _scene = "inicio";

    public void GotoScene()
    {
        SceneManager.LoadScene(_scene);
    }

}