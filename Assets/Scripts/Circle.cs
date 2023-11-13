using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(move * 4f, rb.velocity.y);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(move * 4f, rb.velocity.y);
        }
    }
    
}
