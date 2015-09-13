using UnityEngine;
using System.Collections;

public class SticksCollision : MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{
		AudioSource audio = GetComponent<AudioSource> ();
		audio.Play();
	}
}
