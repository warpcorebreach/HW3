using UnityEngine;
using System.Collections;

public class HostStandScript : MonoBehaviour {
    private AudioSource aud;

    // Use this for initialization
    void Start() {
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter() {
        aud.Play();
    }

}
