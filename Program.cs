// ///////////////////////////////////////////
// //Entrada, Processamento e Saída de Dados//
// ///////////////////////////////////////////

// //////////////////////// Peça ao usuário dois números e mostre a soma, subtração, multiplicação e divisão entre eles.
// Console.WriteLine("Digite o primeiro número inteiro:");
// int numero1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Digite o segundo número inteiro:");
// int numero2 = int.Parse(Console.ReadLine());

// Console.WriteLine($"A soma dos números é: {numero1 + numero2}");
// Console.WriteLine($"A subtração dos números é: {numero1 - numero2}");
// Console.WriteLine($"A multiplicação dos números é: {numero1 * numero2}");
// Console.WriteLine($"A divisão dos números é: {numero1 / numero2}");

// ////////////////////////// Número ao Quadrado e ao Cubo
// Console.WriteLine("Digite um número inteiro:");
// int numero = int.Parse(Console.ReadLine());

// Console.WriteLine($"O quadrado de {numero} é: {numero * numero}");
// Console.WriteLine($"O cubo de {numero} é: {numero * numero * numero}");

// ////////////////////////// Mensagem de Boas-Vindas
// Console.WriteLine("Digite seu nome:");
// string nome = Console.ReadLine();
// Console.WriteLine($"Bem-vindo(a), {nome}!");

// ////////////////////////// Idade daqui 10 anos
// Console.WriteLine("Digite sua idade atual:"); 
// int idade = int.Parse(Console.ReadLine());
// int idadeFutura = idade + 10;
// Console.WriteLine($"Daqui a 10 anos, você terá {idadeFutura} anos.");

// ///////////////////////////////////////////
// //       Estruturas Condicionais         //
// ///////////////////////////////////////////

// ////////////////////////// Par ou Impar
// Console.WriteLine("Digite um número inteiro:");
// int numeroParImpar = int.Parse(Console.ReadLine());
// if (numeroParImpar % 2 == 0)
// {
//     Console.WriteLine($"{numeroParImpar} é par.");
// }
// else
// {
//     Console.WriteLine($"{numeroParImpar} é ímpar.");
// }

// ////////////////////////// Maior de Dois Números ou Igual
// Console.WriteLine("Digite o primeiro número inteiro:");
// int numero1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Digite o segundo número inteiro:");
// int numero2 = int.Parse(Console.ReadLine());
// if (numero1 > numero2)
// {
//     Console.WriteLine($"{numero1} é maior que {numero2}.");
// }
// else if (numero2 > numero1)
// {
//     Console.WriteLine($"{numero2} é maior que {numero1}.");
// }
// else
// {
//     Console.WriteLine("Os números são iguais.");
// }

// ////////////////////////// Aprovado ou Reprovado
// Console.WriteLine("Digite a nota do aluno:");
// double nota = double.Parse(Console.ReadLine());
// if (nota >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else if (nota >= 5)
// {
//     Console.WriteLine("Recuperação");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }

// ////////////////////////// Classificação por Idade
// Console.WriteLine("Digite sua idade:");
// int idadePessoa = int.Parse(Console.ReadLine());
// if (idadePessoa < 18)
// {
//     Console.WriteLine("Você é menor de idade.");
// }
// else if (idadePessoa >= 18 && idadePessoa < 65)
// {
//     Console.WriteLine("Você é adulto.");
// }
// else if (idadePessoa >= 65 && idadePessoa < 120)
// {
//     Console.WriteLine("Você é idoso.");
// }
// else
// {
//     Console.WriteLine("Idade inválida.");
// }

// ////////////////////////// Positivo, Negativo ou Zero
// Console.WriteLine("Digite um número inteiro:");
// int numeroPosNeg = int.Parse(Console.ReadLine());
// if (numeroPosNeg > 0)
// {
//     Console.WriteLine($"{numeroPosNeg} é positivo.");
// }
// else if (numeroPosNeg < 0)
// {
//     Console.WriteLine($"{numeroPosNeg} é negativo.");
// }
// else
// {
//     Console.WriteLine("O número é zero.");
// }

// ///////////////////////////////////////////
// //       Estruturas  de  Repetições      //
// ///////////////////////////////////////////

// ////////////////////////// Contagem de 1 a 10
// Console.WriteLine("Contagem de 1 a 10:");
// for (int i = 1; i <=10; i++)
// {
//     Console.WriteLine(i);
// }

// ////////////////////////// Imprimir os números pares de 1 a 50
// Console.WriteLine("Números pares de 1 a 50:");

// for (int i = 1; i <= 50; i++)
// {
//     if (i % 2 == 0)
//     {
//     Console.WriteLine($"{i}");
//     }
// }

// ///////////////////////////// Tabuada de um número
// Console.WriteLine("Digite um número inteiro para ver sua tabuada:");
// int numeroTabuada = int.Parse(Console.ReadLine());

// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{numeroTabuada} x {i} = {numeroTabuada * i}");
// }

// ///////////////////////////// Leia vários números até que o usuário digite 0 e mostre a soma de todos.
// bool continuar = true;
// int soma = 0;
// while (continuar)
// {
    
//     Console.WriteLine("Digite um número inteiro (ou 0 para sair):");
//     int numero = int.Parse(Console.ReadLine());
//     soma = soma + numero;

//     if (numero == 0)
//     {
//         continuar = false;
//     }

//     Console.WriteLine($"A soma dos números digitados é: {soma}");
// }

// ///////////////////////////// Leia 5 Numeros e informe quais são positivos
// Console.WriteLine("Digite 5 números inteiros:");
// for (int i = 0; i < 5; i++)
// {
//     int numero = int.Parse(Console.ReadLine());
//     if (numero > 0)
//     {
//         Console.WriteLine($"{numero} é positivo.");
//     }
//     else if (numero < 0)
//     {
//         Console.WriteLine($"{numero} é negativo.");
//     }
//     else
//     {
//         Console.WriteLine("O número é zero.");
//     }
// }

// /////////////////////////////////////////
// // Estruturas  de  Decisões Multiplas  //
// /////////////////////////////////////////

// // Calculadora Simples
// bool continuar = true;
// while (continuar)
// {
// Console.WriteLine("Me diga um número inteiro:");	
// int numeroCalculadora = int.Parse(Console.ReadLine());

// Console.WriteLine("Me diga outro número inteiro:");
// int numeroCalculadora2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Escolha a operação que deseja realizar:");
// Console.WriteLine("1 - Soma");  
// Console.WriteLine("2 - Subtração");
// Console.WriteLine("3 - Multiplicação");
// Console.WriteLine("4 - Divisão");
// Console.WriteLine("5 - Sair");

// int opcao = int.Parse(Console.ReadLine());
// switch (opcao)
// {
//    case 1:
//         Console.WriteLine($"A soma dos números é: {numeroCalculadora + numeroCalculadora2}");
//         break; 
//     case 2:
//         Console.WriteLine($"A subtração dos números é: {numeroCalculadora - numeroCalculadora2}");
//         break;
//     case 3:
//         Console.WriteLine($"A multiplicação dos números é: {numeroCalculadora * numeroCalculadora2}");    
//         break;
//     case 4:
//         Console.WriteLine($"A divisão dos números é: {numeroCalculadora / numeroCalculadora2}");
//         break;
//     case 5:
//         Console.WriteLine("Encerrando o programa...");
//         continuar = false;
//         break;
//     default:
//         Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
//         break;
// }
// }

// // 1 a 7 Dia da Semana

// Console.WriteLine("Digite 1 a 7 para escolher o dia da semana:");
// int opcao = int.Parse(Console.ReadLine());

// switch (opcao)
// {
//     case 1:
//         Console.WriteLine("Domingo");
//         break;
//     case 2:
//         Console.WriteLine("Segunda-feira");
//         break;
//     case 3:
//         Console.WriteLine("Terça-feira");
//         break;
//     case 4:
//         Console.WriteLine("Quarta-feira");
//         break;
//     case 5:
//         Console.WriteLine("Quinta-feira");
//         break;
//     case 6:
//         Console.WriteLine("Sexta-feira");
//         break;
//     case 7:
//         Console.WriteLine("Sábado");
//         break;
//     default:
//         Console.WriteLine("Opção inválida. Por favor, escolha um número entre 1 e 7.");
//         break;
// }

// // Leia um código de produto e informe a categoria (ex: 1–Alimento, 2–Bebida, 3–Limpeza).
// Console.WriteLine("Digite o código do produto (1–Enroladinho, 2–Agua, 3–Veja):");
// int codigoProduto = int.Parse(Console.ReadLine());

// switch (codigoProduto)
// {
//     case 1:
//         Console.WriteLine("Categoria: Alimento");
//         break;
//     case 2:
//         Console.WriteLine("Categoria: Bebida");
//         break;
//     case 3:
//         Console.WriteLine("Categoria: Limpeza");
//         break;
//     default:
//         Console.WriteLine("Código de produto inválido.");
//         break;
// }   

///////////////////////////////////////////
// Lógica com Acumuladores e Contadores  //
///////////////////////////////////////////

//Leia 10 números e informe: a soma, a média e o maior número.
// double soma = 0;
// double maiorNumero = 0;
// double media = 0;

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine("Digite um número:");
//     double num = double.Parse(Console.ReadLine());
//     soma += num;
//     if (num > maiorNumero)
//     {
//         maiorNumero = num;
//     }
// }

// media = soma / 10.0;

// Console.WriteLine($"A soma dos números é: {soma}");
// Console.WriteLine($"A média dos números é: {media}");
// Console.WriteLine($"O maior número é: {maiorNumero}");

// // Leia idades até que seja digitado um valor negativo e informe a média das idades.
// double somaIdades = 0;
// int contador = 0;

// Console.WriteLine("Aperte ENTER para começar o programa");
// Console.ReadLine();

// for (int i = 1; i < 10; i--)
// {
//     contador++;
//     Console.WriteLine("Digite uma idade (até ser digitado um valor negativo):");
//     double idade = double.Parse(Console.ReadLine());
//     if (idade <= 0)
//     {
//         break;
//     }
//     somaIdades += idade;
// }

// double mediaIdades = somaIdades / contador;
// Console.WriteLine($"A média das idades é: {mediaIdades}");

// // Leia vários números e informe quantos são pares e quantos são ímpares.

// for(int i = 1; i < 10; i--)
// {
//     Console.WriteLine("Digite um número inteiro (até ser digitado um valor negativo):");
//     int numeroParImpar = int.Parse(Console.ReadLine());
//     if (numeroParImpar == 0)
//     {
//         break;
//     }
//     if (numeroParImpar % 2 == 0)
//     {
//         Console.WriteLine($"{numeroParImpar} é par.");
//     }
//     else
//     {
//         Console.WriteLine($"{numeroParImpar} é ímpar.");
//     }
// }

///////////////////////////////////////////
//          Desafio de Lógica            //
///////////////////////////////////////////

//Leia um número e informe se ele é primo ou não.
Console.WriteLine("Digite um número inteiro:");
int numeroPrimo = int.Parse(Console.ReadLine());
bool ehPrimo = true;

if (numeroPrimo <= 1)
{
    ehPrimo = false;
}
else
{
    for (int i = 2; i <= Math.Sqrt(numeroPrimo); i++)
    {
        if (numeroPrimo % i == 0)
        {
            ehPrimo = false;
            break;
        }
    }
}

if (ehPrimo)
{
    Console.WriteLine($"{numeroPrimo} é um número primo.");
}
else
{
    Console.WriteLine($"{numeroPrimo} não é um número primo.");
}