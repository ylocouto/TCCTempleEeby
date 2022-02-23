using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPhysics : MonoBehaviour
{
    CharacterController characterController;

    public AudioSource audiobox;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        audiobox = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (characterController.isGrounded == false){
        characterController.Move(Physics.gravity * Time.deltaTime);
        }

    }
    void OnCollisionStay(Collision col){
        if (col.gameObject.tag == "Player"){
            if(!audiobox.isPlaying){
                audiobox.Play();
                Invoke ("StopAudio", 1);
            }
        }
    }
    void StopAudio (){
        audiobox.Stop();
    }
    }
