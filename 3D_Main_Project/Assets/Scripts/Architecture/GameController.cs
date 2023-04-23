using Data;
using System.Collections;
using System.Collections.Generic;
using UI;
using UnityEngine;

namespace Architecture
{
    public class GameController : MonoBehaviour
    {
        private BaseState currentState;

        private SaveSystem saveSystem;
        public SaveSystem SaveSystem => saveSystem;

        [SerializeField]
        private CrossyInput crossyInput;
        public CrossyInput CrossyInput => crossyInput;

        [SerializeField]
        private MenuView menuView;
        public MenuView MenuView => menuView;

        public void Start()
        {
            saveSystem = new SaveSystem();
            saveSystem.LoadData();

            ChangeState(new MenuState());
        }

        public void Update()
        {
            //odswiezanie
            currentState?.UpdateState();
            
        }

        public void OnDestroy()
        {
            saveSystem.SaveData();
        }

        public void ChangeState(BaseState newState)
        {
            //if (currentState != null) => currentState.?.Method() Metoda pozwalaj?ca zmieni? stan
            currentState?.DestroyState();
            currentState = newState;
            currentState?.InitSatate(this);
        }
    }
}
