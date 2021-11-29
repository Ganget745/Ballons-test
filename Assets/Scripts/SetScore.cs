using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SetScore : MonoBehaviour
{
    public Text Score;


    public void SetScoreText(int sc = 0)
    {
        Score.text = "Score: " + sc;
    }
}
