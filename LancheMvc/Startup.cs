namespace LancheMvc;
public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    //Método ConfigureServices, configura os serviços do aplicativo
    public void ConfigureServices(IServiceCollection services)
    {
        //Por hora apenas os /controladores de Views, AddControllersWithViews/ está sendo usado
        services.AddControllersWithViews();
    }

    //Método Configure, configura o pipeline de processamento do aplicativo
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        //Verificando SE o ambiente é um ambiente de desenvolvimento
        if (env.IsDevelopment())
        {
            //E SE estiver em um ambiente de desenvolvimento vai usar essa página de exceção que mostra erros mais detalhados.
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error"); //Página de exceção mais específica que por hora não vai ser configurada.
            app.UseHsts();
        }
        //UseHttpsRedirection habilita o pipeline para o redirecionamento do Https.
        app.UseHttpsRedirection();
        //UseStaticFiles, para usar os arquivos statics que estão na pasta wwwroot, pasta css, js, etc.
        app.UseStaticFiles();
        //UseRouting, Pipeline de roteamento que permite definir o mapeamento/são os UseEndpoints.
        app.UseRouting();
        //UseAuthorization, habilita a autorização na aplicação.
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(//Definição do mapeamento padrão
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}