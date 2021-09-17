using UnityEngine;
using UnityEngine.EventSystems;
using System;

namespace TicTacToe.Client.Runtime
{
    public sealed class CellClickHandler : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] private GridPosition m_position = default;
        
        public event Action<Vector2Int> OnClicked = default;

        public void OnPointerClick(PointerEventData eventData)
        {
            OnClicked(m_position.Value);
        }
    }
}