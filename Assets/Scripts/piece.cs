using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piece : MonoBehaviour {

    public GameObject Player;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if(GetComponent<OVRGrabbable>().isGrabbed)
        {
            Player.GetComponent<player>().collect(gameObject.tag);
            Destroy(gameObject);
        }
	}
}
