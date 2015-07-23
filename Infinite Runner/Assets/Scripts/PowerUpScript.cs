using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour {

	HUDScript hud;

	void Awake()
	{
		hud = GameObject.Find("Main Camera").GetComponent<HUDScript> ();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			hud.IncreaseScore(10);
			Destroy(this.gameObject);
		}
	}
}
