using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxbukcnv
{
  class Program
  {
    static int Main(string[] args)
    {

      string sourceFolder = @"E:\Books\_txt\0001\";
      string targetFolder = @"E:\Books\_txt\0001\html\";
      converFolder(sourceFolder, targetFolder);
      return 0;

      if(args.Length == 0){
        return DisplayUsage();
      }
      return 0;
    }

    static private string _generateNewFileName(string fileName,string newExt = null)
    {
      string name = System.IO.Path.GetFileName(fileName);
      string folder = System.IO.Path.GetDirectoryName(fileName);

    label_next_name:

      name = "_" + name;
      string newFileName = folder + "\\" + name;
      if (System.IO.File.Exists(newFileName))
      {
        goto label_next_name;
      }
      name = name.Replace('\r', '_');
      name = name.Replace('\n', '_');
      if (newExt != null)
      {
        string ext = System.IO.Path.GetExtension(name);
        name = name.Replace(ext, newExt);
      }
      return folder + "\\" + name;
    }
    static private string _convertFileContent(string sourceFileName,string sourceCodePage)
    {
      Encoding sourceEncoding = Encoding.GetEncoding(sourceCodePage);
      string text = System.IO.File.ReadAllText(sourceFileName, sourceEncoding);
      return text;
      //byte[] bytes = _selectedCodePage.GetBytes(text);
      //byte[] targetBytes = Encoding.Convert(_selectedCodePage, _targetCodePage, bytes);
      //string result = _targetCodePage.GetString(targetBytes);
    }

    static List<string> _prepareText(string text)
    {
      List<string> list = new List<string>();

      string[] lines = text.Split('\n');
        int i = 0;
        while (i < lines.Length)
        {
          string s = lines[i].Replace('\r', ' ').TrimEnd();
          list.Add(s);
          i++;
        }
        return list;
    }
    static private void _write(System.IO.StreamWriter sw,string s)
    {
      int i = 0;
      sw.WriteLine("<p>");
      while (i < s.Length && (s[i] == ' ' || s[i] == '\t'))
      {
        sw.Write("&nbsp;");
        if (s[i] == '\t') sw.Write("&nbsp;&nbsp;&nbsp;");

        i++;
      }
      string p = s.Substring(i);
      sw.Write(p);
      sw.WriteLine("</p><hr/>");
    }
    static void converFolder(string sourceFolder,string targetFolder)
    {
      string [] files = System.IO.Directory.GetFiles(sourceFolder, "*.txt");
      foreach (var file in files)
      {
        string name = targetFolder +
          System.IO.Path.GetFileNameWithoutExtension(file) + ".html";
        Console.WriteLine(file);
        convertTxt2Html(file, name);
        //var b = Encoding.GetEncoding("windows-1251").GetBytes(file);
        //var s = Encoding.UTF8.GetString(b);
        
      }
    }
    static int convertTxt2Html(string txtFileName,string htmlFileName)
    {
      //string file = @"E:\Books\_txt\0001\0000.txt";
      //string newFileName = _generateNewFileName(file, ".html");
      string text = _convertFileContent(txtFileName, "windows-1251");
      List<string> list = _prepareText(text);

      string p = "";
      using (System.IO.StreamWriter sw = new System.IO.StreamWriter(htmlFileName, false, Encoding.UTF8))
      {
        string head = @"
<head>
<style>
body{
margin:0;
padding:0;
background-color: #fafafa;
}
p{
  margin:3px 10px;
  padding:0;
  font-size:2.3em;

}
hr{
background-color: #fafafa;
}
</style>
</head>
";
        sw.WriteLine("<!DOCTYPE html>");
        sw.WriteLine("<html>");
        sw.WriteLine(head);
        sw.WriteLine("<body>");
        int i = 0;

        while (i < list.Count)
        {
          string s = list[i];

          if (string.IsNullOrEmpty(s))
          {
            if (string.IsNullOrEmpty(p))
            {

            }
            else
            {
              _write(sw, p);
              p = s;
            }
          }
          else
          {
            if (s[0] == ' ')
            {
              if (string.IsNullOrEmpty(p))
              {
                p = s;
              }
              else
              {
                _write(sw, p);
                p = s;
              }
            }
            else
            {
              p += " " + s;
            }
          }
          i++;
        }
        sw.WriteLine("</body>");
        sw.WriteLine("</html>");
        sw.Close();
        sw.Dispose();
      }
      return 1;
    }

    static int DisplayUsage()
    {
      Console.WriteLine("use maxbukcnv file code_page");

      string file = @"E:\Books\_txt\0001\0000.txt";
      string newFileName = _generateNewFileName(file,".html");
      string text =_convertFileContent(file, "windows-1251");
      List<string> list = _prepareText(text);

      string p = "";
      using (System.IO.StreamWriter sw = new System.IO.StreamWriter(newFileName,false, Encoding.UTF8))
      {
        sw.WriteLine("<!DOCTYPE html>");
        sw.WriteLine("<html><head><style>p{ margin:3px 10px;padding:0;}</style></head>");
        sw.WriteLine("<body style='margin:0;padding:0;'>");
        int i = 0;

        while(i < list.Count)
        {
          string s = list[i];

          if (string.IsNullOrEmpty(s))
          {
            if(string.IsNullOrEmpty(p)){

            }
            else
            {
              _write(sw, p);
              p = s;
            }
          }
          else
          {
            if (s[0] == ' ')
            {
              if (string.IsNullOrEmpty(p))
              {
                p = s;
              }
              else
              {
                _write(sw, p);
                p = s;
              }
            }
            else
            {
              p += " " + s;
            }
          }
          i++;
        }
        sw.WriteLine("</body>");
        sw.WriteLine("</html>");
        sw.Close();
        sw.Dispose();
      }
      Console.WriteLine(newFileName);
      return 1;
    }
  }
}
