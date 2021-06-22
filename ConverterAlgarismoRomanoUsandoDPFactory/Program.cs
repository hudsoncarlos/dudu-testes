using ConverterAlgarismoRomanoUsandoDPFactory.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConverterAlgarismoRomanoUsandoDPFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //new IniciandoConversor().ExibiMenuConsole(EnumOpcoesMenu.Inicio);

            var ob1 = new Objeto1() { Id = 1, Nome = "Hudson1" };
            var ob2 = new Objeto1() { Id = 1, Nome = "Hudson" };
            var lista = new List<Objeto1>();
            lista.Add(new Objeto1() { Id = 1, Nome = "Hudson1" });
            lista.Add(new Objeto1() { Id = 1, Nome = "Hudson2" });
            lista.Add(new Objeto1() { Id = 1, Nome = "Hudson3" });

            if (lista.Where(x => x.Nome == "Hudson1").Count() > 0)
            {
                Console.WriteLine(lista.Count());
                Console.WriteLine(lista[0].Nome);
                Console.WriteLine(lista[1].Nome);
            }

            var restorno = ModelExtensions.ValoresDiferentes<Objeto1>(ob1, ob2).ToList();
            //var valoresModificados = ModelExtensions.ValoresDiferentes<RequisicaoFisicaDTO>(requisicaoDaSuaLista).ToList();

            Console.ReadLine();
        }
    }

    public static class ModelExtensions
    {
        public static IEnumerable<KeyValuePair<string, object>> ValoresDiferentes<T>(this T obj, T modifiedObject)
        {
            foreach (var property in typeof(T).GetProperties().Where(p => !p.GetGetMethod().IsVirtual))
            {
                if (property.GetValue(obj).ToString() != property.GetValue(modifiedObject).ToString())
                {
                    yield return new KeyValuePair<string, object>(property.Name, property.GetValue(modifiedObject));
                }
            }
        }
    }


    public class Objeto1
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
