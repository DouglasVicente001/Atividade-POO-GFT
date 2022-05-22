using Exercicio2;

namespace Exercicio2.Models
{
    public class Livro : Produto, Iimposto
    {
        public Livro(string nome, double preco, int qtd,string Autor,string Tema, int qtPag) : base(nome, preco, qtd)
        {
            this.Autor = Autor;
            this.Tema = Tema;
            this.qtdPag = qtdPag;
            this.nome = nome;
        }

        public string Autor { get; set; }
        public string Tema { get; set; }
        public int qtdPag { get; set; }

        public Livro()
        {

        }
        public void CalculaImposto()
        {
            if (Tema.Equals("educativo"))
            {   
                double imposto = preco + 0;
                preco = preco + imposto;
                Console.WriteLine($"O livro {nome} é educativo portanto não contém taxas! Permaneceu em um valor de: R${preco} reais.");
            }
            else
            {
                double imposto = (preco * 10)/100;
                preco = preco + imposto;
                Console.WriteLine($"O livro  {nome} contém taxas! e ficou em um valor de: {preco} reais.");
            }
        }
    }
}