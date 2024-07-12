using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{ 
    public float moveSpeed = 5f; 
    private Rigidbody2D rb; 
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

   
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); 
        float moveVertical = Input.GetAxis("Vertical"); 

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * moveSpeed); 
    }
}
