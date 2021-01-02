using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public CharacterController2D controller;

    public float runspeed = 20;
    float hMove = 0;
    bool jump = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(hMove = Input.GetAxisRaw("Horizontal") * runspeed);

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {
        // Move our Character
        controller.Move(hMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
