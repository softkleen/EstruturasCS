using System;
using System.Collections.Generic; //biblioteca
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLabNu;

namespace EstruturasCS
{
    internal class Program
    {
        // Struct
        struct Carro 
        {
            public string Marca;
            public string Modelo;
            public string Cor;
            public string Placa;

            public Carro(string marca, string modelo, string cor, string placa) // construtor da Struct
            {
                Marca = marca;
                Modelo = modelo;
                Cor = cor;
                Placa = placa;
            }
            public void ExibirDados() 
            {
                Console.WriteLine($"Marca.: {Marca} \nModelo: {Modelo} \nCor...: {Cor} \nPlaca.: {Placa}");
            }
        }

        static void Main(string[] args)
        {
           // Carro carro = new Carro();
            //carro.Marca = "Honda";
            //carro.Modelo = "Fit";
            //carro.Cor = "Vermelho";
            //carro.Placa = "LPM4P98";
            //Carro carro2 = new Carro("Ford","Ka","Azul", "BGT7896");
            //Console.WriteLine("Marca: " + carro2.Marca);
            //Console.WriteLine("Modelo: {0}",carro2.Modelo);
            //Console.WriteLine($"Cor: {carro2.Cor} \nPlaca: {carro2.Placa}");
            //carro2.ExibirDados();

            // Array - Matrizes


            // List - Listas
            List<Carro> carros = new List<Carro>(); 
            carros.Add(new Carro("Ford", "Ka", "Branco", "BGT7896"));
            carros.Add(new Carro("VW", "Fusca", "Azul", "ADE7985"));
            carros.Add(new Carro("Kia", "Soul", "Amarelo", "FLP4k52"));
            foreach (Carro carro in carros)
            {
                carro.ExibirDados();
                Console.WriteLine();
            }
            //List<object> list = new List<object>(); 
            //list.Add(carros);
            var teste = carros.Contains(
                new Carro("Ford", "Focus", "Branco", "BGT7896")
                ) ? "Tem sim, mano!" : "Tem não, Sangue!";
            Console.WriteLine(teste);
            Console.WriteLine($"A lista possui {carros.Count} carros");

            // Queue - Filas
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("José");
            fila.Enqueue("Bruna");
            fila.Enqueue("Gui");
            //exibe o número de elementos na fila
            Console.WriteLine($"Número de pessoas na fila: {fila.Count} ");
            Console.WriteLine($"Proximo da fila: {fila.Peek()}");
            Console.WriteLine($"Número de pessoas na fila: {fila.Count}");
            Console.WriteLine($"Cliente {fila.Dequeue()}, será atendido no guichê 4");
            Console.WriteLine($"Número de pessoas na fila: {fila.Count}");
            Console.WriteLine($"Proximo da fila: {fila.Peek()}");
            fila.Enqueue("Julio");
            Console.WriteLine("O cliente Julio, entrou na fila");
            Console.WriteLine($"Número de pessoas na fila: {fila.Count}");
            
            // Stack - Pilhas
            Stack<int> pilha = new Stack<int>();    
            pilha.Push(12);// adiciona elemento na pilha
            pilha.Push(13);
            pilha.Push(14);
            pilha.Push(15);
            Console.WriteLine($"Removemos o primeiro elemento da pilha: {pilha.Pop()}");
            Console.WriteLine($"Próximo elemento da pilha: {pilha.Peek()}");

                
            Console.WriteLine(cores.azul);
            
           if (Usuario.EfetuarLogin("nome", "senac"))
            { 
                // logado com sucesso
            }

            Usuario usuario = new Usuario("Zé","ze@arroba",new Nivel("do Caixa","cx"),"12547");
            Console.WriteLine(usuario.Nome + " - " + usuario.Nivel.Nome);
            //usuario.Id = 10;
            Nivel nivel = new Nivel("dfd","45");

            nivel.Alterar(1, "cx");
           

            Console.ReadKey();


        }
        enum cores{ azul, verde, vermelho, branco, cinza};
      
    }
}
