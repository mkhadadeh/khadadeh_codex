using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class indicatorParticles : MonoBehaviour {
    public Gradient grad;
	// Use this for initialization
	void Start () {
        var col = gameObject.GetComponent<ParticleSystem>().colorOverLifetime;
        col.color = grad;
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(gameObject, 1);
	}
}
