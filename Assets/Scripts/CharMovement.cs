using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMovement : MonoBehaviour
{
    [SerializeField]
    private float jumpForce =10f;
    [SerializeField]
    private float moveForce = 10f;


    private float MovementX;
    private float MovementY;
    private Rigidbody myBody;
    private Animator ninAnim;
    private SpriteRenderer sr;
    private string N�N_WALK_AN�M = "Walk";
    private Transform trans;
    bool isGrounded = true;
    private string GROUND_TAG = "Ground";
    private string JUMP_AN�M_TAG = "Jump";


    private void Awake()
    {
        myBody = GetComponent<Rigidbody>();
        ninAnim = GetComponent<Animator>();
        trans = GetComponent<Transform>();

    }


    void Start()
    {
        
    }



    void Update()
    {
        PlayerMoveKeyboard();
        AnimatePlayer();
        PlayerJump();
    }

    void PlayerMoveKeyboard()
    {
        MovementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(MovementX, 0f, 0f) * moveForce * Time.deltaTime;


    }

    void AnimatePlayer()
    {
        if(MovementX > 0)
        { 
            ninAnim.SetBool(N�N_WALK_AN�M, true);
            transform.eulerAngles = new Vector3(0, 90, 0);
        }

        else if(MovementX < 0)
        {
            ninAnim.SetBool(N�N_WALK_AN�M, true);
            transform.eulerAngles = new Vector3(0, -90, 0);
        }

        else
        {
            ninAnim.SetBool(N�N_WALK_AN�M, false);
        }

    }
      
    void PlayerJump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            ninAnim.SetBool(JUMP_AN�M_TAG, true);
            myBody.AddForce(new Vector3(0f, jumpForce, 0f) ,ForceMode.Impulse);
            isGrounded = false;



        }
        if (isGrounded == true)
        {
            ninAnim.SetBool(JUMP_AN�M_TAG, false);
        }
        
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(GROUND_TAG))
        {
            isGrounded = true;

            
        }
    }

    

}//class
