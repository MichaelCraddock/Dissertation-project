using UnityEngine;
using System.Collections;

public class Lockpick_Chest : MonoBehaviour {
    public string[] answerbuttons;
    public string[] questions;
    bool DisplayDialogue = false;
    bool Activequestion = false;
    bool secondchance = false;
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
        GUILayout.BeginArea(new Rect(100, 150, 180, 180));
        GUI.skin = skin;
        if (DisplayDialogue && !Activequestion && !notactive && !secondchance)
        {

                GUILayout.Label(questions[0]);
                if (GUILayout.Button(answerbuttons[0]))
                {
                    if (NPC_DialogueThief.Lockpick)
                    {
                        Class_Stats.Rogue += 1;
                        Activequestion = true;
                    }
                else if (!NPC_DialogueThief.Lockpick)
                {
                    secondchance = true;
                }
            }
          
                if (GUILayout.Button(answerbuttons[1]))
            {
                DisplayDialogue = false;
            }
            
        }
        if (DisplayDialogue && secondchance && !notactive)
        {
            GUILayout.Label(questions[3]);
            if (GUILayout.Button(answerbuttons[2]))
            {
                notactive = true;
            }
            if (GUILayout.Button(answerbuttons[1]))
            {
                secondchance = false;
                DisplayDialogue = false;
            }
        }
        if (DisplayDialogue && notactive && secondchance)
        {
            GUILayout.Label(questions[1]);

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
    }
}
