using UnityEngine;
using System.Collections;

public class WallDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        //GameObject.Destroy(this.gameObject);
        if (PigCollision.destroyCount == 10)
        {
            GameObject.Destroy(this.gameObject);
        }

    }
}
