namespace Registro_Estudante;
class Program
{
	// Aluno: Luiz Felipe Cola de Moraes
	
	static void Main()
	{
		Estudante estudante1 = new Estudante("Luiz Gustavo", new DateTime(2004, 5, 24), "2023954", "Libras");
		Estudante estudante2 = new Estudante("Tais", new DateTime(2005, 6, 22), "2023827", "Medicina");

		estudante1.AdicionarNota(10.0);
		estudante1.AdicionarNota(6.0);
		estudante2.AdicionarNota(8.5);
		estudante2.AdicionarNota(9.0);
		estudante2.AdicionarNota(7.5);

		estudante1.ImprimirInformacoes();
		estudante2.ImprimirInformacoes();
	}
}