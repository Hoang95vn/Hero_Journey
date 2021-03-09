using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_ObjectAppear : MonoBehaviour
{
    public GameObject ob;
    private Animator a;
    

    // Start is called before the first frame update
    void Start()
    {
        a = ob.gameObject.GetComponent<Animator>();
        a.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("Player") && ob != null)
        {
            a.enabled = true;
        }
    }
}
