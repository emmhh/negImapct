using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController controller;
    public float baseSpeed = 3f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public float runSpeed = 5f;
    // public float health = 100f;
    private float currAge = 0;
  
    public float distance = 0;
    //age_bar manages the dynamic stats of age in game.
    public age_bar ageBar;

    public float speedBoost = 0.5f;
    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
    }
    void PrintInstruction()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Press space bar to jump.");
    }
    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        // Calculate the direction the character is moving in
        Vector3 moveDirection = move.normalized;

        // Move the character
        controller.Move(moveDirection * (baseSpeed + speedBoost) * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        // Make the character face the direction of movement
        if (moveDirection != Vector3.zero)
        {
            Quaternion newRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime * 1f);

            
        }

        //distance += baseSpeed * Time.deltaTime;
        //Debug.Log(distance.ToString());
        ////add_age_bar
        //if (distance % 50 == 0)
        //{
        //    this.age = ageBar.GetAge();
        //    ageBar.set(this.age + 10);
        //}
        currAge += 0.1f;
        ageBar.set((int)currAge);
    }


}
