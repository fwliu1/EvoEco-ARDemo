using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brownbinInit : MonoBehaviour {

    private GameObject brownbins;

	// Use this for initialization
	void Start () {
        brownbins = GameObject.FindGameObjectWithTag("brownbins");
        brownbins.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
