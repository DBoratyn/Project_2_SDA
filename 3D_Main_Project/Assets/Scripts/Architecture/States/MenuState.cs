using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Architecture
{
    public class MenuState : BaseState
    {
        public override void InitSatate(GameController controller)
        {
            base.InitSatate(controller);
            controller.MenuView.ShowView();
            controller.CrossyInput.IsStartPressed += StartGame;
        }

        public override void UpdateState()
        {
            Debug.Log("Menu State");
        }

        public override void DestroyState()
        {
            controller.MenuView.HideView();
            controller.CrossyInput.ClearAllInputs();
        }

        private void StartGame(bool isPressed)
        {
            if(isPressed)
                controller.ChangeState(new GameState());
        }
    }
}
