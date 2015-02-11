using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour 
{
	public Transform target;
	public int moveSpeed;
	public int rotationSpeed;

	private Transform myTransform;

	void Awake ()
	{
		myTransform = transform;
	}
	
	void Start () 
	{
		GameObject go = GameObject.FindGameObjectWithTag("Player");
	}

	void Update () 
	{
	
	}

}
