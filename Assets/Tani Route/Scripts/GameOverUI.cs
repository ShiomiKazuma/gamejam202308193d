using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    [SerializeField]
    Text textBox;

    float _bestScore;
    // Start is called before the first frame update
    void Start()
    {
        bool exist = PlayerPrefs.HasKey("Score");
        if (exist)
        {
            // �l���ۑ�����Ă���Ƃ��̏���
            _bestScore = PlayerPrefs.GetFloat("Score");
        }
        else
        {
            // �l���ۑ�����Ă��Ȃ��Ƃ��̏���
            PlayerPrefs.SetFloat("Score", 0f);
            _bestScore = PlayerPrefs.GetFloat("Score");
        }

        textBox.text = "Score: " + _bestScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
