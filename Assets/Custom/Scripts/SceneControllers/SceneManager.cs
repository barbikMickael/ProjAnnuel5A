using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {
    public Camera[] cameraArray;
    public Animation[] animationsArray;
    protected int indexCamera = 0;
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

    public void OnAnimationFinished()
    {
        cameraArray[indexCamera].enabled = false;
        indexCamera++;
        cameraArray[indexCamera].enabled = true;

    }

    public int getCameraIndex()
    {
        return indexCamera;
    }
    public void setCameraIndex(int i)
    {
        indexCamera = i;
    }
}
