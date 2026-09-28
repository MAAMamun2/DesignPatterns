using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Document
    {
        private StringBuilder _text = new StringBuilder();

        public void Insert(int possition, string text)
        {
            _text.Insert(possition, text);
        }
        public void Delete(int possition, int length)
        {
            _text.Remove(possition, length);
        }
        public string GetText(int possition,int length)
        {
            return _text.ToString().Substring(possition,Math.Min(length,_text.Length - possition));
        }
        public override string ToString()
        {
            return _text.ToString();
        }
    }
}
