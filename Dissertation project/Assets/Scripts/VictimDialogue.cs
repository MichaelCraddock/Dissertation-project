using UnityEngine;
using System.Collections;

public class VictimDialogue : MonoBehaviour {
    public string[] questions;
    bool DisplayDialogue = false;
    public GUISkin skin = null;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(100, 150, 180, 180));
        GUI.skin = skin;
        if (DisplayDialogue)
        {

            GUILayout.Label(questions[0]);
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
