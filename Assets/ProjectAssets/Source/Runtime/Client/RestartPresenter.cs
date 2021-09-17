using UnityEngine;
using UnityEngine.UI;
using System;

namespace TicTacToe.Client.Runtime
{
    public sealed class RestartPresenter : MonoBehaviour
    {
        public event Action OnClicked = default;
        [SerializeField] private Button m_button;
        [SerializeField] private GameObject m_restartButton = default;

        //sub to onclick
        private void Start()
        {
            m_button.onClick.AddListener(TaskOnClick);
        }

        //unsub
        private void OnDestroy()
        {
            if(m_button != null)
            {
                m_button.onClick.RemoveListener(TaskOnClick);
            }
        }

        //on button event, trigger onclicked
        private void TaskOnClick()
        {
            OnClicked();
        }

        public void Show()
        {
            m_restartButton.SetActive(true);
        }

        public void Hide()
        {
            m_restartButton.SetActive(false);
        }
    }
}
