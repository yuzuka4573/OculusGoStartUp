using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakObject : MonoBehaviour {
    public GameObject Exprode;
    bool isfirst = true;
	// Use this for initialization
	void Start () {
		
	}


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Ammo")
        {
            Debug.Log("true");
            if (isfirst)
            {
                Instantiate(Exprode, gameObject.transform.position, gameObject.transform.rotation);
                isfirst = false;
            }
            Destroy(gameObject);
        }
    }
}
