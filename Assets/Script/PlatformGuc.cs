using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGuc : MonoBehaviour
{
    [SerializeField] private float aci;
    [SerializeField] private float UygulanacakGuc;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(aci, 90) * UygulanacakGuc, ForceMode2D.Force);
    }
}
