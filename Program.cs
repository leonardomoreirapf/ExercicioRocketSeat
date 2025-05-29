using Exercicios;

var opcao = 0;

while(opcao != (int)Exercicio.OpcoesMenu.Sair)
{
	opcao = Exercicio.IniciarMenu();
	Console.Clear();
	switch (opcao)
	{
		case (int)Exercicio.OpcoesMenu.Exercicio1:
			Exercicio.Exercicio1();
			Console.ReadKey();
			Console.Clear();
			break;
		case (int)Exercicio.OpcoesMenu.Exercicio2:
			Exercicio.Exercicio2();
			Console.ReadKey();
			Console.Clear();
			break;
		case (int)Exercicio.OpcoesMenu.Exercicio3:
			Exercicio.Exercicio3();
			Console.ReadKey();
			Console.Clear();
			break;
		case (int)Exercicio.OpcoesMenu.Exercicio4:
			Exercicio.Exercicio4();
			Console.ReadKey();
			Console.Clear();
			break;
		case (int)Exercicio.OpcoesMenu.Exercicio5:
			Exercicio.Exercicio5();
			Console.ReadKey();
			Console.Clear();
			break;
		case (int)Exercicio.OpcoesMenu.Exercicio6:
			Exercicio.Exercicio6();
			Console.ReadKey();
			Console.Clear();
			break;
		case (int)Exercicio.OpcoesMenu.Sair:
			Console.WriteLine("Obrigado por validar os Exercícios!");
			Console.ReadKey();
			Console.Clear();
			break;
		default:
			Console.WriteLine("Opção incorreta, por favor selecionar outra!");
			Console.ReadKey();
			Console.Clear();
			break;
	}

}



