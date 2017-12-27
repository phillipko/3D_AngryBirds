using UnityEngine;
using System.Collections;

public class PigCollision : MonoBehaviour {
     
    public static int destroyCount = 0;
    int count = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    { 
	}

    void OnCollisionEnter(Collision collision)
    {
        //
        if (collision.gameObject.tag == "Bird" && collision.relativeVelocity.magnitude > 10)
        {
            count++;
            if (count == 2)
            {
                GameObject.Destroy(this.gameObject, 1.01f);
                destroyCount++;
                Debug.Log(destroyCount);
            }

        }
        
        
    }
}
