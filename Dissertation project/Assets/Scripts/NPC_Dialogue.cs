﻿using UnityEngine;
using System.Collections;

public class NPC_Dialogue : MonoBehaviour {
    public string[] answerbuttons;
    public string[] questions;
    bool DisplayDialogue = false;
    bool Activequestion = false;
    bool notinterested = false;
    public static bool guardtrue = false;
    public GUISkin skin = null;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI(){
        GUILayout.BeginArea(new Rect(150, 225, 200, 200));
        GUI.skin = skin;
        if (DisplayDialogue && !Activequestion && !notinterested && !NPC_MageDialogue.magetrue)
        {
            GUILayout.Label(questions[0]);
            if (GUILayout.Button(answerbuttons[0]))
            {
                Class_Stats.Warrior += 1;
                Activequestion = true;
                guardtrue = true;
                
            }
            if (GUILayout.Button(answerbuttons[1]))
            {
                
                DisplayDialogue = false;
            }
            if (GUILayout.Button(answerbuttons[2]))
            {
              
                notinterested = true;
               
            }

        }
        if(DisplayDialogue && Activequestion)
        {
            GUILayout.Label(questions[1]);
            if (GUILayout.Button(answerbuttons[3]))
            {
                DisplayDialogue = false;
            }
            
        }
        if (DisplayDialogue && notinterested)
        {
            GUILayout.Label(questions[2]);
        }
        if (DisplayDialogue && NPC_MageDialogue.magetrue)
        {
            GUILayout.Label(questions[3]);
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
    }
}
