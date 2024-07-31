var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.BioDiversify_ApiService>("apiservice");

builder.AddProject<Projects.BioDiversify_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
