// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class TimeManager : MonoBehaviour
// {
//     public static TimeManager Instance;
//     public float startTime;
//     public bool GameOver { get; set;}

//     /// <summary>
//     /// Update is called every frame, if the MonoBehaviour is enabled.
//     /// </summary>
//     void Update()
//     {
//         startTime -= Time.deltaTime;
//         Debug.Log("time" + startTime);

//         if(startTime == 0)
//         {
//             GameOver = true;
//             return;
//         }
//     }
// }
