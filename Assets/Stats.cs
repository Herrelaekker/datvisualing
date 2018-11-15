using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour {

    private int stat1;
    private int stat2;

	// Use this for initialization
	void Start () {
        stat1 = PlayerPrefs.GetInt("stat1");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Q))
        {
            stat1 += 1;
            PlayerPrefs.SetInt("stat1", stat1);
            Debug.Log(PlayerPrefs.GetInt("stat1"));
        }
	}
}
