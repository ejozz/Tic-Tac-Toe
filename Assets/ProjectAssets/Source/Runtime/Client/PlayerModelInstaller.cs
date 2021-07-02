using Zenject;

namespace TicTacToe.Client.Runtime
{    
    public sealed class PlayerModelInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<PlayerModel>().WithId(PlayerID.XPlayer).FromInstance(new PlayerModel(Side.X , 0)).NonLazy();            
            Container.Bind<PlayerModel>().WithId(PlayerID.OPlayer).FromInstance(new PlayerModel(Side.O , 0)).NonLazy();
        }
    }
}