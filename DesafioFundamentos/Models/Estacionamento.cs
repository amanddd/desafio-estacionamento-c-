namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            //implementação concluída
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine();
            Console.WriteLine("Seu veiculo foi registrado!");

            if(veiculos.Contains(placa.ToUpper()))
            {
                Console.WriteLine("Veículo já está estacionado.");
            }
            else
            {
                veiculos.Add(placa.ToUpper());
                Console.WriteLine($"Veículo com placa {placa} estacionado com sucesso.");
            }
            
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            //implementação concluída
            
            string placa = Console.ReadLine();
            

             //implementação concluída
            if (veiculos.Contains(placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                //implementação concluída

                int horas = 0;
                decimal valorTotal = 0;
                

                if (int.TryParse(Console.ReadLine(), out int horas))
                {
                    valorTotal = precoInicial + precoPorHora * horas;
                    
                }

                //implementação concluída
                else
                {
                    Console.WriteLine("Horas erradas!!!");
                }
                //implementação concluída
                
                veiculos.Remove(placa.ToUpper());
                
                Console.WriteLine("Extrato Valores");
                Console.WriteLine("---------------");
                Console.WriteLine($"Valor entrada foi => {precoInicial}");
                Console.WriteLine($"Valor por Hora => {precoPorHora}");
                Console.WriteLine($"Quantidade de horas estacionadas => {horas}");
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
             //implementação concluída
            
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
               //implementação concluída
                foreach (var veiculos in veiculos)
                {
                    Console.WriteLine(veiculos);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}