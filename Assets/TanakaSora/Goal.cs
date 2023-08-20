using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    [SerializeField] SceneObject _sceneObject = default;
    [SerializeField] ScoreManager _scoreManager;
    [SerializeField] AudioClip _sound1;
    AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
  {
        if(collision.gameObject.tag == "Player")
        {
            _audioSource.PlayOneShot(_sound1);
            _scoreManager.BestScore();
            SceneManager.LoadScene(_sceneObject);
        }
  }
}
