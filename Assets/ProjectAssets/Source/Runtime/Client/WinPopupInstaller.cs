using UnityEngine;
using Zenject;

namespace TicTacToe.Client.Runtime
{    
    public sealed class WinPopupInstaller : MonoInstaller
    {
        [SerializeField] private GameObject m_popup = default;

        public override void InstallBindings()
        {
            Container.Bind<GameObject>().FromInstance(m_popup).AsSingle().NonLazy();            
        }
    }
}
