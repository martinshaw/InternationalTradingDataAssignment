namespace InternationalTradingDataAssignment
{
    partial class Information
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.closeModalButton = new System.Windows.Forms.Button();
            this.infoDepthLabel = new System.Windows.Forms.Label();
            this.infoDepthValue = new System.Windows.Forms.Label();
            this.infoCountLabel = new System.Windows.Forms.Label();
            this.infoCountValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.closeModalButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.infoDepthLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.infoDepthValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.infoCountLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.infoCountValue, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 285);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // closeModalButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.closeModalButton, 2);
            this.closeModalButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.closeModalButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.closeModalButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeModalButton.Location = new System.Drawing.Point(3, 259);
            this.closeModalButton.Name = "closeModalButton";
            this.closeModalButton.Size = new System.Drawing.Size(448, 23);
            this.closeModalButton.TabIndex = 0;
            this.closeModalButton.Text = "Close";
            this.closeModalButton.UseVisualStyleBackColor = true;
            this.closeModalButton.Click += new System.EventHandler(this.closeModalButton_Click);
            // 
            // infoDepthLabel
            // 
            this.infoDepthLabel.AutoSize = true;
            this.infoDepthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoDepthLabel.Location = new System.Drawing.Point(3, 0);
            this.infoDepthLabel.Name = "infoDepthLabel";
            this.infoDepthLabel.Size = new System.Drawing.Size(175, 60);
            this.infoDepthLabel.TabIndex = 1;
            this.infoDepthLabel.Text = "AVL Tree Depth:";
            this.infoDepthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // infoDepthValue
            // 
            this.infoDepthValue.AutoSize = true;
            this.infoDepthValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoDepthValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoDepthValue.Location = new System.Drawing.Point(184, 0);
            this.infoDepthValue.Name = "infoDepthValue";
            this.infoDepthValue.Size = new System.Drawing.Size(267, 60);
            this.infoDepthValue.TabIndex = 2;
            this.infoDepthValue.Text = "Calculating...";
            this.infoDepthValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoCountLabel
            // 
            this.infoCountLabel.AutoSize = true;
            this.infoCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoCountLabel.Location = new System.Drawing.Point(3, 60);
            this.infoCountLabel.Name = "infoCountLabel";
            this.infoCountLabel.Size = new System.Drawing.Size(175, 60);
            this.infoCountLabel.TabIndex = 3;
            this.infoCountLabel.Text = "Number of Countries:";
            this.infoCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // infoCountValue
            // 
            this.infoCountValue.AutoSize = true;
            this.infoCountValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoCountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoCountValue.Location = new System.Drawing.Point(184, 60);
            this.infoCountValue.Name = "infoCountValue";
            this.infoCountValue.Size = new System.Drawing.Size(267, 60);
            this.infoCountValue.TabIndex = 4;
            this.infoCountValue.Text = "Calculating...";
            this.infoCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 325);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "Information";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COUNTRIES\' INFORMATION";
            this.Load += new System.EventHandler(this.Information_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button closeModalButton;
        private System.Windows.Forms.Label infoDepthLabel;
        private System.Windows.Forms.Label infoDepthValue;
        private System.Windows.Forms.Label infoCountLabel;
        private System.Windows.Forms.Label infoCountValue;
    }
}