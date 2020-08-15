namespace Ops
{
    using FireSharp.Config;
    using FireSharp.Interfaces;
    using FireSharp.Response;
    using Models;

    public class Class1
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ialdMTdBT4y5CRpzTAO2AuoDhZF4R5A4YMhbrCig",
            BasePath = "https://blackops-63cb7.firebaseio.com/"
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

        public async System.Threading.Tasks.Task<Data> InsertAsync(string text, Data data)
        {
            SetResponse response = await firebaseClient.SetTaskAsync("Cuentas/" + text, data);
            Data result = response.ResultAs<Data>();
            return result;
        }

    }
}
