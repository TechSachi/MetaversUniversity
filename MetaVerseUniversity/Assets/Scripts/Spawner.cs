using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Spawner : MonoBehaviour
{
    public GameObject TeacherPreFab;
    Vector3 TeacherSpawnPoint = new Vector3(-4.4877f, 4.51f, -34.05f);
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(ExampleCoroutine());

    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        PhotonNetwork.Instantiate(TeacherPreFab.name, TeacherSpawnPoint, Quaternion.identity);
    }

}
