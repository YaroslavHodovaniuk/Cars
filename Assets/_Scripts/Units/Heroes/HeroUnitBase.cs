using UnityEngine;

public abstract class HeroUnitBase : UnitBase {
    private bool _canMove;

    private void Awake() => GameStateMachine.OnBeforeStateChanged += OnStateChanged;

    private void OnDestroy() => GameStateMachine.OnBeforeStateChanged -= OnStateChanged;

    private void OnStateChanged(GameState newState) {
        if (newState == GameState.GameProgress) _canMove = true;
    }

    public virtual void ExecuteMove() {

        _canMove = false;
    }
}