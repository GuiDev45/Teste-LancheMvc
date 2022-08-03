namespace LancheMvc;
public class Program
{
    //O m�todo Main configura o ASP.NET Core e inicia a aplica��o.
    public static void Main(string[] args)
    {
        //M�todo CreateHostBuilder, retorna um objeto CreateHostBuilder que implementa uma interface IHostBuilder.
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args) //Host, � usada para criar uma classe de inst�ncia IHostBuilder,
                                        //Essa configura��es s�o pr� definidas,
                                        //CreateDefaultBuilder vai configurar um Host para as configura��es web padr�o.
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>(); //M�todo UseStartup, chamando a classe Startup.
            });
}
