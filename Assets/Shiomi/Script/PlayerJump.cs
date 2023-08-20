using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody), typeof(AudioSource))]
public class PlayerJump : MonoBehaviour
{
    [SerializeField] float _jumpPower = 5f;
    [SerializeField] float _bigJumpPower = 20f;
    Rigidbody _rb;
    [SerializeField] Slider _slider;
    float _sliderValue;
    [SerializeField] float _sliderPower;

    [SerializeField] AudioClip _sound1;
    AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_rb.velocity.y <= 0)
        {
            if (Input.GetButtonDown("Jump"))
            {
                _rb.velocity = new Vector3(_rb.velocity.x, 0, 0);
                _rb.AddForce(transform.up * _jumpPower, ForceMode.Impulse);
                _audioSource.PlayOneShot(_sound1);
            }
            else if(Input.GetKeyDown(KeyCode.F) && _slider.value <= _sliderPower)
            {
                //ƒQ[ƒW‚ðŒ¸‚ç‚·ˆ—‚ð“ü‚ê‚é
                _slider.value -= 10;
                _rb.velocity = new Vector3(_rb.velocity.x, 0, 0);
                _rb.AddForce(transform.up * _bigJumpPower, ForceMode.Impulse);
                _audioSource.PlayOneShot(_sound1);
            }
        }
        
    }
}
