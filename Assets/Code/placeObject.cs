using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;

public class placeObject : MonoBehaviour
{

    public GameObject blackBuilding, redBuilding, blueBuilding;

    // Start is called before the first frame update
    public void Place(int building)
    {
        GameObject go;
        switch (building) {
            case 1:
                go = Instantiate(blackBuilding, new Vector3(Random.Range(0f, 1000f), 50f, Random.Range(0f, 1000f)), new Quaternion(0, 0, 0, 0));
                go.GetComponent<NetworkObject>().Spawn();
                break;

            case 2:
                go = Instantiate(redBuilding, new Vector3(Random.Range(0f, 1000f), 50f, Random.Range(0f, 1000f)), new Quaternion(0, 0, 0, 0));
                go.GetComponent<NetworkObject>().Spawn();
                break;

            case 3:
                go = Instantiate(blueBuilding, new Vector3(Random.Range(0f, 1000f), 50f, Random.Range(0f, 1000f)), new Quaternion(0, 0, 0, 0));
                go.GetComponent<NetworkObject>().Spawn();
                break;
        }
        Debug.Log(building.ToString());
    }


}
