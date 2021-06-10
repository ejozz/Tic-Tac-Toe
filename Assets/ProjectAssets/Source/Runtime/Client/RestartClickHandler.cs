using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

namespace TicTacToe.Client.Runtime
{
    public sealed class RestartClickHandler : Button
    {
        public event Action OnClicked = default;

        public override void OnPointerClick(PointerEventData eventData)
        {
            OnClicked();
        }
    }
}
