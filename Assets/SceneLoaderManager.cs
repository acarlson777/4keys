using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;


public class SceneLoaderManager : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(LoadMainScene());
        StartCoroutine(LoadNetworkTestScene());
    }

    IEnumerator LoadMainScene()
    {
        yield return new WaitUntil(()=>NetworkManager.Singleton != null);
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Loading Main Menu");
    }

    IEnumerator LoadNetworkTestScene()
    {
        yield return new WaitUntil(() => NetworkManager.Singleton != null);
        SceneManager.LoadScene("NetworkTestingGround");
        Debug.Log("Loading NetTest");
    }
}