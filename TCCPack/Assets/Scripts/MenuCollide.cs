using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCollide : MonoBehaviour
{
    public int level;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter (Collider col){
        if (col.gameObject.tag == "Player"){
            OpenDoor.DoorNum = 0;
            OpenDoor.isOpened = false;
            OpenDoorWithCoin.HasCoin = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Application.LoadLevel(level);
        }
    }
}
