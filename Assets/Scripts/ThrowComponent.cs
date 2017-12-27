using UnityEngine;
using System.Collections;

public class ThrowComponent : MonoBehaviour
{
    public GameObject bird;
    public float birdVelocity = 50.00f;
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetButtonUp("Fire1"))
        {
         //   Debug.Log("Fire1");
            GameObject newObject = (GameObject)Instantiate(bird);
            newObject.GetComponent<Rigidbody>().position = this.gameObject.transform.position;
            newObject.GetComponent<Rigidbody>().velocity = this.gameObject.transform.forward * birdVelocity;
            //newObject.GetComponent<Rigidbody>().velocity = transform.worldToLocalMatrix.MultiplyVector(transform.forward) * birdVelocity;

            GameObject.Destroy(newObject, 3.00f);
        }
	}
}
