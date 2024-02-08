using System.Collections.Generic;

namespace ProjetoEnqueteMvcNetCore.Models
{
    public static class Repositorio
    {
        private static List<Resposta> respostas = new List<Resposta>();
        public static IEnumerable<Resposta> Respostas { get { return respostas; }}
        public static void AddRespostas(Resposta resposta)
        {
            respostas.Add(resposta);
        }

        static Repositorio()
        {
            respostas.Add(new Resposta()
                { Nome = "Silas", Email = "silas@gmail.com", Sim = true });
            respostas.Add(new Resposta()
                { Nome = "Paulo", Email = "paulo@gmail.com", Sim = false });
            respostas.Add(new Resposta()
                { Nome = "Luis", Email = "luis@gmail.com", Sim = true });
            respostas.Add(new Resposta()
                { Nome = "Tomas", Email = "tomas@gmail.com", Sim = false });
            respostas.Add(new Resposta()
                { Nome = "Carlos", Email = "carlos@gmail.com", Sim = true });
            respostas.Add(new Resposta()
                { Nome = "Flavio", Email = "flavio@gmail.com", Sim = false });
            
        }
    }
}