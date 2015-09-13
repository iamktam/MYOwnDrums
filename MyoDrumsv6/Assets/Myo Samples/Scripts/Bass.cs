using UnityEngine;
using System.Collections;

public class Bass : MonoBehaviour {
	
	void OnCollisionEnter(Collision col)
	{
		Debug.Log (0);
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play ();
	}
}
