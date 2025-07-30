namespace ET.Client
{
    
    public class GameClient : Singleton<GameClient>, ISingletonAwake<Scene>
    {
        public Scene Root { get; private set; }
        public void Awake(Scene root)
        {
            Root = root;
        }
    }
}
