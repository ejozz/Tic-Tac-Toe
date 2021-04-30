using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TicTacToe.Client.Runtime
{
    public sealed class Gridspace : MonoBehaviour
    {
        [SerializeField] private Button m_button;
        [SerializeField] private Text m_buttonText;
        [SerializeField] private string m_playerSide;
        private int m_randomNumber;

        public void SetSpace()
        {
            if (m_buttonText.text.Equals("X"))
            {
                m_playerSide = "O";
                m_buttonText.text = m_playerSide;
            }

            else if (m_buttonText.text.Equals("O"))
            {
                m_playerSide = "X";
                m_buttonText.text = m_playerSide;
            }

            else
            {
                m_randomNumber = Random.Range(0, 2);

                if (m_randomNumber < 1)
                {
                    m_playerSide = "X";
                    m_buttonText.text = m_playerSide;
                }
                
                else
                {
                    m_playerSide = "O";
                    m_buttonText.text = m_playerSide;
                }

            }
        }
    }
}