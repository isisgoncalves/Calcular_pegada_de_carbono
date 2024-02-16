using System;

class Program
{
    static void Main()
    {
       string nome = Console.ReadLine();
       double quilometrosPorDia = double.Parse(Console.ReadLine());
       int horasDeEletronicos = int.Parse(Console.ReadLine());
       int refeicoesComCarne = int.Parse(Console.ReadLine());

        // Chama o método para calcular a pegada de carbono
        double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);
        
        // TODO: Exiba o resultado para o usuário:
        Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaDeCarbono} toneladas de CO2 por ano.");

        // Aguarda a entrada do usuário antes de encerrar o programa:
        Console.ReadLine();
    }

    // TODO: Crie um método/função para calcular a pegada de carbono com base nos parâmetros fornecidos:
  static double CalcularPegadaDeCarbono(double quilometrosPorDia, int horasDeEletronicos, int refeicoesComCarne)
    {
        // Fatores de emissão
        double fatorTransporte = 0.2;
        double fatorEletronicos = 0.1;
        double fatorCarne = 0.5;

        // Cálculo da pegada de carbono
        double pegadaTransporte = quilometrosPorDia * 365 * fatorTransporte;
        double pegadaEletronicos = horasDeEletronicos * fatorEletronicos;
        double pegadaCarne = refeicoesComCarne * fatorCarne;

        // Soma dos valores
        double pegadaTotal = pegadaTransporte + pegadaEletronicos + pegadaCarne;

        return pegadaTotal;
    }

}
