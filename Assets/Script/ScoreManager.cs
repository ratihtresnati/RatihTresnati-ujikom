using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;

    void Update()
    {
        Debug.Log("score" + score);
    }
    
    public void AddScore()
    {
        score = score + 1; 

        PlayerPrefs.SetInt("score", score);

        PlayerPrefs.Save();
        Debug.Log("add");
    }

    public void Decrease()
    {
        score = score - 3;
    }
}
