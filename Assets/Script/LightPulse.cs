using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPulse : MonoBehaviour
{
    public float PULSE_RANGE = 4.0f;
    public float PULSE_SPEED = 4.0f;
    public float PULSE_MIN = 1.0f;

    Light lt;
    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        lt.range = PULSE_MIN + Mathf.PingPong(Time.time * PULSE_SPEED, PULSE_RANGE);
    }
}
