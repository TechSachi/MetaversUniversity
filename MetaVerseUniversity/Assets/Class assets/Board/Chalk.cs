using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chalk : MonoBehaviour
{
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    
    private void OnCollisionEnter(Collision col)
    {
        Debug.Log("Trigger");
        if (col.gameObject.CompareTag("Board"))Debug.Log("Colid");
    }
    
}
