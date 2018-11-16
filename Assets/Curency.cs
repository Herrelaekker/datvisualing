using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Curency : MonoBehaviour {

    private int money;
    private int energy;
    private float experience;

    public Text moneyText;
    public Text energyText;

    //Hangout
    public Text hangoutStatusText;
    public Text hangoutTimerText;

    public GameObject hangoutButton;
    public GameObject skipButton;

    // Use this for initialization
    void Start () {
        money = PlayerPrefs.GetInt("money");
        energy = PlayerPrefs.GetInt("energy");

        experience = PlayerPrefs.GetInt("experience");

        energyText.text = energy.ToString();
        moneyText.text = money.ToString();
    }

    public void AddMoney(int extraMoney)
    {
        money = PlayerPrefs.GetInt("money");
        money += extraMoney;
        PlayerPrefs.SetInt("money",money);
        moneyText.text = money.ToString();
    }

    public void AddEnergy(int extraEnergy)
    {
        energy = PlayerPrefs.GetInt("energy");
        energy += extraEnergy;
        PlayerPrefs.SetInt("energy", energy);
        energyText.text = energy.ToString();
    }

    public void Update()
    {
        int girl1 = PlayerPrefs.GetInt("girl1");
        if (girl1 > 0)
        {
            hangoutStatusText.text = "Currently brewing Coffee...";
            hangoutTimerText.text = girl1.ToString() + " s";
            hangoutButton.SetActive(false);
            skipButton.SetActive(true);
        }
        else
        {
            hangoutStatusText.text = "Ready";
            hangoutTimerText.text = "Free";
            hangoutButton.SetActive(true);
            skipButton.SetActive(false);
        }
    }
}
