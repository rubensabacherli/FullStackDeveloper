using Fundamentos.Common.Models;

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Rubens";
pessoa1.Idade = 25;
pessoa1.Apresentar();


// // casting -> o Null é valor zero
// int a = Convert.ToInt32("5");
// Console.WriteLine(a);

// // casting implícito
// int teste = 5;
// double teste2 = teste;
// Console.WriteLine(teste2);


// // parse -> o Null retorna erro
// int b = int.Parse("5");
// Console.WriteLine(b);

// // tostring
// int inteiro = 5;
// string c = inteiro.ToString();
// Console.WriteLine(c);


// Calculadora calc = new Calculadora();

// Console.WriteLine("----------------------");

// calc.Somar(10, 23);
// calc.Subtrair(10, 23);
// calc.Multiplicar(10, 23);
// calc.Dividir(10, 23);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);

// Console.Clear();

// string opcao = "";
// bool exibirMenu = true;

// while (exibirMenu)
// {
//     Console.WriteLine("Escolha uma opção");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;
//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;
//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;
//         case "4":
//             Console.WriteLine("Sair");
//             exibirMenu = false;
//             break;
//         default:
//             Console.WriteLine("Inválido"); break;
//     }
// }
// Console.WriteLine("Encerrou");