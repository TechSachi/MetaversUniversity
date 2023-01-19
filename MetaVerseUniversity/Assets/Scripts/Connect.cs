using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class Connect : MonoBehaviourPunCallbacks
{
    string[] Username = {"T_01", "T_02", "T_03", "S_01", "S_02", "S_03" };
    [SerializeField] private InputField UserName_INP;

    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }



    public void Login()
    {
        
        for(int i = 0; i < Username.Length; i++)
        {
            if (Username[i] == UserName_INP.text)
            {
                if (UserName_INP.text.StartsWith("T") )
                {
                    postlogin(0); 
                }
                else { postlogin(1); } 
                break;
            }
            Debug.Log("Incorrect UsernaME");//use this to print Incorrect Credentials
        }
    }
    void postlogin(int TeacherorStudent)
    {
        if (TeacherorStudent == 0) PhotonNetwork.CreateRoom("Teacher1") ;
    }
    public override void OnJoinedLobby()
    {
        Application.LoadLevel("College");
        
    }

}
