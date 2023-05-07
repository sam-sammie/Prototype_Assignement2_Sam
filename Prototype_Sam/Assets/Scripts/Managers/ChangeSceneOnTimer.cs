using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeSceneOnTimer : MonoBehaviour
{
    public string sceneName;

    void Start()
    {
        StartCoroutine(NextScene());
    }


    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(12.5f);
        SceneManager.LoadScene(sceneName);
    }
}
