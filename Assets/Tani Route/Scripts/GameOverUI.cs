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
            // 値が保存されているときの処理
            _bestScore = PlayerPrefs.GetFloat("Score");
        }
        else
        {
            // 値が保存されていないときの処理
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
