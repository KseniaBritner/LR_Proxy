using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class File : IFile
    {
        protected string _path;
        protected StreamReader _reader;
        public File(string path)
        {
            if (path == null)
            {
                throw new ArgumentNullException(nameof(path), "Путь пуст");
            }
            _path = path;
            _reader = new StreamReader(_path);
        }
        public double GetSize()
        {
            FileInfo file = new FileInfo(_path);
            return file.Length;
        }
        public string GetPath()
        {
            return _path;
        }
        public byte[] Show()
        {
            return System.IO.File.ReadAllBytes(_path);
        }
        public void Dispose()
        {
            _reader.Dispose();
        }
    }
}
