using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Pota;

    void Start()
    {
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

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
    }
}
