
using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
	public float speed = 10;
	public float jumpHeight = 13;
	private Vector2 _moveDir;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		_moveDir = new Vector2(Input.GetAxis("Horizontal") * speed, this.GetComponent<Rigidbody2D>().velocity.y);
		this.GetComponent<Rigidbody2D>().velocity = _moveDir;

		if(this.transform.position.y < -10 || this.transform.position.x < - 15)
		{
			Application.LoadLevel(1);
		}
	}

	void OnCollisionStay2D(Collision2D other)
	{
		if(other.gameObject.tag == "Ground" && this.transform.position.y + this.gameObject.GetComponent<MeshRenderer>().bounds.size.y / 2 > other.gameObject.transform.position.y + other.gameObject.GetComponent<MeshRenderer>().bounds.size.y / 2)
		{
			if(Input.GetButton("Jump"))
			{
				_moveDir.y = jumpHeight;
				this.GetComponent<Rigidbody2D>().velocity = _moveDir;
			}
		}
	}
}
