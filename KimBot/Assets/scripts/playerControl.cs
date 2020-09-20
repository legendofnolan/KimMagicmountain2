using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerControl : MonoBehaviour
{
    [SerializeField] private LayerMask Playermask;

    public int health = 100;
    private int healthLoseRate = 5;
    bool isJumping = false;
    //float moveL = 0

    private Vector3 inputVector = new Vector3(0, 0);
    //maybe delete      private Vector2 kimVector = new Vector2(0, 0); //trobleshoot: add inputVector to KimVector's
    private Rigidbody2D rb;
    private BoxCollider2D boxCollider2d;

    public float moveSpeed = 5f;
    public float ceiling = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }


    void Update()
    {
        //this one kinda works
        transform.position += inputVector * moveSpeed * Time.deltaTime;


        if (IsGrounded() && isJumping == true )
        {
            rb.velocity = Vector2.up * 10;
            //rb.AddForce(Vector2.up * 2);
            isJumping = false;
        }

    }


    public void movekim(InputAction.CallbackContext context)
    {
        inputVector = context.ReadValue<Vector2>();
    }


        

    public void jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            isJumping = true;
        }
        else if (context.canceled)
        {
            isJumping = false;
        }
    }


   
    private bool IsGrounded()
    {
        float extraHeightText = .1f;
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, extraHeightText, Playermask);
        if(raycastHit.collider != null)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    void OnTriggerEnter2D(Collider2D coll) {
        if (coll.gameObject.tag == "enemy") {
            if (this.health <= 0)
            {
                Debug.Log("dead");
                //Destroy(gameObject);
                //Destroy(coll.gameObject);
                spawnManager.stopSpawn = true;
                gameObject.SetActive(false);
                gameObject.GetComponent<Renderer>().enabled = false;
                //Game over logic
            }
            else
            {
                health -= healthLoseRate;

                Debug.Log(health);
            }
        }
    }
}
