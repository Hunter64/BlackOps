namespace Ops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using FireSharp.Config;
    using FireSharp.Interfaces;
    using FireSharp.Response;

    public class Class1
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ialdMTdBT4y5CRpzTAO2AuoDhZF4R5A4YMhbrCig",
            BasePath = "https://blackops-63cb7.firebaseio.com/"
        };

        public bool Conectar()
        {
            return Conect();
        }

        public bool Conect()
        {
            IFirebaseClient firebaseClient;
            firebaseClient = new FireSharp.FirebaseClient(config);

            if(firebaseClient != null)
                return true;
            else
                return false;
        }

        
    }
}
