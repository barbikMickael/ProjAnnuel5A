using UnityEngine;
using System.Collections;

public class ActivateObjectsOnTimer : MonoBehaviour {

    public GameObject[] objectsToDisable;
    public GameObject[] objectsToEnable;
    public float timesToDisable;
    public float timesToEnable;

    void Start()
    {
        StartCoroutine(TimerToActivate());
        StartCoroutine(TimerToDisActivate());
    }
    IEnumerator TimerToDisActivate()
    {
        yield return new WaitForSeconds(timesToDisable);
        for (int i = 0; i < objectsToDisable.Length; i++)
        {
            objectsToDisable[i].SetActive(false);
        }
    }
    IEnumerator TimerToActivate()
    {
        yield return new WaitForSeconds(timesToEnable);
        for (int i = 0; i < objectsToEnable.Length; i++)
        {
            objectsToEnable[i].SetActive(true);
        }
    }
}
