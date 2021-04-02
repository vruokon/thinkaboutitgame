using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autsControllelr : MonoBehaviour
{
    private bool thereIsHit;
    public int framesToShowAuts = 400;
    private int showBubble = 0;
    // Start is called before the first frame update
    void Start()
    {
	GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

	thereIsHit = GameObject.Find("lava").GetComponent<MeteorCollides>().hit;
	if(thereIsHit){
		GetComponent<Renderer>().enabled = true;
		GameObject.Find("lava").GetComponent<MeteorCollides>().setHitFalse();
		showBubble = framesToShowAuts;
	}
	if(showBubble >= 1) {
	    showBubble -= 1;
	} else {
	    GetComponent<Renderer>().enabled = false;
	}
    }
}
