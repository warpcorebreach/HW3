using UnityEngine;
using System.Collections;

public class MicrowaveScript : MonoBehaviour {

    public GameObject Player;

    public float MinDist;

    private AudioSource source;
    private float dist;
    
    // Use this for initialization
	void Start () {
        source = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        dist = Vector3.Distance(Player.transform.position, this.transform.position);
        if (dist < MinDist && !source.isPlaying)
        {
            source.Play();
        }
	}
}
