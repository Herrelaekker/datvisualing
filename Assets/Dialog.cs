using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialog {

    public string girlName;

    public string[] name;

    [TextArea(3, 10)]
    public string[] sentences;

    public Sprite[] state;

    public GameObject[] optionButton;

}