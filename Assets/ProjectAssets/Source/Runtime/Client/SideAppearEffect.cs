using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;
using System;

namespace TicTacToe.Client.Runtime
{
    public sealed class SideAppearEffect : MonoBehaviour
    {
        [SerializeField] private float m_cellFadeIntensity = default;
        [SerializeField] private float m_cellFadeDuration = default;
        [SerializeField] private float m_textFadeIntensity = default;
        [SerializeField] private float m_textFadeDuration = default;
        private SpriteRenderer m_cellSpriteRenderer;
        private Text m_cellText;
        private Tweener m_spriteTweener;
        private Tweener m_textTweener;

        private void Awake()
        {
            m_cellSpriteRenderer = GetComponent<SpriteRenderer>();
            m_cellText = GetComponentInChildren<Text>();
        }
        
        public void Play()
        {
            m_spriteTweener = m_cellSpriteRenderer.DOFade(m_cellFadeIntensity, m_cellFadeDuration);
            m_textTweener = m_cellText.DOFade(m_textFadeIntensity, m_textFadeDuration).From();
        }

        public void Stop()
        {
            m_spriteTweener.Kill();
            m_textTweener.Kill();
        }
    }
}