using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTrap : MonoBehaviour
{
    public float speed, changeDirection;
    public char vector;
    Vector3 Move;
    // Start is called before the first frame update
    void Start()
    {
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
        }
        
    }
    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.collider.CompareTag("Ground") || col.collider.CompareTag("Spike"))
        {
            speed *= changeDirection;
            if (speed < 0)
            {
                speed *= 5;
            }
            else
            {
                speed /= 5;
            }
        }

    }

}
