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
        

        public delegate void EventHandler(CellPresenter sender);
        public static event EventHandler OnClick;


        //Detects click and invokes event
        public void OnPointerClick(PointerEventData pointerEventData)
        {
            
            Debug.Log("Clicked on ("+m_xPosition + "," + m_yPosition + ")");
            
            if(OnClick != null)
            {
                OnClick.Invoke(this);
            }
           
        }


        //function sets text object to update view
        public void Show(GridModel grid)
        {
    
            m_text.text = grid.CellModelArray[m_xPosition,m_yPosition].PlayerSide.ToString();
        }

        //function to set cell model side
        public void SetCell(ref GridModel grid)
        {

            int m_randomNumber = Random.Range(0, 2);
            //if X, sets to O
            if (grid.CellModelArray[m_xPosition, m_yPosition].PlayerSide == Side.X)
            {
                grid.CellModelArray[m_xPosition, m_yPosition] = new CellModel(Side.O);
            }

            //if O, sets to X
            else if (grid.CellModelArray[m_xPosition, m_yPosition].PlayerSide == Side.O)
            {
                grid.CellModelArray[m_xPosition, m_yPosition] = new CellModel(Side.X);
            }
            
            //else sets X or O randomly
            else
            {

                if (m_randomNumber == 1)
                {
                    grid.CellModelArray[m_xPosition, m_yPosition] = new CellModel(Side.O);
                }
                
                else
                {
                    grid.CellModelArray[m_xPosition, m_yPosition] = new CellModel(Side.X);
                }

            }
        }

        

    }
}
