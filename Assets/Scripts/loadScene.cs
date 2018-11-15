using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour {

    public void ChangeScene()
    {
        //Changes to game scene
        SceneManager.LoadScene("Main Scene");
    }
}
