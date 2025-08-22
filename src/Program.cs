using System;
using System.Collections.Generic;
using System.IO;

namespace SistemaEstacionamentoAvancado
{
    class Veiculo
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Placa { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public bool Pago { get; set; } = false;
        public decimal ValorPago { get; set; } = 0;
    }

    class Estacionamento
    {
        private List<Veiculo> veiculos = new List<Veiculo>();
        private string registroPagamentos = "registro_pagamentos.txt";

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Nome do proprietário:");
            string nome = Console.ReadLine();
            Console.WriteLine("CPF do proprietário:");
            string cpf = Console.ReadLine();
            Console.WriteLine("Placa do veículo:");
            string placa = Console.ReadLine();

            veiculos.Add(new Veiculo
            {
                Nome = nome,
                CPF = cpf,
                Placa = placa,
                Entrada = DateTime.Now
            });

            Console.WriteLine("✅ Veículo adicionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Placa do veículo a remover:");
            string placa = Console.ReadLine();
            Veiculo v = veiculos.Find(x => x.Placa == placa && !x.Pago);

            if (v == null)
            {
                Console.WriteLine("❌ Veículo não encontrado ou já pago.");
                return;
            }

            v.Saida = DateTime.Now;
            TimeSpan tempo = v.Saida - v.Entrada;
            decimal valor = CalcularValor(tempo);

            Console.WriteLine($"Tempo estacionado: {tempo.Hours}h {tempo.Minutes}m");
            Console.WriteLine($"Valor a pagar: R${valor}");

            Console.WriteLine("Escolha a forma de pagamento:");
            Console.WriteLine("1 - PIX");
            Console.WriteLine("2 - Cartão de Crédito/Débito");
            Console.WriteLine("3 - Criptomoeda");
            string opcao = Console.ReadLine();

            v.Pago = true;
            v.ValorPago = valor;

            RegistrarPagamento(v, opcao);

            Console.WriteLine("✅ Pagamento registrado com sucesso!");
        }

        private decimal CalcularValor(TimeSpan tempo)
        {
            decimal valorHora = 5; // Valor fixo por hora
            int horas = (int)Math.Ceiling(tempo.TotalHours);
            return valorHora * horas;
        }

        private void RegistrarPagamento(Veiculo v, string forma)
        {
            // Converte a opção numérica para um texto descritivo
            string formaPagamentoStr = forma switch
            {
                "1" => "PIX",
                "2" => "Cartão",
                "3" => "Criptomoeda",
                _ => "Outro"
            };
            string registro = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | {v.Nome} | {v.CPF} | {v.Placa} | R${v.ValorPago} | {formaPagamentoStr}";
            File.AppendAllText(registroPagamentos, registro + Environment.NewLine);
        }

        public void ListarVeiculos()
        {
            Console.WriteLine("\n--- Veículos no Estacionamento ---");
            foreach (var v in veiculos.FindAll(x => !x.Pago))
            {
                Console.WriteLine($"- Placa: {v.Placa} | Proprietário: {v.Nome} | Entrada: {v.Entrada:HH:mm}");
            }
            Console.WriteLine("----------------------------------");
        }

        public void Relatorios()
        {
            decimal totalDia = 0, totalSemana = 0, totalMes = 0;
            DateTime hoje = DateTime.Now.Date;

            var pagamentos = veiculos.FindAll(v => v.Pago);

            foreach (var v in pagamentos)
            {
                if (v.Saida.Date == hoje)
                {
                    totalDia += v.ValorPago;
                }
                // Verifica se a saída ocorreu nos últimos 7 dias (incluindo hoje)
                if (v.Saida.Date >= hoje.AddDays(-6))
                {
                    totalSemana += v.ValorPago;
                }
                if (v.Saida.Year == hoje.Year && v.Saida.Month == hoje.Month)
                {
                    totalMes += v.ValorPago;
                }
            }

            Console.WriteLine($"\n📊 Relatório Diário: R${totalDia}");
            Console.WriteLine($"📊 Relatório Semanal: R${totalSemana}");
            Console.WriteLine($"📊 Relatório Mensal: R${totalMes}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Estacionamento estacionamento = new Estacionamento();
            string opcao;
            do
            {
                Console.WriteLine("\n--- 🚗 Menu Controle de Estacionamento ---");
                Console.WriteLine("1 - Adicionar veículo");
                Console.WriteLine("2 - Remover (registrar saída e pagamento)");
                Console.WriteLine("3 - Listar veículos estacionados");
                Console.WriteLine("4 - Ver relatórios de faturamento");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": estacionamento.AdicionarVeiculo(); break;
                    case "2": estacionamento.RemoverVeiculo(); break;
                    case "3": estacionamento.ListarVeiculos(); break;
                    case "4": estacionamento.Relatorios(); break;
                    case "5": Console.WriteLine("Saindo do sistema..."); break;
                    default: Console.WriteLine("❌ Opção inválida. Tente novamente."); break;
                }
            } while (opcao != "5");
        }
    }
}
