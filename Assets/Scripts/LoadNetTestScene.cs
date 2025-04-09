using System.Collections;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadNetTestScene : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(LoadNetworkTestScene());
    }

    IEnumerator LoadNetworkTestScene()
    {
        yield return new WaitUntil(() => NetworkManager.Singleton != null);
        SceneManager.LoadScene("NetworkTestingGround");
        Debug.Log("Loading NetTest");
    }
}