using System;
using System.Collections.Generic;
using System.Text;

namespace S2Pro
{
    internal class Book
    {
        public string Title;
        public int Pages;

        public override string ToString()
        {
            return $"Title: {Title}, Pages: {Pages}";
        }
    }
}
