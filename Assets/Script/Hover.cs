using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour
{
    public float HOVER_STRENGTH = 1.0f;
    public float TIME_OFFSET = 0f;
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
        newPosition.y = startingY + (Mathf.Sin(Time.time + TIME_OFFSET) + 1.0f) * HOVER_STRENGTH;
        this.transform.position = newPosition;
    }
}
