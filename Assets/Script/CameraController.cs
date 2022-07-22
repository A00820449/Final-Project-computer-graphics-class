using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float MOVEMENT_SPEED = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += Vector3.forward * Input.GetAxis("Vertical") * MOVEMENT_SPEED;
        this.transform.position += Vector3.right * Input.GetAxis("Horizontal") * MOVEMENT_SPEED;
    }
}
