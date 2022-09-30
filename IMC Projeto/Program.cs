using System;

namespace DiagnosticoPrevio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resposta;
            do
            {
                Console.Clear();
                Console.WriteLine("Olá, Bem Vindo ao Software de Calculo de IMC");

                Console.WriteLine("Escreva Seu nome");
                string nome = Console.ReadLine();

                Console.WriteLine("Qual Seu Sexo?");
                string sexo = Console.ReadLine();

                Console.WriteLine("Qual Sua Idade");
                int idade = 0;
                while (!int.TryParse(Console.ReadLine(), out idade))
                {
                    int.TryParse(Console.ReadLine(), out idade);
                }

                Console.WriteLine("Digite Sua altura(Ex.:0,00)");
                float altura = 0;
                while (!float.TryParse(Console.ReadLine(), out altura))
                {
                    float.TryParse(Console.ReadLine(), out altura);
                }
                Console.WriteLine("Digite Seu Peso");
                float peso = 0;
                while (!float.TryParse(Console.ReadLine(), out peso))
                {
                    float.TryParse(Console.ReadLine(), out peso);
                }
                string categoria = "";


                if (idade < 12)
                {

                    categoria = "infantil";

                }
                if (idade >= 12 && idade <= 20)
                {

                    categoria = "juvenil";

                }
                if (idade >= 21 && idade <= 65)
                {

                    categoria = "Adulto";
                }
                if (idade > 65)
                {

                    categoria = "idoso";
                }


                float imc = peso / (altura * altura);



                Console.Clear();
                Console.WriteLine($"Nome: {nome}");
                Console.WriteLine($"Sexo: {sexo}");
                Console.WriteLine($"idade: {idade}");
                Console.WriteLine($"Altura: {altura}");
                Console.WriteLine($"Peso: {peso}");
                Console.WriteLine($"Categoria: {categoria} \r\n");
                Console.WriteLine($"{nome}, Seu imc é: {String.Format("{0:0.00}", imc)}\r\n");








                Console.WriteLine("IMC Desejável: Entre 20 e 24 \r\n\r\n");

                if (imc < 20)
                {
                    Console.WriteLine("RISCO: Muitas complicações de saúde como doenças pulmonares e cardiovasculares podem estar associadas ao baixo peso.");
                    Console.WriteLine("Recomendação Inicial:Inclua carboidratos simples em sua dieta, além de proteínas - indispensáveis para ganho de massa magra. Procure um profissional.");
                }
                else if (imc >= 20 && imc <= 24.99999999999)
                {
                    Console.WriteLine("RISCO: Seu peso está ideal para suas referências.");
                    Console.WriteLine("Recomendação Inicial:Mantenha uma dieta saudável e faça seus exames periódicos.");
                }
                else if (imc >= 25 && imc <= 29.99999999999)
                {
                    Console.WriteLine("RISCO: Aumento de peso apresenta risco moderado para outras doenças crônicas e cardiovasculares.");
                    Console.WriteLine("Recomendação Inicial:Adote um tratamento baseado em dieta balanceada, exercício físico e medicação. A ajuda de um profissional pode ser interessante.");
                }
                else if (imc >= 30 && imc <= 34.99999999999)
                {
                    Console.WriteLine("RISCO: Quem tem obesidade vai estar mais exposto a doenças graves e ao risco de mortalidade.");
                    Console.WriteLine("Recomendação Inicial:Adote uma dieta alimentar rigorosa, com o acompanhamento de um nutricionista e um médico especialista (endócrino).");
                }
                else if (imc > 35)
                {
                    Console.WriteLine("RISCO:O obeso mórbido vive menos, tem alto risco de mortalidade geral por diversas causas.");
                    Console.WriteLine("Recomendação Inicial:Procure com urgência o acompanhamento de um nutricionista para realizar reeducação alimentar, um psicólogo e um médico especialista (endócrino).");
                }


                Console.WriteLine("Deseja Calcular outro IMC? Digite 1 para sim ou 2 para não");
                int.TryParse(Console.ReadLine(), out resposta);
            } while (resposta == 1);

        }
    }
}