using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMove : MonoBehaviour
{
    public float speed = 5f;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Food"))
        {
            Destroy(gameObject);
        }
        
        if(other.gameObject.CompareTag("Player"))
        {
            ScoreManager sm = FindObjectOfType<ScoreManager>();
            sm.Decrease();
            Destroy(gameObject);
        }
    }

    void Start()
    {
        
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
