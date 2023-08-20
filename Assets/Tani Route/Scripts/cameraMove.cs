using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameraMove : MonoBehaviour
{
    [SerializeField]
    Camera main_camera;
    [SerializeField]
    GameObject player;
    [SerializeField]
    RawImage rawImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        main_camera.transform.position = new Vector3(main_camera.transform.position.x, player.transform.position.y, main_camera.transform.position.z) ;
        rawImage.rectTransform.position = new Vector3(rawImage.transform.position.x, 1920 - player.transform.position.y,
            rawImage.transform.position.z);
    }
}
