using System;
using UnityEngine;

public class UnitFactory : StaticInstance<UnitFactory>
{
    [SerializeField] private Transform _spawnPosition;
    public void SpawnHeroes() {
        SpawnUnit();
    }

    private void SpawnUnit()
    {
        RCC.SpawnRCC(RCC_DemoVehicles.Instance.vehicles[SelectCarSystem.Instance.SelectedCar], _spawnPosition.position, _spawnPosition.rotation, true, true, true);
        
        //var tarodevScriptable = ResourceSystem.Instance.GetExampleHero(type);

        //var spawned = Instantiate(tarodevScriptable.Prefab, position, rotation);

        // Apply possible modifications here such as potion boosts, team synergies, etc
        //var stats = tarodevScriptable.BaseStats;

        //spawned.SetStats(stats);
    }
    
}