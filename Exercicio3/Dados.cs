using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class Dados
    {
        public int Dia { get; set; }
        public float Valor { get; set; }

        public float MenorValor(List<Dados> listadados)
        {
            var listafiltrada = Filtragem(listadados);
           return listafiltrada.Min(x => x.Valor);
        }
        public float MaiorValor(List<Dados> listadados)
        {
            var listafiltrada = Filtragem(listadados);
            return listafiltrada.Max(x => x.Valor);
        }
        public int ValorSuperior(List<Dados> listadados)
        {
            var listafiltrada = Filtragem(listadados);
            var media = listafiltrada.Sum(x=> x.Valor) / listafiltrada.Count();
            return listafiltrada.Where(x => x.Valor >= media).ToList().Count();
        }

        private List<Dados> Filtragem(List<Dados> listadados)
        {
           return listadados.Where(x => x.Valor != 0).ToList();
        }
    }
}
