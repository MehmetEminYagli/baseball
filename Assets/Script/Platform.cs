using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed;
    public float maxheight;

    private Vector3 targetPosition; //hedef pozisyonu bulmak için
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
        //mobil için
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                        targetPosition = Camera.main.ScreenToWorldPoint(touch.position);
                        targetPosition.z = transform.position.z;
                    break;
                
                case TouchPhase.Moved:
                        targetPosition = Camera.main.ScreenToWorldPoint(touch.position);
                        targetPosition.z = transform.position.z;
                    if (targetPosition.y > maxheight)
                    {
                        targetPosition.y = maxheight;
                    }
                    break;
            }
        }
        // Hareket hesaplama ve uygulama
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        //pc için
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
