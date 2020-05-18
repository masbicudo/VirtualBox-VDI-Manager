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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVdiPath
            // 
            this.txtVdiPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVdiPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtVdiPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.tableLayoutPanel1.SetColumnSpan(this.txtVdiPath, 4);
            this.txtVdiPath.Location = new System.Drawing.Point(4, 6);
            this.txtVdiPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVdiPath.Name = "txtVdiPath";
            this.txtVdiPath.Size = new System.Drawing.Size(806, 22);
            this.txtVdiPath.TabIndex = 0;
            this.txtVdiPath.Text = "E:\\VirtualBox VMs";
            // 
            // btnLoadVdi
            // 
            this.btnLoadVdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadVdi.AutoSize = true;
            this.btnLoadVdi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoadVdi.Location = new System.Drawing.Point(818, 4);
            this.btnLoadVdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadVdi.Name = "btnLoadVdi";
            this.btnLoadVdi.Size = new System.Drawing.Size(76, 27);
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
            this.pgVdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pgVdi.Name = "pgVdi";
            this.pgVdi.Size = new System.Drawing.Size(615, 330);
            this.pgVdi.TabIndex = 4;
            this.pgVdi.ToolbarVisible = false;
            // 
            // lstVdis
            // 
            this.lstVdis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVdis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstVdis.FormattingEnabled = true;
            this.lstVdis.IntegralHeight = false;
            this.lstVdis.Location = new System.Drawing.Point(0, 0);
            this.lstVdis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstVdis.Name = "lstVdis";
            this.lstVdis.Size = new System.Drawing.Size(270, 330);
            this.lstVdis.Sorted = true;
            this.lstVdis.TabIndex = 2;
            this.lstVdis.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstVdis_DrawItem);
            this.lstVdis.SelectedIndexChanged += new System.EventHandler(this.lstVdis_SelectedIndexChanged);
            // 
            // lstVboxs
            // 
            this.lstVboxs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVboxs.FormattingEnabled = true;
            this.lstVboxs.IntegralHeight = false;
            this.lstVboxs.Location = new System.Drawing.Point(0, 0);
            this.lstVboxs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstVboxs.Name = "lstVboxs";
            this.lstVboxs.Size = new System.Drawing.Size(270, 281);
            this.lstVboxs.Sorted = true;
            this.lstVboxs.TabIndex = 5;
            this.lstVboxs.SelectedIndexChanged += new System.EventHandler(this.lstVboxs_SelectedIndexChanged);
            // 
            // pgVbox
            // 
            this.pgVbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgVbox.HelpVisible = false;
            this.pgVbox.Location = new System.Drawing.Point(0, 0);
            this.pgVbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pgVbox.Name = "pgVbox";
            this.pgVbox.Size = new System.Drawing.Size(615, 281);
            this.pgVbox.TabIndex = 7;
            this.pgVbox.ToolbarVisible = false;
            // 
            // btnRebuild
            // 
            this.btnRebuild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRebuild.AutoSize = true;
            this.btnRebuild.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRebuild.Location = new System.Drawing.Point(818, 663);
            this.btnRebuild.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRebuild.Name = "btnRebuild";
            this.btnRebuild.Size = new System.Drawing.Size(76, 27);
            this.btnRebuild.TabIndex = 11;
            this.btnRebuild.Text = "Rebuild";
            this.btnRebuild.UseVisualStyleBackColor = true;
            this.btnRebuild.Click += new System.EventHandler(this.btnRebuild_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.AutoSize = true;
            this.btnRestore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRestore.Location = new System.Drawing.Point(742, 663);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(68, 27);
            this.btnRestore.TabIndex = 10;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstVdis);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pgVdi);
            this.splitContainer1.Size = new System.Drawing.Size(890, 330);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lstVboxs);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pgVbox);
            this.splitContainer2.Size = new System.Drawing.Size(890, 281);
            this.splitContainer2.SplitterDistance = 270;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 6;
            // 
            // splitContainer3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.splitContainer3, 5);
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(4, 39);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.splitContainer3.Size = new System.Drawing.Size(890, 616);
            this.splitContainer3.SplitterDistance = 330;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 7;
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckAll.AutoSize = true;
            this.btnCheckAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheckAll.Location = new System.Drawing.Point(4, 663);
            this.btnCheckAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(75, 27);
            this.btnCheckAll.TabIndex = 8;
            this.btnCheckAll.Text = "Check all";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUncheckAll.AutoSize = true;
            this.btnUncheckAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUncheckAll.Location = new System.Drawing.Point(87, 663);
            this.btnUncheckAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(91, 27);
            this.btnUncheckAll.TabIndex = 9;
            this.btnUncheckAll.Text = "Uncheck all";
            this.btnUncheckAll.UseVisualStyleBackColor = true;
            this.btnUncheckAll.Click += new System.EventHandler(this.btnUncheckAll_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.splitContainer3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCheckAll, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnUncheckAll, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtVdiPath, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRebuild, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnRestore, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnLoadVdi, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(898, 694);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 694);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

