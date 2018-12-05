using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameontroller : MonoBehaviour {

    public KeyCode key;
    bool active = false;
    GameObject note;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetKeyDown(key)&&active)
        {
            Destroy(note);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        active = true;
        if(other.gameObject.tag == "Note")
        {
            note = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        active = false;
    }

    
}
