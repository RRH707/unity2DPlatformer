using UnityEngine;
using System.Collections;

public class ChunkSpawner : MonoBehaviour 
{
	public GameObject chunk;
	private float _timer = 0f;
	public float spawnCoolDown = 1f;
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		_timer += Time.deltaTime;
		if(_timer > spawnCoolDown)
		{
			Instantiate(chunk,new Vector3(10, Random.Range (-3, -9),0), Quaternion.identity);
			_timer = 0;
			spawnCoolDown = Random.Range(2, 3);
		}
	}
}
