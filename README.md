Atividade de criação de projeto MVC com EF CORE + SQL Server
UNOESC - Campus Videira. CC 4ª Fase: 24/08/2023

Acadêmico: João Marcelo Zenaro


Para criar um projeto como esse através do Visual Studio 2022 será necessário:

* Abrir VS 2022, criar novo projeto do modelo: Aplicativo Web do ASP.NET Core (Model-View-Controller)
* Selecionar colocar projeto e solução no mesmo diretorio

* Adicionar Data/AppDbContext.cs com o conteúdo adequado (Definição p/ EF Core)
* Adicionar Models/AppUser.cs com o conteúdo adequado (Definição AppUser : IdentityUser)
* Adicionar Models/Psicologo.cs com o conteúdo adequado (Definição da classe Psicologo)

* Criar connection string em ./appsettings.json
* Configurar serviços do Builder em Program.cs
    * Services.AddDbContext
    * Services.AddIdentity

* Após os arquivos estarem devidamente criados, abra o powershell e execute:

```
dotnet tool install --global dotnet-ef
dotnet-ef migrations add InitialCreate
dotnet-ef database update
```

> Obs: Se necessario, reinicie o console.