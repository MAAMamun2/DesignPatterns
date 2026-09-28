using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class InsertTextCommand : ICommand
    {
        private Document _document;
        private string _textToInsert;
        private int _possition;

        public InsertTextCommand(Document document,string text,int possition)
        {
            _document = document;
            _textToInsert = text;
            _possition = possition;
        }
        public void Execute()
        {
            _document.Insert(_possition, _textToInsert);
        }

        public void Undo()
        {
            _document.Delete(_possition, _textToInsert.Length);
        }
    }
}
