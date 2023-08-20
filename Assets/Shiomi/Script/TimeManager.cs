using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    float _timer;
    [SerializeField] float _firstTimer;
    [SerializeField] Text _text;
    [SerializeField] string _gameOverSceneName;
    // Start is called before the first frame update
    void Start()
    {
        _timer = _firstTimer;
    }

    // Update is called once per frame
    void Update()
    {
        _timer -= Time.deltaTime;
        _text.text = _timer.ToString("F2");
        if(_timer <= 0)
        {
            SceneManager.LoadScene(_gameOverSceneName);
        }
    }
}
