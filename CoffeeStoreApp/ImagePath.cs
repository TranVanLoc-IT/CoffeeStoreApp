using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeStoreApp
{
    class ImagePath
    {
        public string _folder { get; set; }
        public List<string> _imageFullPath { get; set; }

        public List<string> collectAllImagePath()
        {
            var getAllFiles = Directory.GetFiles(this._folder);
            this._imageFullPath = new List<string>(getAllFiles.Count());
            foreach (var image in getAllFiles)
            {
                this._imageFullPath.Add(Path.GetFileName(image));
            }
            return this._imageFullPath;
        }
    }
}
