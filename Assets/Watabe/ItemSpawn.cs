using UnityEngine;

public class ItemSpawn : MonoBehaviour
{ 
    //�V���A���C�Y��
    [Header("�A�C�e���I�u�W�F�N�g")]public GameObject itemObject;
    [Header("�����܂ł̌o�ߎ���")]public float UPDATE_TIME;
    [Header("�����͈͍ŏ�X���W")] public float minX;
    [Header("�����͈͍ő�X���W")] public float maxX;
    [Header("�����͈͍ŏ�Y���W")] public float minY;
    [Header("�����͈͍ő�Y���W")] public float maxY;
    //�v���C�x�[�g�ϐ�
    float progressTime;

    void Start()
    {
        //�o�ߎ��Ԃ�������
        progressTime = 0.0f;
    }
    void Update()
    {
        //�o�ߎ��Ԃ𑝂₷
        progressTime += Time.deltaTime;

        //��莞�Ԍo�߂�����
        if (progressTime > UPDATE_TIME)
        {
            //�����ʒu�����߂�
            float x = Random.Range(minX, maxX);
            float z = 0.0f;
            //Y���݂̂ǂ�ǂ��Ɍ������Ă����ׂ��H
            float y = Random.Range(minY, maxY);

            //�I�u�W�F�N�g�𐶐�����
            Instantiate(itemObject, new Vector3(x, y, z), Quaternion.identity);
            progressTime = 0.0f;
        }
    }
}