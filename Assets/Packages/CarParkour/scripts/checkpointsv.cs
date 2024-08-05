using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointsv : MonoBehaviour
{
    public Vector3 v;
    // Start is called before the first frame update
    void Start()
    {
        v = transform.rotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            SoundManager.instance.Play("hit");
            UiManager.v1 = transform.position;
            UiManager.v1.y = transform.position.y + 2;
            UiManager.r1 = transform.rotation.eulerAngles;
            Destroy(gameObject);
        }
    }
}
