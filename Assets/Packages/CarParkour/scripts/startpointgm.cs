using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startpointgm : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        transform.position = UiManager.v1;
        transform.eulerAngles = UiManager.r1;
    }
}
