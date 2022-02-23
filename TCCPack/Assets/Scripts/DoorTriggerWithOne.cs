using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerWithOne : MonoBehaviour
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
        if (col.gameObject.name == "PushBox"){
        OpenDoor.DoorNum++;
        Debug.Log(OpenDoor.DoorNum);
        if (OpenDoor.DoorNum >= 1 && OpenDoor.isOpened == false){
        door.transform.position += new Vector3 (0,4,0);
        OpenDoor.isOpened = true;
            }
        }
        }


}
