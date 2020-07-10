using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour
{
    public float ThrustForce;
    Rigidbody2D rb;
    Vector2 forceDirection;
    float shipRad;
    public float rotationDegreesPerSecond;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        shipRad = GetComponent<CircleCollider2D>().radius;

        
    }


    void Update()
    {
        if(Input.GetAxis("Thrust")>0)
        {
            //forceDirection = new Vector2(Mathf.Cos(transform.eulerAngles.y), Mathf.Sin(transform.eulerAngles.x));
            rb.AddForce(transform.up * ThrustForce,ForceMode2D.Force);
        }

        if (transform.position.x-shipRad > ScreenUtils.ScreenRight)
        {
            transform.position = new Vector2(ScreenUtils.ScreenLeft, transform.position.y);
        }
        if (transform.position.x+shipRad < ScreenUtils.ScreenLeft)
        {
            transform.position = new Vector2(ScreenUtils.ScreenRight, transform.position.y);
        }
        if(transform.position.y-shipRad > ScreenUtils.ScreenTop)
        {
            transform.position = new Vector2(transform.position.x,ScreenUtils.ScreenBottom);
        }
        if (transform.position.y+shipRad < ScreenUtils.ScreenBottom)
        {
            transform.position = new Vector2(transform.position.x, ScreenUtils.ScreenTop);
        }

        float rotationInput = Input.GetAxis("Rotate");
        float rotationAmount = rotationDegreesPerSecond * Time.deltaTime;


        Debug.Log(Input.GetAxis("Rotate"));

        transform.Rotate(new Vector3(0, 0, rotationInput * rotationAmount));
        //transform.Rotate(Vector3.forward, rotationInput*rotationAmount);                  //both works
    }

    public void OnBecameVisible()
    {
        Debug.Log("Ship is visible");

    }

    private void OnBecameInvisible()
    {
        Debug.Log("Ship invisible");
    }
}
