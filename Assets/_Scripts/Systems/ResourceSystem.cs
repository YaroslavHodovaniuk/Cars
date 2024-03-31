using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ResourceSystem : StaticInstance<ResourceSystem> {
    public List<ScriptableExampleHero> ExampleHeroes { get; private set; }
    private Dictionary<CarType, ScriptableExampleHero> _ExampleHeroesDict;

    protected override void Awake() {
        base.Awake();
        AssembleResources();
    }

    private void AssembleResources() {
        ExampleHeroes = Resources.LoadAll<ScriptableExampleHero>("ExampleHeroes").ToList();
        _ExampleHeroesDict = ExampleHeroes.ToDictionary(r => r.CarType, r => r);
    }

    public ScriptableExampleHero GetExampleHero(CarType t) => _ExampleHeroesDict[t];
    public ScriptableExampleHero GetRandomHero() => ExampleHeroes[Random.Range(0, ExampleHeroes.Count)];
}   