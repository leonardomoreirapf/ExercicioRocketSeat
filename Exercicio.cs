using System.Text.RegularExpressions;

namespace Exercicios;

public static class Exercicio
{
	public enum OpcoesMenu
	{
		Exercicio1 = 1, Exercicio2, Exercicio3, Exercicio4, Exercicio5, Exercicio6, Sair
	}
	public static int IniciarMenu()
	{
		Console.WriteLine("------- MENU --------\n");
		Console.WriteLine("1 - Exercicio 1");
		Console.WriteLine("2 - Exercicio 2");
		Console.WriteLine("3 - Exercicio 3");
		Console.WriteLine("4 - Exercicio 4");
		Console.WriteLine("5 - Exercicio 5");
		Console.WriteLine("6 - Exercicio 6");
		Console.WriteLine("7 - Sair \n\n");
		Console.WriteLine("Digite o código da opção desejada: \n");

		int.TryParse(Console.ReadLine(), out int opcao);

		return opcao;
	}
	//1 - Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida:  Olá, Welisson! Seja muito bem-vindo!
	public static void Exercicio1()
	{
		Console.WriteLine("------- Exercicio 1 --------\n");
		Console.WriteLine("Por favor digite o seu nome: \n");
		var nome = Console.ReadLine();
		Console.WriteLine($"\n\nOlá, {nome}! Seja muito bem-vindo! \n\n");
		Console.WriteLine("Precione ENTER para voltar ao Menu Inicial!");
	}

	//Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo
	public static void Exercicio2()
	{
		Console.WriteLine("------- Exercicio 2 --------\n");
		Console.WriteLine("Por favor digite o seu nome: \n");
		var nome = Console.ReadLine();
		Console.WriteLine("\n\nPor favor digite o seu sobrenome: \n");
		var sobrenome = Console.ReadLine();
		Console.WriteLine($"\n\nNome Completo: {nome} {sobrenome} \n\n");
		Console.WriteLine("Precione ENTER para voltar ao Menu Inicial!");
	}

	/*
	  3 -  Crie um programa com 2 valores do tipo**`double`** já declarados ****que retorne:
		   - A soma entre esses dois números;
		   - A subtração entre os dois números;
		   - A multiplicação entre os dois números;
		   - A divisão entre os dois números(vale uma verificação se o segundo número é 0!);
		   - A média entre os dois números. 
	*/
	public static void Exercicio3()
	{
		Console.WriteLine("------- Exercicio 3 --------\n");
		Console.WriteLine("Digite o valor do primero numero (double): \n");
		var numero1 = Console.ReadLine();
		Console.WriteLine("\n\nDigite o valor do segundo numero (double): \n");
		var numero2 = Console.ReadLine();

		if (string.IsNullOrEmpty(numero1))
		{
			Console.WriteLine($"E necessário digitar um valor para o numero 1!\n\n");
			Console.WriteLine("Precione ENTER para voltar ao Menu Inicial!");
			return;
		}

		if (string.IsNullOrEmpty(numero2))
		{
			Console.WriteLine($"E necessário digitar um valor para o numero 2!\n\n");
			Console.WriteLine("Precione ENTER para voltar ao Menu Inicial!");
			return;
		}

		if (!double.TryParse(numero1.Replace('.',','), out double double1))
		{
			Console.WriteLine($"O numero {numero1} digitado não é um DOUBLE!\n\n");
			Console.WriteLine("Precione ENTER para voltar ao Menu Inicial!");
			return;
		}

		if (!double.TryParse(numero2.Replace('.', ','), out double double2))
		{
			Console.WriteLine($"O numero {numero2} digitado não é um DOUBLE!\n\n");
			Console.WriteLine("Precione ENTER para voltar ao Menu Inicial!");
			return;
		}

		if (double2.Equals(0))
		{
			Console.WriteLine($"O segundo numero digitado não pode ser 0!\n\n");
			Console.WriteLine("Precione ENTER para voltar ao Menu Inicial!");
			return;
		}

		Console.WriteLine($"\nSOMA: {double1} + {double2} = {double1 + double2}");
		Console.WriteLine($"\nSUBTRAÇÃO: {double1} - {double2} = {double1 - double2}");
		Console.WriteLine($"\nMULTIPLICAÇÃO: {double1} * {double2} = {double1 * double2}");
		Console.WriteLine($"\nDIVISÃO: {double1} / {double2} = {double1 / double2}");
		Console.WriteLine($"\nMÉDIA: ({double1} + {double2})/2 = {(double1 + double2)/2}\n\n");
		Console.WriteLine("Precione ENTER para voltar ao Menu Inicial!");
	}

	//Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.
	public static void Exercicio4()
	{
		Console.WriteLine("------- Exercicio 4 --------\n");
		Console.WriteLine("Digite uma palavra ou frase: \n");
		var nome = Console.ReadLine();
		Console.WriteLine($"\n\nQuantidade de caracteres = {nome.Trim().Replace(" ", "").Count()} \n\n");
		Console.WriteLine("Precione ENTER para voltar ao Menu Inicial!");
	}

	/*
	 Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
    - A placa deve ter 7 caracteres alfanuméricos;
    - Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
    - Os quatro últimos caracteres são números;
    
    Ao final, o programa deve exibir ***Verdadeiro*** se a placa for válida e ***Falso*** caso contrário.
	 */
	public static void Exercicio5()
	{
		Console.WriteLine("------- Exercicio 5 --------\n");
		Console.WriteLine("Digite uma placa de um veiculo: \n");
		var placa = Console.ReadLine();
		var regex = new Regex(@"^[a-zA-Z]{3}\d{4}$");
		Console.WriteLine($"\n\nO modelo digitado é: {(regex.IsMatch(placa) ? "Válido (VERDADEIRO)" : "Inválido (FALSO)")} \n\n");
		Console.WriteLine("Precione ENTER para voltar ao Menu Inicial!");
	}

	/*
	 1. Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
    - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
    - Apenas a data no formato "01/03/2024".
    - Apenas a hora no formato de 24 horas.
    - A data com o mês por extenso.
	 */
	public static void Exercicio6()
	{
		Console.WriteLine("------- Exercicio 6 --------\n");
		Console.WriteLine("Data atual em difirentes formatos: \n\n");
		var dataAtual = DateTime.Now;
		Console.WriteLine($"Formato Completo: {dataAtual.ToString("dddd, dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.GetCultureInfo("pt-BR"))}");
		Console.WriteLine($"Apenas a data (dia/mês/ano): {dataAtual.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.GetCultureInfo("pt-BR"))}");
		Console.WriteLine($"Apenas a hora (24 horas): {dataAtual.ToString("HH:mm:ss", System.Globalization.CultureInfo.GetCultureInfo("pt-BR"))}");
		Console.WriteLine($"Data com o mês por extenso: {dataAtual.ToString("dd 'de' MMMM 'de' yyyy", System.Globalization.CultureInfo.GetCultureInfo("pt-BR"))}\n\n");
		Console.WriteLine("Precione ENTER para voltar ao Menu Inicial!");
	}
}
