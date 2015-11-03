using UnityEngine;
using System.Collections;

public class RandomConvo : MonoBehaviour {
    public AudioClip[] clips;

    private AudioSource aud;

	// Use this for initialization
	void Start () {
        aud = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (!aud.isPlaying) {
            aud.clip = clips[Random.Range(0, 3)];
            aud.Play();
        }
	}
}
