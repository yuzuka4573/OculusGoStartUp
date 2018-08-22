using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBullet : MonoBehaviour {
    public float speed = 10f;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().velocity = transform.right * speed;
    }
	
}
