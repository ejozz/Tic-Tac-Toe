using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TicTacToe.Client.Runtime
{

    public sealed class CellPresenter : MonoBehaviour
    {

        [SerializeField] private Text m_text = default;

        public void Show(CellModel model)
        {
            m_text.text = model.PlayerSide.ToString();
        }
    }
}
