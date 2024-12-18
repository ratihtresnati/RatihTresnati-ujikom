using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Animal"))
        {
            ScoreManager sm = FindObjectOfType<ScoreManager>();
            sm.AddScore();
            Destroy(gameObject);
        }
    }
}
