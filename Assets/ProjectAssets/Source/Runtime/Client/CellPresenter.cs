using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace TicTacToe.Client.Runtime
{

    public sealed class CellPresenter : MonoBehaviour, IPointerClickHandler
    {

        [SerializeField] private Text m_text = default;
        [SerializeField] private int m_xPosition;
        [SerializeField] private int m_yPosition;
        [SerializeField] private GameBehaviorTree m_gameBehaviorTree;
        


        //Detects click and sets cell model and updates view
        public void OnPointerClick(PointerEventData pointerEventData)
        {
            
            Debug.Log("Clicked on ("+m_xPosition + "," + m_yPosition + ")");
            SetCell(ref m_gameBehaviorTree.gridModel.CellModelArray[m_xPosition,m_yPosition]);
            Show(m_gameBehaviorTree.gridModel.CellModelArray[m_xPosition,m_yPosition]);
        }


        //function sets text object to update view
        public void Show(CellModel model)
        {
            m_text.text = model.PlayerSide.ToString();
        }

        //function to set cell model side
        public void SetCell(ref CellModel model)
        {

            int m_randomNumber = Random.Range(0, 2);
            //if X, sets to O
            if (model.PlayerSide == Side.X)
            {
                model = new CellModel(Side.O);
            }

            //if O, sets to X
            else if (model.PlayerSide == Side.O)
            {
                model = new CellModel(Side.X);
            }
            
            //else sets X or O randomly
            else
            {

                if (m_randomNumber == 1)
                {
                    model = new CellModel(Side.O);
                }
                
                else
                {
                    model = new CellModel(Side.X);
                }

            }
        }

        

    }
}
