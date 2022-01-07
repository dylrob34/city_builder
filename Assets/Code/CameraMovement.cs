using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Vector3 lastMousePosition;
    //public Vector3 mouseVelocity;
    public Rigidbody rb;
    public Transform t;
    public gridSpawner gs;
    // Start is called before the first frame update
    void Start()
    {
        float center = gs.size * 100 / 2;
        t.SetPositionAndRotation(new Vector3(center, 600, center - (600*Mathf.Tan(60 * Mathf.PI / 180))), new Quaternion(0, 0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
        //mouseVelocity = Input.mousePosition - lastMousePosition;
        
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Vector3 v3 = Input.mousePosition - lastMousePosition;
            t.Translate(new Vector3(-v3.x, -v3.z, -v3.y), Space.World);
        }

        lastMousePosition = Input.mousePosition;
    }
}
