using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    //set the initial distance travelled to 0
    public float distanceTravelled;

    //variable of distance in kilometers
    public float distanceTravelledInKilometers;

    //reference to the Final position
    Vector3 lastPosition;

    //reference to UI text that shows the distance value
    [SerializeField]
    public Text distanceText;

    void Start()
    {
        lastPosition = transform.position;
    }
    // Update is called once per frame
    private void Update ()
    {
        //calculate the distance moved by the ball from the StartPosition
        distanceTravelled += Vector3.Distance(transform.position, lastPosition);
        lastPosition = transform.position;

        for(int i = 0; i < distanceTravelled; i++)
        {
            distanceText.text = "Distance: " + distanceTravelled.ToString("F1") + " m";
        }
        if( distanceTravelled >= 1000)
        {
            distanceTravelledInKilometers = distanceTravelled / 1000;
            distanceText.text = "Distance: " + distanceTravelledInKilometers.ToString("F3") + " km";
        }
        //convert distance travelled to meters
        //if (distanceTravelled < 1000)
        //{
        //    distanceText.text = "Distance: " + distanceTravelled.ToString("F1") + " m";
        //}
        //converts distance travelled to Kilometers
        //else if(distanceTravelled >= 1000)
        //{
        //    distanceTravelled = distanceTravelled/ 1000;
        //    distanceText.text = "Distance: " + distanceTravelled.ToString("F3") + " Km";
        //}
    }

}
