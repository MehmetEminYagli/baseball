using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Pota;

    void Start()
    {
        //oyun baþladýðýnda pota rastgele yerde baþlasýn
        float minX = -2f;
        float maxX = 2f;
        float minY = -1.75f;
        float maxY = 2.5f;

       
        float x = Random.Range(minX, maxX);
        float y = Random.Range(minY, maxY);
        Vector3 newPos = new Vector3(x, y, 0f);
        Pota.transform.position = newPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
