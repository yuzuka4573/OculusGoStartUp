using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropAmmo : MonoBehaviour {

    public GameObject AmmoPre;
    SoundSpawn SS;
    public bool isShoot=true;
    public float CTime = 0f;
    public float limitCT = 0.25f;
	// Use this for initialization
	void Start () {
        SS = GetComponent<SoundSpawn>();
	}
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) && isShoot) {
            Instantiate(AmmoPre,gameObject.transform.position,gameObject.transform.rotation);
            isShoot = false;
            CTime = 0f;
        }
        if (!isShoot) CTime += Time.deltaTime;
        if (CTime > limitCT) isShoot = true;
	}
}
