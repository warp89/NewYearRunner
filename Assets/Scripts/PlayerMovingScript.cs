using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovingScript : MonoBehaviour
{
    private int linePosition;
    private int lowerLine;
    private float changeLineSpeed;
    private SettingsScript settings;
    private bool isJumped = false;
    void Start()
    {
        settings = SettingsScript.FindObjectOfType<SettingsScript>();
        linePosition = 0;
        lowerLine = (int)(settings.lines - (settings.lines + (settings.lines * 0.5))); //Возможно вынести в Settings      
    }


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.DownArrow) && linePosition > lowerLine || Input.GetKeyUp(KeyCode.S) && linePosition > lowerLine)
        {
            linePosition--;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow) && linePosition < (lowerLine + settings.lines) - 1 || Input.GetKeyUp(KeyCode.W) && linePosition < (lowerLine + settings.lines) - 1)
        {
            linePosition++;
        }
        if (Input.GetKeyUp(KeyCode.Space) && transform.position.y % 1 == 0)
        {
            isJumped = true;
        }
        if (isJumped)
        {
            ChangeLine(linePosition + 0.5f);//Высота прыжка пока так
        }
        else
        {
            ChangeLine(linePosition);
        }
    }

    private void ChangeLine(int line)
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, line, 0), Time.deltaTime * settings.changeLineSpeed);

    }
    private void ChangeLine(float line)
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, line, 0), Time.deltaTime * settings.changeLineSpeed * 2);
        StartCoroutine(BackToLine());
    }
    IEnumerator BackToLine()
    {
        yield return new WaitForSeconds((1 / settings.movingSpeed) * 2);//Время полета, пока так
        ChangeLine(linePosition);
        isJumped = false;
    }
}
