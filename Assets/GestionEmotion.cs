using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GestionEmotion : MonoBehaviour {
    int emotion = 10;
    public GameObject queryChan;
    public Image jauge;
    private Color myColor;
    QuerySDEmotionalController qec;

    /*
    changer jauge et mettre chaque émotions avec une jauge et up les jauges correspondantes
        */


    // Use this for initialization
    void Start () {
        //qec = GetComponent<QuerySDEmotionalController>();
        myColor = new Color(2.0f * 1/emotion * 5, 2.0f * (1 - 1/emotion * 5), 0);
        jauge.color = myColor;
    }
	
	// Update is called once per frame
	void Update () {

        //pulling d'émotion renvoyé par les lunettes
        if (Input.GetKeyUp(KeyCode.Z))
        {
            if (emotion < 21)
            {
                emotion++;
                myColor = new Color(2.0f * 1 / emotion * 5, 2.0f * (1 - 1 / emotion * 5), 0);
                jauge.color = myColor;
                Debug.Log("z" + " " + emotion);
            }
        }

        else if (Input.GetKeyUp(KeyCode.S))
        {
            if (emotion > 1)
            {
                emotion--;
                myColor = new Color(2.0f * 1 / emotion * 5, 2.0f * (1 - 1 / emotion * 5), 0);
                jauge.color = myColor;
                Debug.Log("s" + " " + emotion);
            }
        }
       
        if (emotion < 8)
            queryChan.GetComponent<QuerySDEmotionalController>().ChangeEmotion(QuerySDEmotionalController.QueryChanSDEmotionalType.NORMAL_ANGER);
        else if (emotion > 14)
            queryChan.GetComponent<QuerySDEmotionalController>().ChangeEmotion(QuerySDEmotionalController.QueryChanSDEmotionalType.NORMAL_SMILE);
        else
            queryChan.GetComponent<QuerySDEmotionalController>().ChangeEmotion(QuerySDEmotionalController.QueryChanSDEmotionalType.NORMAL_DEFAULT);

    }
    public int GetEmotion()
    {
        return emotion;
    }
}
