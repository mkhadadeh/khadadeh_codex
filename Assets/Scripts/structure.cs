using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class structure : MonoBehaviour {

    public bool piece_disk;
    public bool piece_holder;
    public bool piece_swoop;
    public bool piece_swish;
    public bool piece_top;

    // Use this for initialization
    void Start()    {
        piece_disk = false;
        piece_holder = false;
        piece_swoop = false;
        piece_swish = false;
        piece_top = false;
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }

	
	// Update is called once per frame
	void Update () {
		if(piece_disk = true && !gameObject.transform.GetChild(0).gameObject.activeSelf)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
        if (piece_holder = true && !gameObject.transform.GetChild(1).gameObject.activeSelf)
        {
            gameObject.transform.GetChild(1).gameObject.SetActive(true);
        }
        if (piece_swoop = true && !gameObject.transform.GetChild(2).gameObject.activeSelf)
        {
            gameObject.transform.GetChild(2).gameObject.SetActive(true);
        }
        if (piece_swish = true && !gameObject.transform.GetChild(3).gameObject.activeSelf)
        {
            gameObject.transform.GetChild(3).gameObject.SetActive(true);
        }
        if (piece_top = true && !gameObject.transform.GetChild(4).gameObject.activeSelf)
        {
            gameObject.transform.GetChild(4).gameObject.SetActive(true);
        }
    }
}
