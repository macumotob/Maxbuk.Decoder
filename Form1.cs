using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maxbuk.Decoder
{
  enum MaxbukEncodingMode
  {
    Original,
    Convert
  }
  public partial class Form1 : Form
  {
    string _currentFileName = @"E:\Books\001\0000.txt";
    string _currentFolder ;//= @"E:\Books\002\";

    MaxbukEncodingMode _encodingMode = MaxbukEncodingMode.Original;

    public Form1()
    {
      InitializeComponent();
      _textConverted.KeyPress += _textConverted_KeyPress;
      _createListColumns();

      _loadEncodings();
      _load_files();
    }

    private void _textConverted_KeyPress(object sender, KeyPressEventArgs e)
    {
      
    }

    protected override bool IsInputChar(char charCode)
    {
      return true;
    }
    protected override bool IsInputKey(Keys keyData)
    {
      return true;
    }
    Encoding _selectedEncoding1;
    private Encoding _selectedCodePage
    {
      get
      {
        return _selectedEncoding1;
      }
      set
      {
        _selectedEncoding1 = value;
        _labelEncoding.Text = string.Format("Source codepage {0}",_selectedEncoding1.BodyName);
      }
    }

    Encoding _targetEncoding1;
    private Encoding _targetCodePage
    {
      get
      {
        return _targetEncoding1;
      }
      set
      {
        _targetEncoding1 = value;
        _labelTargetEncoding.Text = string.Format("Target codepage {0}",_targetEncoding1.BodyName);
      }
    }

    private void _createListColumns()
    {
      _listEncodings.View = View.Details;
      _listEncodings.Columns.Add("BodyName", 120, HorizontalAlignment.Left);
      _listEncodings.Columns.Add("CodePage", 40, HorizontalAlignment.Left);
      _listEncodings.Columns.Add("EncodingName", 120, HorizontalAlignment.Left);


      _listViewFiles.View = View.Details;
      _listViewFiles.Columns.Add("FileName", 120, HorizontalAlignment.Left);

      _listEncodings.Click += _listEncodings_Click;
      _listViewFiles.Click += _listViewFiles_Click;
    }

    ListViewItem _selectedFileItem;
    void _listViewFiles_Click(object sender, EventArgs e)
    {
      if (_listViewFiles.SelectedItems != null && _listViewFiles.SelectedItems.Count == 1)
      {
        _selectedFileItem = _listViewFiles.SelectedItems[0];
        string name = _selectedFileItem.Text;
        _currentFileName = _currentFolder + name;
        _textNewFileName.Text = _generateNewFileName();

        _tabControl.SelectedIndex = 0;
        _loadFileWithEncoding(_selectedCodePage);
        _convertFileContent();
      }
    }

    void _listEncodings_Click(object sender, EventArgs e)
    {
      _labelFileName.Text = _currentFileName;
      if (_listEncodings.SelectedItems != null && _listEncodings.SelectedItems.Count == 1)
      {
        if (_encodingMode == MaxbukEncodingMode.Original)
        {
          _selectedCodePage = (Encoding)_listEncodings.SelectedItems[0].Tag;
          _labelEncoding.Text = _selectedCodePage.EncodingName;
          _loadFileWithEncoding(_selectedCodePage);
        }
        else
        {
          _targetCodePage = (Encoding)_listEncodings.SelectedItems[0].Tag;
        }
        _convertFileContent();
      }
    }
    //private void _loadDefaultFile()
    //{
    //  if (System.IO.File.Exists(_currentFileName))
    //  {
    //    _labelFileName.Text = _currentFileName;
    //    this.Cursor = Cursors.WaitCursor;
    //    _textFileContent.SuspendLayout();
    //    _textFileContent.Text = System.IO.File.ReadAllText(_currentFileName);
    //    _textFileContent.ResumeLayout();
    //    this.Cursor = Cursors.Default;
    //  }
    //}
    private void _loadFileWithEncoding(Encoding encoding)
    {
      if (System.IO.File.Exists(_currentFileName))
      {
        if (encoding == null)
        {
          MessageBox.Show(this, "select encoding", "Info", MessageBoxButtons.OK);
          return;
        }
        _labelFileName.Text = _currentFileName;
        this.Cursor = Cursors.WaitCursor;
        _textFileContent.SuspendLayout();
        _textFileContent.Text = System.IO.File.ReadAllText(_currentFileName, encoding);
        _textFileContent.ResumeLayout();
        this.Cursor = Cursors.Default;
      }
    }

    private void _loadEncodings()
    {
      _targetCodePage = 
      _selectedCodePage = Encoding.GetEncoding("utf-8");
      
      _listEncodings.Items.Clear();
      foreach (EncodingInfo ei in Encoding.GetEncodings())
      {
        Encoding e = ei.GetEncoding();
        ListViewItem item = _listEncodings.Items.Add(e.BodyName);
        item.Tag = e;
        item.SubItems.Add(e.CodePage.ToString());
        item.SubItems.Add(e.EncodingName);
      }
      _listEncodings.Select();
    }
    private void _convertFileContent()
    {
      this.Cursor = Cursors.WaitCursor;
      byte[] bytes = _selectedCodePage.GetBytes(_textFileContent.Text);
      byte[] targetBytes = Encoding.Convert(_selectedCodePage, _targetCodePage, bytes);
      _textConverted.Text = _targetCodePage.GetString(targetBytes);
      this.Cursor = Cursors.Default;
    }

    private void _tabControl_SelectedIndexChanged(object sender, EventArgs e)
    {
      _encodingMode = (_tabControl.SelectedIndex == 0 ? MaxbukEncodingMode.Original : MaxbukEncodingMode.Convert);
    }

    private string _generateNewFileName()
    {
      string name = System.IO.Path.GetFileName(_currentFileName);
      string folder = System.IO.Path.GetDirectoryName(_currentFileName);

      label_next_name:

      //name = "_" + name;
      string newFileName = folder + name;
      if(System.IO.File.Exists(newFileName))
      {
        goto label_next_name;
      }
      name = name.Replace('\r', '_');
      name = name.Replace('\n', '_');
      return name;
    }
    private void _buttonSave_Click(object sender, EventArgs e)
    {
      if(string.IsNullOrEmpty(_textNewFileName.Text))
      {
        //
        _textNewFileName.Text = _generateNewFileName();
      }

      string name = _textNewFileName.Text;
      name = name.Replace('\r', '_');
      name = name.Replace('\n', '_');
      //name = name.Replace(' ', '_');
      _textNewFileName.Text = name;
      name = System.IO.Path.GetDirectoryName(_currentFileName) + "/" + name;
      try
      {
        
        if (_textConverted.Text.IndexOf("encoding=\"windows-1251\"") != -1)
        { // encoding="windows-1251"
          _textConverted.Text = _textConverted.Text.Replace("encoding=\"windows-1251\"", "encoding=\"utf-8\"");
        }
        if (_textConverted.Text.IndexOf("encoding=\"windows-1252\"") != -1)
        { // encoding="windows-1251"
          _textConverted.Text = _textConverted.Text.Replace("encoding=\"windows-1252\"", "encoding=\"utf-8\"");
        }
        //_textConverted.Text = _textConverted.Text.Replace("ï¿½", "?");
        //ï¿½
        System.IO.File.WriteAllText(name, _textConverted.Text, _targetCodePage);
        MessageBox.Show(this, "saved as " + name, "Info", MessageBoxButtons.OK);
      }
      catch(Exception ex)
      {
        MessageBox.Show(this, "Error saved as " + name + "\nCheck file name.", "Info", MessageBoxButtons.OK);
      }
    }

    private void _load_files()
    {
      if(_currentFolder == null)
      {
        MessageBox.Show(this, "Select folder with txt files to convert.", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }
      string folder = _currentFolder;
      _listViewFiles.Items.Clear();
      string[] files = System.IO.Directory.GetFiles(folder);//, "*.txt");
      foreach(var f in files)
      {
        string name = System.IO.Path.GetFileName(f);
        _listViewFiles.Items.Add(name);
      }
    }

    private void _buttonDelete_Click(object sender, EventArgs e)
    {
      if (System.IO.File.Exists(_currentFileName) && _selectedFileItem != null)
      {
        if (MessageBox.Show(this, "Delete file " + _currentFileName, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
        {
          System.IO.File.Delete(_currentFileName);
          _listViewFiles.Items.Remove(_selectedFileItem);
          _selectedFileItem = null;
          _listViewFiles.Select();
        }
      }
    }

    private void _buttonRefresh_Click(object sender, EventArgs e)
    {
      _load_files();
    }

    private void _buttonSelectFolder_Click(object sender, EventArgs e)
    {
      OpenFileDialog dlg = new OpenFileDialog();
    //  dlg.InitialDirectory = "c:\\";
      dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
      //dlg.Filter = "txt files (*.txt)|*.txt";
      dlg.FilterIndex = 2;
      dlg.RestoreDirectory = true;

      if (dlg.ShowDialog() == DialogResult.OK)
      {
        try
        {
          string name = dlg.FileName;
          _currentFolder = System.IO.Path.GetDirectoryName(name) + "\\";
          _load_files();
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
        }
      }
    }

    private void _buttonFormat_Click(object sender, EventArgs e)
    {
      TextFormater formater = new TextFormater();
      _textConverted.Text = formater.FormatText(_textConverted.Text);
    }
  }//
}
