using StardewModdingAPI;

namespace iTile.Core
{
    public abstract class Manager : IInitializable
    {
        public IModHelper Helper
            => iTile.Instance.Helper;

        public virtual void Init()
        {
        }
    }
}
