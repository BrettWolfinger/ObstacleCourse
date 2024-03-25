using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Put script on player, Keeps track of the number of collisions
public class Scorer : MonoBehaviour
{
    int numBumps = 0;

    private void OnCollisionEnter(Collision other) {
        numBumps++;
        Debug.Log("You've bumped into a thing this many times: " + numBumps);
    }
}
