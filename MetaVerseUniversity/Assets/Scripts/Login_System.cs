using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Netcode;
using UnityEngine.UI;
using TMPro;

public class Login_System : NetworkBehaviour
{
    public TMP_InputField Username;
    public TMP_InputField Password;

    public void Login()
    {
        Debug.Log(Username.text);
        
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
        SceneManager.LoadScene(0);
    }
    
    

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "College")
        {
            if (Username.text == "T")
            {
                Debug.Log("Entered College as teacher");
                GameObject NetworkManag = GameObject.FindGameObjectWithTag("Network Manager");
                NetworkManag.GetComponent<NetworkManager>().StartClient();
            }
            else
            {
                Debug.Log("Entered College as student");
                GameObject NetworkManag = GameObject.FindGameObjectWithTag("Network Manager");
                NetworkManag.GetComponent<NetworkManager>().StartClient();
            }
        }
    }
}

