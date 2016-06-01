using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {
    public Camera[] cameraArray;
    public Animation[] animationsArray;
    // Use this for initialization
    void OnEnable () {
        for (int i = 0; i < cameraArray.Length; i++)
        {
            cameraArray[i].enabled = false;
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnAnimationFinished(int number) {

    }
}
