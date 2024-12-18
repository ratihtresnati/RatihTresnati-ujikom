using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject scoreTime;

    ScoreManager sm;
    SpawningAnimal sa;

    void Start()
    {
        sm = FindObjectOfType<ScoreManager>();
        sa = FindObjectOfType<SpawningAnimal>();

        gameOver.SetActive(false);
    }

    private void Update()
    {
        if(sa.GameOver == true || sm.score <= -1)
        {
            gameOver.SetActive(true);
            scoreTime.SetActive(false);
        }
    }
}
