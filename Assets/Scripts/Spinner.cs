using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Place on obstacles that are supposed to spin and configure in editor
public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngle = 0;
    [SerializeField] float yAngle = 0;
    [SerializeField] float zAngle = 0;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle,yAngle,zAngle);
    }
}
