using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectorJ : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            Destroy(collision.gameObject);
        }
    }

}
