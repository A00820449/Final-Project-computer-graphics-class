using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float MOVEMENT_SPEED = 1f;
    public float ROTATION_SPEED = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            this.transform.eulerAngles += new Vector3(Input.GetAxis("Mouse Y"), -Input.GetAxis("Mouse X"), 0f) * ROTATION_SPEED;
        }
        else
        {
            this.transform.position += this.transform.forward * Input.GetAxis("Vertical") * MOVEMENT_SPEED;
            this.transform.position += this.transform.right * Input.GetAxis("Horizontal") * MOVEMENT_SPEED;
        }
    }
}
