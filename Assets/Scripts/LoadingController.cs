using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingController : MonoBehaviour
{
    public KeyCode _keyCode = KeyCode.Space;
    public GameObject loadingInfo;
    private AsyncOperation async;

    IEnumerator Start()
    {
        async = SceneManager.LoadSceneAsync("Game");
        loadingInfo.SetActive(false);
        yield return true;
        async.allowSceneActivation = false;
        loadingInfo.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(_keyCode)) async.allowSceneActivation = true;
    }
}
