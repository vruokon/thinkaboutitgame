using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorController : MonoBehaviour
{
    public CapsuleCollider2D collider;
    public new Rigidbody2D rb;
    
    private float width;
    private float scrollSpeed = -1.5f;
    // Start is called before the first frame update
    void Start()
    {
      collider = GetComponent<CapsuleCollider2D>();
     rb = GetComponent<Rigidbody2D>();
     
     width = collider.size.x*1.2f;
     Debug.Log(width);
     
     rb.velocity = new Vector2(scrollSpeed, 0);
       
    }

    // Update is called once per frame
    void Update()
    {
            if(transform.position.x < -5)
        {
            Vector2 resetPosition = new Vector2(21.6f * 2f, 0);
            transform.position = (Vector2)transform.position + resetPosition;
            Debug.Log(transform.position);
        }

    }
}
