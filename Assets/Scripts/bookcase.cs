using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookcase : MonoBehaviour {

    public Material possible_0;
    public Material possible_1;
    public Material possible_2;
    public Material possible_3;

    private Material[] chosen;

    // Use this for initialization
    void Start () {
        chosen = new Material[4];
        chosen[0] = possible_0;
        chosen[1] = possible_1;
        chosen[2] = possible_2;
        chosen[3] = possible_3;
        for (int i = 0; i < 8; i++)
        {
            Shuffle(chosen, 4);
            Transform currentRow = transform.GetChild(i);
            currentRow.GetChild(1).GetChild(0).GetComponent<MeshRenderer>().materials[0] = chosen[0];
            currentRow.GetChild(1).GetChild(0).GetComponent<MeshRenderer>().materials[2] = chosen[1];
            currentRow.GetChild(1).GetChild(0).GetComponent<MeshRenderer>().materials[3] = chosen[2];
            currentRow.GetChild(1).GetChild(0).GetComponent<MeshRenderer>().materials[4] = chosen[3];
        }
	}
	

    void Shuffle(Material[] mats, int size)
    {
        Material temp;
        for (int i = 0; i < size; i++)
        {
            int chosen = Random.Range(i, size-1);
            temp = mats[i];
            mats[i] = mats[chosen];
            mats[chosen] = temp;
        }
    }
}
