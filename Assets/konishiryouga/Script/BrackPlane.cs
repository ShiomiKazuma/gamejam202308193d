using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrackPlane : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Transform startpotision;
    [SerializeField]
    private Transform endpotision;



    // Start is called before the first frame update
    void Start()
    {
        transform.position = startpotision.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.x = 30f;
        transform.position = currentPosition;

        if (transform.position.x < endpotision.position.x)
        {
            transform.position = startpotision.position;
        }


    }
}