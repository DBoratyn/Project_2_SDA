using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Architecture {
    public abstract class BaseState
    {
        protected GameController controller;

        public virtual void InitSatate(GameController controller)
        {
            this.controller = controller;
        }

        public virtual void UpdateState()
        {

        }
        
        public virtual void DestroyState()
        {

        }
    }
}


