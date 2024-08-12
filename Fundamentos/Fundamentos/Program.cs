using Fundamentos.Common.Models;

List<string> listaString = new List<string>();

listaString.Add("São Paulo");
listaString.Add("Rio de Janeiro");
listaString.Add("Minas Gerais");


for(int contador = 0; contador <listaString.Count; contador++){
    Console.WriteLine($"Posição {contador} - {listaString[contador]}");
}

int contador = 0;
foreach(string item in listaString){
    Console.WriteLine($"Posição {contador} - {item}");
    contador++;
}
// int[] arrayInteiros = new int[3]; // Limitado pelo tamanho ser definido

// arrayInteiros[0] = 28;
// arrayInteiros[1] = 32;
// arrayInteiros[2] = 15;

// Array.Resize(ref arrayInteiros, arrayInteiros.Length*2); //dobrando a capacidade do array com a classe Array

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length*2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length)

// //o array.resize faz uma cópia do array original, colocando os itens correspondentes que já existem.

// for(int contador =0 ; contador < arrayInteiros.Length; contador++){
//     Console.WriteLine($"Posição {contador} - {arrayInteiros[contador]}");
// }

// int contador = 0;
// foreach(int valor in arrayInteiros){
//     Console.WriteLine($"Posição {contador} - {valor}");
//     contador++;
// }

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Rubens";
// pessoa1.Idade = 25;
// pessoa1.Apresentar();


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