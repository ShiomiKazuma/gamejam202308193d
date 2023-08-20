using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UIElements;

public class plane : MonoBehaviour
{
    
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
        currentPosition.x = 10f;
        transform.position = currentPosition;

        if (transform.position.x < endpotision.position.x)
        {
            transform.position = startpotision.position;
        }
       

    }
}
