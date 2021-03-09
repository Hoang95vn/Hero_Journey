using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_2object_Appear : MonoBehaviour
{
    public GameObject[] ob;
    public GameObject enemy1, enemy2;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy1 == null && enemy2 == null)
        {
            for (int i = 0; i < ob.Length; i++)
            {
                ob[i].SetActive(true);
            }
        }
    }
}
