using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveBuilder : MonoBehaviour
{
    private float barrierCreateTime;
    private float timeToCreate;
    private SettingsScript settings;
    [SerializeField]
    private GameObject[] barriers = new GameObject[2];

    private void Start()
    {
        settings = SettingsScript.FindObjectOfType<SettingsScript>();
        timeToCreate = settings.spellTime / settings.movingSpeed;
    }
    private void Update()
    {
        timeToCreate -= Time.deltaTime;
        if (timeToCreate <= 0)
        {
            CreateBarriers();
            timeToCreate = settings.spellTime / settings.movingSpeed;
        }
    }
    private void CreateBarriers()
    {
        Instantiate(barriers[Random.Range(0, barriers.Length)], new Vector2(settings.distance, (int)Random.Range(settings.GetLowerLine(), settings.GetLowerLine() + settings.lines)), Quaternion.identity);
    }
}
