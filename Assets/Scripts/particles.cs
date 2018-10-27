using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particles : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = Quaternion.Euler(-(transform.parent.rotation.eulerAngles.x + 90), -transform.parent.rotation.eulerAngles.y, -(transform.parent.rotation.eulerAngles.z + 270));
	}
}
