using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glowingbookScr : MonoBehaviour {

    public Material book_mat;
    public Gradient particle_grad;
    // Use this for initialization
    void Start () {
        gameObject.transform.GetChild(0).GetComponent<Renderer>().material = book_mat;
        var col = gameObject.transform.GetChild(0).GetChild(1).GetComponent<ParticleSystem>().colorOverLifetime;
        col.color = particle_grad;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
