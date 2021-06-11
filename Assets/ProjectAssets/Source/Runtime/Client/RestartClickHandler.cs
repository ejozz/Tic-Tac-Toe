using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

namespace TicTacToe.Client.Runtime
{
    public sealed class RestartClickHandler : MonoBehaviour
    {
        public event Action OnClicked = default;
        [SerializeField] private Button m_button;

        void Start()
        {
            m_button.onClick.AddListener(TaskOnClick);
        }
        void TaskOnClick()
        {
            OnClicked();
        }
    }
}
