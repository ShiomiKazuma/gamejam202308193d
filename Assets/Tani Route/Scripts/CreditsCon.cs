using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;




public class CreditsCon : MonoBehaviour
{
    [SerializeField]
    RawImage credits;


    GameObject creditsButton;

    EventTrigger eventTrigger;
    // Start is called before the first frame update
    void Start()
    {
        credits.enabled = false;
        creditsButton = GameObject.Find("creditsButton");
        eventTrigger = creditsButton.GetComponent<EventTrigger>();

        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerClick;
        entry.callback.AddListener((eventData) => { EnableCredits(); }) ;
        eventTrigger.triggers.Add(entry);
    }

    // Update is called once per frame
    float sum = 0;
    void Update()
    {
        sum += Time.deltaTime;
        if(sum > 5)
        {
            credits.enabled = false;
        }
    }

    void EnableCredits()
    {
        sum = 0;
        credits.enabled = true;
    }

    void DisableCredits()
    {
        credits.enabled = false;
    }
}
