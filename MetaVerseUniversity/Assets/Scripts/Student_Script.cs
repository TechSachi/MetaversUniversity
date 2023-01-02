using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class Student_Script : NetworkBehaviour
{
    private void Update()
    {

    }
    public override void OnNetworkSpawn()
    {
        Debug.Log("Client Spawned With ID" + OwnerClientId);
    }

}
