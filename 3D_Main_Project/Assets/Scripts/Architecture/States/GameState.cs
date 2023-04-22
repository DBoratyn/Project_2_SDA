using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Architecture
{
    public class GameState : BaseState
    {
        public override void UpdateState()
        {
            Debug.Log("Game State");
        }
    }
}
