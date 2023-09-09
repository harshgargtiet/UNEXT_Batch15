## Package Manager Console
```bash
scaffold-dbcontext "Host=localhost; database=DataBaseName; username=username; password=password; "Npgsql.EntityFrameworkCore.PostgreSQL" -outputdir Models
```



## Code First Approach
```bash
# Install tool for code-first approach
dotnet tool install --global dotnet-ef

# Migrate changes to DB
dotnet-ef migrations --context ContextFileName add AnyNameForMigration

# Update db
dotnet-ef database update --context ContextFileName

```
