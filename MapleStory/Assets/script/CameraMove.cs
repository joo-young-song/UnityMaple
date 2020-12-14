using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraMove : MonoBehaviour 
{
	public float smoothTimeX, smoothTimeY;
	public Vector2 velocity;
	public GameObject player;
	private Vector2 minPos, maxPos;
	public int mapNum = 0;
	public bool bound;

	void Start () 
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}


	void FixedUpdate () {

		float posX = Mathf.SmoothDamp (transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
		float posY = Mathf.SmoothDamp (transform.position.y, player.transform.position.y, ref velocity.y, smoothTimeY);

		transform.position = new Vector3 (posX, posY, transform.position.z);

		if(mapNum == 0)
		{
			maxPos.x = 6.75f;
			minPos.x = -6.7f;
			minPos.y = 0;
			maxPos.y = 0;
		}
		else if(mapNum == 1)
		{
			maxPos.x = 32.22f;
			minPos.x = 27.73f;
			
			minPos.y = 0;
			maxPos.y = 1.4f;
		}
		else if(mapNum == 2)
		{
			maxPos.x = 66.5f;
			minPos.x = 53.5f;
			
			minPos.y = 0;
			maxPos.y = 1.3f;
		}
		else if(mapNum == 3)
		{
			minPos.x = 85.3f;
			maxPos.x = 94.5f;
			minPos.y = 0;
			maxPos.y = 5.0f;
		}


		transform.position = new Vector3 (Mathf.Clamp (transform.position.x, minPos.x, maxPos.x),
		Mathf.Clamp (transform.position.y, minPos.y, maxPos.y),
		Mathf.Clamp (transform.position.z, transform.position.z, transform.position.z));

		

	}

}