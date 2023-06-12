using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerActions : MonoBehaviour
{
    [SerializeField]
    Object[] spriteReference;
    public float playerSpeed;
    public float jumpPower;
    private float playerDir = 0.0f;
    
    private Rigidbody2D playerBody;
    private Animator animator;
    private GameObject playerSprite;
    private Transform transform;
    private string playerCharacter;

    private void Awake()
    {
        spriteReference = Resources.LoadAll("Characters", typeof(GameObject)); 

        transform = GetComponent<Transform>();

        if (PlayerInputManager.instance.playerCount == 1)
        {
            playerCharacter = "player1_character";
        } else
        {
            playerCharacter = "player2_character";
        }

        switch (PlayerPrefs.GetInt(playerCharacter))
        {
            case 1:
                playerSprite = Instantiate(spriteReference[1], transform) as GameObject;
                break;
            case 2:
                playerSprite = Instantiate(spriteReference[0], transform) as GameObject;
                break;
            case 3:
                playerSprite = Instantiate(spriteReference[2], transform) as GameObject;
                break;
            case 4:
                playerSprite = Instantiate(spriteReference[7], transform) as GameObject;
                break;
            case 5:
                playerSprite = Instantiate(spriteReference[5], transform) as GameObject;
                break;
            case 6:
                playerSprite = Instantiate(spriteReference[4], transform) as GameObject;
                break;
            case 7:
                playerSprite = Instantiate(spriteReference[6], transform) as GameObject;
                break;
            case 8:
                playerSprite = Instantiate(spriteReference[3], transform) as GameObject;
                break;
            default:
                break;
        }

        playerSprite.AddComponent<Animator>();
        animator = GetComponentInChildren<Animator>();
        animator.runtimeAnimatorController = Resources.Load("Animation/Daigo/Daigo") as RuntimeAnimatorController;
        if (animator.runtimeAnimatorController != null) animator.Play("Daigo_Idle");

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
        if (transform.position.x <= 0)
        {
            transform.localScale = new Vector3(2, 2, 1);
        } else
        {
            transform.localScale = new Vector3(-2, 2, 1);
        }
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
