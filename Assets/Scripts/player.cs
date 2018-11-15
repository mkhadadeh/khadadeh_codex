using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

    public GameObject Structure;
    public GameObject Appear_Particles;

    public Transform piece_disk_t;
    public Transform piece_holder_t;
    public Transform piece_swoop_t;
    public Transform piece_swish_t;
    public Transform piece_top_t;

    public bool piece_disk;
    public bool piece_holder;
    public bool piece_swoop;
    public bool piece_swish;
    public bool piece_top;

    bool updating;
    GameObject part_instance;
    GameObject part_instance1;
    GameObject part_instance2;
    GameObject part_instance3;
    GameObject part_instance4;

    private Gradient[] grads;
    private GradientColorKey[][] colors;
    private GradientAlphaKey[][] alphas;

    // Use this for initialization
    void Start () {
		piece_disk = false;
        piece_holder = false;
        piece_swoop = false;
        piece_swish = false;
        piece_top = false;
        updating = false;

        grads = new Gradient[5];
        colors = new GradientColorKey[5][];
        alphas = new GradientAlphaKey[5][];
        for (int i = 0; i < 5; i++)
        {
            grads[i] = new Gradient();
            colors[i] = new GradientColorKey[2];
            alphas[i] = new GradientAlphaKey[2];
            alphas[i][0].alpha = 0.0f;
            alphas[i][0].time = 0.0f;
            alphas[i][1].alpha = 0.0f;
            alphas[i][1].time = 1.0f;
            colors[i][0].time = 1.0f;
            colors[i][1].time = 1.0f;
        }
        colors[0][0].color = new Color((147f)/(255f), (43f)/ (255f), (30f)/ (255f), 1.0f);
        colors[0][1].color = new Color((147f) / (255f), (43f) / (255f), (30f) / (255f), 1.0f);
        grads[0].SetKeys(colors[0],alphas[0]);
        colors[1][0].color = new Color((234f) / (255f), (199f) / (255f), (131f) / (255f), 1.0f);
        colors[1][1].color = new Color((234f) / (255f), (199f) / (255f), (131f) / (255f), 1.0f);
        grads[1].SetKeys(colors[1], alphas[1]);
        colors[2][0].color = new Color((243f) / (255f), (174f) / (255f), (141f) / (255f), 1.0f);
        colors[2][1].color = new Color((243f) / (255f), (174f) / (255f), (141f) / (255f), 1.0f);
        grads[2].SetKeys(colors[2], alphas[2]);
        colors[3][0].color = new Color((186f) / (255f), (140f) / (255f), (140f) / (255f), 1.0f);
        colors[3][1].color = new Color((186f) / (255f), (140f) / (255f), (140f) / (255f), 1.0f);
        grads[3].SetKeys(colors[3], alphas[3]);
        colors[4][0].color = new Color((111f) / (255f), (68f) / (255f), (25f) / (255f), 1.0f);
        colors[4][1].color = new Color((234f) / (255f), (199f) / (255f), (131f) / (255f), 1.0f);
        grads[4].SetKeys(colors[4], alphas[4]);

    }

    // Update is called once per frame
    void Update () {
        if(OVRInput.GetDown(OVRInput.Button.One))
        {
            SceneManager.LoadScene("UIScene");
        }
		if(!OVRInput.Get(OVRInput.Touch.PrimaryIndexTrigger) && OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger) == 1.0f)
        {
            RaycastHit hit;
            Ray pointRay = new Ray(transform.GetChild(1).GetChild(0).GetChild(4).position, transform.GetChild(1).GetChild(0).GetChild(4).forward);
            if (Physics.Raycast(pointRay, out hit)) {
                if (hit.collider.tag == "Pedestal")
                {
                    if (!updating)
                    {
                        updating = true;
                        StartCoroutine(updatePedestal());
                    }
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
                    if (!updating)
                    {
                        updating = true;
                        StartCoroutine(updatePedestal());
                    }
                }
            }
        }
    }

    IEnumerator updatePedestal(){
        
        Structure.GetComponent<structure>().piece_top = piece_top;
        part_instance = Instantiate(Appear_Particles, piece_top_t);
        part_instance.transform.localPosition = new Vector3(-0.0254f,0.2101f,0);
        part_instance.transform.parent = Structure.transform;
        part_instance.GetComponent<indicatorParticles>().grad = grads[4];
        part_instance.GetComponent<indicatorParticles>().pit = 1.5f;

        yield return new WaitForSeconds(1);
        Structure.GetComponent<structure>().piece_swish = piece_swish;
        part_instance1 = Instantiate(Appear_Particles, piece_swish_t);
        part_instance1.transform.localPosition = new Vector3(-0.01f, 0.008f, 0.01f);
        part_instance1.transform.parent = Structure.transform;
        part_instance1.GetComponent<indicatorParticles>().grad = grads[3];
        part_instance1.GetComponent<indicatorParticles>().pit = 1.2f;

        yield return new WaitForSeconds(1);
        Structure.GetComponent<structure>().piece_swoop = piece_swoop;
        part_instance2 = Instantiate(Appear_Particles, piece_swoop_t);
        part_instance2.transform.localPosition = new Vector3(-0.01f, 0.008f, 0.01f);
        part_instance2.transform.parent = Structure.transform;
        part_instance2.GetComponent<indicatorParticles>().grad = grads[2];
        part_instance2.GetComponent<indicatorParticles>().pit = 1f;

        yield return new WaitForSeconds(1);
        Structure.GetComponent<structure>().piece_holder = piece_holder;
        part_instance3 = Instantiate(Appear_Particles, piece_holder_t);
        part_instance3.transform.localPosition = new Vector3(0.004f, 0.04f, 0.0004f);
        part_instance3.transform.parent = Structure.transform;
        part_instance3.GetComponent<indicatorParticles>().grad = grads[1];
        part_instance3.GetComponent<indicatorParticles>().pit = 0.8f;

        yield return new WaitForSeconds(1);
        Structure.GetComponent<structure>().piece_disk = piece_disk;
        part_instance4 = Instantiate(Appear_Particles, piece_disk_t.position, Quaternion.identity);
        part_instance4.transform.localPosition = new Vector3(3, 1f, 0);
        part_instance4.GetComponent<indicatorParticles>().grad = grads[0];
        part_instance4.GetComponent<indicatorParticles>().pit = 0.5f;
        updating = false;
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