using Zenject;

namespace TicTacToe.Client.Runtime
{    
    public class PlayerModelInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<PlayerModel>().WithId("xPlayer").FromInstance(new PlayerModel(Side.X , 0)).NonLazy();            
            Container.Bind<PlayerModel>().WithId("oPlayer").FromInstance(new PlayerModel(Side.O , 0)).NonLazy();
        }
    }
}