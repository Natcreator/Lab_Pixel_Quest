using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    int varTwo = 3;
    int varOne = 1;

    private Rigidbody2D rb;
    private SpriteRenderer sr;


    string bear = "how are you";
    // Start is called before the first frame update
    public float speed ;
    public string nextLevel = "Scene_2";


    private void OnTriggerEnter2D(Collider2D collision)
    {    Debug.Log(collision.tag);
         switch (collision.tag)
        {
            case "Death":
                {
                    string thislevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislevel);
                    break;

                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;



                }

        }

    }

    void Start()
    {
        Debug.Log(transform.position);

        rb = GetComponent<Rigidbody2D>();

       sr = GetComponent<SpriteRenderer>();




    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        
        rb.velocity=new Vector2(xInput*speed, rb.velocity.y);
        
       

        if (Input.GetKeyDown(KeyCode.Alpha1))

        {
            sr.color = Color.yellow;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))

        {
            sr.color = Color.red;

        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            sr.color = Color.blue;
        }



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