using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovingScript : MonoBehaviour
{
    private int linePosition;
    private float changeLineSpeed;
    private SettingsScript settings;
    void Start()
    {
        settings = SettingsScript.FindObjectOfType<SettingsScript>();
        linePosition = (settings.lines - 1) / 2;
    }


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.DownArrow) && linePosition > 0 || Input.GetKeyUp(KeyCode.S) && linePosition > 0)
        {
            linePosition--;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow) && linePosition < settings.lines - 1 || Input.GetKeyUp(KeyCode.W) && linePosition < settings.lines - 1)
        {
            linePosition++;
        }
        ChangeLine(linePosition);       
    }

    private void ChangeLine(int line)
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, line, 0), Time.deltaTime * settings.changeLineSpeed);

    }  
}
