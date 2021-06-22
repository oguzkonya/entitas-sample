using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class InitializeGameSystem : IInitializeSystem
{
    private readonly Contexts _contexts;

    public InitializeGameSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Initialize() 
    {
        var e = _contexts.game.CreateEntity();
        e.AddPosition(Vector3.zero);
        e.isHorizontallyMoving = true;

        var playerView = Object.Instantiate(Resources.Load<GameObject>("Sphere")).GetComponent<GameObjectView>();
        playerView.Link(_contexts, e);
        e.AddUnityView(playerView);
    }
}