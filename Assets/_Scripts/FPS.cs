using System;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;

public class FPS : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    private float _deltaTime;
    
    // Update is called once per frame
    void Update()
    {
        _deltaTime += (Time.unscaledDeltaTime - _deltaTime) * .1f; 
        text.text = (1f / _deltaTime).ToString();
    }
}
