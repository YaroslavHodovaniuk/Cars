using System;
using UnityEngine;

public class GameStateMachine : StaticInstance<GameStateMachine> {
    public static event Action<GameState> OnBeforeStateChanged;
    public static event Action<GameState> OnAfterStateChanged;

    public GameState State { get; private set; }
    
    void Start() => ChangeState(GameState.Starting);

    public void ChangeState(GameState newState) {
        OnBeforeStateChanged?.Invoke(newState);

        State = newState;
        switch (newState) {
            case GameState.Starting:
                HandleStarting();
                break;
            case GameState.SpawningHeroes:
                HandleSpawningHeroes();
                break;
            case GameState.SpawningEnemies:
                HandleSpawningEnemies();
                break;
            case GameState.GameProgress:
                break;
            case GameState.Win:
                break;
            case GameState.Lose:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }

        OnAfterStateChanged?.Invoke(newState);
        
        Debug.Log($"New state: {newState}");
    }

    private void HandleStarting() {
        ChangeState(GameState.SpawningHeroes);
    }

    private void HandleSpawningHeroes() {
        UnitFactory.Instance.SpawnHeroes();
        
        ChangeState(GameState.SpawningEnemies);
    }

    private void HandleSpawningEnemies() {
        
        ChangeState(GameState.GameProgress);
    }
    
}

[Serializable]
public enum GameState {
    Starting = 0,
    SpawningHeroes = 1,
    SpawningEnemies = 2,
    GameProgress = 3,
    Win = 4,
    Lose = 5,
}