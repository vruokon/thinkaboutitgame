using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    
    public float jumbHeight = 7f;
    [SerializeField] private LayerMask platformsLayerMask;
    private Animator animator;
    private BoxCollider2D boxCollider2d;
    private Rigidbody2D rb;
    public int health = 1;

    // Start is called before the first frame update
    void Start()
    {
	animator = gameObject.GetComponent<Animator>();
	rb = transform.GetComponent<Rigidbody2D>();
	boxCollider2d = transform.GetComponent<BoxCollider2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
       if (IsGrounded() && Input.GetKeyDown(KeyCode.Space)) //Hyppää vain jos koskettaa maata
        {
            rb.velocity = Vector2.up * this.jumbHeight;
        } 
    }

    private bool IsGrounded()
    {
	RaycastHit2D raycastHit = Physics2D.Raycast(boxCollider2d.bounds.center, Vector2.down, boxCollider2d.bounds.extents.y + .5f, platformsLayerMask);
	Color rayColor;
	if(raycastHit.collider != null)
	{
	    animator.SetBool("isInAir", false);
	    rayColor = Color.green;
	} else {
	    animator.SetBool("isInAir", true);
	    rayColor = Color.red;
	}
	Debug.DrawRay(boxCollider2d.bounds.center, Vector2.down * (boxCollider2d.bounds.extents.y+.01f), rayColor);
	return raycastHit.collider != null;
    
    }
}
