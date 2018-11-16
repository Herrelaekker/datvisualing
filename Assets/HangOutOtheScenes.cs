using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HangOutOtheScenes : MonoBehaviour {

    private float timer;

    public void Start()
    {
        timer = PlayerPrefs.GetInt("girl1");
    }

    public void Hangout(int time)
    {
        timer = time;
    }

    public void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            PlayerPrefs.SetInt("girl1", Mathf.RoundToInt(timer));
        }
    }
}
