using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveVector;

    private float speed = 5.0f;
    private float verticalVelocity = 0.0f;
    private float gravity = 12.0f;

    private bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
            return;

        moveVector = Vector3.zero;

        if(controller.isGrounded)
        {
            verticalVelocity = -0.5f;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        //X ;Left-Right
        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;

        //Y ;Up-Down
        moveVector.y = verticalVelocity;

        //Z ;Forward-Backward
        moveVector.z = speed;

        controller.Move(moveVector * Time.deltaTime);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.point.z > transform.position.z + controller.radius)
            Death();
    }

    private void Death()
    {
        isDead = true;
        GetComponent<Score>().OnDeath();
    }
}
