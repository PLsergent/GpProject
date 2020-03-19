# GpProject
Social network project - ASP.net application

## Commands

Generate controller
```
dotnet aspnet-codegenerator controller -name ArticlesController -m Article -dc GpProject.Data.ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -f
```

Migrate models
```
dotnet ef migrations add changeArticle1 --context GpProject.Data.ApplicationDbContext

dotnet ef database update --context GpProject.Data.ApplicationDbContext
```

Remove last migration
```
dotnet ef migrations remove --context GpProject.Data.ApplicationDbContext
```

Command used to create project
```
dotnet new mvc --auth Individual --no-https -o GpProject
```

## Links

https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-3.1&tabs=visual-studio-code

https://docs.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-3.1&tabs=netcore-cli
