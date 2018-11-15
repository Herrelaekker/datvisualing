using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableObjects : MonoBehaviour {

    public GameObject[] disableObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DisablingObjects()
    {
        for (int i = 0; i<disableObject.Length; i++)
        {
            disableObject[i].SetActive(false);
        }
    }
}
