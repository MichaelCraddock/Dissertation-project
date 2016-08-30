using UnityEngine;
using System.Collections;

public class Fight_event : MonoBehaviour {
    public string[] answerbuttons;
    public string[] questions;
    bool DisplayDialogue = false;
    bool Activequestion = false;
    public static bool destroythugs = false;
    bool end = false;
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
        if (DisplayDialogue && !Activequestion)
        {
            GUILayout.Label(questions[0]);
            if (GUILayout.Button(answerbuttons[0]))
            {
                Class_Stats.Warrior += 1;
                Activequestion = true;
                destroythugs = true;
                end = true;

            }

            if (GUILayout.Button(answerbuttons[1]))
            {

                DisplayDialogue = false;

            }

        }
        if (DisplayDialogue && Activequestion)
        {
            GUILayout.Label(questions[1]);
        }
        GUILayout.EndArea();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        DisplayDialogue = true;
        Debug.Log("Something here");
        if (end)
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
