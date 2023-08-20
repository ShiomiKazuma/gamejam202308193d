using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonHover : MonoBehaviour
{
    [SerializeField]
    Texture texture_Hovered;
    [SerializeField]
    Texture texture_UnHovered;

    RawImage raw;

    EventTrigger eventtrigger;
    
    // Start is called before the first frame update
    void Start()
    {
        raw = gameObject.GetComponent<RawImage>();

        eventtrigger = GetComponent<EventTrigger>();
        EventTrigger.Entry entry1 = new EventTrigger.Entry();

        entry1.eventID = EventTriggerType.PointerEnter;
        entry1.callback.AddListener((eventDate) => { OnHoveredEnter(); });
        eventtrigger.triggers.Add(entry1);

        EventTrigger.Entry entry2 = new EventTrigger.Entry();
        entry2.eventID = EventTriggerType.PointerExit;
        entry2.callback.AddListener((eventDate) => { OnHoveredExit(); });
        eventtrigger.triggers.Add(entry2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnHoveredEnter()
    {
        Debug.Log("Hovered");
        raw.texture = texture_Hovered;
    }
    public void OnHoveredExit()
    {
        Debug.Log("UnHovered");
        raw.texture = texture_UnHovered;
    }

}


