using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirdPersonCharacterControl : MonoBehaviour
{
    Vector3 moveDirection;
    public float Speed;
    CharacterController characterController;
    private float _pushforce = 5;
    public Animator anim;
    public AudioSource audsourc;
    public Text diatext;

    private string Walks = "Walk";
    private string Pushs = "Push";

    private string Idles = "Idle";


    Vector3 lastvalidpos;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        audsourc = GetComponent<AudioSource>();
        lastvalidpos = transform.position;
        diatext.enabled = false;
    }

	void Update()
    {
        PlayerMovement();

    }

    void PlayerMovement()
    { 
        if (characterController.isGrounded == false){
        characterController.Move(Physics.gravity * Time.deltaTime);
        }
        //float hor = Input.GetAxis("Horizontal");
        //float ver = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.W)){
            if(!audsourc.isPlaying)
            audsourc.Play();
            anim.SetBool("WalkTrue", true);
        }
        else if (Input.GetKey(KeyCode.S)){
            if(!audsourc.isPlaying)
            audsourc.Play();
            anim.SetBool("WalkTrue", true);
        }
        else if (Input.GetKey(KeyCode.A)){
            if(!audsourc.isPlaying)
            audsourc.Play();
            anim.SetBool("WalkTrue", true);
        }
        else if (Input.GetKey(KeyCode.D)){
            if(!audsourc.isPlaying)
            audsourc.Play();
            anim.SetBool("WalkTrue", true);
        }
        else {
            audsourc.Stop();
            anim.SetBool("WalkTrue", false);
        }
        if(Input.GetKey(KeyCode.F)){
            if(diatext.enabled == true)
            {
                diatext.enabled = false;
            }
        }
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection);
        //transform.Translate(playerMovement, Space.Self);
        characterController.Move(moveDirection * Speed * Time.deltaTime);
    }
        void OnControllerColliderHit(ControllerColliderHit hit)
    {
        CharacterController con = hit.transform.GetComponent<CharacterController> ();

        if (con == null) {return;}
        if (hit.moveDirection.y < -0.3F) {return;}

        Vector3 pushDir = new Vector3 (hit.moveDirection.x, 0, hit.moveDirection.z);
        con.Move (pushDir * Time.deltaTime * _pushforce);
    }
    void OnTriggerExit(Collider col){
        if (col.gameObject.tag == "Ground"){
            characterController.Move(Physics.gravity * Time.deltaTime);
        }
        else if (col.gameObject.tag == "PushObj"){
            anim.SetBool("PushTrue", false);
        }
    }

    void OnTriggerStay (Collider colx){
        if (colx.gameObject.tag == "PushObj"){
            anim.SetBool ("WalkTrue", false);
            anim.SetBool("PushTrue", true);
        }
        else if (colx.gameObject.tag == "TalkObj")
        {
            if (Input.GetKey(KeyCode.E))
            {
            if(diatext.enabled == false){
                diatext.enabled = true;
            }
        }
    }
}
}