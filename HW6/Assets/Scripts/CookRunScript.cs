using UnityEngine;
using System.Collections;

public class CookRunScript : MonoBehaviour {

    public Transform pointA, pointB;
    public GameObject Player;

    private AudioSource source;
    public AudioClip KnifeSlice;
    public AudioClip RunClip;
    public AudioClip Scream;

    public float MinDist = 5f;

    private float speed, currentPoint;

    private float dist;
    private bool moved;

    // Use this for initialization
    void Start()
    {
        speed = 7f;
        currentPoint = 0f;
        source = this.GetComponent<AudioSource>();
        source.clip = RunClip;
        moved = false;
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(Player.transform.position, this.transform.position);
        if (dist < MinDist && !moved)
        {
            
            StartCoroutine("Move");
            moved = true;
        }


        
    }

    IEnumerator Move()
    {
        source.clip = KnifeSlice;
        source.Play();
        yield return new WaitForSeconds(3);

        source.clip = Scream;
        source.Play();
        float iter = Scream.length / 100.0f;
        for (int i = 0; i < 50; i++)
        {
            yield return new WaitForSeconds(iter);
            source.pitch += 0.01f;
        }

        source.pitch = 1;
        source.clip = RunClip;
        source.Play();
        //startTime = Time.time;
        //jLength = Vector3.Distance(pointA.position, pointB.position);
        //float dCovered = (Time.time - startTime) * speed;
        //float fraction = dCovered / jLength;
        float curTime = 0;
        float jTime = 5;
        while(curTime < jTime)
        {
            transform.position = Vector3.Lerp(pointA.position, pointB.position, (curTime / jTime));
            curTime += Time.deltaTime;
            yield return null;
        }
        moved = false;
        transform.position = pointA.position;
    }
}
