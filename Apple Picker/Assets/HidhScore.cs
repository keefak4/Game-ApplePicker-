using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HidhScore : MonoBehaviour
{
    static public int score = 100;
    private void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "Поймай :" + score;
        if(score > PlayerPrefs.GetInt("HidhScore"))
        {
            PlayerPrefs.SetInt("HidhScore", score);
        }

    }
    private void Awake()
    {
        if(PlayerPrefs.HasKey("HidhScore"))
        {
            score = PlayerPrefs.GetInt("HidhScore");
        }
        PlayerPrefs.SetInt("HidhScore", score);
    }
}
