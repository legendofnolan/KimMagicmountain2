using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{

    public Transform player;
    public Vector2 enemyVector;

    public Rigidbody2D rb;




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        enemyVector = new Vector2(player.transform.position.x - gameObject.transform.position.x, player.transform.position.y - gameObject.transform.position.y);
        enemyVector.Normalize();
        transform.Translate(enemyVector * Time.deltaTime * 2);
        Debug.Log(enemyVector);
    }
}
