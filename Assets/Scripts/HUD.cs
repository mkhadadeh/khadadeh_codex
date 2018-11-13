using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour {

    public GameObject playerObj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (playerObj.GetComponent<player>().piece_top)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
            gameObject.transform.GetChild(1).gameObject.SetActive(true);
        }
        if (playerObj.GetComponent<player>().piece_swish)
        {
            gameObject.transform.GetChild(4).gameObject.SetActive(false);
            gameObject.transform.GetChild(5).gameObject.SetActive(true);
        }
        if (playerObj.GetComponent<player>().piece_swoop)
        {
            gameObject.transform.GetChild(2).gameObject.SetActive(false);
            gameObject.transform.GetChild(3).gameObject.SetActive(true);
        }
        if (playerObj.GetComponent<player>().piece_holder)
        {
            gameObject.transform.GetChild(6).gameObject.SetActive(false);
            gameObject.transform.GetChild(7).gameObject.SetActive(true);
        }
        if (playerObj.GetComponent<player>().piece_disk)
        {
            gameObject.transform.GetChild(8).gameObject.SetActive(false);
            gameObject.transform.GetChild(9).gameObject.SetActive(true);
        }
    }
}
