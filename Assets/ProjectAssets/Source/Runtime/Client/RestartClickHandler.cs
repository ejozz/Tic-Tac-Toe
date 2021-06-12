using UnityEngine;
using UnityEngine.UI;
using System;

namespace TicTacToe.Client.Runtime
{
    public sealed class RestartClickHandler : MonoBehaviour
    {
        public event Action OnClicked = default;
        [SerializeField] private Button m_button;

        private void Start()
        {
            m_button.onClick.AddListener(TaskOnClick);
        }
        private void TaskOnClick()
        {
            OnClicked();
        }
    }
}
