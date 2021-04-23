using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CashMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] note = {100,50,20,10,5,2,1};                              //introduzindo variáveis inteiras para reais porque esses valores não precisam de vírgula, da maior valor para a menor, pois quero que o cliente receba a menor quantidade de notas possíveise (então no "enquanto" ela vai começar com as maiores)
            int[] cent = {50,25,10,5,1};                                   //introduzindo variáveis inteiras para centavos porque esses valores não precisam de vírgula, da maior valor para a menor, pois quero que o cliente receba a menor quantidade de centavos possíveis (então no "enquanto" ela vai começar com as maiores)

            string NotesCents;                                                  //definindo variável do tipo texto para saída de valores totais de Notas e Centavos
            decimal value;                                                      //Introduzindo uma variável decimal para o valor que será digitado para saque, já que pode ser um valor quebrado e grande
            int i,NoteQuant, CentQuant;                                       //Introduzindo o i que será condicional para o meu While, a variável para fazer contagem das notas e a dos centavos


            Console.WriteLine("Bem vindo ao sistema do banco Letícia!");        //Joguei na tela um texto amigável para o cliente
            Console.WriteLine("Digite o valor do seu saque:");                  //Joguei na tela um texto para ele entender que deve digitar o valor
            value = decimal.Parse(Console.ReadLine());                          //recebi o valor digitado pelo cliente na variável que receberá o quanto ele quer sacar


            int ValueNote = (int)value;                                         //Transformo a variável do tipo decimal em uma variável inteira, objetivando cortar os valores após a vírgula, para poder ficar com os valores de nota

            NotesCents = "\n Você efetuou um Saque de R$ " + (value) + "\n\n";           //Defini minha primeira saída para NotesCents, mostrando na tela o valor que o cliente digitou de saque e pulando duas linhas ao final    

            i = 0;                                                                             //introduzi o meu i com zero, para ele começar do ponto zero de cada variável que o usará
            while (ValueNote != 0)                                                             //Enquanto o valor inteiro de dinheiro for diferente de zero
            {
                NoteQuant = ValueNote / note[i];                                              //Vou pegar a Valor inteiro para saque e dividir pelo maior valor divísível presente na variável note em um ciclo e atribuo esse valor para NoteQuanty
                if (NoteQuant != 0)                                                          //Se a quantidadede notas de um tipo que estou processando no momento for diferente de zero eu vou entrar nesse "Se"
                {                    
                    NotesCents = NotesCents + (NoteQuant + "x R$ " + note[i] + "\n");               //Vou atribuir a NotesCents os valores de NoteQuanty para imprimir na tela a quantidade de notas do tipo que estou analisando       
                    ValueNote = ValueNote % note[i];                                                 //Calculo a sobra relacionando o valor do saque com relação a nota em análise
                }
                i = i + 1;                                                                           //saio do if e vou para outra nota
            }

            NotesCents = NotesCents + "\n";                                                                   //saio do primeiro "enquanto" porque terminei a quantidade de notas e atribuo novo valor a Variável de total de reais e moedas


            int ValueNote2 =(int) ((value - (int)value) * 100);                                          //Atribuo novo valor a variável de valor, agora pegando o valor da entrada que o cliente deu e subtraindo dela a parte  que calculei como inteiro em reais, também arredondo essa variável após multiplicar por 100, por causa dos valores inteiros que atribui para centavos
            i = 0;                                                                                          //introduzi o meu i com zero, para ele começar do ponto zero de cada variável que o usará
            while (ValueNote2 != 0)                                                                          // Enquanto o valor inteiro de dinheiro for diferente de zero
            {
                CentQuant = ValueNote2 / cent[i];                                                            //Vou pegar a Valor inteiro de moedas e dividir pelo maior valor divísível presente na variável cent em um ciclo e atribuo esse valor para NoteQuanty
                if (CentQuant != 0)                                                                         //Se a quantidadede centavos de um tipo que estou processando no momento for diferente de zero eu vou entrar nesse "Se"
                {
                    NotesCents = NotesCents + (CentQuant + "x centavo(s) de R$ " + cent[i] + "\n");             //Vou atribuir a NotesCents os valores de NoteCents para imprimir na tela a quantidade de moedas do tipo que estou analisando
                    ValueNote2 = ValueNote2 % cent[i];                                                        //Calculo a sobra relacionando o valor do saque com relação a nota em análise
                }
                i = i + 1;                                                                                  //saio do if e vou para outra moeda
            }
            Console.WriteLine(NotesCents);                                                                  //mando imprimir na tela o valor de NotesCents
        }

    }
}
