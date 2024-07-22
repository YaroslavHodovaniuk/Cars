using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private int _damage;

    private bool _touched;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent<Player>(out var player))
        {
            if(_touched) return;
            
            player.HP -= _damage;
            _touched = true;
        }
    }
    
}
