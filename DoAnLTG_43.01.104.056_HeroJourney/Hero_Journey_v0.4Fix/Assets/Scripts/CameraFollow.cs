using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float smoothtimeX, smoothtimeY;
    public Vector2 velocity;

    public GameObject player;

    public Vector2 minpox, maxpox;
    public bool bound;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(this.transform.position.x, player.transform.position.x, ref velocity.x, smoothtimeX);
        float posY = Mathf.SmoothDamp(this.transform.position.y, player.transform.position.y, ref velocity.y, smoothtimeY);
        transform.position = new Vector3(posX, posY, transform.position.z);

        if (bound)
        {   
            if( (Screen.width == 320 && Screen.height == 200) 
                    || (Screen.width == 640 && Screen.height == 400)
                    || (Screen.width == 1280 && Screen.height == 768)
                    || (Screen.width == 1280 && Screen.height == 800)
                    || (Screen.width == 1440 && Screen.height == 900)
                    || (Screen.width == 1680 && Screen.height == 1050) )
            {
                transform.position = new Vector3(
                    Mathf.Clamp(transform.position.x, minpox.x - 3, maxpox.x + 3),
                    Mathf.Clamp(transform.position.y, minpox.y, maxpox.y),
                    Mathf.Clamp(transform.position.z, transform.position.z, transform.position.z)
                );
            }
            else if ( (Screen.width == 320 && Screen.height == 240)
                        || (Screen.width == 400 && Screen.height == 300)
                        || (Screen.width == 521 && Screen.height == 384)
                        || (Screen.width == 640 && Screen.height == 480)
                        || (Screen.width == 800 && Screen.height == 600)
                        || (Screen.width == 1024 && Screen.height == 768)
                        || (Screen.width == 1152 && Screen.height == 864)
                        || (Screen.width == 1280 && Screen.height == 960)
                        || (Screen.width == 1400 && Screen.height == 1050) )
            {
                transform.position = new Vector3(
                    Mathf.Clamp(transform.position.x, minpox.x - 4, maxpox.x + 4),
                    Mathf.Clamp(transform.position.y, minpox.y, maxpox.y),
                    Mathf.Clamp(transform.position.z, transform.position.z, transform.position.z)
                );
            }
            else if (Screen.width == 1280 && Screen.height == 600)
            {
                transform.position = new Vector3(
                    Mathf.Clamp(transform.position.x, minpox.x, maxpox.x),
                    Mathf.Clamp(transform.position.y, minpox.y, maxpox.y),
                    Mathf.Clamp(transform.position.z, transform.position.z, transform.position.z)
                );
            }
            else if (Screen.width == 1280 && Screen.height == 720
                        || (Screen.width == 1360 && Screen.height == 768)
                        || (Screen.width == 1366 && Screen.height == 768)
                        || (Screen.width == 1600 && Screen.height == 900)
                        || (Screen.width == 1920 && Screen.height == 1080) )
            {
                transform.position = new Vector3(
                    Mathf.Clamp(transform.position.x, minpox.x - 2, maxpox.x + 2),
                    Mathf.Clamp(transform.position.y, minpox.y, maxpox.y),
                    Mathf.Clamp(transform.position.z, transform.position.z, transform.position.z)
                );
            }

            else if (Screen.width == 1280 && Screen.height == 1024)
            {
                transform.position = new Vector3(
                    Mathf.Clamp(transform.position.x, minpox.x - 5, maxpox.x + 5),
                    Mathf.Clamp(transform.position.y, minpox.y, maxpox.y),
                    Mathf.Clamp(transform.position.z, transform.position.z, transform.position.z)
                );
            }

            else
            {
                transform.position = new Vector3(
                    Mathf.Clamp(transform.position.x, minpox.x, maxpox.x),
                    Mathf.Clamp(transform.position.y, minpox.y, maxpox.y),
                    Mathf.Clamp(transform.position.z, transform.position.z, transform.position.z)
                );
            }
            
        }
    }
}
