using UnityEngine;
using System.Collections;

public class Blacksmith_Dialogue : MonoBehaviour {
    public string[] answerbuttons;
    public string[] questions;
    bool DisplayDialogue = false;
    bool Activequestion = false;
    bool Weaponquestion = false;
    bool Armourquestion = false;
    bool warwep = false;
    bool roguewep = false;
    bool Warriorset = false;
    bool Rogueset = false;
    bool Finished = false;
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
        if (DisplayDialogue && !Activequestion && !Weaponquestion && !Armourquestion && !Rogueset && !roguewep && !Warriorset && !warwep)
        {
            GUILayout.Label(questions[0]);
            if (GUILayout.Button(answerbuttons[0]))
            {
                Weaponquestion = true;
            }
            if (GUILayout.Button(answerbuttons[1]))
            {

                DisplayDialogue = false;
            }

        }
        if (DisplayDialogue && Weaponquestion && !Armourquestion)
        {
            GUILayout.Label(questions[1]);
            if (GUILayout.Button(answerbuttons[2]))
            {
                Class_Stats.Warrior += 0.5f;
                warwep = true;
                Armourquestion = true;
                Weaponquestion = false;

            }
            if (GUILayout.Button(answerbuttons[3]))
            {
                Class_Stats.Rogue += 0.5f;
                roguewep = true;
                Armourquestion = true;
                Weaponquestion = false;
            }


        }
        if (DisplayDialogue && Armourquestion)
        {
            GUILayout.Label(questions[2]);
            if (GUILayout.Button(answerbuttons[4]))
            {
                Class_Stats.Warrior += 0.5f;
                Warriorset = true;
                Armourquestion = false;
            }
            if (GUILayout.Button(answerbuttons[5]))
            {
                Class_Stats.Rogue += 0.5f;
                Rogueset = true;
                Armourquestion = false;
            }
        }
        if (DisplayDialogue && warwep && Warriorset && !Armourquestion)
        {
            GUILayout.Label(questions[3]);
            Finished = true;
        }
        if(DisplayDialogue && roguewep && Rogueset)
        {
            GUILayout.Label(questions[4]);
            Finished = true;
        }
        if(DisplayDialogue && roguewep && Warriorset)
        {
            GUILayout.Label(questions[5]);
            Finished = true;
        }
        if(DisplayDialogue && warwep && Rogueset)
        {
            GUILayout.Label(questions[6]);
            Finished = true;
        }

        GUILayout.EndArea();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        DisplayDialogue = true;
        Debug.Log("Something here");
        if (Finished)
        {
            DisplayDialogue = false;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        DisplayDialogue = false;
        Debug.Log("Something has left");

    }
}
