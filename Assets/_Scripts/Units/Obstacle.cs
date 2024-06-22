using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private GameObject _explosion;
    [SerializeField] private int _delay;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent<RCC_CarControllerV3>(out var car))
        {
            
        }
    }
}
