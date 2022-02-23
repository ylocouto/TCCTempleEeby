using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDoorSwitch : MonoBehaviour
{
    [SerializeField]
    GameObject doorCoin;
    public Text keyText;

    public bool DoorOpened = false;

    public GameObject target;

    public float speed = 3;

    public AudioSource AudioDoor;

    public GameObject targetsound;

    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        AudioDoor = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(DoorOpened == true){
            doorCoin.transform.position = Vector3.MoveTowards(doorCoin.transform.position,target.transform.position, speed * Time.deltaTime);
            AudioDoor.Play();
        }
    }
        void OnTriggerStay(Collider col){
        if (Input.GetKeyDown (KeyCode.E) && col.gameObject.tag == "Player")
                if(OpenDoorWithCoin.HasCoin == true){
                    //Instantiate(targetsound, transform.position, transform.rotation);
                    AudioSource.PlayClipAtPoint(clip, transform.position);
                    keyText.text = "";
                    DoorOpened = true;
                    AudioDoor.Play();
                    Update();

            }
        }
        void CoinFalse(){
            DoorOpened = false;
        }
    }
