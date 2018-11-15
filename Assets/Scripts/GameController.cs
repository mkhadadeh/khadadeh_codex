using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject spot_light;
    public GameObject all_light;
    public GameObject hud;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Victory()
    {
        spot_light.SetActive(true);
        all_light.SetActive(false);
        hud.GetComponent<HUD>().win();
    }
}
