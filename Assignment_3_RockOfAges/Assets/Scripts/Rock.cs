using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public int minImpulse, maxImpulse;
    float angle;
    float force;

    [SerializeField]
    Rigidbody2D rb;

    float rockRadius;

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(Mathf.Sin(angle), Mathf.Cos(angle));
        force = Random.Range(minImpulse, maxImpulse);

        rb.AddForce(direction * force, ForceMode2D.Impulse);
        rockRadius = GetComponent<CircleCollider2D>().radius;
        
    }

    private void Update()
    {
        if (isNotVisible())
        {
            Debug.Log("ok then destroying this gameobject");
            Destroy(this.gameObject);
        }
    }


    bool isNotVisible()
    {
        if (transform.position.x-rockRadius > ScreenUtils.screenRight || transform.position.x+rockRadius < ScreenUtils.screenLeft || transform.position.y- rockRadius > ScreenUtils.screenTop || transform.position.y+rockRadius < ScreenUtils.screenBottom)
            return true;


        return false;
    }

    private void OnBecameInvisible()
    {

        //this function is not working so I made isNotVisible
        Debug.Log("Destroying rock");
        Destroy(this.gameObject);
    }

   
}
