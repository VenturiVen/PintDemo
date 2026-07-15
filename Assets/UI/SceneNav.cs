using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNav : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        Debug.Log("Loading Scene: " +  sceneName);
        SceneManager.LoadScene(sceneName);
    }
}
