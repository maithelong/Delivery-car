using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    [SerializeField] float steerSpeed = 150f;
    [SerializeField] float moveSpeed = 20f;
    private float boostSpeed = 30f;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 20f;
    }

    // Update is called once per frame
    void Update()
    { 
        float horizontalValue = Input.GetAxis("Horizontal");
        float verticalValue = Input.GetAxis("Vertical");
       
        transform.Rotate(0, 0, -steerSpeed * horizontalValue * Time.deltaTime);
        transform.Translate(0, moveSpeed * verticalValue * Time.deltaTime,0);
        
    }
    private void FixedUpdate()
    {
       /* if(moveSpeed>20)
        {
            moveSpeed--;
        }    */
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="boost")
        {
            moveSpeed = boostSpeed;
        }    

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag=="boost")
        {
            if(moveSpeed!=20f)
            {
            moveSpeed--;

            }    
        }    
    }

}
