using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Put on obstacles, changes color of obstacles to indicate they were hit
public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
        }
    }
}
