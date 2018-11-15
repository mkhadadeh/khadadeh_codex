using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class indicatorParticles : MonoBehaviour {
    public Gradient grad;
    public float pit;
	// Use this for initialization
	void Start () {
        var col = gameObject.GetComponent<ParticleSystem>().colorOverLifetime;
        col.color = grad;
        var Asource = transform.GetChild(0).GetComponent<AudioSource>();
        Asource.pitch = pit;
    }

    // Update is called once per frame
    void Update () {
        Destroy(gameObject, 1);
	}
}
