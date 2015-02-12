﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Targeting : MonoBehaviour 
{
	public List<Transform> targets;
	public Transform selectedTarget;
	
	void Start () 
	{
		targets = new List<Transform>();
		selectedTarget = null;

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

	private void TargetEnemy ()
	{
		selectedTarget = targets[0];
	}

	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Tab))
		{
			TargetEnemy();
		}
	}

}
