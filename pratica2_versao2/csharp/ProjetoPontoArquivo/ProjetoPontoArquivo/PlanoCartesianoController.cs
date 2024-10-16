using modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle
{
    public class PlanoCartesianoController
    {
        /**
         * Selecionar os pontos por semiplano que pode ser:
         * 1: direito (X > 0);
         * 2: esquerdo (X < 0);
         * 3: superior (Y > 0);
         * 4: inferior (Y < 0);
         */
        public ArrayList selecionarPontosPorSemiplano(int codigo)
        {
            PlanoCartesianoDAO dao = new PlanoCartesianoDAO();
            ArrayList lista = dao.obterTodos(1, true); // Carrega todos os pontos
            ArrayList pontosFiltrados = new ArrayList();

            foreach (PontoVO ponto in lista)
            {
                switch (codigo)
                {
                    case 1: // Semiplano direito (X > 0)
                        if (ponto.X > 0) pontosFiltrados.Add(ponto);
                        break;
                    case 2: // Semiplano esquerdo (X < 0)
                        if (ponto.X < 0) pontosFiltrados.Add(ponto);
                        break;
                    case 3: // Semiplano superior (Y > 0)
                        if (ponto.Y > 0) pontosFiltrados.Add(ponto);
                        break;
                    case 4: // Semiplano inferior (Y < 0)
                        if (ponto.Y < 0) pontosFiltrados.Add(ponto);
                        break;
                }
            }
            return pontosFiltrados;
        }

        /**
         * Selecionar os pontos do semiplano ímpar (X * Y > 0).
         */
        public ArrayList selecionarPontosSemiPlanoImpar()
        {
            PlanoCartesianoDAO dao = new PlanoCartesianoDAO();
            ArrayList lista = dao.obterTodos(1, true); // Carrega todos os pontos
            ArrayList pontosSemiPlanoImpar = new ArrayList();

            foreach (PontoVO ponto in lista)
            {
                if (ponto.X * ponto.Y > 0) // Ambos positivos ou ambos negativos
                {
                    pontosSemiPlanoImpar.Add(ponto);
                }
            }
            return pontosSemiPlanoImpar;
        }

        /**
         * Selecionar os pontos do semiplano par (X * Y < 0).
         */
        public ArrayList selecionarPontosSemiPlanoPar()
        {
            PlanoCartesianoDAO dao = new PlanoCartesianoDAO();
            ArrayList lista = dao.obterTodos(1, true); // Carrega todos os pontos
            ArrayList pontosSemiPlanoPar = new ArrayList();

            foreach (PontoVO ponto in lista)
            {
                if (ponto.X * ponto.Y < 0) // Um positivo e outro negativo
                {
                    pontosSemiPlanoPar.Add(ponto);
                }
            }
            return pontosSemiPlanoPar;
        }

        /**
         * Selecionar os pontos por tipo de figura.
         */
        public ArrayList selecionarPontos(int tipoFigura)
        {
            PlanoCartesianoDAO dao = new PlanoCartesianoDAO();
            ArrayList lista = dao.obterTodos(1, true); // Carrega todos os pontos
            ArrayList pontosPorTipo = new ArrayList();

            foreach (PontoVO ponto in lista)
            {
                if (ponto.TipoFigura == tipoFigura)
                {
                    pontosPorTipo.Add(ponto);
                }
            }
            return pontosPorTipo;
        }
    }
}