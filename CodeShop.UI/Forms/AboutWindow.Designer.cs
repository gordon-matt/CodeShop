namespace CodeShop.UI;

partial class AboutWindow
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
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
        tableLayoutPanel = new TableLayoutPanel();
        pbLogo = new PictureBox();
        lblProductName = new Label();
        lblVersion = new Label();
        lblCopyright = new Label();
        lblCompanyName = new Label();
        btnOK = new KryptonButton();
        rtbDescription = new KryptonRichTextBox();
        tableLayoutPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
        SuspendLayout();
        // 
        // tableLayoutPanel
        // 
        tableLayoutPanel.ColumnCount = 2;
        tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
        tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67F));
        tableLayoutPanel.Controls.Add(pbLogo, 0, 0);
        tableLayoutPanel.Controls.Add(lblProductName, 1, 0);
        tableLayoutPanel.Controls.Add(lblVersion, 1, 1);
        tableLayoutPanel.Controls.Add(lblCopyright, 1, 2);
        tableLayoutPanel.Controls.Add(lblCompanyName, 1, 3);
        tableLayoutPanel.Controls.Add(btnOK, 1, 5);
        tableLayoutPanel.Controls.Add(rtbDescription, 1, 4);
        tableLayoutPanel.Dock = DockStyle.Fill;
        tableLayoutPanel.Location = new System.Drawing.Point(10, 10);
        tableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
        tableLayoutPanel.Name = "tableLayoutPanel";
        tableLayoutPanel.RowCount = 6;
        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 48.6413F));
        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.22826F));
        tableLayoutPanel.Size = new System.Drawing.Size(903, 408);
        tableLayoutPanel.TabIndex = 0;
        // 
        // pbLogo
        // 
        pbLogo.Image = Resources.Heroicsoft_Logo;
        pbLogo.Location = new System.Drawing.Point(4, 3);
        pbLogo.Margin = new Padding(4, 3, 4, 3);
        pbLogo.Name = "pbLogo";
        tableLayoutPanel.SetRowSpan(pbLogo, 6);
        pbLogo.Size = new System.Drawing.Size(289, 97);
        pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
        pbLogo.TabIndex = 12;
        pbLogo.TabStop = false;
        // 
        // lblProductName
        // 
        lblProductName.Dock = DockStyle.Fill;
        lblProductName.Location = new System.Drawing.Point(304, 0);
        lblProductName.Margin = new Padding(7, 0, 4, 0);
        lblProductName.MaximumSize = new System.Drawing.Size(0, 20);
        lblProductName.Name = "lblProductName";
        lblProductName.Size = new System.Drawing.Size(595, 20);
        lblProductName.TabIndex = 0;
        lblProductName.Text = "Product Name";
        lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblVersion
        // 
        lblVersion.Dock = DockStyle.Fill;
        lblVersion.Location = new System.Drawing.Point(304, 40);
        lblVersion.Margin = new Padding(7, 0, 4, 0);
        lblVersion.MaximumSize = new System.Drawing.Size(0, 20);
        lblVersion.Name = "lblVersion";
        lblVersion.Size = new System.Drawing.Size(595, 20);
        lblVersion.TabIndex = 1;
        lblVersion.Text = "Version";
        lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblCopyright
        // 
        lblCopyright.Dock = DockStyle.Fill;
        lblCopyright.Location = new System.Drawing.Point(304, 80);
        lblCopyright.Margin = new Padding(7, 0, 4, 0);
        lblCopyright.MaximumSize = new System.Drawing.Size(0, 20);
        lblCopyright.Name = "lblCopyright";
        lblCopyright.Size = new System.Drawing.Size(595, 20);
        lblCopyright.TabIndex = 2;
        lblCopyright.Text = "Copyright";
        lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblCompanyName
        // 
        lblCompanyName.Dock = DockStyle.Fill;
        lblCompanyName.Location = new System.Drawing.Point(304, 120);
        lblCompanyName.Margin = new Padding(7, 0, 4, 0);
        lblCompanyName.MaximumSize = new System.Drawing.Size(0, 20);
        lblCompanyName.Name = "lblCompanyName";
        lblCompanyName.Size = new System.Drawing.Size(595, 20);
        lblCompanyName.TabIndex = 3;
        lblCompanyName.Text = "Company Name";
        lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // btnOK
        // 
        btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnOK.DialogResult = DialogResult.Cancel;
        btnOK.Location = new System.Drawing.Point(800, 366);
        btnOK.Margin = new Padding(4, 3, 4, 3);
        btnOK.Name = "btnOK";
        btnOK.Size = new System.Drawing.Size(99, 39);
        btnOK.TabIndex = 5;
        btnOK.Values.Image = Resources.OK_32x32;
        btnOK.Values.Text = "&OK";
        // 
        // rtbDescription
        // 
        rtbDescription.Dock = DockStyle.Fill;
        rtbDescription.Location = new System.Drawing.Point(300, 163);
        rtbDescription.Name = "rtbDescription";
        rtbDescription.ReadOnly = true;
        rtbDescription.Size = new System.Drawing.Size(600, 190);
        rtbDescription.TabIndex = 4;
        rtbDescription.Text = "Description";
        rtbDescription.LinkClicked += rtbDescription_LinkClicked;
        // 
        // AboutWindow
        // 
        AcceptButton = btnOK;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(923, 428);
        Controls.Add(tableLayoutPanel);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "AboutWindow";
        Padding = new Padding(10);
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "About";
        tableLayoutPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel;
    private PictureBox pbLogo;
    private Label lblProductName;
    private Label lblVersion;
    private Label lblCopyright;
    private Label lblCompanyName;
    private KryptonButton btnOK;
    private KryptonRichTextBox rtbDescription;
}
