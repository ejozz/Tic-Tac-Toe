using UnityEngine;
using UnityEngine.UI;

namespace TicTacToe.Client.Runtime
{
    public sealed class WinPopupPresenter : MonoBehaviour
    {
        [SerializeField] private Text m_text = default;
        [SerializeField] private GameObject m_winPopup = default;
        
        //function sets text object to update view
        public void Show(WinPopupModel model)
        {
            m_winPopup.SetActive(true);
            m_text.text = model.m_winMessage;
        }

        public void Hide()
        {
            m_winPopup.SetActive(false);
        }
    }
}