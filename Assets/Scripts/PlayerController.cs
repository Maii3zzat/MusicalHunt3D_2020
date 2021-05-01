using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    Animator anim;
    public int health = 20;
    public float walkSpeed;
    public float runSpeed;
    public float backSpeed;
    public float rotSpeed;
    Vector3 moveDirection = Vector3.zero;
    CharacterController controller;
    float rot = 0f;
    float gravity = 8f;
    public musicalNotes notes;

	void Start () {
        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
	}
	

	void Update () {
        controller.Move(moveDirection * Time.deltaTime);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveDirection = new Vector3(0, 0, 1);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection = moveDirection * walkSpeed;
            anim.SetBool("walk", true);
            anim.SetBool("run", false);
            
        } 
        if (Input.GetKey(KeyCode.DownArrow))
        {
            moveDirection = new Vector3(0, 0, -1);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection = moveDirection * walkSpeed;
            anim.SetBool("walk", true);
            anim.SetBool("run", false);
        }
        if (Input.GetKey(KeyCode.R))
        {
            moveDirection = new Vector3(0, 0, 1);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection = moveDirection * runSpeed;
            anim.SetBool("walk", false);
            anim.SetBool("run", true);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            moveDirection = new Vector3(0, 0, 0);
            anim.SetBool("run", false);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            moveDirection = new Vector3(0, 0, 0);
            anim.SetBool("walk", false);

        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            moveDirection = new Vector3(0, 0, 0);
            anim.SetBool("walk", false);
          
        }


        rot += Input.GetAxis("Horizontal") * rotSpeed + Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rot, 0);
        moveDirection.y -= gravity * Time.deltaTime;
        
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "sol")
        {

            notes.notesnumber++;
            Debug.Log(notes.notesnumber);

        }
    }
}
