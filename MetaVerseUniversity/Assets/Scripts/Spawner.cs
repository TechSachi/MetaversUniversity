using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Spawner : MonoBehaviour
{
    public GameObject TeacherPreFab;
    Vector3 TeacherSpawnPoint = new Vector3(8.969511f, -3.800001f, 1.59f);
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
        Instantiate(TeacherPreFab, TeacherSpawnPoint, Quaternion.Euler(0,180,0));
    }

}
