using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_ObjectAppear : MonoBehaviour
{
    public GameObject[] ob;
    public GameObject enemies;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(enemies == null)
        {
            for(int i = 0; i < ob.Length; i++)
            {
                ob[i].SetActive(true);
            }
        }   
    }

}
