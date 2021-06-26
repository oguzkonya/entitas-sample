using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;


public class LoggingSystem : ReactiveSystem<GameEntity> 
{
	private Contexts _contexts;

	public LoggingSystem(Contexts contexts) : base(contexts.game) 
	{
		_contexts = contexts;
	}
		
	protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
	{
		return context.CreateCollector(GameMatcher.Position.Added());
	}
		
	protected override bool Filter(GameEntity entity) 
	{
		return entity.hasPosition;
	}

	protected override void Execute(List<GameEntity> entities) 
	{
		foreach (var e in entities) 
		{
			Debug.Log(e.position.position);
		}
	}
}
