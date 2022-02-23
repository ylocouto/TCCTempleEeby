using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject doorCoin;
    public Text text;
    public AudioSource AudioKey;

    public Renderer rend;

    public Collider col;
    // Start is called before the first frame update
    void Start()
    {
        AudioKey = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter (Collider col){
        if (col.gameObject.tag == "Player"){
            OpenDoorWithCoin.HasCoin = true;
            AudioKey.Play();
            text.text = "You found the key. Press E near a lock to open.";
            Debug.Log(OpenDoorWithCoin.HasCoin);
            this.col.enabled = false;
            this.rend.enabled = false;
        }
    }
}
