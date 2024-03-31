using UnityEngine;

public abstract class HeroUnitBase : UnitBase {
    private bool _canMove;

    private void Awake() => ExampleGameManager.OnBeforeStateChanged += OnStateChanged;

    private void OnDestroy() => ExampleGameManager.OnBeforeStateChanged -= OnStateChanged;

    private void OnStateChanged(GameState newState) {
        if (newState == GameState.HeroTurn) _canMove = true;
    }

    private void OnMouseDown() {
        if (ExampleGameManager.Instance.State != GameState.HeroTurn) return;

        
        if (!_canMove) return;

        
        Debug.Log("Unit clicked");
    }

    public virtual void ExecuteMove() {

        _canMove = false;
    }
}