using Common;

namespace Example.Common
{
    public class CreateAccount: ICommand
    {
        public CreateAccount(int shard)
        {
            Shard = shard;
        }

        public int Shard { get; private set; }
    }
}