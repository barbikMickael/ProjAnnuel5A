using UnityEngine;
using System.Collections;

public class AnimationEnd : MonoBehaviour {
    public SceneManager myManager;
    public int number; 
	// Use this for initialization
	void OnEnable () {
        myManager.OnAnimationFinished(number);
	}
}
