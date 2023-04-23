using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class BaseView : MonoBehaviour
    {
        public virtual void ShowView()
        {
            this.gameObject.SetActive(true);
        }

        public virtual void HideView()
        {
            gameObject.SetActive(false);
        }
    }
}
