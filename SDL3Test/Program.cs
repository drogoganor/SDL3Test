// See https://aka.ms/new-console-template for more information
using SDL3;

// Try using https://github.com/edwardgushchin/SDL3-CS which has examples and a nuget package?
// The version at https://github.com/flibitijibibo/SDL3-CS doesn't have much else.

// Or FNA? https://github.com/FNA-XNA/FNA


Console.WriteLine("Hello, World!");

//if (!SDL.Init(SDL.InitFlags.Video))
//{
//    SDL.LogError(SDL.LogCategory.System, $"SDL could not initialize: {SDL.GetError()}");
//    return;
//}

//if (!SDL.CreateWindowAndRenderer("SDL3 Create Window", 800, 600, 0, out var window, out var renderer))
//{
//    SDL.LogError(SDL.LogCategory.Application, $"Error creating window and rendering: {SDL.GetError()}");
//    return;
//}

//SDL.SetRenderDrawColor(renderer, 100, 149, 237, 0);

//var loop = true;

//while (loop)
//{

//    while (SDL.PollEvent(out var e))
//    {
//        if ((SDL.EventType)e.Type == SDL.EventType.Quit)
//        {
//            loop = false;
//        }
//    }

//    SDL.RenderClear(renderer);
//    SDL.RenderPresent(renderer);
//}

//SDL.DestroyRenderer(renderer);
//SDL.DestroyWindow(window);

//SDL.Quit();