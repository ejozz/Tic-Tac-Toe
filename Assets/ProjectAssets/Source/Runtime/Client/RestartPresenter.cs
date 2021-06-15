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

        private void Start()
        {
            m_button.onClick.AddListener(TaskOnClick);
        }
        private void TaskOnClick()
        {
            OnClicked();
        }

        public void EnableButton()
        {
            m_restartButton.gameObject.SetActive(true);
        }

        public void DisableButtton()
        {
            m_restartButton.gameObject.SetActive(false);
        }
    }
}
