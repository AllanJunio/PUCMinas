using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class PontoVO
    {
        private int codigo;
        private string descricao;
        private double x;
        private double y;
        private int tipoFigura;

        // Construtor padrão
        public PontoVO() { }

        // Construtor com código
        public PontoVO(int codigo)
        {
            this.Codigo = codigo;
        }

        // Construtor completo
        public PontoVO(int codigo, int tipoFigura, string descricao, double x, double y) : this(codigo)
        {
            this.Descricao = descricao;
            this.X = x;
            this.Y = y;
            this.TipoFigura = tipoFigura;
        }

        // Propriedades (Getters e Setters)
        public int Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public int TipoFigura { get => tipoFigura; set => tipoFigura = value; }

        // Sobrescrita do Equals para comparação por código
        public override bool Equals(object? obj)
        {
            return obj is PontoVO vO && codigo == vO.codigo;
        }

        // Sobrescrita do ToString para exibir informações completas
        public override string ToString()
        {
            return $"Código: {Codigo}, Descrição: {Descricao}, X: {X}, Y: {Y}, TipoFigura: {TipoFigura}";
        }
    }
}