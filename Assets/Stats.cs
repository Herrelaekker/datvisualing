using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour {

    private Text statText;
    public int statNumber;
    public string statName;

    private Text statsNumberText;
    private int statsNumber;

	// Use this for initialization
	void Start () {

        statNumber = PlayerPrefs.GetInt(statName);
        statText = GameObject.Find(statName.ToString()).GetComponent<Text>();
        statText.text  = PlayerPrefs.GetInt(statName).ToString();

        statsNumber = PlayerPrefs.GetInt("statsNumber");
        statsNumberText = GameObject.Find("StatsNumber").GetComponent<Text>();
        statsNumberText.text = PlayerPrefs.GetInt("statsNumber").ToString();
    }
	
	// Update is called once per frame
	void Update () {

	}

    public void AddStat()
    {
        statsNumber = PlayerPrefs.GetInt("statsNumber");
        statNumber = PlayerPrefs.GetInt(statName);

        if (statsNumber > 0)
        {
            statsNumber -= 1;
            PlayerPrefs.SetInt("statsNumber", statsNumber);
            statsNumberText.text = PlayerPrefs.GetInt("statsNumber").ToString();
            statsNumber = 0;

            statNumber += 1;
            PlayerPrefs.SetInt(statName, statNumber);
            statText.text = PlayerPrefs.GetInt(statName).ToString();
            statNumber = 0;
        }
    }

    public void ResetStats()
    {

        for (int i=1; i<6; i++)
        {
            statText = GameObject.Find("stat" + i).GetComponent<Text>();
            PlayerPrefs.SetInt("stat" + i, 0);
            statText.text = PlayerPrefs.GetInt("stat" + i).ToString();
        }

        PlayerPrefs.SetInt("statsNumber", 10);
        statsNumberText.text = PlayerPrefs.GetInt("statsNumber").ToString();
    }
}
