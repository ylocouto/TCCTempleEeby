using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSound : MonoBehaviour
{
    [SerializeField]
    public AudioSource DoorS;
    // Start is called before the first frame update
    void Start()
    {
     DoorS = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        DoorS.Play();
    }
}
