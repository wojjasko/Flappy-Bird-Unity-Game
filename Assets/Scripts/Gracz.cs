using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gracz : MonoBehaviour
{
    public float szybkosc;
    public float wysokoscSkoku;
    Rigidbody graczRB;
    float czas = 0;
    public bool uderzyl = false;
    private void Start()
    {
        graczRB = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        czas += Time.deltaTime;
        graczRB.velocity = new Vector3(szybkosc + (czas/10), graczRB.velocity.y, graczRB.velocity.z);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            graczRB.velocity = new Vector3(graczRB.velocity.x, graczRB.velocity.y + wysokoscSkoku, graczRB.velocity.z);
        }
        if(transform.position.y > 4)
        {
            transform.position = new Vector3(transform.position.x, 4, transform.position.z);
            graczRB.velocity = new Vector3(graczRB.velocity.x, 0, 0);
        }
        else if (transform.position.y < -6)
        {
            transform.position = new Vector3(transform.position.x, -6, transform.position.z);
            graczRB.velocity = new Vector3(graczRB.velocity.x, 0, 0);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        uderzyl = true;
        //if (collision.gameObject.CompareTag("CanBePickedUp"))
        //{
            //collision.gameObject.SetActive(false);
            //Destroy(collision.gameObject);
        //}
    }
}
