using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boom : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (shipcontril.boomexist == true && Input.GetKeyDown(KeyCode.B))
        {
            Destroy(gameObject);
        }

    }
}
