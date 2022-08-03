namespace LancheMvc;
public class Program
{
    //O método Main configura o ASP.NET Core e inicia a aplicação.
    public static void Main(string[] args)
    {
        //Método CreateHostBuilder, retorna um objeto CreateHostBuilder que implementa uma interface IHostBuilder.
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args) //Host, é usada para criar uma classe de instância IHostBuilder,
                                        //Essa configurações são pré definidas,
                                        //CreateDefaultBuilder vai configurar um Host para as configurações web padrão.
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>(); //Método UseStartup, chamando a classe Startup.
            });
}
