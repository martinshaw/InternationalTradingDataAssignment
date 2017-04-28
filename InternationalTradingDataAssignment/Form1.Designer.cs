namespace InternationalTradingDataAssignment
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countriesListContainer = new System.Windows.Forms.TableLayoutPanel();
            this.countriesList = new System.Windows.Forms.ListView();
            this.countryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.cHDIRankingPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cHDIRankingTextBox = new System.Windows.Forms.TextBox();
            this.cHDIRankingLabel = new System.Windows.Forms.Label();
            this.cTradeBalancePanel = new System.Windows.Forms.TableLayoutPanel();
            this.cTradeBalanceTextBox = new System.Windows.Forms.TextBox();
            this.cTradeBalanceLabel = new System.Windows.Forms.Label();
            this.cInflationPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cInflationTextBox = new System.Windows.Forms.TextBox();
            this.cInflationLabel = new System.Windows.Forms.Label();
            this.cGDPGrowthPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cGDPGrowthTextBox = new System.Windows.Forms.TextBox();
            this.cGDPGrowthLabel = new System.Windows.Forms.Label();
            this.cNamePanel = new System.Windows.Forms.TableLayoutPanel();
            this.cNameTextBox = new System.Windows.Forms.TextBox();
            this.cNameLabel = new System.Windows.Forms.Label();
            this.cMainTradePartnersContainer = new System.Windows.Forms.TableLayoutPanel();
            this.cMainTradePartnersPanel = new System.Windows.Forms.GroupBox();
            this.cMainTradePartnersList = new System.Windows.Forms.ListView();
            this.mtpName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtpGDPGrowth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtpInflation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtpTradeBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtpHDIRanking = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSaveCountryPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cSaveCountryButton = new System.Windows.Forms.Button();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.countriesListContainer.SuspendLayout();
            this.dataTableContainer.SuspendLayout();
            this.cHDIRankingPanel.SuspendLayout();
            this.cTradeBalancePanel.SuspendLayout();
            this.cInflationPanel.SuspendLayout();
            this.cGDPGrowthPanel.SuspendLayout();
            this.cNamePanel.SuspendLayout();
            this.cMainTradePartnersContainer.SuspendLayout();
            this.cMainTradePartnersPanel.SuspendLayout();
            this.cSaveCountryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.countryToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(992, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "Main Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // countryToolStripMenuItem
            // 
            this.countryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.countryToolStripMenuItem.Name = "countryToolStripMenuItem";
            this.countryToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.countryToolStripMenuItem.Text = "Country";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // countriesListContainer
            // 
            this.countriesListContainer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.countriesListContainer.ColumnCount = 2;
            this.countriesListContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.40404F));
            this.countriesListContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.59596F));
            this.countriesListContainer.Controls.Add(this.countriesList, 0, 0);
            this.countriesListContainer.Controls.Add(this.dataTableContainer, 1, 0);
            this.countriesListContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countriesListContainer.Location = new System.Drawing.Point(0, 24);
            this.countriesListContainer.Name = "countriesListContainer";
            this.countriesListContainer.RowCount = 1;
            this.countriesListContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.countriesListContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.countriesListContainer.Size = new System.Drawing.Size(992, 649);
            this.countriesListContainer.TabIndex = 1;
            // 
            // countriesList
            // 
            this.countriesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countriesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.countryName});
            this.countriesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countriesList.Location = new System.Drawing.Point(1, 1);
            this.countriesList.Margin = new System.Windows.Forms.Padding(0);
            this.countriesList.MultiSelect = false;
            this.countriesList.Name = "countriesList";
            this.countriesList.Size = new System.Drawing.Size(201, 647);
            this.countriesList.TabIndex = 0;
            this.countriesList.UseCompatibleStateImageBehavior = false;
            this.countriesList.View = System.Windows.Forms.View.Details;
            this.countriesList.SelectedIndexChanged += new System.EventHandler(this.countriesList_SelectedIndexChanged);
            // 
            // countryName
            // 
            this.countryName.Text = "Country Name";
            this.countryName.Width = 160;
            // 
            // dataTableContainer
            // 
            this.dataTableContainer.ColumnCount = 2;
            this.dataTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99775F));
            this.dataTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00225F));
            this.dataTableContainer.Controls.Add(this.cHDIRankingPanel, 0, 2);
            this.dataTableContainer.Controls.Add(this.cTradeBalancePanel, 1, 1);
            this.dataTableContainer.Controls.Add(this.cInflationPanel, 0, 1);
            this.dataTableContainer.Controls.Add(this.cGDPGrowthPanel, 1, 0);
            this.dataTableContainer.Controls.Add(this.cNamePanel, 0, 0);
            this.dataTableContainer.Controls.Add(this.cMainTradePartnersContainer, 0, 4);
            this.dataTableContainer.Controls.Add(this.cSaveCountryPanel, 1, 2);
            this.dataTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTableContainer.Location = new System.Drawing.Point(206, 4);
            this.dataTableContainer.Name = "dataTableContainer";
            this.dataTableContainer.RowCount = 6;
            this.dataTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.87468F));
            this.dataTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.87469F));
            this.dataTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.87469F));
            this.dataTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.062407F));
            this.dataTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.11569F));
            this.dataTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.19785F));
            this.dataTableContainer.Size = new System.Drawing.Size(782, 641);
            this.dataTableContainer.TabIndex = 1;
            // 
            // cHDIRankingPanel
            // 
            this.cHDIRankingPanel.ColumnCount = 1;
            this.cHDIRankingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cHDIRankingPanel.Controls.Add(this.cHDIRankingTextBox, 0, 1);
            this.cHDIRankingPanel.Controls.Add(this.cHDIRankingLabel, 0, 0);
            this.cHDIRankingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cHDIRankingPanel.Location = new System.Drawing.Point(3, 219);
            this.cHDIRankingPanel.Name = "cHDIRankingPanel";
            this.cHDIRankingPanel.Padding = new System.Windows.Forms.Padding(20);
            this.cHDIRankingPanel.RowCount = 2;
            this.cHDIRankingPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.cHDIRankingPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.cHDIRankingPanel.Size = new System.Drawing.Size(384, 102);
            this.cHDIRankingPanel.TabIndex = 4;
            // 
            // cHDIRankingTextBox
            // 
            this.cHDIRankingTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cHDIRankingTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cHDIRankingTextBox.Location = new System.Drawing.Point(23, 48);
            this.cHDIRankingTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cHDIRankingTextBox.Name = "cHDIRankingTextBox";
            this.cHDIRankingTextBox.Size = new System.Drawing.Size(338, 24);
            this.cHDIRankingTextBox.TabIndex = 0;
            this.cHDIRankingTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cHDIRankingTextBox_KeyDown);
            // 
            // cHDIRankingLabel
            // 
            this.cHDIRankingLabel.AutoSize = true;
            this.cHDIRankingLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cHDIRankingLabel.Location = new System.Drawing.Point(20, 25);
            this.cHDIRankingLabel.Margin = new System.Windows.Forms.Padding(0);
            this.cHDIRankingLabel.Name = "cHDIRankingLabel";
            this.cHDIRankingLabel.Size = new System.Drawing.Size(344, 13);
            this.cHDIRankingLabel.TabIndex = 1;
            this.cHDIRankingLabel.Text = "HDI Ranking:";
            // 
            // cTradeBalancePanel
            // 
            this.cTradeBalancePanel.ColumnCount = 1;
            this.cTradeBalancePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cTradeBalancePanel.Controls.Add(this.cTradeBalanceTextBox, 0, 1);
            this.cTradeBalancePanel.Controls.Add(this.cTradeBalanceLabel, 0, 0);
            this.cTradeBalancePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cTradeBalancePanel.Location = new System.Drawing.Point(393, 111);
            this.cTradeBalancePanel.Name = "cTradeBalancePanel";
            this.cTradeBalancePanel.Padding = new System.Windows.Forms.Padding(20);
            this.cTradeBalancePanel.RowCount = 2;
            this.cTradeBalancePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.cTradeBalancePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.cTradeBalancePanel.Size = new System.Drawing.Size(386, 102);
            this.cTradeBalancePanel.TabIndex = 3;
            // 
            // cTradeBalanceTextBox
            // 
            this.cTradeBalanceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cTradeBalanceTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTradeBalanceTextBox.Location = new System.Drawing.Point(23, 48);
            this.cTradeBalanceTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cTradeBalanceTextBox.Name = "cTradeBalanceTextBox";
            this.cTradeBalanceTextBox.Size = new System.Drawing.Size(340, 24);
            this.cTradeBalanceTextBox.TabIndex = 0;
            this.cTradeBalanceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cTradeBalanceTextBox_KeyDown);
            // 
            // cTradeBalanceLabel
            // 
            this.cTradeBalanceLabel.AutoSize = true;
            this.cTradeBalanceLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cTradeBalanceLabel.Location = new System.Drawing.Point(20, 25);
            this.cTradeBalanceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.cTradeBalanceLabel.Name = "cTradeBalanceLabel";
            this.cTradeBalanceLabel.Size = new System.Drawing.Size(346, 13);
            this.cTradeBalanceLabel.TabIndex = 1;
            this.cTradeBalanceLabel.Text = "Trade Balance:";
            // 
            // cInflationPanel
            // 
            this.cInflationPanel.ColumnCount = 1;
            this.cInflationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cInflationPanel.Controls.Add(this.cInflationTextBox, 0, 1);
            this.cInflationPanel.Controls.Add(this.cInflationLabel, 0, 0);
            this.cInflationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cInflationPanel.Location = new System.Drawing.Point(3, 111);
            this.cInflationPanel.Name = "cInflationPanel";
            this.cInflationPanel.Padding = new System.Windows.Forms.Padding(20);
            this.cInflationPanel.RowCount = 2;
            this.cInflationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.cInflationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.cInflationPanel.Size = new System.Drawing.Size(384, 102);
            this.cInflationPanel.TabIndex = 2;
            // 
            // cInflationTextBox
            // 
            this.cInflationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cInflationTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cInflationTextBox.Location = new System.Drawing.Point(23, 48);
            this.cInflationTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cInflationTextBox.Name = "cInflationTextBox";
            this.cInflationTextBox.Size = new System.Drawing.Size(338, 24);
            this.cInflationTextBox.TabIndex = 0;
            this.cInflationTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cInflationTextBox_KeyDown);
            // 
            // cInflationLabel
            // 
            this.cInflationLabel.AutoSize = true;
            this.cInflationLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cInflationLabel.Location = new System.Drawing.Point(20, 25);
            this.cInflationLabel.Margin = new System.Windows.Forms.Padding(0);
            this.cInflationLabel.Name = "cInflationLabel";
            this.cInflationLabel.Size = new System.Drawing.Size(344, 13);
            this.cInflationLabel.TabIndex = 1;
            this.cInflationLabel.Text = "Inflation Rate:";
            // 
            // cGDPGrowthPanel
            // 
            this.cGDPGrowthPanel.ColumnCount = 1;
            this.cGDPGrowthPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cGDPGrowthPanel.Controls.Add(this.cGDPGrowthTextBox, 0, 1);
            this.cGDPGrowthPanel.Controls.Add(this.cGDPGrowthLabel, 0, 0);
            this.cGDPGrowthPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cGDPGrowthPanel.Location = new System.Drawing.Point(393, 3);
            this.cGDPGrowthPanel.Name = "cGDPGrowthPanel";
            this.cGDPGrowthPanel.Padding = new System.Windows.Forms.Padding(20);
            this.cGDPGrowthPanel.RowCount = 2;
            this.cGDPGrowthPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.cGDPGrowthPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.cGDPGrowthPanel.Size = new System.Drawing.Size(386, 102);
            this.cGDPGrowthPanel.TabIndex = 1;
            // 
            // cGDPGrowthTextBox
            // 
            this.cGDPGrowthTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cGDPGrowthTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cGDPGrowthTextBox.Location = new System.Drawing.Point(23, 48);
            this.cGDPGrowthTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cGDPGrowthTextBox.Name = "cGDPGrowthTextBox";
            this.cGDPGrowthTextBox.Size = new System.Drawing.Size(340, 24);
            this.cGDPGrowthTextBox.TabIndex = 0;
            this.cGDPGrowthTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cGDPGrowthTextBox_KeyDown);
            // 
            // cGDPGrowthLabel
            // 
            this.cGDPGrowthLabel.AutoSize = true;
            this.cGDPGrowthLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cGDPGrowthLabel.Location = new System.Drawing.Point(20, 25);
            this.cGDPGrowthLabel.Margin = new System.Windows.Forms.Padding(0);
            this.cGDPGrowthLabel.Name = "cGDPGrowthLabel";
            this.cGDPGrowthLabel.Size = new System.Drawing.Size(346, 13);
            this.cGDPGrowthLabel.TabIndex = 1;
            this.cGDPGrowthLabel.Text = "GDP Growth:";
            // 
            // cNamePanel
            // 
            this.cNamePanel.ColumnCount = 1;
            this.cNamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cNamePanel.Controls.Add(this.cNameTextBox, 0, 1);
            this.cNamePanel.Controls.Add(this.cNameLabel, 0, 0);
            this.cNamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cNamePanel.Location = new System.Drawing.Point(3, 3);
            this.cNamePanel.Name = "cNamePanel";
            this.cNamePanel.Padding = new System.Windows.Forms.Padding(20);
            this.cNamePanel.RowCount = 2;
            this.cNamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.cNamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.cNamePanel.Size = new System.Drawing.Size(384, 102);
            this.cNamePanel.TabIndex = 0;
            // 
            // cNameTextBox
            // 
            this.cNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cNameTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cNameTextBox.Location = new System.Drawing.Point(23, 48);
            this.cNameTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cNameTextBox.Name = "cNameTextBox";
            this.cNameTextBox.Size = new System.Drawing.Size(338, 24);
            this.cNameTextBox.TabIndex = 0;
            this.cNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cNameTextBox_KeyDown);
            // 
            // cNameLabel
            // 
            this.cNameLabel.AutoSize = true;
            this.cNameLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cNameLabel.Location = new System.Drawing.Point(20, 25);
            this.cNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.cNameLabel.Name = "cNameLabel";
            this.cNameLabel.Size = new System.Drawing.Size(344, 13);
            this.cNameLabel.TabIndex = 1;
            this.cNameLabel.Text = "Country Name:";
            // 
            // cMainTradePartnersContainer
            // 
            this.cMainTradePartnersContainer.ColumnCount = 1;
            this.dataTableContainer.SetColumnSpan(this.cMainTradePartnersContainer, 2);
            this.cMainTradePartnersContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cMainTradePartnersContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.cMainTradePartnersContainer.Controls.Add(this.cMainTradePartnersPanel, 0, 0);
            this.cMainTradePartnersContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cMainTradePartnersContainer.Location = new System.Drawing.Point(3, 359);
            this.cMainTradePartnersContainer.Name = "cMainTradePartnersContainer";
            this.cMainTradePartnersContainer.Padding = new System.Windows.Forms.Padding(20);
            this.cMainTradePartnersContainer.RowCount = 1;
            this.dataTableContainer.SetRowSpan(this.cMainTradePartnersContainer, 2);
            this.cMainTradePartnersContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cMainTradePartnersContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 239F));
            this.cMainTradePartnersContainer.Size = new System.Drawing.Size(776, 279);
            this.cMainTradePartnersContainer.TabIndex = 5;
            // 
            // cMainTradePartnersPanel
            // 
            this.cMainTradePartnersPanel.Controls.Add(this.cMainTradePartnersList);
            this.cMainTradePartnersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cMainTradePartnersPanel.Location = new System.Drawing.Point(23, 23);
            this.cMainTradePartnersPanel.Name = "cMainTradePartnersPanel";
            this.cMainTradePartnersPanel.Padding = new System.Windows.Forms.Padding(13, 7, 13, 7);
            this.cMainTradePartnersPanel.Size = new System.Drawing.Size(730, 233);
            this.cMainTradePartnersPanel.TabIndex = 0;
            this.cMainTradePartnersPanel.TabStop = false;
            this.cMainTradePartnersPanel.Text = "Main Trade Partners:";
            // 
            // cMainTradePartnersList
            // 
            this.cMainTradePartnersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cMainTradePartnersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mtpName,
            this.mtpGDPGrowth,
            this.mtpInflation,
            this.mtpTradeBalance,
            this.mtpHDIRanking});
            this.cMainTradePartnersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cMainTradePartnersList.GridLines = true;
            this.cMainTradePartnersList.Location = new System.Drawing.Point(13, 20);
            this.cMainTradePartnersList.Name = "cMainTradePartnersList";
            this.cMainTradePartnersList.Size = new System.Drawing.Size(704, 206);
            this.cMainTradePartnersList.TabIndex = 0;
            this.cMainTradePartnersList.UseCompatibleStateImageBehavior = false;
            this.cMainTradePartnersList.View = System.Windows.Forms.View.Details;
            this.cMainTradePartnersList.SelectedIndexChanged += new System.EventHandler(this.cMainTradePartnersList_SelectedIndexChanged);
            // 
            // mtpName
            // 
            this.mtpName.Text = "Country Name";
            this.mtpName.Width = 307;
            // 
            // mtpGDPGrowth
            // 
            this.mtpGDPGrowth.Text = "GDP Growth";
            this.mtpGDPGrowth.Width = 90;
            // 
            // mtpInflation
            // 
            this.mtpInflation.Text = "Inflation Rate";
            this.mtpInflation.Width = 90;
            // 
            // mtpTradeBalance
            // 
            this.mtpTradeBalance.Text = "Trade Balance";
            this.mtpTradeBalance.Width = 110;
            // 
            // mtpHDIRanking
            // 
            this.mtpHDIRanking.Text = "HDI Ranking";
            this.mtpHDIRanking.Width = 90;
            // 
            // cSaveCountryPanel
            // 
            this.cSaveCountryPanel.ColumnCount = 1;
            this.cSaveCountryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cSaveCountryPanel.Controls.Add(this.cSaveCountryButton, 0, 0);
            this.cSaveCountryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cSaveCountryPanel.Location = new System.Drawing.Point(393, 219);
            this.cSaveCountryPanel.Name = "cSaveCountryPanel";
            this.cSaveCountryPanel.Padding = new System.Windows.Forms.Padding(50, 30, 50, 30);
            this.cSaveCountryPanel.RowCount = 1;
            this.cSaveCountryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cSaveCountryPanel.Size = new System.Drawing.Size(386, 102);
            this.cSaveCountryPanel.TabIndex = 6;
            // 
            // cSaveCountryButton
            // 
            this.cSaveCountryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.cSaveCountryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cSaveCountryButton.Location = new System.Drawing.Point(53, 33);
            this.cSaveCountryButton.Name = "cSaveCountryButton";
            this.cSaveCountryButton.Size = new System.Drawing.Size(280, 36);
            this.cSaveCountryButton.TabIndex = 0;
            this.cSaveCountryButton.Text = "Save Changes";
            this.cSaveCountryButton.UseVisualStyleBackColor = true;
            this.cSaveCountryButton.Click += new System.EventHandler(this.cSaveCountryButton_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 673);
            this.Controls.Add(this.countriesListContainer);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "International Trading Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.countriesListContainer.ResumeLayout(false);
            this.dataTableContainer.ResumeLayout(false);
            this.cHDIRankingPanel.ResumeLayout(false);
            this.cHDIRankingPanel.PerformLayout();
            this.cTradeBalancePanel.ResumeLayout(false);
            this.cTradeBalancePanel.PerformLayout();
            this.cInflationPanel.ResumeLayout(false);
            this.cInflationPanel.PerformLayout();
            this.cGDPGrowthPanel.ResumeLayout(false);
            this.cGDPGrowthPanel.PerformLayout();
            this.cNamePanel.ResumeLayout(false);
            this.cNamePanel.PerformLayout();
            this.cMainTradePartnersContainer.ResumeLayout(false);
            this.cMainTradePartnersPanel.ResumeLayout(false);
            this.cSaveCountryPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel countriesListContainer;
        private System.Windows.Forms.TableLayoutPanel dataTableContainer;
        private System.Windows.Forms.TableLayoutPanel cNamePanel;
        private System.Windows.Forms.TextBox cNameTextBox;
        private System.Windows.Forms.Label cNameLabel;
        private System.Windows.Forms.TableLayoutPanel cGDPGrowthPanel;
        private System.Windows.Forms.TextBox cGDPGrowthTextBox;
        private System.Windows.Forms.Label cGDPGrowthLabel;
        private System.Windows.Forms.TableLayoutPanel cHDIRankingPanel;
        private System.Windows.Forms.TextBox cHDIRankingTextBox;
        private System.Windows.Forms.Label cHDIRankingLabel;
        private System.Windows.Forms.TableLayoutPanel cTradeBalancePanel;
        private System.Windows.Forms.TextBox cTradeBalanceTextBox;
        private System.Windows.Forms.Label cTradeBalanceLabel;
        private System.Windows.Forms.TableLayoutPanel cInflationPanel;
        private System.Windows.Forms.TextBox cInflationTextBox;
        private System.Windows.Forms.Label cInflationLabel;
        private System.Windows.Forms.TableLayoutPanel cMainTradePartnersContainer;
        private System.Windows.Forms.GroupBox cMainTradePartnersPanel;
        private System.Windows.Forms.ListView cMainTradePartnersList;
        private System.Windows.Forms.ColumnHeader mtpName;
        private System.Windows.Forms.ColumnHeader mtpGDPGrowth;
        private System.Windows.Forms.ColumnHeader mtpInflation;
        private System.Windows.Forms.ColumnHeader mtpTradeBalance;
        private System.Windows.Forms.ColumnHeader mtpHDIRanking;
        private System.Windows.Forms.ColumnHeader countryName;
        public System.Windows.Forms.ListView countriesList;
        private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        public System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.TableLayoutPanel cSaveCountryPanel;
        private System.Windows.Forms.Button cSaveCountryButton;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
    }
}

