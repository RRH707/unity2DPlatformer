using UnityEngine;
using System.Collections;

public class WorldMover : MonoBehaviour 
{
	private Vector3 _moveDir;
	public float speed = 1f;
	
	// Use this for initialization
	void Start () 
	{
		_moveDir = new Vector3(speed, 0, 0);
	}
	
	// Update is called once per frame
	void Update () 
	{
		this.transform.position -= _moveDir;

		if(this.transform.position.x < -15)
		{
			Destroy(this.gameObject);
		}

	}
}
