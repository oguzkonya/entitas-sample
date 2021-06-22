using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class GameController : MonoBehaviour
{
	private Systems systems;

	private void Start()
	{
		systems = new Feature("systems")
			.Add(new InitializeGameSystem(Contexts.sharedInstance))

			.Add(new HorizontalMovementSystem(Contexts.sharedInstance))

			.Add(new GameEventSystems(Contexts.sharedInstance))
			;

		systems.Initialize();
	}

	private void Update()
	{
		systems.Execute();
	}

	private void OnDestroy()
	{
		systems.TearDown();
	}
}
