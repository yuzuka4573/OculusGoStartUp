using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSpawn : MonoBehaviour {
    private AudioSource se;
    public bool isRing = false;
    // Use this for initialization
    void Start () {
        se = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (isRing)
        {
            se.PlayOneShot(se.clip);
            isRing = false;
        }
    }
}
