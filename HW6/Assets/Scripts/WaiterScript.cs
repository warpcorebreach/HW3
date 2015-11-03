using UnityEngine;
using System.Collections;

public class WaiterScript : MonoBehaviour {
    public Transform[] tables;

    private AudioSource aud;
    private int curTable;

	// Use this for initialization
	void Start () {
        aud = GetComponent<AudioSource>();
        curTable = 0;
        aud.Play();
	}
	
	// Update is called once per frame
	void Update () {
	    if (!aud.isPlaying) {
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, tables[(curTable + 1)%3].position.z), 1f);
            curTable++;
            aud.Play();
        }
	}
}
