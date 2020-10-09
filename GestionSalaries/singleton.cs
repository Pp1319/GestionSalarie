using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSalaraies
{
    public sealed class Singleton
    {
        public static Singleton _instance = null;
        private static readonly object padlock = new object();
       private  Singleton()
        {
        }
        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (_instance == null) 
                    {
                        _instance = new Singleton();
                    }
                    return _instance;
                }
            }
        }
    }
}
