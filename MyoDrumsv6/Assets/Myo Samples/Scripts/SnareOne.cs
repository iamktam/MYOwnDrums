using UnityEngine;
using System.Collections;

public class SnareOne : MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{
        AudioSource[] audio = GetComponents<AudioSource>();
        if (audio[0].isPlaying)
        {
            audio[1].Play ();
        }
		Vector3 contactPoint = col.contacts[0].point;
		Vector3 center = col.collider.bounds.center;
		bool top = contactPoint.y < center.y;
		if (top) {
			audio[0].Play ();
		}
	}
}
