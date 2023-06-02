using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerActions : MonoBehaviour
{

    private float playerSpeed = 5.0f;
    private float jumpPower = 5.0f;

    private Rigidbody2D p1_body;
    private Rigidbody2D p2_body;

    private 

    void Update()
    {
        
        if (Gamepad.all[0].leftStick.IsActuated()) {

            var horizontalInput = Gamepad.all[0].leftStick.ReadValue();
            p1_body = GameObject.Find("Player_Character_1").GetComponent<Rigidbody2D>();

            p1_body.velocity = new Vector2(horizontalInput.x * playerSpeed, p1_body.velocity.y);
        }


        if (Gamepad.all[0].crossButton.IsActuated())
        {
            p1_body.velocity = new Vector2(p1_body.velocity.x, jumpPower);
        }

    }
}
