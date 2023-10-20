using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // Fields

    public Transform cameraPosition;

    // Update is called once per frame
    void Update()
    {
        // Always moving with player
        transform.position = cameraPosition.position;        
    }
}
