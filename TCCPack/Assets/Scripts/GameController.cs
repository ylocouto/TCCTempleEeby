using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    
    public int lvl;
    public Image image;
    public bool isImgOn;
    // Start is called before the first frame update
    void Start()
    {
        OpenDoor.DoorNum = 0;
        OpenDoor.isOpened = false;
        OpenDoorWithCoin.HasCoin = false;
        OpenDoorWithCoin.HasCoin = false;
        image.enabled = false;
        isImgOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)){
            OpenDoor.DoorNum = 0;
            OpenDoor.isOpened = false;
            OpenDoorWithCoin.HasCoin = false;
            Application.LoadLevel(lvl);
        }
        else if (Input.GetKeyDown(KeyCode.Escape)){
            Application.LoadLevel(0);
            OpenDoor.DoorNum = 0;
            OpenDoor.isOpened = false;
            OpenDoorWithCoin.HasCoin = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else if (Input.GetKeyDown(KeyCode.T)){
            if (isImgOn == false){
                image.enabled = true;
                isImgOn = true;
            }
            else{
                image.enabled = false;
                isImgOn = false;
            }

        }
    }
}
