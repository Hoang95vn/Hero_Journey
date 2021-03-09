using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransfer : MonoBehaviour
{
    public float size;
    public Vector2 nminpos, nmaxpos;
    public GameObject gb;
    public CameraFollow  cf;
    public Camera cm;
    // Start is called before the first frame update
    void Start()
    {

        cf = gb.gameObject.GetComponent<CameraFollow>();
        cm = gb.gameObject.GetComponent<Camera>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("Player"))
        {
            cm.orthographicSize = size;
            cf.minpox = nminpos;
            cf.maxpox = nmaxpos;
            
        }
    }
}
