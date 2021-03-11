using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorController : MonoBehaviour
{
    public BoxCollider2D collider;
    public new Rigidbody2D rb;
    
    private float width;
    private float scrollSpeed = -3.5f;
    // Start is called before the first frame update
    void Start()
    {
      collider = GetComponent<BoxCollider2D>();
     rb = GetComponent<Rigidbody2D>();
     
     width = collider.size.x*1.2f;
     
     rb.velocity = new Vector2(scrollSpeed, 0);
       
    }

    // Update is called once per frame
    void Update()
    {
            if(transform.position.x < -8)
        {
            Vector2 resetPosition = new Vector2(8 * 2f, 0);
            transform.position = (Vector2)transform.position + resetPosition;
        }

    }
}
