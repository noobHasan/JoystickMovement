using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Joystick joystick;
    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = joystick.Horizontal;
        float verticalMovement = joystick.Vertical;

        transform.position = new Vector3(transform.position.x + horizontalMovement * moveSpeed * 
            Time.deltaTime, transform.position.y, transform.position.z + verticalMovement * moveSpeed * Time.deltaTime);


    }
}
