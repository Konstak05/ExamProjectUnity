using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plcontroller : MonoBehaviour
{
    private playermodel Playermodel;

    void Awake()
    {
        Playermodel = GetComponent<playermodel>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Inputdir = new Vector2(0,0);
        
        //if(Input.GetKey(KeyCode.W))
            //Inputdir.y = 1;
        Inputdir.x = Input.GetAxis("Horizontal");
        Inputdir.y = Input.GetAxis("Vertical");


        Inputdir.Normalize();
        Playermodel.Move(Inputdir);
    }
}
