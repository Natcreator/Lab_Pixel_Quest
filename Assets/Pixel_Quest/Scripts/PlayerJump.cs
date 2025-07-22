using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    public Transform feetCollider;
    public LayerMask groundMask;
    private bool _groundMask;
    private Rigidbody2D _rigidbody2d;


    public float CapusuleHeight = 0.25f;
    public float CapsuleRadius = 0.08f;
    private bool _groundCheck;
    private float fallForce = 2;
    private Vector2 gravityVector;
    public float jumpForce = 10;
    private bool waterCheck;

    // Start is called before the first frame update
    void Start()
    {

        _rigidbody2d = GetComponent<Rigidbody2D>();

        gravityVector = new Vector2(0, Physics2D.gravity.y);


    }




    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Water") { waterCheck = true; }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "water") { waterCheck = false; }


    }

        
 





    // Update is called once per frame
    void Update()
    {

        _groundCheck = Physics2D.OverlapCapsule(feetCollider.position, new Vector2(CapsuleRadius, CapusuleHeight), CapsuleDirection2D.Horizontal, 0, groundMask);

        if (Input.GetKeyDown(KeyCode.Space) && _groundCheck)
        {
            _rigidbody2d.velocity = new Vector2(_rigidbody2d.velocity.x, jumpForce);

        }
        if (_rigidbody2d.velocity.y < 0)
        { 
          _rigidbody2d.velocity += gravityVector * (fallForce * Time.deltaTime);

        }
    
        if (Input.GetKeyDown(KeyCode.Space) && (_groundCheck || waterCheck))
        {

            _rigidbody2d.velocity = new Vector2(_rigidbody2d.velocity.x, jumpForce);

        }





    }



}