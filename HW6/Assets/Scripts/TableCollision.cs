using UnityEngine;
using System.Collections;

public class TableCollision : MonoBehaviour {
    private AudioSource aud;

	// Use this for initialization
	void Start () {
        aud = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag.Equals("Player")) {
            aud.Play();
        }
    }
}
