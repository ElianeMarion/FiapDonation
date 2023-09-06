namespace FiapDonationSystem
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string nome, telefone, email, senha, apelido;
			Console.WriteLine("FIAP Donation System!");
			//char letra = 'e';

			//Criar um menu
			Console.WriteLine("\n 1 - Registrar um novo usuário\n 2 - Logar\n 3 - Sair\n Digite a opção desejada: ");
			int opcao = Convert.ToInt32(Console.ReadLine());

			
				Console.WriteLine("Digite seu nome: ");
				nome = Console.ReadLine();
				Console.WriteLine("Digite seu telefone: ");
				telefone = Console.ReadLine();
				Console.WriteLine("Digite seu email: ");
				email = Console.ReadLine();
				Console.WriteLine("Digite sua senha: ");
				senha = Console.ReadLine();
				Console.WriteLine("Digite seu apelido: ");
				apelido = Console.ReadLine();
		



		}
	}
}