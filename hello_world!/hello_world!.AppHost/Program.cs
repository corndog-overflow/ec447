var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.hello_world__ApiService>("apiservice");

builder.AddProject<Projects.hello_world__Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
