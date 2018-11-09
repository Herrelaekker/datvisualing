using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour {

    public Text nameText;
    public Text dialogText;
    public Image personImage;

    public GameObject dialogBox;

    private Queue<string> names;
    private Queue<string> sentences;
    private Queue<Sprite> states;

    public GameObject[] optionButton;
    public int choice = 0;

    // Use this for initialization
    void Start () {
        sentences = new Queue<string>();
        names = new Queue<string>();
        states = new Queue<Sprite>();
	}
	
	public void StartDialog (Dialog dialog)
    {
        //sætter valuesne til det man har defineret.
        optionButton = dialog.optionButton;

        //fjerner alle dialogboxe
        GameObject[] buttons = GameObject.FindGameObjectsWithTag("Button");
        foreach (GameObject button in buttons)
        {
            button.SetActive(false);
        }

        //viser doalogboxen
        dialogBox.SetActive(true);

        //sletter de gamle beskeder
        sentences.Clear();
        names.Clear();

        //for hver besked i arrayet, sætter den beskedern i en liste.
        foreach (string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence);
        }

        foreach (string name in dialog.name)
        {
            names.Enqueue(name);
        }

        foreach (Sprite sprite in dialog.state)
        {
            states.Enqueue(sprite);
        }

        print(name);

        //Vis næste besked
        DisplayNextSentence();
    }

        public void  DisplayNextSentence()
    {
        //hvis der ikke er flere beskeder -> slut dialogen
        if (sentences.Count == 0)
        {
            EndDialog();
            return;
        }

        Sprite sprite = states.Dequeue();
        personImage.sprite = sprite;
        personImage.enabled = false;

        string name = names.Dequeue();
        nameText.text = name;
        //fjerner en besked fra listen
            string sentence = sentences.Dequeue();
        //afbryder forrige forsøg på at klikke videre.
            StopAllCoroutines();
        //skriver beskeden
            StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        //texten bliver først ingenting
        dialogText.text = "";
        //Den skriver hvert bogstav, et ad gangen
        foreach (char letter in sentence.ToCharArray())
        {
            dialogText.text += letter;
            yield return null;
        }
    }

    void EndDialog()
    {
        //dialogbox bliver fjernet
        dialogBox.SetActive(false);

        //hver option dukker op
        for (int i = 0; i < optionButton.Length; i++)
        {
            optionButton[i].SetActive(true);
        }
    }

    public void NewChoice()
    {
        choice += 1;
    }

}
