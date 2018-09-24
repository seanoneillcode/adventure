using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cahrcontroller : MonoBehaviour {

    public SpriteRenderer spriteRenderer;
    public Animator animator;
    public float speed;
    public float turningSpeed = 60;
    public float movementSpeed = 10;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        //var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        //if (Mathf.Abs(x) > 0)
        //{
        //    spriteRenderer.flipX = x < 0;
        //}

        //transform.Translate(x, 0, 0);
        //transform.Translate(0, 0, z);


        float horizontal = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        float h = turningSpeed * Input.GetAxis("Mouse X");
        transform.Rotate(0, h, 0);

        float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        transform.Translate(horizontal, 0, vertical);

        animator.SetBool("isWalking", Mathf.Abs(vertical) + Mathf.Abs(horizontal) > 0);
    }
}
