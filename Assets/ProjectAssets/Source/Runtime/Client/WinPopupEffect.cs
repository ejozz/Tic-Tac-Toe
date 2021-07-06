using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace TicTacToe.Client.Runtime
{
    public sealed class WinPopupEffect : Effect
    {
        [SerializeField] private float m_intensity = default;
        [SerializeField] private float m_duration = default;
        [SerializeField] private Text m_text;
        [SerializeField] private SpriteRenderer m_spriteRenderer;
        
        private Sequence m_effectSequence;

        public override void Play()
        {
            if (!(m_effectSequence != null))
            {
                m_effectSequence = DOTween.Sequence();
                m_effectSequence.Insert(0, m_spriteRenderer.DOFade(m_intensity, m_duration).From())
                                .Insert(0, m_text.DOFade(m_intensity, m_duration).From());
            }
        }

        public override void Stop()
        {
            if (m_effectSequence != null)
            {
                m_effectSequence.Kill();
            }
            m_effectSequence = null;
        }

    }
}

