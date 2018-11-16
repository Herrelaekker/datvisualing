using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HangOutTimer : MonoBehaviour {

    private float timer;

    public GameObject[] PopUpMessages;

    //time
    [SerializeField]
    private Stat girl1Progress;

    private void Awake()
    {
        girl1Progress.Initialize();
    }

    public void Start()
    {
        timer = PlayerPrefs.GetInt("girl1");
        girl1Progress.CurVal = PlayerPrefs.GetInt("girl1");
    }

    public void Hangout(int time)
    {
        timer = time;
        girl1Progress.CurVal = timer;
    }

    public void StopHangout(int price)
    {
        int money = PlayerPrefs.GetInt("money");

        if (money > price)
        {
            timer = 0;
            PlayerPrefs.SetInt("girl1", 0);
            money -= price;
            PlayerPrefs.SetInt("money", money);
        }
        else
        {
            for (int i = 0; i < PopUpMessages.Length; i++)
                PopUpMessages[i].SetActive(true);
        }
    }

    public void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            PlayerPrefs.SetInt("girl1", Mathf.RoundToInt(timer));
            girl1Progress.CurVal -= Time.deltaTime;
        }
        else
            girl1Progress.CurVal = 0;
    }
}
