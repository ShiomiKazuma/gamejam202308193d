using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour
{
    //�v���C���[�ƏՓ˂�����Q�[�W��������
    [Header("��������Q�[�W��")]public float _gaugeParameter;
    //[Header("�v���C���[����")] public PlayerTriggerCheck _player;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //�Q�[�W�𑝂₷
            //GaugeManager.Instance.AddGauge(_gaugeParameter);
            //�I�u�W�F�N�g���폜����
            Destroy(this.gameObject);
        }
    }
}
