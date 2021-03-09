using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public new BoxCollider2D collider;
    public new Rigidbody2D rb;
    
    private float width;
    private float scrollSpeed = -1f;
    // Start is called before the first frame update
    void Start()
    {
     collider = GetComponent<BoxCollider2D>();
     rb = GetComponent<Rigidbody2D>();
     
     width = collider.size.x;
     collider.enabled = false;
     
     rb.velocity = new Vector3(scrollSpeed, 0, 11);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -width*2.1)
        {
            Vector3 resetPosition = new Vector3(width*2.1f * 2f, 0, 11);
            transform.position = (Vector3)transform.position + resetPosition;
        }
    }
}
