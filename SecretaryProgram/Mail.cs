using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Collections.Generic;

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

        public String NameAndDate()
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

        public Letter LastLetter()
        {
            return LetterList[LetterList.Count - 1];            
        }
    }

    public class MailBox
    {
        public Dictionary<String, MailFolder> Folders;
        public MailBox()
        {
            Folders = new Dictionary<String, MailFolder>();
        }

        public void AddFolderToMailBox(String FolderName)
        {
            String ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                            "MailList.xlsx" +
                            ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

            OleDbConnection DbConnection = new OleDbConnection(ConnectionString);
            OleDbCommand DbCommand = new OleDbCommand("Select * From [" + FolderName + "$]", DbConnection);
            DbConnection.Open();

            OleDbDataAdapter DataAdapter = new OleDbDataAdapter(DbCommand);

            DataTable MailData = new DataTable();
            DataAdapter.Fill(MailData);
            Folders.Add(FolderName, new MailFolder());
            foreach (DataRow row in MailData.Rows)
            {
                Folders[FolderName].LetterList.Add(new Letter(row[0].ToString(), (DateTime)row[1], row[2].ToString(), row[3].ToString()));
            }
        }
    }
}
