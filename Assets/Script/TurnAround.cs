using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnAround : MonoBehaviour
{
    public float START_ANGLE = -90f;
    public float TURN_AROUND_ANGLE = 90f;
    public float ROTATION_SPEED = 0.1f;
    Quaternion startRotation;
    Quaternion endRotation;
    bool turnedAround = false;
    public bool TURNED_AROUND 
    {
        get { return turnedAround; }
    }
    float rotationCounter = 0f;
    // Start is called before the first frame update
    void Start()
    {
        startRotation = Quaternion.Euler(0f, START_ANGLE, 0f);
        endRotation = Quaternion.Euler(0f, TURN_AROUND_ANGLE, 0f);
    }

    // Update is called once per frame
    void Update()
    {   
        if (turnedAround != Input.GetButton("Jump"))
        {
            // Resets the counter if the user pressed/stopped pressing the button
            rotationCounter = 0f;
            turnedAround = Input.GetButton("Jump");
        }
        // Sets rotation depending on whether or not the button is being held down
        if (turnedAround)
        {
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, endRotation, rotationCounter);
        }
        else
        {
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, startRotation, rotationCounter);
        }
        // Avoids getting the counter bigger than necessary
        if (rotationCounter <= 1f)
        {
            rotationCounter += ROTATION_SPEED * Time.deltaTime;
        }
    }
}
