using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabbable : MonoBehaviour {

    private bool grabbed;
    public GameObject grabber;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (grabber != null)
        {
            transform.position = grabber.transform.position;
        }
	}


    public void getGrabbed(GameObject grabber)
    {
        grabbed = true;
        this.grabber = grabber;
    }

    public void release()
    {
        grabbed = false;
        grabber = null;
    }
}
