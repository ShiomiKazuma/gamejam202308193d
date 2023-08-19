using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] float _jumpPower = 5f;
    [SerializeField] float _bigJumpPower = 20f;
    Rigidbody _rb;
    [SerializeField] Slider _slider;
    float _sliderValue;
    [SerializeField] float _sliderPower;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
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
            }
            else if(Input.GetKeyDown(KeyCode.F) && _slider.value <= _sliderPower)
            {
                //ƒQ[ƒW‚ðŒ¸‚ç‚·ˆ—‚ð“ü‚ê‚é
                _slider.value -= 10;
                _rb.velocity = new Vector3(_rb.velocity.x, 0, 0);
                _rb.AddForce(transform.up * _bigJumpPower, ForceMode.Impulse);
            }
        }
        
    }
}
