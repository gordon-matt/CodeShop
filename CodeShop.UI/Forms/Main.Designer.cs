﻿namespace CodeShop.UI
{
    partial class Main
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
            if (disposing)
            {
                customValuesForm?.Dispose();
                databaseNavigationForm?.Dispose();
                templateForm?.Dispose();
                propertiesForm?.Dispose();
                resultForm?.Dispose();
                resultPage?.Dispose();
                snippetsForm?.Dispose();
                templatePage?.Dispose();
                directorySelectionWindow?.Dispose();
                workspace?.Dispose();
                components?.Dispose();
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            menuStrip = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuFileEditConfiguration = new ToolStripMenuItem();
            mnuFileDatabaseConnect = new ToolStripMenuItem();
            mnuFileDatabaseDisconnect = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuFileNewTemplate = new ToolStripMenuItem();
            mnuFileOpenTemplate = new ToolStripMenuItem();
            mnuFileSaveTemplate = new ToolStripMenuItem();
            mnuFileSaveAsTemplate = new ToolStripMenuItem();
            mnuFileSaveAsResult = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            mnuFileSettings = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            mnuFileTemplateExit = new ToolStripMenuItem();
            mnuView = new ToolStripMenuItem();
            mnuViewTemplate = new ToolStripMenuItem();
            mnuViewResults = new ToolStripMenuItem();
            mnuGenerate = new ToolStripMenuItem();
            mnuGenerateFromTemplateTab = new ToolStripMenuItem();
            mnuGenerateFromTemplateFiles = new ToolStripMenuItem();
            mnuHelp = new ToolStripMenuItem();
            mnuHelpDocumentation = new ToolStripMenuItem();
            mnuHelpAbout = new ToolStripMenuItem();
            mnuHelpAboutHeroicsoft = new ToolStripMenuItem();
            kryptonManager = new KryptonManager(components);
            kryptonDockingManager = new KryptonDockingManager();
            kryptonDockableWorkspace = new KryptonDockableWorkspace();
            kryptonPanel = new KryptonPanel();
            dlgSaveFile = new SaveFileDialog();
            dlgOpenFile = new OpenFileDialog();
            kryptonToolStrip1 = new KryptonToolStrip();
            tsBtnDatabaseConfig = new ToolStripButton();
            tsBtnDatabaseConnect = new ToolStripButton();
            tsBtnDatabaseDisconnect = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            tsBtnOpenTemplate = new ToolStripButton();
            tsBtnNewTemplate = new ToolStripButton();
            tsBtnSaveTemplate = new ToolStripButton();
            tsBtnSaveTemplateAs = new ToolStripButton();
            tsBtnSaveResultAs = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            tsBtnSettings = new ToolStripButton();
            tsBtnGenerate = new ToolStripButton();
            tsBtnGenerateFiles = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            tsBtnHelp = new ToolStripButton();
            tsBtnAbout = new ToolStripButton();
            tsBtnAboutHeroicsoft = new ToolStripButton();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDockableWorkspace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel).BeginInit();
            kryptonPanel.SuspendLayout();
            kryptonToolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            menuStrip.Items.AddRange(new ToolStripItem[] { mnuFile, mnuView, mnuGenerate, mnuHelp });
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new System.Drawing.Size(1264, 24);
            menuStrip.TabIndex = 3;
            menuStrip.Text = "menuStrip";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileEditConfiguration, mnuFileDatabaseConnect, mnuFileDatabaseDisconnect, toolStripSeparator1, mnuFileNewTemplate, mnuFileOpenTemplate, mnuFileSaveTemplate, mnuFileSaveAsTemplate, mnuFileSaveAsResult, toolStripSeparator3, mnuFileSettings, toolStripSeparator2, mnuFileTemplateExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new System.Drawing.Size(37, 20);
            mnuFile.Text = "&File";
            // 
            // mnuFileEditConfiguration
            // 
            mnuFileEditConfiguration.Image = Resources.DatabaseConfig_32x32;
            mnuFileEditConfiguration.Name = "mnuFileEditConfiguration";
            mnuFileEditConfiguration.Size = new System.Drawing.Size(184, 22);
            mnuFileEditConfiguration.Text = "Edit Configuration";
            mnuFileEditConfiguration.Click += mnuFileEditConfiguration_Click;
            // 
            // mnuFileDatabaseConnect
            // 
            mnuFileDatabaseConnect.Image = Resources.Connect_32x32;
            mnuFileDatabaseConnect.Name = "mnuFileDatabaseConnect";
            mnuFileDatabaseConnect.Size = new System.Drawing.Size(184, 22);
            mnuFileDatabaseConnect.Text = "Database &Connect";
            mnuFileDatabaseConnect.Click += mnuFileDatabaseConnect_Click;
            // 
            // mnuFileDatabaseDisconnect
            // 
            mnuFileDatabaseDisconnect.Image = Resources.Disconnect_32x32;
            mnuFileDatabaseDisconnect.Name = "mnuFileDatabaseDisconnect";
            mnuFileDatabaseDisconnect.Size = new System.Drawing.Size(184, 22);
            mnuFileDatabaseDisconnect.Text = "Database &Disconnect";
            mnuFileDatabaseDisconnect.Click += mnuFileDatabaseDisconnect_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // mnuFileNewTemplate
            // 
            mnuFileNewTemplate.Image = Resources.AddFile_32x32;
            mnuFileNewTemplate.Name = "mnuFileNewTemplate";
            mnuFileNewTemplate.Size = new System.Drawing.Size(184, 22);
            mnuFileNewTemplate.Text = "New Template";
            mnuFileNewTemplate.Click += mnuFileNewTemplate_Click;
            // 
            // mnuFileOpenTemplate
            // 
            mnuFileOpenTemplate.Image = Resources.OpenFolder_32x32;
            mnuFileOpenTemplate.Name = "mnuFileOpenTemplate";
            mnuFileOpenTemplate.Size = new System.Drawing.Size(184, 22);
            mnuFileOpenTemplate.Text = "&Open Template";
            mnuFileOpenTemplate.Click += mnuFileOpenTemplate_Click;
            // 
            // mnuFileSaveTemplate
            // 
            mnuFileSaveTemplate.Image = Resources.Save_32x32;
            mnuFileSaveTemplate.Name = "mnuFileSaveTemplate";
            mnuFileSaveTemplate.Size = new System.Drawing.Size(184, 22);
            mnuFileSaveTemplate.Text = "&Save Template";
            mnuFileSaveTemplate.Click += mnuFileSaveTemplate_Click;
            // 
            // mnuFileSaveAsTemplate
            // 
            mnuFileSaveAsTemplate.AccessibleDescription = "";
            mnuFileSaveAsTemplate.Image = Resources.SaveAs_32x32;
            mnuFileSaveAsTemplate.Name = "mnuFileSaveAsTemplate";
            mnuFileSaveAsTemplate.Size = new System.Drawing.Size(184, 22);
            mnuFileSaveAsTemplate.Text = "Save Template &As";
            mnuFileSaveAsTemplate.Click += mnuFileSaveAsTemplate_Click;
            // 
            // mnuFileSaveAsResult
            // 
            mnuFileSaveAsResult.AccessibleDescription = "";
            mnuFileSaveAsResult.Image = Resources.SaveResult_32x32;
            mnuFileSaveAsResult.Name = "mnuFileSaveAsResult";
            mnuFileSaveAsResult.Size = new System.Drawing.Size(184, 22);
            mnuFileSaveAsResult.Text = "Save Result As";
            mnuFileSaveAsResult.Click += mnuFileSaveAsResult_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(181, 6);
            // 
            // mnuFileSettings
            // 
            mnuFileSettings.Image = Resources.Settings_32x32;
            mnuFileSettings.Name = "mnuFileSettings";
            mnuFileSettings.Size = new System.Drawing.Size(184, 22);
            mnuFileSettings.Text = "Settings";
            mnuFileSettings.Click += mnuFileSettings_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // mnuFileTemplateExit
            // 
            mnuFileTemplateExit.Name = "mnuFileTemplateExit";
            mnuFileTemplateExit.Size = new System.Drawing.Size(184, 22);
            mnuFileTemplateExit.Text = "E&xit";
            mnuFileTemplateExit.Click += mnuFileTemplateExit_Click;
            // 
            // mnuView
            // 
            mnuView.DropDownItems.AddRange(new ToolStripItem[] { mnuViewTemplate, mnuViewResults });
            mnuView.Name = "mnuView";
            mnuView.Size = new System.Drawing.Size(44, 20);
            mnuView.Text = "&View";
            // 
            // mnuViewTemplate
            // 
            mnuViewTemplate.Image = Resources.Design_32x32;
            mnuViewTemplate.Name = "mnuViewTemplate";
            mnuViewTemplate.Size = new System.Drawing.Size(122, 22);
            mnuViewTemplate.Text = "Template";
            mnuViewTemplate.Click += mnuViewTemplate_Click;
            // 
            // mnuViewResults
            // 
            mnuViewResults.Image = Resources.Code_32x32;
            mnuViewResults.Name = "mnuViewResults";
            mnuViewResults.Size = new System.Drawing.Size(122, 22);
            mnuViewResults.Text = "Results";
            mnuViewResults.Click += mnuViewResults_Click;
            // 
            // mnuGenerate
            // 
            mnuGenerate.DropDownItems.AddRange(new ToolStripItem[] { mnuGenerateFromTemplateTab, mnuGenerateFromTemplateFiles });
            mnuGenerate.Name = "mnuGenerate";
            mnuGenerate.Size = new System.Drawing.Size(66, 20);
            mnuGenerate.Text = "&Generate";
            // 
            // mnuGenerateFromTemplateTab
            // 
            mnuGenerateFromTemplateTab.Image = Resources.Lightning_32x32;
            mnuGenerateFromTemplateTab.Name = "mnuGenerateFromTemplateTab";
            mnuGenerateFromTemplateTab.Size = new System.Drawing.Size(187, 22);
            mnuGenerateFromTemplateTab.Text = "From Template Tab";
            mnuGenerateFromTemplateTab.Click += mnuGenerateFromTemplateTab_Click;
            // 
            // mnuGenerateFromTemplateFiles
            // 
            mnuGenerateFromTemplateFiles.Image = Resources.Wand_32x32;
            mnuGenerateFromTemplateFiles.Name = "mnuGenerateFromTemplateFiles";
            mnuGenerateFromTemplateFiles.Size = new System.Drawing.Size(187, 22);
            mnuGenerateFromTemplateFiles.Text = "From Template File(s)";
            mnuGenerateFromTemplateFiles.Click += mnuGenerateFromTemplateFiles_Click;
            // 
            // mnuHelp
            // 
            mnuHelp.DropDownItems.AddRange(new ToolStripItem[] { mnuHelpDocumentation, mnuHelpAbout, mnuHelpAboutHeroicsoft });
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new System.Drawing.Size(44, 20);
            mnuHelp.Text = "&Help";
            // 
            // mnuHelpDocumentation
            // 
            mnuHelpDocumentation.Image = Resources.Help_32x32;
            mnuHelpDocumentation.Name = "mnuHelpDocumentation";
            mnuHelpDocumentation.Size = new System.Drawing.Size(168, 22);
            mnuHelpDocumentation.Text = "Documentation";
            mnuHelpDocumentation.Click += mnuHelpDocumentation_Click;
            // 
            // mnuHelpAbout
            // 
            mnuHelpAbout.Image = Resources.About_32x32;
            mnuHelpAbout.Name = "mnuHelpAbout";
            mnuHelpAbout.Size = new System.Drawing.Size(168, 22);
            mnuHelpAbout.Text = "About Code Shop";
            mnuHelpAbout.Click += mnuHelpAbout_Click;
            // 
            // mnuHelpAboutHeroicsoft
            // 
            mnuHelpAboutHeroicsoft.BackColor = System.Drawing.SystemColors.Control;
            mnuHelpAboutHeroicsoft.Image = Resources.Heroicsoft_Icon;
            mnuHelpAboutHeroicsoft.Name = "mnuHelpAboutHeroicsoft";
            mnuHelpAboutHeroicsoft.Size = new System.Drawing.Size(168, 22);
            mnuHelpAboutHeroicsoft.Text = "About Heroicsoft";
            mnuHelpAboutHeroicsoft.Click += mnuHelpAboutHeroicsoft_Click;
            // 
            // kryptonManager
            // 
            kryptonManager.GlobalPaletteMode = PaletteMode.Microsoft365Silver;
            // 
            // kryptonDockableWorkspace
            // 
            kryptonDockableWorkspace.ActivePage = null;
            kryptonDockableWorkspace.AutoHiddenHost = false;
            kryptonDockableWorkspace.CompactFlags = Krypton.Workspace.CompactFlags.RemoveEmptyCells | Krypton.Workspace.CompactFlags.RemoveEmptySequences | Krypton.Workspace.CompactFlags.PromoteLeafs;
            kryptonDockableWorkspace.ContainerBackStyle = PaletteBackStyle.PanelClient;
            kryptonDockableWorkspace.Dock = DockStyle.Fill;
            kryptonDockableWorkspace.Location = new System.Drawing.Point(0, 0);
            kryptonDockableWorkspace.Margin = new Padding(4, 3, 4, 3);
            kryptonDockableWorkspace.Name = "kryptonDockableWorkspace";
            // 
            // 
            // 
            kryptonDockableWorkspace.Root.UniqueName = "F867F895E47B4CA5C6AC47791205A4AB";
            kryptonDockableWorkspace.Root.WorkspaceControl = kryptonDockableWorkspace;
            kryptonDockableWorkspace.SeparatorStyle = SeparatorStyle.LowProfile;
            kryptonDockableWorkspace.ShowMaximizeButton = false;
            kryptonDockableWorkspace.Size = new System.Drawing.Size(1264, 618);
            kryptonDockableWorkspace.SplitterWidth = 5;
            kryptonDockableWorkspace.TabIndex = 5;
            kryptonDockableWorkspace.TabStop = true;
            // 
            // kryptonPanel
            // 
            kryptonPanel.Controls.Add(kryptonDockableWorkspace);
            kryptonPanel.Dock = DockStyle.Fill;
            kryptonPanel.Location = new System.Drawing.Point(0, 63);
            kryptonPanel.Margin = new Padding(4, 3, 4, 3);
            kryptonPanel.Name = "kryptonPanel";
            kryptonPanel.Size = new System.Drawing.Size(1264, 618);
            kryptonPanel.TabIndex = 6;
            // 
            // dlgSaveFile
            // 
            dlgSaveFile.RestoreDirectory = true;
            // 
            // dlgOpenFile
            // 
            dlgOpenFile.Filter = "All files (*.*)|*.*";
            dlgOpenFile.RestoreDirectory = true;
            // 
            // kryptonToolStrip1
            // 
            kryptonToolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            kryptonToolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            kryptonToolStrip1.Items.AddRange(new ToolStripItem[] { tsBtnDatabaseConfig, tsBtnDatabaseConnect, tsBtnDatabaseDisconnect, toolStripSeparator4, tsBtnOpenTemplate, tsBtnNewTemplate, tsBtnSaveTemplate, tsBtnSaveTemplateAs, tsBtnSaveResultAs, toolStripSeparator5, tsBtnSettings, tsBtnGenerate, tsBtnGenerateFiles, toolStripSeparator6, tsBtnHelp, tsBtnAbout, tsBtnAboutHeroicsoft });
            kryptonToolStrip1.Location = new System.Drawing.Point(0, 24);
            kryptonToolStrip1.Name = "kryptonToolStrip1";
            kryptonToolStrip1.Size = new System.Drawing.Size(1264, 39);
            kryptonToolStrip1.TabIndex = 8;
            kryptonToolStrip1.Text = "kryptonToolStrip1";
            // 
            // tsBtnDatabaseConfig
            // 
            tsBtnDatabaseConfig.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnDatabaseConfig.Image = Resources.DatabaseConfig_32x32;
            tsBtnDatabaseConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsBtnDatabaseConfig.Name = "tsBtnDatabaseConfig";
            tsBtnDatabaseConfig.Size = new System.Drawing.Size(36, 36);
            tsBtnDatabaseConfig.Text = "Database Config";
            tsBtnDatabaseConfig.Click += tsBtnDatabaseConfig_Click;
            // 
            // tsBtnDatabaseConnect
            // 
            tsBtnDatabaseConnect.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnDatabaseConnect.Image = Resources.Connect_32x32;
            tsBtnDatabaseConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsBtnDatabaseConnect.Name = "tsBtnDatabaseConnect";
            tsBtnDatabaseConnect.Size = new System.Drawing.Size(36, 36);
            tsBtnDatabaseConnect.Text = "Database Connect";
            tsBtnDatabaseConnect.Click += tsBtnDatabaseConnect_Click;
            // 
            // tsBtnDatabaseDisconnect
            // 
            tsBtnDatabaseDisconnect.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnDatabaseDisconnect.Image = Resources.Disconnect_32x32;
            tsBtnDatabaseDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsBtnDatabaseDisconnect.Name = "tsBtnDatabaseDisconnect";
            tsBtnDatabaseDisconnect.Size = new System.Drawing.Size(36, 36);
            tsBtnDatabaseDisconnect.Text = "Database Disconnect";
            tsBtnDatabaseDisconnect.Click += tsBtnDatabaseDisconnect_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // tsBtnOpenTemplate
            // 
            tsBtnOpenTemplate.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnOpenTemplate.Image = Resources.OpenFolder_32x32;
            tsBtnOpenTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsBtnOpenTemplate.Name = "tsBtnOpenTemplate";
            tsBtnOpenTemplate.Size = new System.Drawing.Size(36, 36);
            tsBtnOpenTemplate.Text = "Open Template";
            tsBtnOpenTemplate.Click += tsBtnOpenTemplate_Click;
            // 
            // tsBtnNewTemplate
            // 
            tsBtnNewTemplate.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnNewTemplate.Image = Resources.AddFile_32x32;
            tsBtnNewTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsBtnNewTemplate.Name = "tsBtnNewTemplate";
            tsBtnNewTemplate.Size = new System.Drawing.Size(36, 36);
            tsBtnNewTemplate.Text = "New Template";
            tsBtnNewTemplate.Click += tsBtnNewTemplate_Click;
            // 
            // tsBtnSaveTemplate
            // 
            tsBtnSaveTemplate.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnSaveTemplate.Image = Resources.Save_32x32;
            tsBtnSaveTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsBtnSaveTemplate.Name = "tsBtnSaveTemplate";
            tsBtnSaveTemplate.Size = new System.Drawing.Size(36, 36);
            tsBtnSaveTemplate.Text = "Save Template";
            tsBtnSaveTemplate.Click += tsBtnSaveTemplate_Click;
            // 
            // tsBtnSaveTemplateAs
            // 
            tsBtnSaveTemplateAs.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnSaveTemplateAs.Image = Resources.SaveAs_32x32;
            tsBtnSaveTemplateAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsBtnSaveTemplateAs.Name = "tsBtnSaveTemplateAs";
            tsBtnSaveTemplateAs.Size = new System.Drawing.Size(36, 36);
            tsBtnSaveTemplateAs.Text = "Save Template As..";
            tsBtnSaveTemplateAs.Click += tsBtnSaveTemplateAs_Click;
            // 
            // tsBtnSaveResultAs
            // 
            tsBtnSaveResultAs.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnSaveResultAs.Image = Resources.SaveResult_32x32;
            tsBtnSaveResultAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsBtnSaveResultAs.Name = "tsBtnSaveResultAs";
            tsBtnSaveResultAs.Size = new System.Drawing.Size(36, 36);
            tsBtnSaveResultAs.Text = "Save Result As..";
            tsBtnSaveResultAs.Click += tsBtnSaveResultAs_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // tsBtnSettings
            // 
            tsBtnSettings.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnSettings.Image = Resources.Settings_32x32;
            tsBtnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsBtnSettings.Name = "tsBtnSettings";
            tsBtnSettings.Size = new System.Drawing.Size(36, 36);
            tsBtnSettings.Text = "Settings";
            tsBtnSettings.Click += tsBtnSettings_Click;
            // 
            // tsBtnGenerate
            // 
            tsBtnGenerate.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnGenerate.Image = Resources.Lightning_32x32;
            tsBtnGenerate.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsBtnGenerate.Name = "tsBtnGenerate";
            tsBtnGenerate.Size = new System.Drawing.Size(36, 36);
            tsBtnGenerate.Text = "Generate";
            tsBtnGenerate.Click += tsBtnGenerate_Click;
            // 
            // tsBtnGenerateFiles
            // 
            tsBtnGenerateFiles.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnGenerateFiles.Image = Resources.Wand_32x32;
            tsBtnGenerateFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsBtnGenerateFiles.Name = "tsBtnGenerateFiles";
            tsBtnGenerateFiles.Size = new System.Drawing.Size(36, 36);
            tsBtnGenerateFiles.Text = "Generate Files";
            tsBtnGenerateFiles.Click += tsBtnGenerateFiles_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // tsBtnHelp
            // 
            tsBtnHelp.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnHelp.Image = Resources.Help_32x32;
            tsBtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsBtnHelp.Name = "tsBtnHelp";
            tsBtnHelp.Size = new System.Drawing.Size(36, 36);
            tsBtnHelp.Text = "Documentation";
            tsBtnHelp.Click += tsBtnHelp_Click;
            // 
            // tsBtnAbout
            // 
            tsBtnAbout.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnAbout.Image = Resources.About_32x32;
            tsBtnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsBtnAbout.Name = "tsBtnAbout";
            tsBtnAbout.Size = new System.Drawing.Size(36, 36);
            tsBtnAbout.Text = "About Code Shop";
            tsBtnAbout.Click += tsBtnAbout_Click;
            // 
            // tsBtnAboutHeroicsoft
            // 
            tsBtnAboutHeroicsoft.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnAboutHeroicsoft.Image = Resources.Heroicsoft_Icon;
            tsBtnAboutHeroicsoft.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsBtnAboutHeroicsoft.Name = "tsBtnAboutHeroicsoft";
            tsBtnAboutHeroicsoft.Size = new System.Drawing.Size(36, 36);
            tsBtnAboutHeroicsoft.Text = "About Heroicsoft";
            tsBtnAboutHeroicsoft.Click += tsBtnAboutHeroicsoft_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1264, 681);
            Controls.Add(kryptonPanel);
            Controls.Add(kryptonToolStrip1);
            Controls.Add(menuStrip);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Code Shop";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDockableWorkspace).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel).EndInit();
            kryptonPanel.ResumeLayout(false);
            kryptonToolStrip1.ResumeLayout(false);
            kryptonToolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuView;
        private ToolStripMenuItem mnuGenerate;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem mnuFileDatabaseConnect;
        private ToolStripMenuItem mnuFileDatabaseDisconnect;
        private ToolStripMenuItem mnuFileEditConfiguration;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuFileOpenTemplate;
        private ToolStripMenuItem mnuFileSaveTemplate;
        private ToolStripMenuItem mnuFileSaveAsTemplate;
        private ToolStripMenuItem mnuFileSaveAsResult;
        private ToolStripMenuItem mnuFileTemplateExit;
        private ToolStripMenuItem mnuHelpDocumentation;
        private ToolStripMenuItem mnuHelpAbout;
        private ToolStripMenuItem mnuHelpAboutHeroicsoft;
        private ToolStripMenuItem mnuViewTemplate;
        private ToolStripMenuItem mnuViewResults;
        private ToolStripMenuItem mnuFileNewTemplate;
        private KryptonManager kryptonManager;
        private KryptonDockingManager kryptonDockingManager;
        private KryptonDockableWorkspace kryptonDockableWorkspace;
        private KryptonPanel kryptonPanel;
        private SaveFileDialog dlgSaveFile;
        private OpenFileDialog dlgOpenFile;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mnuFileSettings;
        private ToolStripSeparator toolStripSeparator2;
        private KryptonToolStrip kryptonToolStrip1;
        private ToolStripButton tsBtnOpenTemplate;
        private ToolStripButton tsBtnDatabaseConfig;
        private ToolStripButton tsBtnNewTemplate;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton tsBtnSaveTemplate;
        private ToolStripButton tsBtnSaveTemplateAs;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton tsBtnSettings;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton tsBtnHelp;
        private ToolStripButton tsBtnAbout;
        private ToolStripButton tsBtnAboutHeroicsoft;
        private ToolStripButton tsBtnGenerate;
        private ToolStripButton tsBtnGenerateFiles;
        private ToolStripButton tsBtnDatabaseConnect;
        private ToolStripButton tsBtnDatabaseDisconnect;
        private ToolStripMenuItem mnuGenerateFromTemplateTab;
        private ToolStripMenuItem mnuGenerateFromTemplateFiles;
        private ToolStripButton tsBtnSaveResultAs;
    }
}