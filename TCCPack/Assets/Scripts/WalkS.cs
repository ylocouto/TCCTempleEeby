using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkS : MonoBehaviour
{
    public Animator anim;
    public Collider cols;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)){
            anim.SetTrigger("Walk");
        }
        else if (Input.GetKeyDown(KeyCode.S)){
            anim.SetTrigger("Walk");
    }
        else if (Input.GetKeyDown(KeyCode.A)){
            anim.SetTrigger("Walk");
}
        else if (Input.GetKeyDown(KeyCode.D)){
            anim.SetTrigger("Walk");
    }
    else if (Input.GetKeyUp(KeyCode.W)){
            anim.SetTrigger("Walk");
}
}
void OnTriggerEnter(Collider col){
    if (col.gameObject.tag == "PushObj"){
        anim.SetTrigger("Push");
    }
}
}
