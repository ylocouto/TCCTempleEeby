using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverDoorSwitch : MonoBehaviour
{
    [SerializeField]
    GameObject LeverDoorCoin;

    private bool DoorOpened2 = false;

    public GameObject target;

    public float speed = 1;

    public bool LeverTrigger = false;

    public Animator anims;

    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(DoorOpened2==true){
            anims.SetBool("Lever", true);
            LeverDoorCoin.transform.position = Vector3.MoveTowards(LeverDoorCoin.transform.position,target.transform.position, speed * Time.deltaTime);
        }
    }
    void OnTriggerStay(Collider col){
    if (Input.GetKeyDown (KeyCode.E) && col.gameObject.tag == "Player"){
        AudioSource.PlayClipAtPoint(clip, transform.position);
        DoorOpened2 = true;
        Update();
        }
    }

}
