namespace Maxbuk.Decoder
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this._buttonFormat = new System.Windows.Forms.Button();
      this._buttonSelectFolder = new System.Windows.Forms.Button();
      this._buttonRefresh = new System.Windows.Forms.Button();
      this._buttonDelete = new System.Windows.Forms.Button();
      this._labelTargetEncoding = new System.Windows.Forms.Label();
      this._labelFileName = new System.Windows.Forms.Label();
      this.splitContainer2 = new System.Windows.Forms.SplitContainer();
      this._listViewFiles = new System.Windows.Forms.ListView();
      this._tabControl = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this._textFileContent = new System.Windows.Forms.TextBox();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this._labelNewFileName = new System.Windows.Forms.Label();
      this._buttonSave = new System.Windows.Forms.Button();
      this._textNewFileName = new System.Windows.Forms.TextBox();
      this._textConverted = new System.Windows.Forms.TextBox();
      this._labelEncoding = new System.Windows.Forms.Label();
      this._listEncodings = new System.Windows.Forms.ListView();
      this.bntKoi8r = new System.Windows.Forms.Button();
      this.btnUtf8 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      this._tabControl.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this._buttonFormat);
      this.splitContainer1.Panel1.Controls.Add(this._buttonSelectFolder);
      this.splitContainer1.Panel1.Controls.Add(this._buttonRefresh);
      this.splitContainer1.Panel1.Controls.Add(this._buttonDelete);
      this.splitContainer1.Panel1.Controls.Add(this._labelTargetEncoding);
      this.splitContainer1.Panel1.Controls.Add(this._labelFileName);
      this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
      this.splitContainer1.Panel1.Controls.Add(this._labelEncoding);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.btnUtf8);
      this.splitContainer1.Panel2.Controls.Add(this.bntKoi8r);
      this.splitContainer1.Panel2.Controls.Add(this._listEncodings);
      this.splitContainer1.Size = new System.Drawing.Size(1023, 488);
      this.splitContainer1.SplitterDistance = 658;
      this.splitContainer1.TabIndex = 0;
      // 
      // _buttonFormat
      // 
      this._buttonFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this._buttonFormat.Location = new System.Drawing.Point(359, 31);
      this._buttonFormat.Name = "_buttonFormat";
      this._buttonFormat.Size = new System.Drawing.Size(92, 23);
      this._buttonFormat.TabIndex = 8;
      this._buttonFormat.Text = "Format";
      this._buttonFormat.UseVisualStyleBackColor = true;
      this._buttonFormat.Click += new System.EventHandler(this._buttonFormat_Click);
      // 
      // _buttonSelectFolder
      // 
      this._buttonSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this._buttonSelectFolder.Location = new System.Drawing.Point(555, 4);
      this._buttonSelectFolder.Name = "_buttonSelectFolder";
      this._buttonSelectFolder.Size = new System.Drawing.Size(92, 23);
      this._buttonSelectFolder.TabIndex = 7;
      this._buttonSelectFolder.Text = "Select Folder";
      this._buttonSelectFolder.UseVisualStyleBackColor = true;
      this._buttonSelectFolder.Click += new System.EventHandler(this._buttonSelectFolder_Click);
      // 
      // _buttonRefresh
      // 
      this._buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this._buttonRefresh.Location = new System.Drawing.Point(457, 31);
      this._buttonRefresh.Name = "_buttonRefresh";
      this._buttonRefresh.Size = new System.Drawing.Size(92, 23);
      this._buttonRefresh.TabIndex = 6;
      this._buttonRefresh.Text = "Refresh Files";
      this._buttonRefresh.UseVisualStyleBackColor = true;
      this._buttonRefresh.Click += new System.EventHandler(this._buttonRefresh_Click);
      // 
      // _buttonDelete
      // 
      this._buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this._buttonDelete.Location = new System.Drawing.Point(555, 31);
      this._buttonDelete.Name = "_buttonDelete";
      this._buttonDelete.Size = new System.Drawing.Size(92, 23);
      this._buttonDelete.TabIndex = 5;
      this._buttonDelete.Text = "Delete Original";
      this._buttonDelete.UseVisualStyleBackColor = true;
      this._buttonDelete.Click += new System.EventHandler(this._buttonDelete_Click);
      // 
      // _labelTargetEncoding
      // 
      this._labelTargetEncoding.AutoSize = true;
      this._labelTargetEncoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._labelTargetEncoding.Location = new System.Drawing.Point(330, 9);
      this._labelTargetEncoding.Name = "_labelTargetEncoding";
      this._labelTargetEncoding.Size = new System.Drawing.Size(19, 13);
      this._labelTargetEncoding.TabIndex = 4;
      this._labelTargetEncoding.Text = "...";
      // 
      // _labelFileName
      // 
      this._labelFileName.AutoSize = true;
      this._labelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._labelFileName.Location = new System.Drawing.Point(12, 31);
      this._labelFileName.Name = "_labelFileName";
      this._labelFileName.Size = new System.Drawing.Size(19, 13);
      this._labelFileName.TabIndex = 2;
      this._labelFileName.Text = "...";
      // 
      // splitContainer2
      // 
      this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.splitContainer2.Location = new System.Drawing.Point(3, 60);
      this.splitContainer2.Name = "splitContainer2";
      // 
      // splitContainer2.Panel1
      // 
      this.splitContainer2.Panel1.Controls.Add(this._listViewFiles);
      // 
      // splitContainer2.Panel2
      // 
      this.splitContainer2.Panel2.Controls.Add(this._tabControl);
      this.splitContainer2.Size = new System.Drawing.Size(652, 425);
      this.splitContainer2.SplitterDistance = 141;
      this.splitContainer2.TabIndex = 1;
      // 
      // _listViewFiles
      // 
      this._listViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
      this._listViewFiles.FullRowSelect = true;
      this._listViewFiles.GridLines = true;
      this._listViewFiles.HideSelection = false;
      this._listViewFiles.Location = new System.Drawing.Point(0, 0);
      this._listViewFiles.Name = "_listViewFiles";
      this._listViewFiles.Size = new System.Drawing.Size(141, 425);
      this._listViewFiles.TabIndex = 0;
      this._listViewFiles.UseCompatibleStateImageBehavior = false;
      // 
      // _tabControl
      // 
      this._tabControl.Controls.Add(this.tabPage1);
      this._tabControl.Controls.Add(this.tabPage2);
      this._tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this._tabControl.Location = new System.Drawing.Point(0, 0);
      this._tabControl.Name = "_tabControl";
      this._tabControl.SelectedIndex = 0;
      this._tabControl.Size = new System.Drawing.Size(507, 425);
      this._tabControl.TabIndex = 1;
      this._tabControl.SelectedIndexChanged += new System.EventHandler(this._tabControl_SelectedIndexChanged);
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this._textFileContent);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(499, 399);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Original";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // _textFileContent
      // 
      this._textFileContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this._textFileContent.Dock = System.Windows.Forms.DockStyle.Fill;
      this._textFileContent.Location = new System.Drawing.Point(3, 3);
      this._textFileContent.Multiline = true;
      this._textFileContent.Name = "_textFileContent";
      this._textFileContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this._textFileContent.Size = new System.Drawing.Size(493, 393);
      this._textFileContent.TabIndex = 1;
      this._textFileContent.WordWrap = false;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this._labelNewFileName);
      this.tabPage2.Controls.Add(this._buttonSave);
      this.tabPage2.Controls.Add(this._textNewFileName);
      this.tabPage2.Controls.Add(this._textConverted);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(499, 399);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Converted";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // _labelNewFileName
      // 
      this._labelNewFileName.AutoSize = true;
      this._labelNewFileName.Location = new System.Drawing.Point(6, 12);
      this._labelNewFileName.Name = "_labelNewFileName";
      this._labelNewFileName.Size = new System.Drawing.Size(79, 13);
      this._labelNewFileName.TabIndex = 4;
      this._labelNewFileName.Text = "New File Name";
      // 
      // _buttonSave
      // 
      this._buttonSave.Location = new System.Drawing.Point(435, 6);
      this._buttonSave.Name = "_buttonSave";
      this._buttonSave.Size = new System.Drawing.Size(55, 26);
      this._buttonSave.TabIndex = 3;
      this._buttonSave.Text = "Save";
      this._buttonSave.UseVisualStyleBackColor = true;
      this._buttonSave.Click += new System.EventHandler(this._buttonSave_Click);
      // 
      // _textNewFileName
      // 
      this._textNewFileName.Location = new System.Drawing.Point(86, 9);
      this._textNewFileName.Name = "_textNewFileName";
      this._textNewFileName.Size = new System.Drawing.Size(343, 20);
      this._textNewFileName.TabIndex = 2;
      // 
      // _textConverted
      // 
      this._textConverted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this._textConverted.Location = new System.Drawing.Point(6, 38);
      this._textConverted.MaxLength = 0;
      this._textConverted.Multiline = true;
      this._textConverted.Name = "_textConverted";
      this._textConverted.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this._textConverted.Size = new System.Drawing.Size(487, 355);
      this._textConverted.TabIndex = 0;
      this._textConverted.WordWrap = false;
      // 
      // _labelEncoding
      // 
      this._labelEncoding.AutoSize = true;
      this._labelEncoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._labelEncoding.Location = new System.Drawing.Point(12, 9);
      this._labelEncoding.Name = "_labelEncoding";
      this._labelEncoding.Size = new System.Drawing.Size(19, 13);
      this._labelEncoding.TabIndex = 0;
      this._labelEncoding.Text = "...";
      // 
      // _listEncodings
      // 
      this._listEncodings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this._listEncodings.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this._listEncodings.FullRowSelect = true;
      this._listEncodings.GridLines = true;
      this._listEncodings.HideSelection = false;
      this._listEncodings.Location = new System.Drawing.Point(0, 44);
      this._listEncodings.Name = "_listEncodings";
      this._listEncodings.Size = new System.Drawing.Size(361, 444);
      this._listEncodings.TabIndex = 0;
      this._listEncodings.UseCompatibleStateImageBehavior = false;
      // 
      // bntKoi8r
      // 
      this.bntKoi8r.Location = new System.Drawing.Point(14, 9);
      this.bntKoi8r.Name = "bntKoi8r";
      this.bntKoi8r.Size = new System.Drawing.Size(90, 29);
      this.bntKoi8r.TabIndex = 1;
      this.bntKoi8r.Text = "KOI8-R";
      this.bntKoi8r.UseVisualStyleBackColor = true;
      this.bntKoi8r.Click += new System.EventHandler(this.bntKoi8r_Click);
      // 
      // btnUtf8
      // 
      this.btnUtf8.Location = new System.Drawing.Point(119, 9);
      this.btnUtf8.Name = "btnUtf8";
      this.btnUtf8.Size = new System.Drawing.Size(90, 29);
      this.btnUtf8.TabIndex = 2;
      this.btnUtf8.Text = "UTF-8";
      this.btnUtf8.UseVisualStyleBackColor = true;
      this.btnUtf8.Click += new System.EventHandler(this.btnUtf8_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1023, 488);
      this.Controls.Add(this.splitContainer1);
      this.DoubleBuffered = true;
      this.KeyPreview = true;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Maxbuk Text File Decoder";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
      this.splitContainer2.ResumeLayout(false);
      this._tabControl.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.ListView _listEncodings;
    private System.Windows.Forms.Label _labelEncoding;
    private System.Windows.Forms.SplitContainer splitContainer2;
    private System.Windows.Forms.Label _labelFileName;
    private System.Windows.Forms.TabControl _tabControl;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TextBox _textFileContent;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TextBox _textConverted;
    private System.Windows.Forms.Button _buttonSave;
    private System.Windows.Forms.TextBox _textNewFileName;
    private System.Windows.Forms.ListView _listViewFiles;
    private System.Windows.Forms.Label _labelTargetEncoding;
    private System.Windows.Forms.Button _buttonDelete;
    private System.Windows.Forms.Button _buttonRefresh;
    private System.Windows.Forms.Button _buttonSelectFolder;
    private System.Windows.Forms.Label _labelNewFileName;
    private System.Windows.Forms.Button _buttonFormat;
    private System.Windows.Forms.Button bntKoi8r;
    private System.Windows.Forms.Button btnUtf8;
  }
}

