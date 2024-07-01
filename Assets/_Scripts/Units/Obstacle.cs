using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private GameObject _explosion;
    [SerializeField] private int _delay;
    [SerializeField] private int _lvlToDestroy;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent<Player>(out var player))
        {
            if(_lvlToDestroy < player.Lvl){}
                
        }
    }
}
