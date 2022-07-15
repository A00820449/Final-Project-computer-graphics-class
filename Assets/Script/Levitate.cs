using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levitate : MonoBehaviour
{
    public float hoverStrength = 1.0f;
    public float timeOffset = 0f;
    float startingY;
    // Start is called before the first frame update
    void Start()
    {
        startingY = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = this.transform.position;
        newPosition.y = startingY + (Mathf.Sin(Time.time + timeOffset) + 1.0f) * hoverStrength;
        this.transform.position = newPosition;
    }
}
