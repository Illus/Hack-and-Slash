using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour 
{
	public int maxHealth = 100;
	public int curHealth = 100;

	public float healthBarLength;

	void Start () 
	{
		healthBarLength = Screen.width / 2;
	}

	void Update () 
	{
	
	}

	void OnGUI ()
	{
		GUI.Box(new Rect(10, 10, Screen.width / 2 / (maxHealth / curHealth), 20), curHealth + "/" + maxHealth);
	}
}
