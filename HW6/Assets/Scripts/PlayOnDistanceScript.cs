using UnityEngine;
using System.Collections;

public class PlayOnDistanceScript : MonoBehaviour {

    public AudioClip CloseClip;
    public AudioClip FarClip;



    public GameObject Player;

    public float MinDist;
    public float MaxDist;

    public float CloseVolume;
    public float FarVolume;


    private AudioSource TableSource;
    private bool startAudio;
    private bool playingSizzle;
    public bool PlaySizzle
    {
        get { return playingSizzle; }
        private set
        {
            playingPans = !value;
            playingSizzle = value;
        }
    }
    private bool playingPans;
    public bool PlayPans
    {
        get { return playingPans; }
        private set
        {
            playingSizzle = !value;
            playingPans = value;
        }
    }

    private float dist;

	// Use this for initialization
	void Start () {
        TableSource = this.GetComponent<AudioSource>();
        playingSizzle = false;
        playingPans = false;
        startAudio = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        dist = Vector3.Distance(Player.transform.position, this.transform.position);
	    if (dist < MinDist)
        {
            
            TableSource.clip = CloseClip;
            if (playingSizzle) startAudio = false;
            else startAudio = true;
            PlaySizzle = true;
            TableSource.volume = CloseVolume;
            
        }
        else if (dist < MaxDist)
        {
            TableSource.clip = FarClip;
            if (playingPans) startAudio = false;
            else startAudio = true;
            PlayPans = true;
            TableSource.volume = FarVolume;
        }
        else
        {
            if (TableSource.isPlaying)
            {
                TableSource.Stop();
            }
        }

        if (startAudio)
        {
            TableSource.Play();
        }
	}











    
}
