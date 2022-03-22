using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Params
    {
        private string resourcesFoler;

        public Params()
        {
            // Получить индекс папки bin
            var ind = Directory.GetCurrentDirectory().ToString().IndexOf("bin", StringComparison.Ordinal);

            // Путь до указанной в индексе папки
            string binFolder = Directory.GetCurrentDirectory().ToString().Substring(0, ind).ToString();

            resourcesFoler = binFolder + "resources\\";
        }

        public string GetResourceFolder()
        {
            return resourcesFoler;
        }
    }
}
