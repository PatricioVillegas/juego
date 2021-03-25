using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    bool canJump;
    public float vel;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1000f * Time.deltaTime, 0));
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1000f * Time.deltaTime, 0));
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKeyDown("space") && canJump)
        {
            canJump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 200f));
        }
        if (Input.GetKey("up")) 
        {
            gameObject.GetComponent<Animator>().SetBool("arriba", true);
        }
        else
        {
            gameObject.GetComponent<Animator>().SetBool("arriba", false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
      if(collision.transform.tag == "ground") 
      {
            canJump = true;  
      }
    
    }

}