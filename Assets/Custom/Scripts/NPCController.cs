using UnityEngine;
using System.Collections;

public class NPCController : MonoBehaviour
{
    [SerializeField]
    protected GameObject queryChan;
    //===============================
    [SerializeField]
    QuerySDMecanimController.QueryChanSDAnimationType defaultAnimType = QuerySDMecanimController.QueryChanSDAnimationType.NORMAL_STAND;
    [SerializeField]
    QuerySDEmotionalController.QueryChanSDEmotionalType defaultFaceType = QuerySDEmotionalController.QueryChanSDEmotionalType.NORMAL_DEFAULT;
    // Use this for initialization

    public float newAnimType;
    private int lastAnimType;

    void OnEnable()
    {
        newAnimType = (int)defaultAnimType;
        if (queryChan == null)
        {
            queryChan = this.gameObject;
        }
    }

    void Start () {
        ChangeAnimation((int)defaultAnimType);
        ChangeEmotion(defaultFaceType);
        lastAnimType = (int)defaultAnimType;
    }

    void Update()
    {
        if ((int)newAnimType != lastAnimType)
        {
            lastAnimType = (int) newAnimType;
            ChangeAnimation(lastAnimType);
        }
    }
    public void ChangeEmotion(QuerySDEmotionalController.QueryChanSDEmotionalType faceNumber)
    {
        queryChan.GetComponent<QuerySDEmotionalController>().ChangeEmotion(faceNumber);
    }

    public void ChangeAnimation(int animNumber)
    {
        queryChan.GetComponent<QuerySDMecanimController>().ChangeAnimation((QuerySDMecanimController.QueryChanSDAnimationType)animNumber);
    }
}
