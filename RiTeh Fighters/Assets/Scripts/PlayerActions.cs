using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerActions : MonoBehaviour
{
    [SerializeField]
    public float playerSpeed;
    public float jumpPower;
    private float playerDir = 0.0f;

    private float jumpTime;
    private bool jumpingStatus;

    private Rigidbody2D playerBody;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        playerBody = GetComponent<Rigidbody2D>();

        if (playerBody is null)
        {
            Debug.LogError("Body is NULL");
        }

    }

    private void FixedUpdate()
    {
        playerBody.velocity = new Vector2(playerDir * playerSpeed, playerBody.velocity.y);
    }

    private void Update()
    {
        if (playerBody.velocity.x > -0.01f && playerBody.velocity.x < 0.01f) animator.SetBool("isWalking", false);
    }

    void OnJump()
    {
        if (playerBody.velocity.y > -0.01f && playerBody.velocity.y < 0.01f) playerBody.velocity = Vector2.up * jumpPower;
    }

    void OnMove(InputValue inputValue)
    {
        animator.SetBool("isWalking", true);
        playerDir = inputValue.Get<float>();
    }
   
}
