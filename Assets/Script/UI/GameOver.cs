using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject scoreTime;

    public TextMeshProUGUI score;

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
            int sc = PlayerPrefs.GetInt("score", 0);

            score.text = sc.ToString();
            gameOver.SetActive(true);
            scoreTime.SetActive(false);
            sa.GameOver = true;
        }
    }
}
