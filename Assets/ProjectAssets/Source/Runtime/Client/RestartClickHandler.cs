using UnityEngine;
using UnityEngine.EventSystems;
using System;

namespace TicTacToe.Client.Runtime
{
    public sealed class RestartClickHandler : MonoBehaviour, IPointerClickHandler
    {
        public event Action OnClicked = default;

        public void OnPointerClick(PointerEventData eventData)
        {
            OnClicked();
        }
    }
}
