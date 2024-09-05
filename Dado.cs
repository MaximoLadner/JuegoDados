using ConsoleApp40;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Dado
    {
        private int _valor;
        private static Random aleatoio;

        public Dado()
        {
            
            aleatoio = new Random();
        }
        public void Tirar()
        {
            _valor = aleatoio.Next(1, 7);
        }
        public void Impimir()
        {
            Console.WriteLine($"El valo que te toco es: {_valor}");
        }
        public int RetonarValor()
        {
            return _valor;
        }
    }
}

class JuegoDados
{
    private Dado dado1;
    private Dado dado2;
    private Dado dado3;

    public JuegoDados()
    {
        dado1 = new Dado();
        dado2 = new Dado();
        dado3 = new Dado();
    }
    public void Jugar()
    {

        dado1.Tirar();
        dado1.Impimir();
        dado2.Tirar();
        dado2.Impimir();
        dado3.Tirar();
        dado3.Impimir();
        if (dado1 == dado2 && dado1 == dado3)
        {
            Console.WriteLine("GANASTE PAPAAA");
        }
        else
        {
            Console.WriteLine("PERDISTE BRO...");
        }
    }
}