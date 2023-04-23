using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Classes.Base
{
       public class SingletonBase<T> where T : class, new()
    {
        private static T instance = null;
        private static object locker = new();
        public static T Instance
        {
          

            get
            {
                if (instance == null)
                {
                    lock (locker)
                    {
                        if (instance == null)
                        {
                            instance = new();
                        }
                    }
                }
                return instance;
            }

        }

    }
}


