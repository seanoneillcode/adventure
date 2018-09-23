using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cahrcontroller : MonoBehaviour {

    public SpriteRenderer spriteRenderer;
    public Animator animator;
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        
        if (Mathf.Abs(x) > 0)
        {
            spriteRenderer.flipX = x < 0;
        }

        transform.Translate(x, 0, 0);
        transform.Translate(0, 0, z);

        animator.SetBool("isWalking", Mathf.Abs(x) + Mathf.Abs(z) > 0);
    }
}
