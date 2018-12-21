using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whitebinInit : MonoBehaviour {

    private GameObject whitebins;

    // Use this for initialization
    void Start()
    {
        whitebins = GameObject.FindGameObjectWithTag("whitebins");
        whitebins.SetActive(false);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
