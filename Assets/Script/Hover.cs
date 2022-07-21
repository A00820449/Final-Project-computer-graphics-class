using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour
{
    public float HOVER_STRENGTH = 1.0f;
    public float TIME_OFFSET = 0f;
    public bool ENABLED = true;
    float startingY;
    float counter = Mathf.PI;
    // Start is called before the first frame update
    void Start()
    {
        startingY = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (ENABLED)
        {
            Vector3 newPosition = this.transform.position;
            newPosition.y = startingY + (Mathf.Cos(counter + TIME_OFFSET) + 1.0f) * HOVER_STRENGTH;
            this.transform.position = newPosition;
            counter += Time.deltaTime;
        }
    }
}
