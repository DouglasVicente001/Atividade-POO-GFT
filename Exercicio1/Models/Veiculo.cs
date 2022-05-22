using static System.Console;
namespace Exercicio1.Models
{
    public class Veiculo
    {   
        private string Marca { get; set; }
        private string Modelo { get; set; }
        private string Placa { get; set; }
        private string Cor { get; set; }
        private int Velocidade { get; set; }
        private int litrosCombustivel { get; set; }
        private float Km { get; set; }
        private bool isLigado { get; set; }

            public Veiculo(string marca, string modelo, string placa, string cor, int velocidade, int litrosCombustivel, float km, bool isLigado)
            {
                  Marca = marca;
                  Modelo = modelo;
                  Placa = placa;
                  Cor = cor;
                  Velocidade = Velocidade;
                  this.litrosCombustivel = litrosCombustivel;
                  Km = km;
                  this.isLigado = isLigado;
            }

            public void Acelerar()
            {
                Velocidade = Velocidade + 20;
                WriteLine($"A velocidade atual é: {Velocidade}");
            }
            public void Abastecer(int combustivel)
            {
                this.litrosCombustivel = combustivel;
                if (combustivel <= 60)
                {
                    WriteLine($"O tanque está com {combustivel} litros de gasolina.");
                } 
                else if(combustivel > 60)
                {   
                    combustivel = 60;
                    WriteLine($"O tanque foi completado! e está com {combustivel} litros de gasolina.");
                }
            }
            public void Frear()
            {
                Velocidade = Velocidade -20;
                if (Velocidade > 0)
                {   
                    WriteLine($"Após usar o freio você reduziu 20km/h e está em uma velocidade de {Velocidade} km/h.");
                } 
                else
                {
                    WriteLine("Não foi póssivel frear o veículo pois está parado! ");
                }
            }
            public void Pintar(string cor)
            {
                this.Cor = cor;
                WriteLine($"A cor atual do veiculo é {cor}");
            }
            public void Ligar()
            {
                if (isLigado.Equals(false))
                {
                    this.isLigado = true;
                    WriteLine("O veículo esta ligado");
                }
            }
            public void Desligar()
            {
                if (isLigado.Equals(true))
                {
                    WriteLine("Você desligou o veículo");
                }
            }
    }
}