using SDL3;

namespace SDL3Test.Providers
{
    internal class Sdl3WindowProvider
    {
        public nint Window { get; init; }
        public nint Renderer { get; init; }

        public Sdl3WindowProvider()
        {
            if (!SDL.SDL_Init(SDL.SDL_InitFlags.SDL_INIT_VIDEO))
            {
                SDL.SDL_LogError((int)SDL.SDL_LogCategory.SDL_LOG_CATEGORY_SYSTEM, $"SDL could not initialize: {SDL.SDL_GetError()}");
                return;
            }

            if (!SDL.SDL_CreateWindowAndRenderer("SDL3Test", 1860, 980, 0, out var window, out var renderer))
            {
                SDL.SDL_LogError((int)SDL.SDL_LogCategory.SDL_LOG_CATEGORY_SYSTEM, $"Error creating window and rendering: {SDL.SDL_GetError()}");
                return;
            }

            Window = window;
            Renderer = renderer;
        }
    }
}
