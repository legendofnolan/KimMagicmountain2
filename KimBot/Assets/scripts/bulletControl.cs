using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class bulletControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;

    private Vector2 aimVector = new Vector2(0, 0);
    private Rigidbody2D rb;

    void Start()
    {
        //the varible rb creates a shell for a rigidbody. Get Component
        rb = GetComponent<Rigidbody2D>();

        //velocity moves exactly the speed when the method is called. Addforce has a pause before speeding up
        rb.velocity = transform.up * speed;

        
    }

    // Update is called once per frame
    private void Update()
    {
        Destroy(gameObject, 1f);

    }


    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Destroy(gameObject);
    }


    //public void aimArm(InputAction.CallbackContext context)
    //{
    //    aimVector = context.ReadValue<Vector2>();
    //}
}
