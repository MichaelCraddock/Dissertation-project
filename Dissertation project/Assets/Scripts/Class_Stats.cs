using UnityEngine;
using System.Collections;

public class Class_Stats : MonoBehaviour {
    public static float Rogue = 0.0f;
    public static float Warrior = 0.0f;
    public static float Mage = 0.0f;
    public string[] answerbuttons;
    public string[] questions;
    bool DisplayDialogue = false;
    bool Rogueanswer = false;
    bool Warrioranswer = false;
    bool Mageanswer = false;
    bool Villageranswer = false;
    bool Villager = false;
    bool mixed = false;
    public GUISkin skin = null;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        ClassUpdate();
	
	}

  

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(150, 225, 200, 200));
        GUI.skin = skin;
        if (DisplayDialogue && !Rogueanswer && !Warrioranswer && !Mageanswer && !Villageranswer && !Villager && !mixed)
        {
            GUILayout.Label(questions[0]);
            if (GUILayout.Button(answerbuttons[0]))
            {
               if(Rogue > Warrior && Rogue > Mage)
                {
                    Rogueanswer = true;
                    Debug.Log("Rogue is your class");
                  
                }         
               else if (Mage > Warrior && Mage > Rogue)
                {                
                    Mageanswer = true;
                    Debug.Log("mage is your class");
                }  
               else if (Warrior > Rogue && Warrior > Mage)
                {
                    Warrioranswer = true;
                    Debug.Log("Warrior is your class");
                }
               else if (Warrior == 0 && Mage == 0 && Rogue == 0)
                {
                    Villageranswer = true;
                    Debug.Log("Villager could happen");
                }
               else if (Warrior == Mage && Warrior == Rogue)
                {
                    mixed = true;
                }
               else if (Warrior == Mage)
                {
                    mixed = true;
                }
               else if (Warrior == Rogue)
                {
                    mixed = true;
                }
               else if (Mage == Rogue)
                {
                    mixed = true;
                }
            }
        if (GUILayout.Button(answerbuttons[1]))
            {
                DisplayDialogue = false;
            }
           
        }
        if (DisplayDialogue && Rogueanswer)
        {
            GUILayout.Label(questions[2]);
            if (GUILayout.Button(answerbuttons[4]))
            {
                DisplayDialogue = false;
            }
        }
        if (DisplayDialogue && Mageanswer)
        {
            GUILayout.Label(questions[3]);
            if (GUILayout.Button(answerbuttons[4]))
            {
                DisplayDialogue = false;
            }
        }
        if (DisplayDialogue && Warrioranswer)
        {
            GUILayout.Label(questions[4]);
            if (GUILayout.Button(answerbuttons[4]))
            {
                DisplayDialogue = false;
            }
        }
        if (DisplayDialogue && Villageranswer)
        {
            GUILayout.Label(questions[1]);
            if (GUILayout.Button(answerbuttons[2]))
            {
                Villager = true;
                Villageranswer = false;
            }
            if (GUILayout.Button(answerbuttons[1]))
            {
                Villageranswer = false;
            }
        }
        if (DisplayDialogue && Villager)
        {
            GUILayout.Label(questions[5]);
            if (GUILayout.Button(answerbuttons[4]))
            {
                DisplayDialogue = false;
            }
        }
        if (DisplayDialogue && mixed)
        {
            GUILayout.Label(questions[6]);
            if (GUILayout.Button(answerbuttons[4]))
            {
                DisplayDialogue = false;
            }
        }
        GUILayout.EndArea();
    }

    void ClassUpdate()
    {
        if (Input.GetKeyDown("r"))
        {
            Debug.Log("The warrior stat is: " + Warrior + " The Rogue stat is: " + Rogue + " The mage stat is: " + Mage);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.name == "End NPC")
        {
            DisplayDialogue = true;
            Debug.Log("Something here");
        }
        
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.name == "End NPC")
        {
            DisplayDialogue = false;
            Debug.Log("Something gone");
        }
    }
}



