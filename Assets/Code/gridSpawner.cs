using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridSpawner : MonoBehaviour
{
    public GameObject white, grey;


    public int size;
    // Start is called before the first frame update
    void Start()
    {
        
        
        for (int i = 0; i < size; i++)
        {
            for(int j = 0; j < size; j++)
            {
                if (j % 2 == 0)
                {
                    if(i % 2 == 0)
                    {
                        Instantiate(white, new Vector3(j * 100, 0, i * 100), new Quaternion(0, 0, 0, 0));
                    }
                    else
                    {
                        Instantiate(grey, new Vector3(j * 100, 0, i * 100), new Quaternion(0, 0, 0, 0));
                    }
                    
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        Instantiate(grey, new Vector3(j * 100, 0, i * 100), new Quaternion(0, 0, 0, 0));
                    }
                    else
                    {
                        Instantiate(white, new Vector3(j * 100, 0, i * 100), new Quaternion(0, 0, 0, 0));
                    }
                }
                
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
