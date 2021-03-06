﻿using UnityEngine;
using System.Collections;

public class Tome_Dialogue : MonoBehaviour {
    public string[] answerbuttons;
    public string[] questions;
    bool DisplayDialogue = false;
    bool Activequestion = false;
    bool notactive = false;
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
        if (DisplayDialogue && !Activequestion && !notactive)
        {
            GUILayout.Label(questions[0]);
            if (GUILayout.Button(answerbuttons[0]))
            {
                if (Libary_Dialogue.ArcaneLang)
                {
                    Class_Stats.Mage += 1;
                    Activequestion = true;
                }
                else if (!Libary_Dialogue.ArcaneLang)
                {
                    notactive = true;
                }
                

            }
            if (GUILayout.Button(answerbuttons[1]))
            {

                DisplayDialogue = false;
            }

        }
        if (DisplayDialogue && Activequestion)
        {
            GUILayout.Label(questions[2]);
        }
        if (DisplayDialogue && notactive)
        {
            GUILayout.Label(questions[1]);
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
        notactive = false;

    }
}

