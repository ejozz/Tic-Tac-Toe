using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace TicTacToe.Client.Runtime
{
    public sealed class RestartAppearEffect : Effect
    {
        [SerializeField] private float m_intensity = default;
        [SerializeField] private float m_duration = default;
        
        private SpriteRenderer m_buttonSpriteRenderer;
        private Text m_text;
        private Sequence m_effectSequence;

        private void Awake()
        {
            m_buttonSpriteRenderer = GetComponent<SpriteRenderer>();
            m_text = GetComponentInChildren<Text>();;
        }

        public override void Play()
        {
            if (!(m_effectSequence != null))
            {
                m_effectSequence = DOTween.Sequence();
                m_effectSequence.Insert(0, m_buttonSpriteRenderer.DOFade(m_intensity, m_duration).From())
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
