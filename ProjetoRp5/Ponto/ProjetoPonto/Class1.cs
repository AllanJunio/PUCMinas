using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPonto
{
    public class ponto
    {
        private double x = 0;
        private double y = 0;
        private string descricao;


        public ponto(string descricao)
        {
            this.descricao = "default";
            this.y = 0;
            this.x = 0;
        }
        public ponto()
        {
            this.descricao = "default";
            this.y = 0;
            this.x = 0;
        }
        public ponto(string descricao, double x, double y) {
            this.descricao = descricao;
            this.y = y;
            this.x = x;
        }
        public double getX()
        {

        return x; }
        public double getY()
        {
            return y;
        }
        public string getDescricao()
        {
            return descricao;
        }
        public void setX(double x)
        {
            this.x = x;
        }
        public void setY(double y)
        {
            this.y = y;
        }
        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }
        public void incrementarCoordenadas(int deltaX, int deltaY)
        {
            x = x + deltaX;
            y = y + deltaY;
        }
        public void imprimirCoordenadas()
        {
            // imprime as coordenadas x e y 
            Console.WriteLine(""+descricao+"x={0}, y={1}", x, y);
        }
        public void zerarCoordenadas()
        {
            x = 0;
            y = 0;
        }
        public string toString()
        {
            return descricao+"/"+x+ "/"+y+"]";
        }
        public double GetX()
        {
            return this.x;
        }
        public double GetY()
        {
            return this.y;
        }
        public void SetDescricao(string descricao)
        {
            this.descricao = descricao;
        }
        public override string ToString()
        {
            return descricao + "/" + x + "/" + y + "]";
        }
        public string GetDescricao()
        {
            return this.descricao;
        }
    }
}
