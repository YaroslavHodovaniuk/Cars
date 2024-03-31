using System;
using UnityEngine;
using UnityEngine.Serialization;


[CreateAssetMenu(fileName = "New Scriptable Car")]
public class ScriptableExampleHero : ScriptableExampleUnitBase {
    public CarType CarType;
 
}

[Serializable]
public enum CarType {
    Bus = 0,
    Coupe = 1,
    F1 = 2,
    M3_E36 = 4,
    M3_E46 = 5,
    Pickup = 6,
    Sedan = 7,
    Skala = 8,
    Skyline = 9,
    Sofia = 10,
    T100 = 11,
    Truck = 12,
}

