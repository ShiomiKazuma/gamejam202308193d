using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    //�X���C�_�[���擾
    Slider _slider;

    void Start()
    {
        _slider=GameObject.Find("Slider").GetComponent<Slider>();
        _slider.value=0;
    }

    void Update()
    {
        //�X�y�[�X��������Q�[�W��������
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _slider.value+=0.1f;
        }
    }
}
