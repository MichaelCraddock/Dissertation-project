using UnityEngine;
using System.Collections;

public class NPC_Captain : MonoBehaviour {
    public string[] answerbuttons;
    public string[] questions;
    bool DisplayDialogue = false;
    bool Activequestion = false;
    bool secondresponse = false;
    public GUISkin skin = null;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(150, 225, 200, 200));
        GUI.skin = skin;
        if (DisplayDialogue && !Activequestion && !secondresponse)
        {


            if (Class_Stats.Warrior == 0)
            {
                GUILayout.Label(questions[0]);
            }
            if (Class_Stats.Warrior >= 1)
            {
                GUILayout.Label(questions[1]);
                if (GUILayout.Button(answerbuttons[0]))
                {
                    Class_Stats.Warrior += 1;
                    Activequestion = true;
                }
                if (GUILayout.Button(answerbuttons[1]))
                {
                    secondresponse = true;
                }
            }
        }
        if (DisplayDialogue && secondresponse)
        {
            GUILayout.Label(questions[3]);

        }
        if (DisplayDialogue && Activequestion)
        {
            GUILayout.Label(questions[2]);

        }
        GUILayout.EndArea();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        DisplayDialogue = true;
        Debug.Log("Something here");
    }
    void OnTriggerExit2D(Collider2D col)
    {
        DisplayDialogue = false;
        Debug.Log("Something has left");
        secondresponse = false;
    }
}
