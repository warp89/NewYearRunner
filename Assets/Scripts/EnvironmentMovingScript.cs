using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentMovingScript : MonoBehaviour
{
    private Vector3 targetTransform;
    private Vector3 startingTransform;
    private SettingsScript settings;
    private void Start()
    {
        settings = SettingsScript.FindObjectOfType<SettingsScript>();
        targetTransform = new Vector3(-transform.position.x, transform.position.y,0);
        startingTransform = transform.position;
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetTransform, Time.deltaTime * settings.movingSpeed);
        if (transform.position == targetTransform)
        {
            transform.position = startingTransform;
        }
    }
}
