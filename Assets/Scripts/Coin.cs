using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        MoneyController.MoneyOperation(1);
        Destroy(gameObject);
    }
}
