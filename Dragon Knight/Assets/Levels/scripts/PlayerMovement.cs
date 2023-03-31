using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D playerRigidBody;
    Vector2 playerInput;
    float speed = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerInput.x = Input.GetAxisRaw("Horizontal");
        playerInput.y = Input.GetAxisRaw("Vertical");
        MovePlayer();
    }

    void MovePlayer()
    {
        playerRigidBody.MovePosition(playerRigidBody.position + playerInput * Time.deltaTime * speed);
    }
}
