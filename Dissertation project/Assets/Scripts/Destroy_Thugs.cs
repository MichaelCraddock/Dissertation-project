using UnityEngine;
using System.Collections;

public class Destroy_Thugs : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Fight_event.destroythugs)
        {
            Destroy(gameObject);
        }
	
	}
}
