using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer sr1;
    public int speed = 4;
    

    
  



    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        sr1 = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");

        _rigidbody2D.velocity = new Vector2(xInput * speed, _rigidbody2D.velocity.y);

        if (xInput == -1)
        {
            sr1.flipX = true;

        }
        else if (xInput == 0)
        {

            sr1.flipX = false;

        }
       


       
                




    }


}
