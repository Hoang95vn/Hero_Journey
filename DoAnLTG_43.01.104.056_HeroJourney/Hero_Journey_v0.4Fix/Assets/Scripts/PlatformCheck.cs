using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCheck : MonoBehaviour
{

    PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("MovingPlat"))
        {
            player.transform.parent = col.transform;
        }
    }
    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("MovingPlat"))
        {
            player.transform.parent = null;
        }
    }
}
