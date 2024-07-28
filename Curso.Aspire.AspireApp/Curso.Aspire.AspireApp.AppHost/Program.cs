var builder = DistributedApplication.CreateBuilder(args);

var cacheRedis = builder.AddRedisContainer("rediscache");


var api = builder.AddProject<Projects.Curso_Aspire_Api>("curso-aspire-api");
builder.AddProject<Projects.Curso_Aspire_Web>("curso-aspire-web")
    .WithReference(api)
       .WithReference(cacheRedis); ;


builder.Build().Run();
