using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Vector3 lastMousePosition;
    //public Vector3 mouseVelocity;
    public Rigidbody rb;
    public Transform t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //mouseVelocity = Input.mousePosition - lastMousePosition;
        
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Vector3 v3 = Input.mousePosition - lastMousePosition;
            t.Translate(-v3, Space.Self);
        }

        lastMousePosition = Input.mousePosition;
    }
}
