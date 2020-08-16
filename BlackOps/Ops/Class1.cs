namespace Ops
{
    using FireSharp.Config;
    using FireSharp.Interfaces;
    using FireSharp.Response;
    using Models;
    using System;

    public class Class1
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ialdMTdBT4y5CRpzTAO2AuoDhZF4R5A4YMhbrCig",
            BasePath = "https://blackops-63cb7.firebaseio.com/"

            //AuthSecret = "JrZhD3wcJs8HYYVf8UgpVcGiGZbgFNLQqSycXc3m",
            //BasePath = "https://task-d8100.firebaseio.com/"
        };

        IFirebaseClient firebaseClient;

        public bool Conectar()
        {
            return Conect();
        }

        public bool Conect()
        {
            firebaseClient = new FireSharp.FirebaseClient(config);

            if(firebaseClient != null)
                return true;
            else
                return false;
        }

        public async System.Threading.Tasks.Task<string> InsertAsync(Guid text, Data data)
        {

            firebaseClient = new FireSharp.FirebaseClient(config);

            SetResponse response = await firebaseClient.SetTaskAsync("Cuentas/" + text, data);
            Data result = response.ResultAs<Data>();
            return result.Concepto;
        }

    }
}
