using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D col) {
        
        if(col.gameObject.name == "Enemy")
        {
            Destroy(col.gameObject);   
        }
	
	}
}
