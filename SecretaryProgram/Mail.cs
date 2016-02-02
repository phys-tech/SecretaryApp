using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretaryProgram
{
    public class Letter
    {
        public String Sender;
        public DateTime Date;
        public String Theme;
        public String Text;
        public Letter()
        {
        }
        public Letter(String _sender, DateTime _date, String _theme, String _text)
        {
            Sender = _sender;
            Date = _date;
            Theme = _theme;
            Text = _text;
        }

        String NameAndDate()
        {
            String result = Sender;
            result += ", ";
            result += Date.ToShortDateString();
            return result;
        }
    }

    public class MailFolder
    {
        public List<Letter> LetterList;
        public MailFolder()
        {
            LetterList = new List<Letter>();
        }
    }
}
