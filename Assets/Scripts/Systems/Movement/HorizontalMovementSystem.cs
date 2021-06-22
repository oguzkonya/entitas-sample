using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class HorizontalMovementSystem : IExecuteSystem  
{
    private readonly Contexts _contexts;
    private readonly IGroup<GameEntity> _movingEntities;

    public HorizontalMovementSystem(Contexts contexts)
    {
        _contexts = contexts;
        _movingEntities = contexts.game.GetGroup(GameMatcher.HorizontallyMoving);
    }

    public void Execute() 
    {
        foreach (GameEntity movingEntity in _movingEntities)
        {
            movingEntity.ReplacePosition(new Vector3(
                Mathf.Cos(Time.time) * 5f,
                movingEntity.position.position.y,
                movingEntity.position.position.z
            ));
        }
    }
}