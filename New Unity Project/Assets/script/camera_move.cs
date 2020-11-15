using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move : MonoBehaviour
{

    Vector3 camera_interval;
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {

        /*공과 카메라간격*/
        camera_interval = transform.position - obj.transform.position;



    }

    // Update is called once per frame
    void Update()
    {


        /*카메라랑 동시에 구체 움직임*/
        transform.position =  obj.transform.position + camera_interval;

    }
}
