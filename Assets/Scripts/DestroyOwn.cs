using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOwn : MonoBehaviour {

    float timer = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > 5f)
        {
            Debug.Log("destroied...");
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider collision) {
        if(collision.tag!="Target" && collision.tag != "Palyer" && collision.tag != "Effect") Destroy(gameObject);
    }
}
