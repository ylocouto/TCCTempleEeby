using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject door;
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
        OpenDoor.DoorNum++;
        Debug.Log(OpenDoor.DoorNum);
        if (OpenDoor.DoorNum >= 3 && OpenDoor.isOpened == false){
        door.transform.position += new Vector3 (0,4,0);
        OpenDoor.isOpened = true;
            }
        }
        }

    void OnTriggerExit (Collider cols){
        if (cols.gameObject.tag == "PushObj"){
            OpenDoor.DoorNum--;
        if (OpenDoor.DoorNum >= 0 && OpenDoor.isOpened == true){
        door.transform.position -= new Vector3 (0,4,0);
        OpenDoor.isOpened = false;
            Debug.Log(OpenDoor.DoorNum);
        }
    }
}
}
