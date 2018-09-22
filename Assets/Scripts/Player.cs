using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Player : MonoBehaviour {

	NetworkIdentity networkIdentity;

	void Awake() {
		networkIdentity = GetComponent<NetworkIdentity>();
	}

    void Update() {
    	if(!networkIdentity.hasAuthority) {
    		return;
    	}

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }
}
