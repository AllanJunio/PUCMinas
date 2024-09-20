using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    internal class PontoVO
    {
        private int codigo;
        private string descricao;
        private double x;
        private double y;
        private int tipoFigura;

        public PontoVO()
        {
        }

        public PontoVO(int codigo)
        {
            this.codigo = codigo;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public int TipoFigura { get => tipoFigura; set => tipoFigura = value; }

        public override bool Equals(object? obj)
        {
            return obj is PontoVO vO &&
                   Codigo == vO.Codigo;
        }

        public override string? ToString()
        {
            return "Código:" + Codigo + " descricao: " + Descricao + " x:" + X + " y:" + Y;
        }
    }
}
