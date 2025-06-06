﻿using System.Drawing;

namespace CodeShop.UI;

public partial class SnippetsControl : UserControl
{
    public SnippetsControl()
    {
        InitializeComponent();
        LoadSnippets();
    }

    public delegate void SnippetEventHandler(object sender, SnippetEventArgs args);

    public event SnippetEventHandler SnippetSelected;

    protected virtual void OnSnippetSelected(SnippetEventArgs args)
    {
        SnippetSelected?.Invoke(this, args);
    }

    private void AddSnippetButton(string snippetKey)
    {
        var button = new KryptonButton
        {
            Text = snippetKey,
            Dock = DockStyle.Top,
            //FlatStyle = FlatStyle.Popup,
            Font = new Font("Microsoft Sans Serif",
                7.2567F,
                FontStyle.Regular,
                GraphicsUnit.Point, 0)
        };
        button.Click += button_Click;
        Controls.Add(button);
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Acceptable for WinForms event handlers")]
    private void button_Click(object sender, EventArgs e)
    {
        var button = (KryptonButton)sender;
        var args = new SnippetEventArgs(button.Text);
        SnippetSelected(this, args);
        //throwEvent(b.Text);
    }

    private void LoadSnippets()
    {
        foreach (string key in SnippetsHelper.Snippets.Keys.Reverse())
        {
            AddSnippetButton(key);
        }
    }
}