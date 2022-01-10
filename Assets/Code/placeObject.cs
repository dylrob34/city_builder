using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class placeObject : MonoBehaviour
{

    public GameObject blackBuilding, redBuilding, blueBuilding;
    public bool black, red, blue;

    // Start is called before the first frame update
    public void Place(int i)
    {
        black = false;
        red = false;
        blue = false;
        
        
        if (i == 1)
        {
            black = true;
        }
        if (i == 2)
        {
            Instantiate(redBuilding, Input.mousePosition, new Quaternion(0, 0, 0, 0));
        }
        if (i == 3)
        {
            Instantiate(blueBuilding, Input.mousePosition, new Quaternion(0, 0, 0, 0));
        }
        Debug.Log(i.ToString());
    }

    private void Update()
    {
        if (black)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Instantiate(blackBuilding, new Vector3(0, 5, 0), new Quaternion(0, 0, 0, 0));
                black = false;
            }
        }
    }


}
