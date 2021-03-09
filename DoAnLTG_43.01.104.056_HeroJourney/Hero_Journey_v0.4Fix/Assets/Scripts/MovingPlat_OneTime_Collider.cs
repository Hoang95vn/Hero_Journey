using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlat_OneTime_Collider : MonoBehaviour
{
    public float speed;
    public char vector;
    private bool enable;
    Vector3 Move;
    // Start is called before the first frame update
    void Start()
    {
        enable = true;
        Move = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PauseMenu.pause)
        {
            transform.position = transform.position;
        }
        if (PauseMenu.pause == false)
        {
            if (vector == 'x')
            {
                Move.x += speed;
            }
            else if (vector == 'y')
            {
                Move.y += speed;
            }
            transform.position = Move;
            if(enable == false)
            {
                speed = 0;
            }
        }

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("Ground") || col.collider.CompareTag("Spike"))
        {
            enable = false;
        }
        else if (col.collider.CompareTag("Player") && !col.collider.CompareTag("Ground"))
        {
            speed = 0.015f;
        }
    }
}
