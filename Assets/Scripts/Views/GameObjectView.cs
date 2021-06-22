using Entitas;
using UnityEngine;

public class GameObjectView : UnityView, IPositionListener
{
    public override void Link(Contexts contexts, GameEntity e)
    {
        base.Link(contexts, e);
        e.AddPositionListener(this);
    }

    public void OnPosition(GameEntity entity, Vector3 value)
    {
        transform.position = value;
    }
}