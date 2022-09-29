using System;

namespace DiagnosticoPrevio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIAGNÓSTICO PRÉVIO");


            string Nome = ("Louise Gusmão");
            Console.WriteLine("NOME:" + Nome);
            string Sexo = ("Feminino");
            Console.WriteLine("Sexo:" + Sexo);
            double Idade = (35);
            Console.WriteLine("Idade:" + Idade);
            double Altura = (1.65);
            Console.WriteLine("Altura:" + Altura);
            double Peso = (58.5);
            Console.WriteLine("Peso:" + Peso);

            if (Idade < 12)
            {
                Console.WriteLine("Categoria: Infantil");
            }
            else if (Idade >= 12 && Idade <= 20)
            {
                Console.WriteLine("Categoria: Juvenil");
            }
            else if (Idade > 20 && Idade <= 65)
            {
                Console.WriteLine("Categoria: Adulto");
            }
            else
            {
                Console.WriteLine("Categoria: Idoso");
            }
            
            Console.WriteLine("IMC Desejável: entre 20 e 24");

            double IMC = (Peso / (Altura * Altura));
            Console.WriteLine("Resultado IMC:" + IMC);

            if (IMC < 20)
            {
                Console.WriteLine("RISCO: Muitas complicações de saúde como doenças pulmonares e cardiovasculares podem estar associadas ao baixo peso.");
                Console.WriteLine("Recomendação Inicial:Inclua carboidratos simples em sua dieta, além de proteínas - indispensáveis para ganho de massa magra. Procure um profissional.");
            }
            else if (IMC >= 20 && IMC < 25)
            {
                Console.WriteLine("RISCO: Seu peso está ideal para suas referências.");
                Console.WriteLine("Recomendação Inicial:Mantenha uma dieta saudável e faça seus exames periódicos.");
            }
            else if (IMC >= 25 && IMC <= 29)
            {
                Console.WriteLine("RISCO: Aumento de peso apresenta risco moderado para outras doenças crônicas e cardiovasculares.");
                Console.WriteLine("Recomendação Inicial:Adote um tratamento baseado em dieta balanceada, exercício físico e medicação. A ajuda de um profissional pode ser interessante.");
            }
            else if (IMC >= 30 && IMC <= 35)
            {
                Console.WriteLine("RISCO: Quem tem obesidade vai estar mais exposto a doenças graves e ao risco de mortalidade.");
                Console.WriteLine("Recomendação Inicial:Adote uma dieta alimentar rigorosa, com o acompanhamento de um nutricionista e um médico especialista (endócrino).");
            }
            else if (IMC > 35)
            {
                Console.WriteLine("RISCO:O obeso mórbido vive menos, tem alto risco de mortalidade geral por diversas causas.");
                Console.WriteLine("Recomendação Inicial:Procure com urgência o acompanhamento de um nutricionista para realizar reeducação alimentar, um psicólogo e um médico especialista (endócrino).");
            }

        }
    }
}