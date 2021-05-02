using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TicTacToe.Client.Runtime;

namespace TicTacToe.Client.Runtime
{
    public sealed class GridspacePresenter : MonoBehaviour, IPointerClickHandler
    {
        
        [SerializeField] private GridspaceModel m_gridModel;
        private int m_randomNumber;
        
        //Detect if a click occurs
        public void OnPointerClick(PointerEventData pointerEventData)
        {

            if (m_gridModel.m_spaceText.text.Equals("X"))
            {
                m_gridModel.m_playerSide = "O";
                m_gridModel.m_spaceText.text = m_gridModel.m_playerSide;
            }

            else if (m_gridModel.m_spaceText.text.Equals("O"))
            {
                m_gridModel.m_playerSide = "X";
                m_gridModel.m_spaceText.text = m_gridModel.m_playerSide;
            }

            else
            {
                m_randomNumber = Random.Range(0, 2);

                if (m_randomNumber < 1)
                {
                    m_gridModel.m_playerSide = "X";
                    m_gridModel.m_spaceText.text = m_gridModel.m_playerSide;
                }
                
                else
                {
                    m_gridModel.m_playerSide = "O";
                    m_gridModel.m_spaceText.text = m_gridModel.m_playerSide;
                }

            }
        
        }
    }
}