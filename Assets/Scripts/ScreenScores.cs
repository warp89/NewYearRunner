using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenScores : MonoBehaviour
{
    private SettingsScript settings;
    [SerializeField]
    private Text inGameScores;
    void Start()
    {
        settings = SettingsScript.FindObjectOfType<SettingsScript>();
    }

    
    void Update()
    {
        inGameScores.text = settings.GetScores().ToString();
    }
}
