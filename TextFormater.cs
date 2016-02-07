using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxbuk.Decoder
{
  class TextFormater
  {
    private List<string> _words;
    private bool _isTerm(char c)
    {
      switch (c)
      {
        case '\r':
        case '\n':
        case '\t':
        case ' ':
        case '~':
        case '!':
        case '@':
        case '#':
        case '$':
        case '%':
        case '^':
        case '&':
        case '*':
        case '(':
        case ')':
        case '_':
        case '-':
        case '+':
        case '=':
        case '{':
        case '}':
        case '[':
        case ']':
        case ';':
        case ':':
        case '\"':
        case '\'':
        case '|':
        case '\\':
        case '<':
        case ',':
        case '>':
        case '.':
        case '?':
        case '/':
          return true;
        default:
          return false;
      }

    }

    public string Text
    {

      get
      {
        string s = "";
        foreach (var word in _words)
        {
          s += word;
        }
        return s;
      }
    }
    public string FormatText(string text)
    {
        this.ParseText(text);
        return null;
        int i = 0;
      while(i < _words.Count)
      {
        if(_words[i] == "-")
        {

        }
        i++;
      }
      return this.Text;
    }
    public void ParseText(string s)
    {
      string[] lines = s.Split('\n');

    }
    public void ParseText2(string s)
    {

      string word = "";

      _words = new List<string>();
      int i = 0;
      while (i < s.Length)
      {
        char c = s[i];
        if (_isTerm(c))
        {
          if (c == '\r')
          {
            i++;
            continue;
          }
          word = "" + c;
          _words.Add(word);
          i++;
          continue;
        }
        word = "";
        while (i < s.Length && !_isTerm(s[i]))
        {
          word += s[i];
          i++;
        }
        _words.Add(word);
      }
    }
  }//
}

