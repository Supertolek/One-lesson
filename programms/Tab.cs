using Microsoft.UI.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.Streams;

namespace One_Lesson
{
    internal class Tab
    {
        public string Title = "new document";
        // public RichEditTextDocument Document; // try a byte[] to store a "file"
        public byte[] Data = null;
        public IRandomAccessStream Stream;
    }
}
