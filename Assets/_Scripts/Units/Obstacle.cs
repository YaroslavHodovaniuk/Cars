using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private GameObject _explosion;
    [SerializeField] private int _delay;
    [SerializeField] private int _lvlToDestroy;
    [SerializeField] private int _damage;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent<Player>(out var player))
        {
            if(_lvlToDestroy <= player.Lvl)
            {
                player.HP -= _damage;
                StartCoroutine(CreateExplosion());
            }
                
        }
    }

    private IEnumerator CreateExplosion()
    {
        yield return new WaitForSeconds(_delay);
        if(_explosion != null)
            Instantiate(_explosion);
        Destroy(gameObject);
        Debug.Log("destroed");
    }
}
