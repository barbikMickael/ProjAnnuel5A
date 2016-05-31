using UnityEngine;
using System.Collections;

public class ShakeScript : MonoBehaviour
{
    public float speed; //0.2
    public float limit; //40
    private float newSpeed;
    private float distance;
    //private bool toRight;
    private float randMove;
    private float count;

    void Start()
    {
        distance = limit / 2;
        count = 1;
        //toRight = true;

        //StartCoroutine(SmoothWind());
    }
    void Update()
    {
        /*if ((distance >= 0)&&(distance <= limit))
		{
			if (toRight)
			{

				transform.Rotate(Vector3.forward * Time.deltaTime * Random.Range (speed-speed/3,speed+speed/3));
				//Debug.Log ("Time spent : " + Time.deltaTime);
				distance += 1 ;
				if (distance >= Random.Range (limit-limit/3,limit+limit/3))
				{
					toRight = false;
				}
			}
			else 
			{
				transform.Rotate(Vector3.back * Time.deltaTime *  Random.Range (speed-speed/3,speed+speed/3));
				//Debug.Log ("Time spent : " + Time.deltaTime);
				distance -= 1;
				if (distance <= Random.Range (0-limit/3, 0+limit/3))
				{
					toRight = true;
				}
			}
		}*/

        if ((count > 0) && (count <= limit))
        {
            count -= 1;
            if (count <= distance)
            {
                count = -limit;
                distance = Random.Range(-1, 0 - limit / 3);
            }
            if (count <= distance * 2)
            {
                newSpeed = newSpeed * 2 / 3;
            }
            else
            {
                newSpeed = Random.Range(speed - speed / 3, speed + speed / 3);
            }
            transform.Rotate(Vector3.forward * Time.deltaTime * newSpeed);
            transform.Rotate(Vector3.right * Time.deltaTime * newSpeed);
            transform.Rotate(Vector3.up * Time.deltaTime * newSpeed);
        }
        else if ((count < 0) && (count >= -limit))
        {
            count += 1;
            if (count >= distance)
            {
                count = limit;
                distance = Random.Range(1, 0 + limit / 3);
            }
            if (count >= distance * 2)
            {
                newSpeed = newSpeed * 2 / 3;
            }
            else
            {
                newSpeed = Random.Range(speed - speed / 3, speed + speed / 3);
            }

            transform.Rotate(Vector3.back * Time.deltaTime * newSpeed);
            transform.Rotate(Vector3.left * Time.deltaTime * newSpeed);
            transform.Rotate(Vector3.down * Time.deltaTime * newSpeed);
        }

    }


    /*IEnumerator SmoothWind()
	{
		while (loop)
		{
			transform.Rotate(Vector3.forward * Time.deltaTime * speed);
			yield return new WaitForSeconds (3);
			transform.Rotate(Vector3.back * Time.deltaTime * speed);
			yield return new WaitForSeconds (3);
		}	
	}*/
    /*
	public AnimationCurve curve;
	public Vector3 distance;
	public float speed;
	
	private Vector3 startPos, toPos;
	private float timeStart;
	public float smoothTime = 0.3F;
	private Vector3 velocity = Vector3.zero;
	
	void randomToPos() {
		toPos = startPos;
		toPos.x += Random.Range(-1.0f, +1.0f) * distance.x;
		toPos.y += Random.Range(-1.0f, +1.0f) * distance.y;
		toPos.z += Random.Range(-1.0f, +1.0f) * distance.z;
		timeStart = Time.time;
	}
	
	// Use this for initialization
	void Start () {
		startPos = transform.position;
		randomToPos();
	}
	
	// Update is called once per frame
	void Update () {
		float d = (Time.time - timeStart) / speed;
		if (d > 0.5) {
			randomToPos();
		} 
		transform.position =  Vector3.SmoothDamp(transform.position, toPos, ref velocity, smoothTime);
		}*/
}