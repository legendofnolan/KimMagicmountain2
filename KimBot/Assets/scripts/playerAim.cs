using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerAim : MonoBehaviour
{
    public float playerSpeed;
    public float turnSpeed;
    private float verrtical;
    private float horizontal;

    // 8/24/20  it works!!!!
    private float testAim;
    private Quaternion aimRotation;


    public Transform bulletShot;
    // delay fire varibles
    public float nextFire = 0.0f;
    public float delayFire = 0.5f;
    //public bool readyFire = true;

    private Vector2 aimVector;
    private Vector3 target;
    private Rigidbody2D armRB;

    // Update is called once per frame
    //fixedUpdate is called once per frame AFTER Update. Its best to do physics stuff in FixedUpdate
    
    private void Update()
    {

    }

    private void FixedUpdate()
    {
      
        target = new Vector3(-horizontal, verrtical);


        testAim = Mathf.Atan2(target.x, target.y) * Mathf.Rad2Deg;

        if (verrtical != 0 && horizontal != 0)
        {
            
            aimRotation = Quaternion.AngleAxis(testAim, Vector3.forward);
            armRB.transform.rotation = Quaternion.Slerp(armRB.transform.rotation, aimRotation, turnSpeed * Time.time);

            if (Time.time > nextFire)
            {
                nextFire = Time.time + delayFire;
                //bullet spawn
                Instantiate(bulletShot, transform.position + (1.0f * transform.forward), transform.rotation);
                //readyFire = false;
            }
            

        }


        /*
         * Atan2
         * returns the anle in radians: Tan is y/x
         *  tan is opposite over adjacent
         * Rad2Deg: makes radians constant
         * Q.AngleAxis
         * 
         */


        
    }


    void Start()
    {
        armRB = GetComponent<Rigidbody2D>();
    }


    public void onMovement(InputAction.CallbackContext context)
    {
        Debug.Log("Z: " + transform.rotation.z.ToString());
        Debug.Log(target);
    }


    public void aimArmX(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<float>();
    }

    public void aimArmY(InputAction.CallbackContext context)
    {
        verrtical = context.ReadValue<float>();
    }
}
