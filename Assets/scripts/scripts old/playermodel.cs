using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermodel : MonoBehaviour
{
    private Rigidbody rigidBody;
    [SerializeField] private float speed;
    private Vector3 wantedDir;

    public void Move(Vector2 dirxz){
        Vector3 _localdir = new Vector3(dirxz.x,0,dirxz.y);
        wantedDir = transform.InverseTransformDirection(_localdir);
    }
    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rigidBody.AddForce(wantedDir * speed * Time.fixedDeltaTime);
        wantedDir = Vector3.zero;
    }
}
