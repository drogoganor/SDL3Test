using Microsoft.Extensions.DependencyInjection;
using SDL3Test;
using SDL3Test.Providers;

// Try using https://github.com/edwardgushchin/SDL3-CS which has examples and a nuget package?
// The version at https://github.com/flibitijibibo/SDL3-CS doesn't have much else.

// Or FNA? https://github.com/FNA-XNA/FNA

var services = DependencyInjection.Build();

var serviceProvider = services.BuildServiceProvider();
var client = serviceProvider.GetService<ClientProvider>();

client.Run();