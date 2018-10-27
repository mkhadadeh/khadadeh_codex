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
		if(!OVRInput.Get(OVRInput.Touch.PrimaryIndexTrigger) && OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger) == 1.0f)
        {
            RaycastHit hit;
            Ray pointRay = new Ray(transform.GetChild(1).GetChild(0).GetChild(4).position, transform.GetChild(1).GetChild(0).GetChild(4).forward);
            if (Physics.Raycast(pointRay, out hit)) {
                if (hit.collider.tag == "Pedestal")
                {
                    updatePedestal();
                }
            }
        }
        if (!OVRInput.Get(OVRInput.Touch.SecondaryIndexTrigger) && OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger) == 1.0f)
        {
            RaycastHit hit;
            Ray pointRay = new Ray(transform.GetChild(1).GetChild(0).GetChild(5).position, transform.GetChild(1).GetChild(0).GetChild(5).forward);
            if (Physics.Raycast(pointRay, out hit))
            {
                if (hit.collider.tag == "Pedestal")
                {
                    updatePedestal();
                }
            }
        }
    }

    void updatePedestal(){
        Structure.GetComponent<structure>().piece_disk = piece_disk;
        Structure.GetComponent<structure>().piece_holder = piece_holder;
        Structure.GetComponent<structure>().piece_swoop = piece_swoop;
        Structure.GetComponent<structure>().piece_swish = piece_swish;
        Structure.GetComponent<structure>().piece_top = piece_top;
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