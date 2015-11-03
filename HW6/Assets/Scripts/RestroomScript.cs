using UnityEngine;
using System.Collections;

public class RestroomScript : MonoBehaviour {
    public AudioSource ambient;

    private AudioSource aud;

	// Use this for initialization
	void Start () {
        aud = GetComponentInChildren<AudioSource>();
        StartCoroutine(FlushToilet());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator FlushToilet() {
        while (true) {
            yield return new WaitForSeconds(Random.Range(10f, 30f));
            aud.Play();
        }
    }

    void OnTriggerStay(Collider other) {
        if (other.GetComponent<Rigidbody>().tag.Equals("Player")) {
            ambient.volume = 0.2f;
            Debug.Log("player entered bathroom");
        }
    }

    void OnTriggerExit() {
        ambient.volume = 0.5f;
    }
}
