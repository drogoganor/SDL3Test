// See https://aka.ms/new-console-template for more information
using SDL3;

// Try using https://github.com/edwardgushchin/SDL3-CS which has examples and a nuget package?
// The version at https://github.com/flibitijibibo/SDL3-CS doesn't have much else.

// Or FNA? https://github.com/FNA-XNA/FNA

//Console.WriteLine("Hello, World!");

if (!SDL.SDL_Init(SDL.SDL_InitFlags.SDL_INIT_VIDEO))
{
    SDL.SDL_LogError((int)SDL.SDL_LogCategory.SDL_LOG_CATEGORY_SYSTEM, $"SDL could not initialize: {SDL.SDL_GetError()}");
    return;
}

if (!SDL.SDL_CreateWindowAndRenderer("SDL3 Create Window", 800, 600, 0, out var window, out var renderer))
{
    SDL.SDL_LogError((int)SDL.SDL_LogCategory.SDL_LOG_CATEGORY_SYSTEM, $"Error creating window and rendering: {SDL.SDL_GetError()}");
    return;
}

SDL.SDL_SetRenderDrawColor(renderer, 100, 149, 237, 0);

var loop = true;

while (loop)
{

    while (SDL.SDL_PollEvent(out var e))
    {
        if ((SDL.SDL_EventType)e.type == SDL.SDL_EventType.SDL_EVENT_QUIT)
        {
            loop = false;
        }
    }

    SDL.SDL_RenderClear(renderer);
    SDL.SDL_RenderPresent(renderer);
}

SDL.SDL_DestroyRenderer(renderer);
SDL.SDL_DestroyWindow(window);

SDL.SDL_Quit();