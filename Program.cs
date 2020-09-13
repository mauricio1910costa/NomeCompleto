using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeDoUsuario;
            string sobreNomeDoUsuario; 
            string nomeCompleto;
            String Catalogo; 
            
            Console.Write("Por favor, digite seu primeiro: ");
            nomeDoUsuario = Console.ReadLine();
            
            Console.Write("Agora, digite seu sobrenome: ");
            sobreNomeDoUsuario = Console.ReadLine();
            
            nomeCompleto = $"{nomeDoUsuario} {sobreNomeDoUsuario}";
            Catalogo = $"{sobreNomeDoUsuario.ToUpper()}, {nomeDoUsuario}";
            Console.WriteLine();
            
            Console.WriteLine($" Nome Completo: {nomeCompleto} ");
            Console.Write($" Nome do Catálago: {Catalogo} \n OBRIGADO");
            Console.WriteLine();
            
            
        }
    }
}
