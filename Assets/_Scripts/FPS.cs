using System;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;

public class FPS : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    private float _deltaTime;


    private void Start()
    {
        QualitySettings.vSyncCount = 1;
        Application.targetFrameRate = 240;
    }

    // Update is called once per frame
    void Update()
    {
        _deltaTime += (Time.unscaledDeltaTime - _deltaTime) * .1f; 
        text.text = (1f / _deltaTime).ToString();
    }
}
