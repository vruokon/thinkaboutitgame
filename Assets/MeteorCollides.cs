using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorCollides : MonoBehaviour
{
    public bool hit = false;
    
    private void OnTriggerEnter2D(Collider2D other){
	hit = true;
    }
    
    public void setHitFalse(){
	hit = false;
    }
}
