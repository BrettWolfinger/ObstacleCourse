using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Put script on player to handle movement. Uses old unity system
public class Mover : MonoBehaviour
{

    [SerializeField] float moveSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
    }

    void MovePlayer()
    {
        float xVal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float zVal = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(xVal,0,zVal);
    }
}
