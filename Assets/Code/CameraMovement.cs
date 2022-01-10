using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Vector3 lastMousePosition;
    //public Vector3 mouseVelocity;
    public Rigidbody rb;
    public Transform t;
    public Transform camara;
    public gridSpawner gs;
    // Start is called before the first frame update
    void Start()
    {
        float center = gs.size * 100 / 2;
        t.SetPositionAndRotation(new Vector3(center, 600, center - (600*Mathf.Tan(30 * Mathf.PI / 180))), new Quaternion(0, 0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
        //mouseVelocity = Input.mousePosition - lastMousePosition;
        
        if (Input.GetKey(KeyCode.Mouse1) && !Input.GetKey(KeyCode.LeftAlt))
        {
            Vector3 v3 = Input.mousePosition - lastMousePosition;
            t.Translate(new Vector3(-v3.x, -v3.z, -v3.y), Space.Self);
        }

        if (Input.GetKey(KeyCode.Mouse1) && Input.GetKey(KeyCode.LeftAlt))
        {
            Vector3 v3 = Input.mousePosition - lastMousePosition;
            t.Rotate(new Vector3(0, v3.x, 0), Space.Self);
        }

        lastMousePosition = Input.mousePosition;

        camara.Translate(new Vector3(0, -Input.mouseScrollDelta.y * 100, 0), Space.World);
        if (camara.position.y > 600)
        {
            camara.SetPositionAndRotation(new Vector3(camara.position.x, 600, camara.position.z), camara.rotation);
        }
        if (camara.position.y < 200)
        {
            camara.SetPositionAndRotation(new Vector3(camara.position.x, 200, camara.position.z), camara.rotation);
        }
    }
}
