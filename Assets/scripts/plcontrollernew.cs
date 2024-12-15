using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plcontrollernew : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float moveY,moveX;
    public int Iframes;
    public Rigidbody rigidBody;
    public currencymanager currencymanager;

    void Update()
    {
        if(Iframes <= 300){Iframes += 1;}
        moveY = Input.GetAxis("Vertical");
        moveX = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveX, moveY, 0);
        rigidBody.AddForce(movement * moveSpeed * Time.fixedDeltaTime);
    }

    //CollisionStuff
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Wall") && Iframes >= 300)
        {
            currencymanager.health -= 20;
            Iframes = 0;
        }
        if (other.collider.CompareTag("coins") && Iframes >= 300)
        {
            Destroy(other.gameObject);
            currencymanager.coins += 1;
            Iframes = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().CompareTag("RestoreHealthButton") && Iframes >= 300 && currencymanager.health < 100 && currencymanager.coins >= 1)
        {
            currencymanager.health = currencymanager.MaxHealth;
            currencymanager.coins -= 1;
            Iframes = 0;
        }
        if (other.GetComponent<Collider>().CompareTag("Bomb") && Iframes >= 300)
        {
            currencymanager.health -= 20;
            Iframes = 0;
        }
    }
}