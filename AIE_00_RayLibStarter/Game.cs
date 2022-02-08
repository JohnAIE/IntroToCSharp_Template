using System;
using Raylib_cs;

namespace AIE_00_RayLibStarter
{
    class Game
    {
        public int windowWidth = 500;
        public int windowHeight = 500;
        public string windowTitle = "Your Project Name";

        public void Load()
        {
            // TODO:
            // load game assets here
        }

        public void Update()
        {
            // TODO:
            // Add game update logic here - this code will run 60 times per second
        }
        
        public void Draw()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.RAYWHITE);
            
            // TODO:
            // Add game drawing logic here - this code will run 60 times per second
            // ​
            Raylib.EndDrawing();
        }
    }
}
