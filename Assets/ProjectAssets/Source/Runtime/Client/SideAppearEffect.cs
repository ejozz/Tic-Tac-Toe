using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace TicTacToe.Client.Runtime
{
    public sealed class SideAppearEffect : Effect
    {
        [SerializeField] private float m_cellFadeIntensity = default;
        [SerializeField] private float m_cellFadeDuration = default;
        [SerializeField] private float m_textFadeIntensity = default;
        [SerializeField] private float m_textFadeDuration = default;
        
        private SpriteRenderer m_cellSpriteRenderer;
        private Text m_cellText;
        private Sequence m_effectSequence;

        private void Awake()
        {
            m_cellSpriteRenderer = GetComponent<SpriteRenderer>();
            m_cellText = GetComponentInChildren<Text>();;
        }

        public override void CreateSequence()
        {
            m_effectSequence = DOTween.Sequence();
            m_effectSequence.Insert(0, m_cellSpriteRenderer.DOFade(m_cellFadeIntensity, m_cellFadeDuration))
                            .Insert(0, m_cellText.DOFade(m_textFadeIntensity, m_textFadeDuration).From());
        }

    }
}
