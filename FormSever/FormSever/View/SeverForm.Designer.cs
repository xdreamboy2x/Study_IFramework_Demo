﻿using System;

namespace FormSever
{
    partial class SeverForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Clear = new System.Windows.Forms.Button();
            this.logView = new System.Windows.Forms.ListView();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Pages = new System.Windows.Forms.TabControl();
            this.TCP = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TCPTimeOut = new System.Windows.Forms.TextBox();
            this.TcpCheckSpace = new System.Windows.Forms.TextBox();
            this.TCPMaxCon = new System.Windows.Forms.TextBox();
            this.TCPPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TCPBufferSize = new System.Windows.Forms.TextBox();
            this.Net_Fresh = new System.Windows.Forms.Button();
            this.LogPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Log_ErrLev = new System.Windows.Forms.TextBox();
            this.Log_WarnLev = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Log_LogLev = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Log_ErrEnable = new System.Windows.Forms.CheckBox();
            this.Log_WarnEnable = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Log_FontSize = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Log_LogEnable = new System.Windows.Forms.CheckBox();
            this.Log_Enable = new System.Windows.Forms.CheckBox();
            this.Log_Fresh = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.data_save = new System.Windows.Forms.Button();
            this.SendMessagePage = new System.Windows.Forms.TabPage();
            this.Message_gap_slider = new System.Windows.Forms.HScrollBar();
            this.MessageGap = new System.Windows.Forms.Label();
            this.MessageCount = new System.Windows.Forms.Label();
            this.MesaggSlider = new System.Windows.Forms.HScrollBar();
            this.message_send = new System.Windows.Forms.Button();
            this.message_message = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Port = new System.Windows.Forms.TextBox();
            this.Port000 = new System.Windows.Forms.Label();
            this.Run = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.Pages.SuspendLayout();
            this.TCP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.LogPage.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SendMessagePage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear.Location = new System.Drawing.Point(1080, 0);
            this.Clear.Margin = new System.Windows.Forms.Padding(0);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(72, 22);
            this.Clear.TabIndex = 0;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.LogClear);
            // 
            // logView
            // 
            this.logView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.logView.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logView.HideSelection = false;
            this.logView.Location = new System.Drawing.Point(0, 0);
            this.logView.Margin = new System.Windows.Forms.Padding(0);
            this.logView.Name = "logView";
            this.logView.Size = new System.Drawing.Size(1068, 217);
            this.logView.TabIndex = 1;
            this.logView.UseCompatibleStateImageBehavior = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 24);
            this.toolStripMenuItem1.Text = "Tool";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1216, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Pages
            // 
            this.Pages.Controls.Add(this.TCP);
            this.Pages.Controls.Add(this.LogPage);
            this.Pages.Controls.Add(this.tabPage1);
            this.Pages.Controls.Add(this.SendMessagePage);
            this.Pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pages.Font = new System.Drawing.Font("宋体", 15F);
            this.Pages.Location = new System.Drawing.Point(0, 0);
            this.Pages.Margin = new System.Windows.Forms.Padding(0);
            this.Pages.Name = "Pages";
            this.Pages.SelectedIndex = 0;
            this.Pages.Size = new System.Drawing.Size(1160, 356);
            this.Pages.TabIndex = 7;
            // 
            // TCP
            // 
            this.TCP.BackColor = System.Drawing.SystemColors.GrayText;
            this.TCP.Controls.Add(this.groupBox1);
            this.TCP.Controls.Add(this.Net_Fresh);
            this.TCP.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TCP.Location = new System.Drawing.Point(4, 35);
            this.TCP.Margin = new System.Windows.Forms.Padding(0);
            this.TCP.Name = "TCP";
            this.TCP.Size = new System.Drawing.Size(1152, 317);
            this.TCP.TabIndex = 0;
            this.TCP.Text = "NET";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 15F);
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(32, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(368, 270);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TCP";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.TCPTimeOut, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.TcpCheckSpace, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.TCPMaxCon, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.TCPPort, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.TCPBufferSize, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 29);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(368, 241);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // TCPTimeOut
            // 
            this.TCPTimeOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCPTimeOut.Location = new System.Drawing.Point(142, 192);
            this.TCPTimeOut.Margin = new System.Windows.Forms.Padding(0);
            this.TCPTimeOut.Name = "TCPTimeOut";
            this.TCPTimeOut.Size = new System.Drawing.Size(268, 36);
            this.TCPTimeOut.TabIndex = 9;
            // 
            // TcpCheckSpace
            // 
            this.TcpCheckSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TcpCheckSpace.Location = new System.Drawing.Point(142, 144);
            this.TcpCheckSpace.Margin = new System.Windows.Forms.Padding(0);
            this.TcpCheckSpace.Name = "TcpCheckSpace";
            this.TcpCheckSpace.Size = new System.Drawing.Size(268, 36);
            this.TcpCheckSpace.TabIndex = 8;
            // 
            // TCPMaxCon
            // 
            this.TCPMaxCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCPMaxCon.Location = new System.Drawing.Point(142, 96);
            this.TCPMaxCon.Margin = new System.Windows.Forms.Padding(0);
            this.TCPMaxCon.Name = "TCPMaxCon";
            this.TCPMaxCon.Size = new System.Drawing.Size(268, 36);
            this.TCPMaxCon.TabIndex = 7;
            // 
            // TCPPort
            // 
            this.TCPPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCPPort.Location = new System.Drawing.Point(142, 48);
            this.TCPPort.Margin = new System.Windows.Forms.Padding(0);
            this.TCPPort.Name = "TCPPort";
            this.TCPPort.Size = new System.Drawing.Size(268, 36);
            this.TCPPort.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "BufferSize";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "MaxConn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "TimeOut";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "CheckSpace";
            // 
            // TCPBufferSize
            // 
            this.TCPBufferSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCPBufferSize.Location = new System.Drawing.Point(142, 0);
            this.TCPBufferSize.Margin = new System.Windows.Forms.Padding(0);
            this.TCPBufferSize.Name = "TCPBufferSize";
            this.TCPBufferSize.Size = new System.Drawing.Size(268, 36);
            this.TCPBufferSize.TabIndex = 5;
            // 
            // Net_Fresh
            // 
            this.Net_Fresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Net_Fresh.BackColor = System.Drawing.Color.DimGray;
            this.Net_Fresh.ForeColor = System.Drawing.Color.SeaShell;
            this.Net_Fresh.Location = new System.Drawing.Point(1009, 241);
            this.Net_Fresh.Margin = new System.Windows.Forms.Padding(0);
            this.Net_Fresh.Name = "Net_Fresh";
            this.Net_Fresh.Size = new System.Drawing.Size(122, 38);
            this.Net_Fresh.TabIndex = 8;
            this.Net_Fresh.Text = "Fresh";
            this.Net_Fresh.UseVisualStyleBackColor = false;
            this.Net_Fresh.Click += new System.EventHandler(this.Net_Fresh_Click);
            // 
            // LogPage
            // 
            this.LogPage.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.LogPage.Controls.Add(this.tableLayoutPanel5);
            this.LogPage.Controls.Add(this.tableLayoutPanel4);
            this.LogPage.Controls.Add(this.Log_Fresh);
            this.LogPage.ForeColor = System.Drawing.Color.YellowGreen;
            this.LogPage.Location = new System.Drawing.Point(4, 35);
            this.LogPage.Margin = new System.Windows.Forms.Padding(0);
            this.LogPage.Name = "LogPage";
            this.LogPage.Size = new System.Drawing.Size(1152, 317);
            this.LogPage.TabIndex = 1;
            this.LogPage.Text = "Log";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.Log_ErrLev, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.Log_WarnLev, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label17, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.Log_LogLev, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label20, 0, 0);
            this.tableLayoutPanel5.Font = new System.Drawing.Font("宋体", 15F);
            this.tableLayoutPanel5.ForeColor = System.Drawing.Color.Yellow;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(458, 120);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(368, 158);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // Log_ErrLev
            // 
            this.Log_ErrLev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Log_ErrLev.Location = new System.Drawing.Point(103, 104);
            this.Log_ErrLev.Margin = new System.Windows.Forms.Padding(0);
            this.Log_ErrLev.Name = "Log_ErrLev";
            this.Log_ErrLev.Size = new System.Drawing.Size(268, 36);
            this.Log_ErrLev.TabIndex = 7;
            // 
            // Log_WarnLev
            // 
            this.Log_WarnLev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Log_WarnLev.Location = new System.Drawing.Point(103, 52);
            this.Log_WarnLev.Margin = new System.Windows.Forms.Padding(0);
            this.Log_WarnLev.Name = "Log_WarnLev";
            this.Log_WarnLev.Size = new System.Drawing.Size(268, 36);
            this.Log_WarnLev.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 52);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "WarnLev";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(0, 104);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 25);
            this.label17.TabIndex = 2;
            this.label17.Text = "ErrLev";
            // 
            // Log_LogLev
            // 
            this.Log_LogLev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Log_LogLev.Location = new System.Drawing.Point(103, 0);
            this.Log_LogLev.Margin = new System.Windows.Forms.Padding(0);
            this.Log_LogLev.Name = "Log_LogLev";
            this.Log_LogLev.Size = new System.Drawing.Size(268, 36);
            this.Log_LogLev.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(0, 0);
            this.label20.Margin = new System.Windows.Forms.Padding(0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 25);
            this.label20.TabIndex = 0;
            this.label20.Text = "LogLev";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.Log_ErrEnable, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.Log_WarnEnable, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label14, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label15, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label16, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.Log_FontSize, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Log_LogEnable, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.Log_Enable, 1, 1);
            this.tableLayoutPanel4.Font = new System.Drawing.Font("宋体", 15F);
            this.tableLayoutPanel4.ForeColor = System.Drawing.Color.Yellow;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(48, 30);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(368, 248);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // Log_ErrEnable
            // 
            this.Log_ErrEnable.AutoSize = true;
            this.Log_ErrEnable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Log_ErrEnable.Checked = true;
            this.Log_ErrEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Log_ErrEnable.Location = new System.Drawing.Point(145, 199);
            this.Log_ErrEnable.Name = "Log_ErrEnable";
            this.Log_ErrEnable.Size = new System.Drawing.Size(18, 17);
            this.Log_ErrEnable.TabIndex = 9;
            this.Log_ErrEnable.UseVisualStyleBackColor = true;
            // 
            // Log_WarnEnable
            // 
            this.Log_WarnEnable.AutoSize = true;
            this.Log_WarnEnable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Log_WarnEnable.Checked = true;
            this.Log_WarnEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Log_WarnEnable.Location = new System.Drawing.Point(145, 150);
            this.Log_WarnEnable.Name = "Log_WarnEnable";
            this.Log_WarnEnable.Size = new System.Drawing.Size(18, 17);
            this.Log_WarnEnable.TabIndex = 8;
            this.Log_WarnEnable.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(0, 49);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "Enable";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(0, 98);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 25);
            this.label14.TabIndex = 2;
            this.label14.Text = "LogEnable";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(0, 196);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 25);
            this.label15.TabIndex = 3;
            this.label15.Text = "ErrEnable";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(0, 147);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(142, 25);
            this.label16.TabIndex = 4;
            this.label16.Text = "WarnEnable";
            // 
            // Log_FontSize
            // 
            this.Log_FontSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Log_FontSize.Location = new System.Drawing.Point(142, 0);
            this.Log_FontSize.Margin = new System.Windows.Forms.Padding(0);
            this.Log_FontSize.Name = "Log_FontSize";
            this.Log_FontSize.Size = new System.Drawing.Size(268, 36);
            this.Log_FontSize.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "FontSize";
            // 
            // Log_LogEnable
            // 
            this.Log_LogEnable.AutoSize = true;
            this.Log_LogEnable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Log_LogEnable.Checked = true;
            this.Log_LogEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Log_LogEnable.Location = new System.Drawing.Point(145, 101);
            this.Log_LogEnable.Name = "Log_LogEnable";
            this.Log_LogEnable.Size = new System.Drawing.Size(18, 17);
            this.Log_LogEnable.TabIndex = 7;
            this.Log_LogEnable.UseVisualStyleBackColor = true;
            // 
            // Log_Enable
            // 
            this.Log_Enable.AutoSize = true;
            this.Log_Enable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Log_Enable.Checked = true;
            this.Log_Enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Log_Enable.Location = new System.Drawing.Point(145, 52);
            this.Log_Enable.Name = "Log_Enable";
            this.Log_Enable.Size = new System.Drawing.Size(18, 17);
            this.Log_Enable.TabIndex = 10;
            this.Log_Enable.UseVisualStyleBackColor = true;
            // 
            // Log_Fresh
            // 
            this.Log_Fresh.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Log_Fresh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Log_Fresh.Location = new System.Drawing.Point(1048, 255);
            this.Log_Fresh.Margin = new System.Windows.Forms.Padding(0);
            this.Log_Fresh.Name = "Log_Fresh";
            this.Log_Fresh.Size = new System.Drawing.Size(96, 45);
            this.Log_Fresh.TabIndex = 2;
            this.Log_Fresh.Text = "Fresh";
            this.Log_Fresh.UseVisualStyleBackColor = false;
            this.Log_Fresh.Click += new System.EventHandler(this.Log_Fresh_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Picture);
            this.tabPage1.Controls.Add(this.data_save);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1152, 317);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Picture
            // 
            this.Picture.Location = new System.Drawing.Point(3, 3);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(300, 300);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 1;
            this.Picture.TabStop = false;
            // 
            // data_save
            // 
            this.data_save.Location = new System.Drawing.Point(803, 146);
            this.data_save.Name = "data_save";
            this.data_save.Size = new System.Drawing.Size(201, 77);
            this.data_save.TabIndex = 0;
            this.data_save.Text = "save";
            this.data_save.UseVisualStyleBackColor = true;
            this.data_save.Click += new System.EventHandler(this.data_save_Click);
            // 
            // SendMessagePage
            // 
            this.SendMessagePage.Controls.Add(this.Message_gap_slider);
            this.SendMessagePage.Controls.Add(this.MessageGap);
            this.SendMessagePage.Controls.Add(this.MessageCount);
            this.SendMessagePage.Controls.Add(this.MesaggSlider);
            this.SendMessagePage.Controls.Add(this.message_send);
            this.SendMessagePage.Controls.Add(this.message_message);
            this.SendMessagePage.Location = new System.Drawing.Point(4, 35);
            this.SendMessagePage.Name = "SendMessagePage";
            this.SendMessagePage.Padding = new System.Windows.Forms.Padding(3);
            this.SendMessagePage.Size = new System.Drawing.Size(1152, 317);
            this.SendMessagePage.TabIndex = 3;
            this.SendMessagePage.Text = "SendMessage";
            this.SendMessagePage.UseVisualStyleBackColor = true;
            // 
            // Message_gap_slider
            // 
            this.Message_gap_slider.Location = new System.Drawing.Point(31, 244);
            this.Message_gap_slider.Minimum = -1;
            this.Message_gap_slider.Name = "Message_gap_slider";
            this.Message_gap_slider.Size = new System.Drawing.Size(677, 21);
            this.Message_gap_slider.TabIndex = 5;
            this.Message_gap_slider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Message_gap_slider_Scroll);
            // 
            // MessageGap
            // 
            this.MessageGap.AutoSize = true;
            this.MessageGap.Location = new System.Drawing.Point(26, 187);
            this.MessageGap.Name = "MessageGap";
            this.MessageGap.Size = new System.Drawing.Size(168, 25);
            this.MessageGap.TabIndex = 4;
            this.MessageGap.Text = "label6666666";
            // 
            // MessageCount
            // 
            this.MessageCount.AutoSize = true;
            this.MessageCount.Location = new System.Drawing.Point(26, 86);
            this.MessageCount.Name = "MessageCount";
            this.MessageCount.Size = new System.Drawing.Size(168, 25);
            this.MessageCount.TabIndex = 3;
            this.MessageCount.Text = "label6666666";
            // 
            // MesaggSlider
            // 
            this.MesaggSlider.Location = new System.Drawing.Point(31, 137);
            this.MesaggSlider.Minimum = -1;
            this.MesaggSlider.Name = "MesaggSlider";
            this.MesaggSlider.Size = new System.Drawing.Size(677, 21);
            this.MesaggSlider.TabIndex = 2;
            this.MesaggSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // message_send
            // 
            this.message_send.Location = new System.Drawing.Point(791, 226);
            this.message_send.Name = "message_send";
            this.message_send.Size = new System.Drawing.Size(252, 60);
            this.message_send.TabIndex = 1;
            this.message_send.Text = "Send";
            this.message_send.UseVisualStyleBackColor = true;
            this.message_send.Click += new System.EventHandler(this.message_send_Click);
            // 
            // message_message
            // 
            this.message_message.Location = new System.Drawing.Point(22, 19);
            this.message_message.Name = "message_message";
            this.message_message.Size = new System.Drawing.Size(812, 36);
            this.message_message.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logView);
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 228);
            this.panel1.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Pages);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1160, 592);
            this.splitContainer1.SplitterDistance = 356;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Location = new System.Drawing.Point(16, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 592);
            this.panel2.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.68159F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.31841F));
            this.tableLayoutPanel1.Controls.Add(this.Port, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Port000, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Run, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(873, 101);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(122, 3);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(226, 25);
            this.Port.TabIndex = 2;
            // 
            // Port000
            // 
            this.Port000.AutoSize = true;
            this.Port000.Location = new System.Drawing.Point(3, 0);
            this.Port000.Name = "Port000";
            this.Port000.Size = new System.Drawing.Size(0, 15);
            this.Port000.TabIndex = 3;
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(122, 53);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(75, 23);
            this.Run.TabIndex = 4;
            // 
            // SeverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 630);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SeverForm";
            this.Text = "Sever";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Pages.ResumeLayout(false);
            this.TCP.ResumeLayout(false);
            this.TCP.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.LogPage.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.SendMessagePage.ResumeLayout(false);
            this.SendMessagePage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ListView logView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl Pages;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage TCP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.Label Port000;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Button Net_Fresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox TCPTimeOut;
        private System.Windows.Forms.TextBox TcpCheckSpace;
        private System.Windows.Forms.TextBox TCPMaxCon;
        private System.Windows.Forms.TextBox TCPPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TCPBufferSize;
        private System.Windows.Forms.TabPage LogPage;
        private System.Windows.Forms.Button Log_Fresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Log_FontSize;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox Log_ErrLev;
        private System.Windows.Forms.TextBox Log_WarnLev;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Log_LogLev;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox Log_LogEnable;
        private System.Windows.Forms.CheckBox Log_ErrEnable;
        private System.Windows.Forms.CheckBox Log_WarnEnable;
        private System.Windows.Forms.CheckBox Log_Enable;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button data_save;
        public System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.TabPage SendMessagePage;
        private System.Windows.Forms.TextBox message_message;
        private System.Windows.Forms.Button message_send;
        private System.Windows.Forms.HScrollBar MesaggSlider;
        private System.Windows.Forms.Label MessageCount;
        private System.Windows.Forms.HScrollBar Message_gap_slider;
        private System.Windows.Forms.Label MessageGap;
    }
  
}

