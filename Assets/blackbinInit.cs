using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackbinInit : MonoBehaviour {

    private GameObject blackbins;

    // Use this for initialization
    void Start()
    {
        blackbins = GameObject.FindGameObjectWithTag("blackbins");
        blackbins.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
