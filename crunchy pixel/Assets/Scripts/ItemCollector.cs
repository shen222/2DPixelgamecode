using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int biscuits = 0;

    [SerializeField] private Text biscuitsText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Biscuit"))
        {
            Destroy(collision.gameObject);
            biscuits++;
            biscuitsText.text = "Biscuits: " + biscuits;
        }
    }
}
