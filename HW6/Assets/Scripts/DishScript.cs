using UnityEngine;
using System.Collections;

public class DishScript : MonoBehaviour {
    public Transform pointA, pointB;

    private bool direction;
    private float speed, currentPoint;
    private AudioSource aud;


    // Use this for initialization
    void Start() {
        speed = 0.2f;
        currentPoint = 0f;
        direction = false;
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {
        if (direction)
            currentPoint += Time.deltaTime * speed;
        else
            currentPoint -= Time.deltaTime * speed;
        if (currentPoint > 1f) {
            direction = !direction;
            currentPoint = 1f;

            if (aud.isPlaying) {
                aud.Stop();
            } else {
                aud.Play();
            }
        }
        if (currentPoint < 0f) {
            direction = !direction;
            currentPoint = 0f;

            if (aud.isPlaying) {
                aud.Stop();
            } else {
                aud.Play();
            }
        }
        transform.position = Vector3.Lerp(pointA.position, pointB.position, currentPoint);
    }
}
