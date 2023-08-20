using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public float _bestScore;
    [SerializeField] TimeManager _timeManager;
    // Start is called before the first frame update
    void Start()
    {
        bool exist = PlayerPrefs.HasKey("Score");

        if (exist)
        {
            // ’l‚ª•Û‘¶‚³‚ê‚Ä‚¢‚é‚Æ‚«‚Ìˆ—
            _bestScore = PlayerPrefs.GetFloat("Score");
        }
        else
        {
            // ’l‚ª•Û‘¶‚³‚ê‚Ä‚¢‚È‚¢‚Æ‚«‚Ìˆ—
            PlayerPrefs.SetFloat("Score", 0f);
            _bestScore = PlayerPrefs.GetFloat("Score");
        }
    }

    public void BestScore()
    {
        if(_bestScore < _timeManager._timer)
        {
            PlayerPrefs.SetFloat("Score", _timeManager._timer);
        }
    }
}
