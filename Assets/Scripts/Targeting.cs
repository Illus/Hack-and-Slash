using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Targeting : MonoBehaviour 
{
	public List<Transform> targets;
	
	void Start () 
	{
		targets = new List<Transform>();

		AddAllEnemies();
	}

	public void AddAllEnemies ()
	{
		GameObject[] go = GameObject.FindGameObjectsWithTag("Enemy");

		foreach (GameObject enemy in go)
		{
			AddTarget(enemy.transform);
		}
	}

	public void AddTarget (Transform enemy)
	{
		targets.Add (enemy);
	}

	void Update () 
	{
	
	}

}
