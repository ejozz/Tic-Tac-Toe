using UnityEngine;
using DG.Tweening;

namespace TicTacToe.Client.Runtime
{
    public abstract class Effect : MonoBehaviour
    {        
        private Sequence m_effectSequence;
        
        public abstract void CreateSequence();
        
        public void Play()
        {
            if (!(m_effectSequence != null))
            {
                CreateSequence();
            }
        }
        
        public void Stop()
        {
            if (m_effectSequence != null)
            {
                m_effectSequence.Kill();
            }
            m_effectSequence = null;
        }

        
    }
}