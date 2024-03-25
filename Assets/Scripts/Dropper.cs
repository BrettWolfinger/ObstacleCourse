using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Place on obstacles that drop from the sky
public class Dropper : MonoBehaviour
{

    MeshRenderer myRenderer;
    Rigidbody myRigidbody;
    [SerializeField] float timeUntilDrop = 3f;
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();

        myRenderer.enabled = false;
        myRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        //If the game has been started long enough than drop the obstacle
        if(Time.time > timeUntilDrop)
        {
            myRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
