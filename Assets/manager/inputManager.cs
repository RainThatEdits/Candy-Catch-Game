// INPUT MANAGER SCRIPT

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class inputManager
{

    private static GameControls _gameControls;
   
    public static void Init(Player myPlayer)
    {
        _gameControls = new GameControls();
      
        _gameControls.Permanent.Enable();

        _gameControls.Game.Movement.performed += ctx =>
        {
            myPlayer.SetMovementDirection(ctx.ReadValue<Vector2>());
        };
    }

    public static void SetGameControls()
    {
        _gameControls.Game.Enable();
        _gameControls.UI.Disable();
      
    }

    public static void SetUIControls()
    {
        _gameControls.Game.Disable();
        _gameControls.UI.Enable();
    }
}