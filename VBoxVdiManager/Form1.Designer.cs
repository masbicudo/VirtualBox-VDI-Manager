namespace VBoxVdiManager
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
            this.txtVdiPath = new System.Windows.Forms.TextBox();
            this.btnLoadVdi = new System.Windows.Forms.Button();
            this.pgVdi = new System.Windows.Forms.PropertyGrid();
            this.lstVdis = new System.Windows.Forms.ListBox();
            this.lstVboxs = new System.Windows.Forms.CheckedListBox();
            this.pgVbox = new System.Windows.Forms.PropertyGrid();
            this.btnRebuild = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.btnUncheckAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVdiPath
            // 
            this.txtVdiPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVdiPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtVdiPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtVdiPath.Location = new System.Drawing.Point(12, 12);
            this.txtVdiPath.Name = "txtVdiPath";
            this.txtVdiPath.Size = new System.Drawing.Size(793, 20);
            this.txtVdiPath.TabIndex = 0;
            this.txtVdiPath.Text = "E:\\VirtualBox VMs";
            // 
            // btnLoadVdi
            // 
            this.btnLoadVdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadVdi.Location = new System.Drawing.Point(807, 10);
            this.btnLoadVdi.Name = "btnLoadVdi";
            this.btnLoadVdi.Size = new System.Drawing.Size(75, 23);
            this.btnLoadVdi.TabIndex = 1;
            this.btnLoadVdi.Text = "Load VDI";
            this.btnLoadVdi.UseVisualStyleBackColor = true;
            this.btnLoadVdi.Click += new System.EventHandler(this.btnLoadVdi_Click);
            // 
            // pgVdi
            // 
            this.pgVdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgVdi.HelpVisible = false;
            this.pgVdi.Location = new System.Drawing.Point(0, 0);
            this.pgVdi.Name = "pgVdi";
            this.pgVdi.Size = new System.Drawing.Size(602, 384);
            this.pgVdi.TabIndex = 2;
            this.pgVdi.ToolbarVisible = false;
            // 
            // lstVdis
            // 
            this.lstVdis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVdis.FormattingEnabled = true;
            this.lstVdis.IntegralHeight = false;
            this.lstVdis.Location = new System.Drawing.Point(0, 0);
            this.lstVdis.Name = "lstVdis";
            this.lstVdis.Size = new System.Drawing.Size(264, 384);
            this.lstVdis.Sorted = true;
            this.lstVdis.TabIndex = 3;
            this.lstVdis.SelectedIndexChanged += new System.EventHandler(this.lstVdis_SelectedIndexChanged);
            // 
            // lstVboxs
            // 
            this.lstVboxs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVboxs.FormattingEnabled = true;
            this.lstVboxs.IntegralHeight = false;
            this.lstVboxs.Location = new System.Drawing.Point(0, 0);
            this.lstVboxs.Name = "lstVboxs";
            this.lstVboxs.Size = new System.Drawing.Size(264, 328);
            this.lstVboxs.Sorted = true;
            this.lstVboxs.TabIndex = 4;
            this.lstVboxs.SelectedIndexChanged += new System.EventHandler(this.lstVboxs_SelectedIndexChanged);
            // 
            // pgVbox
            // 
            this.pgVbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgVbox.HelpVisible = false;
            this.pgVbox.Location = new System.Drawing.Point(0, 0);
            this.pgVbox.Name = "pgVbox";
            this.pgVbox.Size = new System.Drawing.Size(602, 328);
            this.pgVbox.TabIndex = 2;
            this.pgVbox.ToolbarVisible = false;
            // 
            // btnRebuild
            // 
            this.btnRebuild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRebuild.Location = new System.Drawing.Point(807, 760);
            this.btnRebuild.Name = "btnRebuild";
            this.btnRebuild.Size = new System.Drawing.Size(75, 23);
            this.btnRebuild.TabIndex = 1;
            this.btnRebuild.Text = "Rebuild";
            this.btnRebuild.UseVisualStyleBackColor = true;
            this.btnRebuild.Click += new System.EventHandler(this.btnRebuild_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.Location = new System.Drawing.Point(726, 760);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstVdis);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pgVdi);
            this.splitContainer1.Size = new System.Drawing.Size(870, 384);
            this.splitContainer1.SplitterDistance = 264;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lstVboxs);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pgVbox);
            this.splitContainer2.Size = new System.Drawing.Size(870, 328);
            this.splitContainer2.SplitterDistance = 264;
            this.splitContainer2.TabIndex = 6;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer3.Location = new System.Drawing.Point(12, 38);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer3.Size = new System.Drawing.Size(870, 716);
            this.splitContainer3.SplitterDistance = 384;
            this.splitContainer3.TabIndex = 7;
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheckAll.Location = new System.Drawing.Point(12, 760);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(75, 23);
            this.btnCheckAll.TabIndex = 1;
            this.btnCheckAll.Text = "Check all";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUncheckAll.Location = new System.Drawing.Point(93, 760);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(75, 23);
            this.btnUncheckAll.TabIndex = 1;
            this.btnUncheckAll.Text = "Uncheck all";
            this.btnUncheckAll.UseVisualStyleBackColor = true;
            this.btnUncheckAll.Click += new System.EventHandler(this.btnUncheckAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 793);
            this.Controls.Add(this.splitContainer3);
            this.Controls.Add(this.btnUncheckAll);
            this.Controls.Add(this.btnCheckAll);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnRebuild);
            this.Controls.Add(this.btnLoadVdi);
            this.Controls.Add(this.txtVdiPath);
            this.Name = "Form1";
            this.Text = "VirtualBox .vbox file fixer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVdiPath;
        private System.Windows.Forms.Button btnLoadVdi;
        private System.Windows.Forms.PropertyGrid pgVdi;
        private System.Windows.Forms.ListBox lstVdis;
        private System.Windows.Forms.CheckedListBox lstVboxs;
        private System.Windows.Forms.PropertyGrid pgVbox;
        private System.Windows.Forms.Button btnRebuild;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Button btnUncheckAll;
    }
}

