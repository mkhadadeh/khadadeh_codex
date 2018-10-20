using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public GameObject Structure;

    private bool piece_disk;
    private bool piece_holder;
    private bool piece_swoop;
    private bool piece_swish;
    private bool piece_top;

    // Use this for initialization
    void Start () {
		piece_disk = false;
        piece_holder = false;
        piece_swoop = false;
        piece_swish = false;
        piece_top = false;
    }

    // Update is called once per frame
    void Update () {
		if(OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            Structure.GetComponent<structure>().piece_disk = piece_disk;
            Structure.GetComponent<structure>().piece_holder = piece_holder;
            Structure.GetComponent<structure>().piece_swoop = piece_swoop;
            Structure.GetComponent<structure>().piece_swish = piece_swish;
            Structure.GetComponent<structure>().piece_top = piece_top;
        }
	}

    public void collect(string piece_tag) {
        switch(piece_tag)
        {
            case "Disk":
                piece_disk = true;
                break;
            case "Holder":
                piece_holder = true;
                break;
            case "Swoop":
                piece_swoop = true;
                break;
            case "Swish":
                piece_swish = true;
                break;
            case "Top":
                piece_top = true;
                break;
        }
    }
}