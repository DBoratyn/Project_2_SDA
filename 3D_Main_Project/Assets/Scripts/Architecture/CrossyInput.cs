using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Architecture { 
    public class CrossyInput : MonoBehaviour
    {
        public Action<bool> IsStartPressed;
        public Action<bool> IsPausePressed;
        public Action<Vector2> IsMovePressed;

        public void StartGame(InputAction.CallbackContext ctx)
        {
            if (ctx.performed || ctx.canceled)
            {
                var val = ctx.ReadValueAsButton();
                Debug.Log("StartGame: " + val);
            }   
        }
        public void PauseGame(InputAction.CallbackContext ctx)
        {
            if (ctx.performed || ctx.canceled)
            {
                var val = ctx.ReadValueAsButton();
                Debug.Log("PauseGame: " + val);
            }
        }
        public void Move(InputAction.CallbackContext ctx)
        {
            if (ctx.performed || ctx.canceled)
            {
                var val = ctx.ReadValue<Vector2>();
                Debug.Log("Move: " + val);
            }          
        }
    }
}
