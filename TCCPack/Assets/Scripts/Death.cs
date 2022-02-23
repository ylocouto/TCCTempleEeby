using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Death : MonoBehaviour
{
    public GameObject PlayerDestroy;
    public GameObject OldCamera;
    public GameObject NewCamera;
    public Text deathText;
    public Text keyText;
    public Text resetText;

    public int lvl;
    // Start is called before the first frame update
    void Start()
    {
        OldCamera.SetActive(true);
        NewCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        void OnTriggerEnter (Collider col){
        if (col.gameObject.tag == "Player"){
            OldCamera.SetActive(false);
            NewCamera.SetActive(true);
            deathText.text = "Ha ha ha, you died. Respawning in 3 seconds.";
            keyText.text = "";
            resetText.text = "";
            Destroy(col.gameObject);
            OpenDoor.DoorNum = 0;
            OpenDoor.isOpened = false;
            OpenDoorWithCoin.HasCoin = false;
            StartCoroutine(WaitForIt(3.0f));
        }
}
IEnumerator WaitForIt(float waitTime){
    yield return new WaitForSeconds(waitTime);
    resetText.text = "Press R to reset.";
    Application.LoadLevel(lvl);
}
}
