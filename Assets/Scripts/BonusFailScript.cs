using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonusFailScript : MonoBehaviour
{
    private SettingsScript settings;
    private void Start()
    {
        settings = SettingsScript.FindObjectOfType<SettingsScript>();
    }
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.tag);
        if (other.CompareTag("Bonus"))
        {
            settings.AddScores();
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Barrier"))
        {
            settings.ResetScores();
            Destroy(other.gameObject);
        }
    }
}
