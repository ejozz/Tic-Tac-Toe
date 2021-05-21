using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace TicTacToe.Client.Runtime
{
    public sealed class CellPresenter : MonoBehaviour
    {
        [SerializeField] private Text m_text = default;
        
        //function sets text object to update view
        public void Show(CellModel model)
        {
            m_text.text = model.PlayerSide.ToString();
        }
        
    }
}