using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
    private Animator anim;
	
    void Start()
    {
        anim = GetComponent<Animator>();
    }
	// Update is called once per frame
	void Update () {
        float input_x = Input.GetAxisRaw("Horizontal");
        float input_y = Input.GetAxisRaw("Vertical");

        bool isWalking = (Mathf.Abs(input_x) + Mathf.Abs(input_y)) > 0;
        anim.SetBool("isWalking", isWalking);
        if (isWalking)
        {
            anim.SetFloat("x", input_x);
            anim.SetFloat("y", input_y);

            transform.position += new Vector3(input_x, input_y, 0).normalized * 0.05f;
        }
        

    }

}
