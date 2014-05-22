using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;

namespace HarlekinEngine.com.root.engine
{
    class Window: GameWindow
    {

        private static GameWindow instance;

        private Window()
        {

        }

        public static Window Instance
        {
           get
            {

               if(instance == null)
               {
                   instance = new Window();
               }

               return (Window)instance;

           }
            
        }

    }
}
