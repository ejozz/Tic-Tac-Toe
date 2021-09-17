using UnityEngine;

namespace TicTacToe.Client.Runtime
{
    public sealed class GridPosition : MonoBehaviour
    {
        
        [SerializeField] private Vector2Int m_position = default;
        
        public Vector2Int Value => m_position;
        
    }
}
