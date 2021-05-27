using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;
using System;

namespace TicTacToe.Client.Runtime
{
    public sealed class CellAnimation : MonoBehaviour
    {
        [SerializeField] private float m_cellFadeIntensity = default;
        [SerializeField] private float m_cellFadeDuration = default;
        [SerializeField] private float m_textFadeIntensity = default;
        [SerializeField] private float m_textFadeDuration = default;
        
        public void StartAnimation()
        {
            GetComponent<SpriteRenderer>().DOFade(m_cellFadeIntensity, m_cellFadeDuration);
            GetComponentInChildren<Text>().DOFade(m_cellFadeIntensity, m_textFadeDuration).From();
        }

        public void StopAnimation()
        {
            GetComponent<SpriteRenderer>().DOPause();
            GetComponentInChildren<Text>().DOPause();
        }
    }
}
