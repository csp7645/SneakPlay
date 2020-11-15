using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    int IsDoubleJump = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        float Time_interval = Time.deltaTime;
        float speed = 10;

        
        if (Input.GetKeyDown(KeyCode.UpArrow) && 0 < IsDoubleJump)
        {
            //transform.position += Time_interval* Vector3.up * speed;

            IsDoubleJump -= 1;
            GetComponent<Rigidbody>().AddForce(Vector3.up * 300);
            
            
        }

        /*if (Input.GetKey(KeyCode.DownArrow))
        {

            transform.position += Time_interval * Vector3.down * speed;
        }*/


        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.position += Time_interval * Vector3.right * speed;

        }
      
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Time_interval * Vector3.left * speed;
        }




    }

    private void OnCollisionEnter(Collision collision)
    {
        IsDoubleJump = 3;
    }

}