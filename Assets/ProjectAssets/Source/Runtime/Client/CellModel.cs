using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TicTacToe.Client.Runtime
{
    
    public enum Side
    {
        X,
        O
    }
      
    public sealed class CellModel
    {
        public readonly Side PlayerSide = default;

        public CellModel(Side side)
        {
            PlayerSide = side;
        }   

    }

    public sealed class CellPresenter : UnityEngine.MonoBehaviour
    {
        [SerializeField] private Text m_text = default;

        public void Show(CellModel model)
        {
            m_text.text = model.PlayerSide.ToString();
        }
    }
}
