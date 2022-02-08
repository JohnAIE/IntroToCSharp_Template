using System;

using Raylib_cs;

namespace AIE_00_RayLibStarter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            
            Raylib.InitWindow(game.windowWidth, game.windowHeight, game.windowTitle);
            Raylib.SetTargetFPS(60);
            
            game.Load();
            
            while (!Raylib.WindowShouldClose())
            {
                game.Update();
                game.Draw();
            }
            
            Raylib.CloseWindow();
        }
    }
}