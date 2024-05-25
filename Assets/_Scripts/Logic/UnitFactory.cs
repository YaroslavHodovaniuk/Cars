using System;
using UnityEngine;

public class UnitFactory : StaticInstance<UnitFactory>
{
    [SerializeField] private Transform _spawnPosition;
    public void SpawnHeroes() {
        SpawnUnit(CarType.Coupe, _spawnPosition.position, _spawnPosition.rotation);
    }

    void SpawnUnit(CarType type, Vector3 position, Quaternion rotation) {
        var tarodevScriptable = ResourceSystem.Instance.GetExampleHero(type);

        var spawned = Instantiate(tarodevScriptable.Prefab, position, rotation);

        // Apply possible modifications here such as potion boosts, team synergies, etc
        var stats = tarodevScriptable.BaseStats;

        spawned.SetStats(stats);
    }
    
    private void Start()
    {
        RCC.SpawnRCC(RCC_DemoVehicles.Instance.vehicles[SelectCarSystem.Instance.SelectedCar], _spawnPosition.position, _spawnPosition.rotation, true, true, true);
    }
}