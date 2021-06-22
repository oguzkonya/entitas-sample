using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class VerticalMovementSystem : IExecuteSystem  
{
    private readonly Contexts _contexts;
    private readonly IGroup<GameEntity> _movingEntities;

    public VerticalMovementSystem(Contexts contexts)
    {
        _contexts = contexts;
        _movingEntities = contexts.game.GetGroup(GameMatcher.VerticallyMoving);
    }

    public void Execute()
    {
        foreach (GameEntity movingEntity in _movingEntities)
        {
            movingEntity.ReplacePosition(new Vector3(
                movingEntity.position.position.x,
                Mathf.Sin(Time.time) * 5f,
                movingEntity.position.position.z
            ));
        }
    }
}