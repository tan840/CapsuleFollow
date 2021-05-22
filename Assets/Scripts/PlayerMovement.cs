using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles the playerMovement
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    public float forwardMoveSpeed = 5f;
    public float sideMoveSpeed = 5f;

    void Update()
    {
        ForwardMovement();
        SideMovement();
    }

    void ForwardMovement()
    {
        transform.Translate(Vector3.forward * forwardMoveSpeed * Time.deltaTime, Space.World);
    }
    void SideMovement()
    {
        float h = Input.GetAxis("Horizontal");

        this.transform.Translate(h * Time.deltaTime * sideMoveSpeed, 0, 0);
        //print(h);
    }
}
