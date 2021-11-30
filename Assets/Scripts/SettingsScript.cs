using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsScript : MonoBehaviour
{
    public float movingSpeed = 3;
    public int lines = 3;
    public float changeLineSpeed = 2;
    public float spellTime = 4;
    public float distance = 20;
    [SerializeField]
    private int scores = 0;
    public int GetLowerLine()
    {
        return (int)(lines - (lines + (lines * 0.5)));
    }
    public  void AddScores()
    {
        scores++;
    }   
    public int GetScores()
    {
        return scores;
    }
    public void ResetScores()
    {
        scores=0;
    }
}
