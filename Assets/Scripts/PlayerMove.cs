using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    public float speed = 3.0F;
    Vector2 touchPadPt;
    public CharacterController controller;
    // Use this for initialization
    void Start () {
        controller = GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void Update () {
        touchPadPt = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
        if (OVRInput.Get(OVRInput.Button.PrimaryTouchpad) && touchPadPt.y > 0.5 && -0.5 < touchPadPt.x && touchPadPt.x < 0.5) controller.Move(gameObject.transform.forward * speed);
    }
}
