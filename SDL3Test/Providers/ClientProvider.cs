using SDL3;

namespace SDL3Test.Providers
{
    internal class ClientProvider
    {
        private readonly Sdl3WindowProvider windowProvider;

        public ClientProvider(Sdl3WindowProvider windowProvider)
        {
            this.windowProvider = windowProvider;
        }

        public void Run()
        {
            var renderer = windowProvider.Renderer;
            var window = windowProvider.Window;

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
        }
    }
}
