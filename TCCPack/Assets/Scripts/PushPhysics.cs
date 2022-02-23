using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushPhysics : MonoBehaviour
{
    [SerializeField]
    private float ForceMagnitude;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnControllerColliderHit (ControllerColliderHit hit){
        Rigidbody rigidbody = hit.collider.attachedRigidbody;
        if(rigidbody != null){
            Vector3 forceDirection = hit.gameObject.transform.position - transform.position;
            forceDirection.y = 0;
            forceDirection.Normalize();
            rigidbody.AddForceAtPosition(forceDirection * ForceMagnitude, transform.position, ForceMode.Impulse);
        }
    }
    void OnCollisionStay (Collision col){
        if (col.gameObject.tag == "PushObj"){
            anim.SetBool ("WalkTrue", false);
            anim.SetBool("PushTrue", true);
        }
    }
}
