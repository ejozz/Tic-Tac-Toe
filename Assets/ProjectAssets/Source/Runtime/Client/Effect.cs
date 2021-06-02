using UnityEngine;
using DG.Tweening;

namespace TicTacToe.Client.Runtime
{
    public abstract class Effect : MonoBehaviour
    {        
        private Sequence m_effectSequence;
        
        public abstract void Play();
        
        public abstract void Stop();

    }
}