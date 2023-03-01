using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //-------- [変数の定義]  ----------
    public Rigidbody rb;


    //--------------------------------
    void Start()
    {
        //-------- [旗が倒された時]  ----------       

        //-----------------------------------
    }

    void Update()
    {
        //-------- [旗が押された時、ずっと]  ----------
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, 5);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -5);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(5, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-5, 0, 0);
        }

        if (transform.position.y < -10)
        {
            transform.position = new Vector3(0, 3, -3);
        }
        //------------------------------------------
    }

    private void OnCollisionEnter(Collision hit)
    {
        //-------- [何かに触れた時]  ----------
        if (hit.gameObject.tag == "Enemy")
        {
            transform.position = new Vector3(0, 3, -3);
        }
        //-----------------------------------
    }
}
