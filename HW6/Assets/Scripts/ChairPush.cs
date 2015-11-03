using UnityEngine;
using System.Collections;

public class ChairPush : MonoBehaviour {
    private AudioSource aud;

    // Use this for initialization
    void Start() {
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerStay(Collider other) {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb.tag.Equals("Player")) {
            aud.Play();
            GetComponent<Rigidbody>().AddForceAtPosition(5f * gameObject.transform.forward, rb.transform.forward, ForceMode.Acceleration);
        }

    }

    void OnTriggerExit() {
        aud.Stop();
    }
}
