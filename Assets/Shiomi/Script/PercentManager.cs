using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PercentManager : MonoBehaviour
{
    [SerializeField] Text _percentText;
    Transform _playerTransform;
    [SerializeField] GameObject _goal;
    // Start is called before the first frame update
    void Start()
    {
        _playerTransform = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float percent = _playerTransform.position.y / _goal.transform.position.y * 100;
        percent = Mathf.Floor(percent);
        _percentText.text = percent.ToString();
    }
}
