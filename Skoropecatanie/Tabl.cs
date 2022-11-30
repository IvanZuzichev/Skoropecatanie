using Newtonsoft.Json;
using System.Reflection.Metadata;

namespace Skoropecatanie
{
    internal class Tabl
    {
        public void exel(Info user)
        {
            string json = JsonConvert.SerializeObject(user);
            File.WriteAllText("C:\\Users\\79671\\Desktop\\tabl.json", json);
            Console.ReadKey();
        }
}
}
