using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace TicTacToe.Client.Runtime
{
    public sealed class WinEffect : MonoBehaviour
    {
        [SerializeField] private Color m_winColor = default;
        [SerializeField] private float m_winDuration = default;
        private SpriteRenderer m_cellSpriteRenderer;
        private Tweener m_winTweener;

        private void Awake()
        {
            m_cellSpriteRenderer = GetComponent<SpriteRenderer>();
        }

        public void Play()
        {
            if (!(m_winTweener != null))
            {
                m_winTweener = DOTween.To(() => m_cellSpriteRenderer.color, x => m_cellSpriteRenderer.color = x, m_winColor, m_winDuration);
                m_winTweener =DOTween.ToAlpha(() => m_cellSpriteRenderer.color, x => m_cellSpriteRenderer.color = x, 1, m_winDuration);
            }
        }

        public void Stop()
        {
            if (m_winTweener != null)
            {
                m_winTweener.Kill();
            }
            m_winTweener = null;
        }
    }
}