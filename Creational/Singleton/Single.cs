using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Single
    {
        // Static members are 'eagerly initialized', that is, 
        // immediately when class is loaded for the first time.
        // .NET guarantees thread safety for static initialization
        private static readonly Single _instance = new Single();

        //Stop class user to make a new instance using the constructor. Hence private.
        private Single()
        {

        }

        public static Single GetInstance()
        {
            return _instance;
        }
    }
}
