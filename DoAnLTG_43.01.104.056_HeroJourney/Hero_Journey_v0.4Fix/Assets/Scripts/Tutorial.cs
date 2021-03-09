using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameMaster gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {

            gm.inputText.text = ("Press A,D or Left,Right arrow to Move \n Press W or Up arrow to Jump \n Press Space to Attack \n Press Shift to Dash \n Press Esc to Pause");
        }
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            gm.inputText.text = ("Press A,D or Left,Right arrow to Move \n Press W or Up arrow to Jump \n Press Space to Attack \n Press Shift to Dash \n Press Esc to Pause");
        }
        
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        gm.inputText.text = ("");
    }

}
