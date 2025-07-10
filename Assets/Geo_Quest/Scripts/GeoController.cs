using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int varTwo = 3;
    int varOne = 1;

    private Rigidbody2D rb;
    


    string bear = "how are you";
    // Start is called before the first frame update
    public int speed = 10;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");
    }



    void Start()
    {
        Debug.Log(transform.position);

        rb = GetComponent<Rigidbody2D>();

        Debug.Log("Hello World");

        string goat = "im good how about you";

        Debug.Log(bear + goat);
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        Debug.Log(xInput);
        rb.velocity=new Vector2(xInput, rb.velocity.y);
        

        




       /*
     
       Debug.Log(varTwo);
        varTwo++;
        if (Input.GetKeyDown(KeyCode.W))

        {
            transform.position += new Vector3(0, 1, 0);

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, -1, 0);

        }
        if (Input.GetKeyDown(KeyCode.D))
        {

            transform.position += new Vector3(1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0);



        }





        */

    }
    

    


}

    

// notes 