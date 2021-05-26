using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace TicTacToe.Client.Runtime
{
    public sealed class CellPresenter : MonoBehaviour
    {
        [SerializeField] private Text m_text = default;
        

        //function sets text object to update view
        public void Show(CellModel model)
        {
            GetComponent<SpriteRenderer>().DOFade(0.55f,0.25f);
            GetComponentInChildren<Text>().DOFade(0f, 0f);
            GetComponentInChildren<Text>().DOFade(1.0f,0.25f);
            
            m_text.text = model.PlayerSide.ToString();
        }
        
    }
}