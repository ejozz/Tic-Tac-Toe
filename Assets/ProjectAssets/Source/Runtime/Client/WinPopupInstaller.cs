using UnityEngine;
using Zenject;

namespace TicTacToe.Client.Runtime
{    
    public sealed class WinPopupInstaller : MonoInstaller
    {
        [SerializeField] private RestartPresenter m_restartPresenter = default;
        [SerializeField] private RestartAppearEffect m_restartAppearEffect = default;
        [SerializeField] private WinPopupPresenter m_winPopupPresenter = default;
        [SerializeField] private WinPopupEffect m_winPopupEffect = default;

        public override void InstallBindings()
        {
            Container.Bind<RestartPresenter>().FromInstance(m_restartPresenter).AsSingle().NonLazy();            
            Container.Bind<RestartAppearEffect>().FromInstance(m_restartAppearEffect).AsSingle().NonLazy();            
            Container.Bind<WinPopupPresenter>().FromInstance(m_winPopupPresenter).AsSingle().NonLazy();            
            Container.Bind<WinPopupEffect>().FromInstance(m_winPopupEffect).AsSingle().NonLazy();            
        }
    }
}
