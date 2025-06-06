namespace CodeShop.UI;

/// <summary>
/// Summary description for AboutWindow.
/// </summary>
public class DocumentationWindow : KryptonForm
{
    private KryptonRichTextBox rtbDocumentation;

    public DocumentationWindow()
    {
        InitializeComponent();
        rtbDocumentation.LoadFile($"{AppDomain.CurrentDomain.BaseDirectory}Documentation.rtf");
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentationWindow));
        this.rtbDocumentation = new Krypton.Toolkit.KryptonRichTextBox();
        this.SuspendLayout();
        //
        // rtbDocumentation
        //
        this.rtbDocumentation.Dock = System.Windows.Forms.DockStyle.Fill;
        this.rtbDocumentation.Location = new System.Drawing.Point(0, 0);
        this.rtbDocumentation.Name = "rtbDocumentation";
        this.rtbDocumentation.Size = new System.Drawing.Size(1008, 681);
        this.rtbDocumentation.TabIndex = 0;
        this.rtbDocumentation.Text = "";
        //
        // DocumentationWindow
        //
        this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
        this.BackColor = System.Drawing.SystemColors.Window;
        this.ClientSize = new System.Drawing.Size(1024, 720);
        this.Controls.Add(this.rtbDocumentation);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Name = "DocumentationWindow";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Code Shop";
        this.ResumeLayout(false);
    }

    #endregion Windows Form Designer generated code
}