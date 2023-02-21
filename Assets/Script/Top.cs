using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Top : MonoBehaviour
{
    public Text skor;
    private int sayac = 0;
    public GameObject Pota;
    public Button TryAgain;
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
            if (collision.gameObject.name == "Sayi") // 1. nesneyle çarpýþýldý mý kontrol ediyoruz
            {
            sayac++;
            skor.text = sayac.ToString();
            // 2. nesnenin rastgele bir konuma yerleþtirileceði sýnýrlarý belirleyin
            float minX = -2f;
                float maxX = 2f;
                float minY = -1.75f;
                float maxY = 2.5f;

                // 2. nesnenin yeni pozisyonunu belirleyin
                float x = Random.Range(minX, maxX);
                float y = Random.Range(minY, maxY);
                Vector3 newPos = new Vector3(x, y, 0f);

                // 2. nesnenin pozisyonunu güncelleyin
                Pota.transform.position = newPos;
            }

            if (collision.gameObject.name == "GameOver")
            {

            TryAgain.gameObject.SetActive(true);
            Time.timeScale = 0;
            }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Ses efekti çal
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }



}
