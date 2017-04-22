﻿namespace InternationalTradingDataAssignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countriesListContainer = new System.Windows.Forms.TableLayoutPanel();
            this.countriesList = new System.Windows.Forms.ListView();
            this.countryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.countriesListContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // countriesListContainer
            // 
            this.countriesListContainer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.countriesListContainer.ColumnCount = 2;
            this.countriesListContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.countriesListContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.75F));
            this.countriesListContainer.Controls.Add(this.countriesList, 0, 0);
            this.countriesListContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countriesListContainer.Location = new System.Drawing.Point(0, 24);
            this.countriesListContainer.Name = "countriesListContainer";
            this.countriesListContainer.RowCount = 1;
            this.countriesListContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.countriesListContainer.Size = new System.Drawing.Size(992, 649);
            this.countriesListContainer.TabIndex = 1;
            // 
            // countriesList
            // 
            this.countriesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.countryName});
            this.countriesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countriesList.Location = new System.Drawing.Point(5, 5);
            this.countriesList.Name = "countriesList";
            this.countriesList.Size = new System.Drawing.Size(302, 639);
            this.countriesList.TabIndex = 0;
            this.countriesList.UseCompatibleStateImageBehavior = false;
            this.countriesList.View = System.Windows.Forms.View.Details;
            // 
            // countryName
            // 
            this.countryName.Text = "Country Name";
            this.countryName.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 673);
            this.Controls.Add(this.countriesListContainer);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "International Trading Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.countriesListContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel countriesListContainer;
        private System.Windows.Forms.ListView countriesList;
        private System.Windows.Forms.ColumnHeader countryName;
    }
}

