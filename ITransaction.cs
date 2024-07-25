using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handson_2
{
    internal interface ITransaction
    {
        long  FromAccount { get; }

        long ToAccount { get; }

        void TransferAccount(long fromAccount, long toAccount);






    }
}
