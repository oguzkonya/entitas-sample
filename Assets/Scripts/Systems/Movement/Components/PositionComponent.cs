using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Entitas.CodeGeneration.Attributes;

[Game, Event(EventTarget.Self)]
public class PositionComponent : IComponent
{
	public Vector3 position;
}