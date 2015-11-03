using UnityEngine;
using System.Collections;

public class KitchenCollision : MonoBehaviour {

    public AudioSource CollisionSource;

    public AudioClip CollisionClip;

    void Start()
    {
        CollisionSource.clip = CollisionClip;
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        CollisionSource.clip = CollisionClip;
        if (other.gameObject.tag.Equals("Player"))
        {
            CollisionSource.Play();
        }
    }
}
