using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour 
{
	public GameObject target;
	
	void Start () 
	{
	
	}

	void Update () 
	{
		if (Input.GetKeyUp(KeyCode.F))
		{
			Attack();
		}
	}

	private void Attack()
	{
		EnemyHealth eh = (EnemyHealth)target.GetComponent("EnemyHealth");
		eh.AdjustCurrentHealth(-10);
	}

}
