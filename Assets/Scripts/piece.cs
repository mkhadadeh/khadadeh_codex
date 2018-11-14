using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piece : MonoBehaviour {

    public GameObject Player;
    public GameObject Indicators;

    private GameObject parts;

    private Gradient grad;
    private GradientAlphaKey[] gradAlphas;
    private GradientColorKey[] gradColors;

    private float sound_pitch;

	// Use this for initialization
	void Start () {
        sound_pitch = 1;
        grad = new Gradient();
        gradAlphas = new GradientAlphaKey[2];
        gradColors = new GradientColorKey[2];
        gradAlphas[0].alpha = 0.0f;
        gradAlphas[0].time = 0.0f;
        gradAlphas[1].alpha = 0.0f;
        gradAlphas[1].time = 1.0f;
        gradColors[0].time = 1.0f;
        gradColors[1].time = 1.0f;
    }
	
	// Update is called once per frame
	void Update () {
        if(GetComponent<OVRGrabbable>().isGrabbed)
        {
            Player.GetComponent<player>().collect(gameObject.tag);
            parts = Instantiate(Indicators, transform.position, Quaternion.identity);
            switch(gameObject.tag)
                {
                case "Disk":
                    gradColors[0].color = new Color((147f) / (255f), (43f) / (255f), (30f) / (255f), 1.0f);
                    gradColors[1].color = new Color((147f) / (255f), (43f) / (255f), (30f) / (255f), 1.0f);
                    sound_pitch = 0.5f;
                    break;
                case "Holder":
                    gradColors[0].color = new Color((234f) / (255f), (199f) / (255f), (131f) / (255f), 1.0f);
                    gradColors[1].color = new Color((234f) / (255f), (199f) / (255f), (131f) / (255f), 1.0f);
                    sound_pitch = 0.8f;
                    break;
                case "Swoop":
                    gradColors[0].color = new Color((243f) / (255f), (174f) / (255f), (141f) / (255f), 1.0f);
                    gradColors[1].color = new Color((243f) / (255f), (174f) / (255f), (141f) / (255f), 1.0f);
                    sound_pitch = 1;
                    break;
                case "Swish":
                    gradColors[0].color = new Color((186f) / (255f), (140f) / (255f), (140f) / (255f), 1.0f);
                    gradColors[1].color = new Color((186f) / (255f), (140f) / (255f), (140f) / (255f), 1.0f);
                    sound_pitch = 1.2f;
                    break;
                case "Top":
                    gradColors[0].color = new Color((111f) / (255f), (68f) / (255f), (25f) / (255f), 1.0f);
                    gradColors[1].color = new Color((234f) / (255f), (199f) / (255f), (131f) / (255f), 1.0f);
                    sound_pitch = 1.5f;
                    break;
            }
            grad.SetKeys(gradColors, gradAlphas);
            parts.GetComponent<indicatorParticles>().grad = grad;
            parts.GetComponent<indicatorParticles>().pit = sound_pitch;
            Destroy(gameObject);
        }
	}


}