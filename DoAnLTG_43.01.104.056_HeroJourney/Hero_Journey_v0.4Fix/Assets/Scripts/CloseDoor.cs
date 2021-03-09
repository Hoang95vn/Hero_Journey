using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{
    public GameObject ground;
    public Rigidbody2D r2;
    // Start is called before the first frame update
    void Start()
    {
        r2 = ground.gameObject.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("Player"))
        {
            r2.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
