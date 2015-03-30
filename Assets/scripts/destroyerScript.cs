using UnityEngine;
using System.Collections;

public class destroyerScript : MonoBehaviour 
{
	void OnCollisionEnter2D(Collision2D hit)
	{
		Debug.Log ("hit");
		if(hit.gameObject.tag == "Ground")
		{
			Destroy(hit.gameObject);
			Debug.Log ("hit");
		}
	}

}
