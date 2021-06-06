using UnityEngine;
using DG.Tweening;

namespace TicTacToe.Client.Runtime
{
    public abstract class Effect : MonoBehaviour
    {        
        public abstract void Play();
        
        public abstract void Stop();
    }
}
