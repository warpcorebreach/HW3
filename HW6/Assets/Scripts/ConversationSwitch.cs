using UnityEngine;
using System.Collections;

public class ConversationSwitch : MonoBehaviour {
    public AudioClip[] clips;

    private AudioSource aud;

    // Use this for initialization
    void Start() {
        aud = GetComponent<AudioSource>();
        aud.clip = clips[0];
        aud.loop = true;
        aud.Play();
    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter() {
        aud.Stop();
        aud.loop = false;
        aud.clip = clips[1];
        aud.Play();
    }

    void OnTriggerExit() {
        aud.Stop();
        aud.loop = true;
        aud.clip = clips[0];
        aud.Play();
    }
}
