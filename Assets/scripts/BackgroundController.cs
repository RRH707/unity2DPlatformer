using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour 
{
	public GameObject background;
	public GameObject background2;
	public float speed;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		background.transform.position -= new Vector3(speed, 0, 0);
		background2.transform.position -= new Vector3(speed, 0, 0);
		if(background.transform.position.x < -background.GetComponent<SpriteRenderer>().bounds.size.x)
		{
			background.transform.position = new Vector3(background2.transform.position.x + background.GetComponent<SpriteRenderer>().bounds.size.x, background2.transform.position.y, background2.transform.position.z);
		}


	}
}
