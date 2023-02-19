using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Hareket();


    }

    public void Hareket()
    {
        float horizontal = Input.GetAxis("Horizontal");


        if (Input.GetKey(KeyCode.A))
        {
            Vector3 newposition = transform.position + new Vector3(horizontal * speed * Time.deltaTime, 0, 0);
            transform.position = newposition;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Vector3 newposition = transform.position + new Vector3(horizontal * speed * Time.deltaTime, 0, 0);
            transform.position = newposition;
        }


    }

}
