using UnityEngine;
using System.Collections;

public class CollisionComponent : MonoBehaviour {

    public AudioClip collisionSound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("!");
        if (collision.relativeVelocity.magnitude > 10)
        {
            gameObject.GetComponent<AudioSource>().PlayOneShot(collisionSound);
        }

    }
}
