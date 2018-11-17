using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogTrigger : MonoBehaviour {

    public Dialog dialog;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }

    public void FirstDialog()
    {
        if (PlayerPrefs.GetInt("progress") == 0)
            FindObjectOfType<DialogManager>().StartDialog(dialog);
    }
}
