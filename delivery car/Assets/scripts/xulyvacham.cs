using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xulyvacham : MonoBehaviour
{
   [SerializeField]Color32 originalColor=new Color32(1,1,1,1);
    private SpriteRenderer render;
    private bool haspackage;
    private void Start()
    {
        
        render = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("a");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="package"&&haspackage==false)
        {
            Debug.Log("va cham voi package");
            haspackage = true;
            Destroy(collision.gameObject, 0.5f);
           render.color= collision.GetComponent<SpriteRenderer>().color;
        }
        if(collision.tag=="guest"&&haspackage==true)
        {
            render.color = originalColor;

            Debug.Log("success delivery");
            haspackage = false;
            Destroy(collision.gameObject, 0.5f);
        }   
        
    }
}
