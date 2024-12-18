using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PanelUI : MonoBehaviour
{
    public TextMeshProUGUI score;
    public TMP_Text time;

    ScoreManager sm;
    SpawningAnimal sa;

    void Start()
    {
        sm = FindObjectOfType<ScoreManager>();
        sa = FindObjectOfType<SpawningAnimal>();
    }

    void Update()
    {
        score.text = sm.score.ToString();
        time.text = sa.startTime.ToString();
    }
    

}
