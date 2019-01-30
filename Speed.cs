using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speed : Distance
{ 
    //give the object a rigidbody
    public Rigidbody rb;
    //create the variable for currentspeed
    public float currentSpeed;
    //reference to UI text that shows the distance value
    [SerializeField]
    public Text speedText;

    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	void Update () {
        //calculate the speed moving at the current time
        currentSpeed = GetComponent<Rigidbody>().velocity.magnitude;
        //dipslay the calculated speed to the text UI
        speedText.text = "Speed: " + currentSpeed.ToString("F1") + " km/h";
    }
}

//There is no 'rigidbody' attached to the 'speed' game object but the script is trying to access it.
