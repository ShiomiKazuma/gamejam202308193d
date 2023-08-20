using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    [SerializeField] SceneObject _sceneObject = default;
    [SerializeField]ScoreManager _scoreManager;

  private void OnCollisionEnter(Collision collision)
  {
        if(collision.gameObject.tag == "Player")
        {
            _scoreManager.BestScore();
            SceneManager.LoadScene(_sceneObject);
        }
  }
}
