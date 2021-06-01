using UnityEngine;
using DG.Tweening;

namespace TicTacToe.Client.Runtime
{
    public sealed class WinEffect : Effect
    {
        [SerializeField] private Color m_winColor = default;
        [SerializeField] private float m_winDuration = default;
        
        private float m_colorAlpha = 1;
        private SpriteRenderer m_cellSpriteRenderer;
        private Sequence m_effectSequence;

        private void Awake()
        {
            m_cellSpriteRenderer = GetComponent<SpriteRenderer>();
        }

        public override void CreateSequence()
        {
            m_effectSequence = DOTween.Sequence();
            m_effectSequence.Insert(0, DOTween.To(() => m_cellSpriteRenderer.color, x => m_cellSpriteRenderer.color = x, m_winColor, m_winDuration))
                            .Insert(0, DOTween.ToAlpha(() => m_cellSpriteRenderer.color, x => m_cellSpriteRenderer.color = x, m_colorAlpha, m_winDuration));
        }

    }
}