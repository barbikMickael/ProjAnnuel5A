using UnityEngine;
using System.Collections;

public class AnimationEnd : MonoBehaviour {
    public SceneManager myManager;
	// Use this for initialization
	void OnEnable () {
        myManager.OnAnimationFinished();
    }
}
