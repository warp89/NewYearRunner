using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveMovingScript : MonoBehaviour
{
    private Vector3 targetTransform;
    private SettingsScript settings;
    private SpriteRenderer spriteRender;
    private void Start()
    {
        settings = SettingsScript.FindObjectOfType<SettingsScript>();
        targetTransform = new Vector3(-transform.position.x, transform.position.y,0);
        GetComponentInChildren<SpriteRenderer>().sortingOrder = ((int)transform.position.y * -1)-1;
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetTransform, Time.deltaTime * settings.movingSpeed);
        if (transform.position == targetTransform)
        {
            Destroy(gameObject);
        }
    }
}
