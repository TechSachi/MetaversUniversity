using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Netcode;

public class Login_System : NetworkBehaviour
{
    // Start is called before the first frame update
    public Spawner User;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Login()
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
        SceneManager.LoadScene(0);
    }
    


    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "College")
        {
            Debug.Log("Entered College");
            GameObject NetworkManag = GameObject.FindGameObjectWithTag("Network Manager");
            NetworkManag.GetComponent<NetworkManager>().StartHost();
 
        }
    }
}

