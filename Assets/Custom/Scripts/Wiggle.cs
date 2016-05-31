using UnityEngine;

public class Wiggle : MonoBehaviour
{

    public AnimationCurve curve;
    public Vector3 distance;
    public float speed;

    private Vector3 startPos, toPos;
    private float timeStart;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;

    void randomToPos()
    {
        toPos = startPos;
        toPos.x += Random.Range(-1.0f, +1.0f) * distance.x;
        toPos.y += Random.Range(-1.0f, +1.0f) * distance.y;
        toPos.z += Random.Range(-1.0f, +1.0f) * distance.z;
        timeStart = Time.time;
    }

    // Use this for initialization
    void Start()
    {
        startPos = transform.position;
        randomToPos();
    }

    // Update is called once per frame
    void Update()
    {
        float d = (Time.time - timeStart) / speed;
        if (d > 0.5)
        {
            randomToPos();
        }
        transform.position = Vector3.SmoothDamp(transform.position, toPos, ref velocity, smoothTime);
    }
}