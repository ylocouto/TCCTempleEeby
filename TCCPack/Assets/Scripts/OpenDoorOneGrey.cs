using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorOneGrey : MonoBehaviour
{
            [SerializeField]
    GameObject door;
    GameObject door2;
    GameObject obj;

    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        void OnTriggerEnter(Collider col){
        if (col.gameObject.tag == "PushObj"){
        OpenDoor.DoorNum2++;
        Debug.Log(OpenDoor.DoorNum2);
        if (OpenDoor.DoorNum2 >= 1 && OpenDoor.isOpened2 == false){
        door.transform.position += new Vector3 (0,4,0);
        OpenDoor.isOpened2 = true;
            }
        }
        }
}
