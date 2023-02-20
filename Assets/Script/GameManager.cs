using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text skor;
    private int sayac = 0;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        sayac++;
        skor.text = sayac.ToString();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
