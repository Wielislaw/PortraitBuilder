﻿using System;

namespace PortraitBuilder.UI {
	partial class PortraitBuilderForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
				previewImage.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortraitBuilderForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label24 = new System.Windows.Forms.Label();
			this.cbGovernment = new System.Windows.Forms.ComboBox();
			this.label22 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCopy = new System.Windows.Forms.Button();
			this.tbDNA = new System.Windows.Forms.TextBox();
			this.pbPortrait = new System.Windows.Forms.PictureBox();
			this.cbRank = new System.Windows.Forms.ComboBox();
			this.label20 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabDNA = new System.Windows.Forms.TabPage();
			this.panelDNA = new System.Windows.Forms.FlowLayoutPanel();
			this.tabProperties = new System.Windows.Forms.TabPage();
			this.panelProperties = new System.Windows.Forms.FlowLayoutPanel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbPeriod = new System.Windows.Forms.ComboBox();
			this.cbAge = new System.Windows.Forms.ComboBox();
			this.cbSex = new System.Windows.Forms.ComboBox();
			this.cbCulturePortraitTypes = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.btnRandom = new System.Windows.Forms.Button();
			this.btnImport = new System.Windows.Forms.Button();
			this.cbPortraitTypes = new System.Windows.Forms.ComboBox();
			this.tabContent = new System.Windows.Forms.TabControl();
			this.tabDLCs = new System.Windows.Forms.TabPage();
			this.panelDLCs = new System.Windows.Forms.FlowLayoutPanel();
			this.tabMods = new System.Windows.Forms.TabPage();
			this.panelMods = new System.Windows.Forms.FlowLayoutPanel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnToogleAll = new System.Windows.Forms.Button();
			this.btnReload = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbPortrait)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabDNA.SuspendLayout();
			this.tabProperties.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tabContent.SuspendLayout();
			this.tabDLCs.SuspendLayout();
			this.tabMods.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label24);
			this.groupBox1.Controls.Add(this.cbGovernment);
			this.groupBox1.Controls.Add(this.label22);
			this.groupBox1.Controls.Add(this.btnSave);
			this.groupBox1.Controls.Add(this.btnCopy);
			this.groupBox1.Controls.Add(this.tbDNA);
			this.groupBox1.Controls.Add(this.pbPortrait);
			this.groupBox1.Controls.Add(this.cbRank);
			this.groupBox1.Controls.Add(this.label20);
			this.groupBox1.Location = new System.Drawing.Point(491, 10);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(188, 492);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Output";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(9, 22);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(33, 13);
			this.label24.TabIndex = 26;
			this.label24.Text = "Govt:";
			// 
			// cbGovernment
			// 
			this.cbGovernment.FormattingEnabled = true;
			this.cbGovernment.Items.AddRange(new object[] {
            "Feudal",
            "Iqta",
            "Theocracy",
            "Republic",
            "Merchant Republic",
            "Tribal",
            "Nomadic"});
			this.cbGovernment.Location = new System.Drawing.Point(45, 19);
			this.cbGovernment.Name = "cbGovernment";
			this.cbGovernment.Size = new System.Drawing.Size(136, 21);
			this.cbGovernment.TabIndex = 25;
			this.cbGovernment.SelectedIndexChanged += new System.EventHandler(this.onChangeGovernment);
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(3, 371);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(181, 26);
			this.label22.TabIndex = 24;
			this.label22.Text = "*Warning: properties are dynamically \r\noverridden by portrait_properties.txt";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(6, 463);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 22;
			this.btnSave.Text = "Save Image";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.onClickSave);
			// 
			// btnCopy
			// 
			this.btnCopy.Location = new System.Drawing.Point(107, 463);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(75, 23);
			this.btnCopy.TabIndex = 23;
			this.btnCopy.Text = "Copy";
			this.btnCopy.UseVisualStyleBackColor = true;
			this.btnCopy.Click += new System.EventHandler(this.onClickCopy);
			// 
			// tbDNA
			// 
			this.tbDNA.Location = new System.Drawing.Point(6, 303);
			this.tbDNA.Multiline = true;
			this.tbDNA.Name = "tbDNA";
			this.tbDNA.ReadOnly = true;
			this.tbDNA.Size = new System.Drawing.Size(176, 51);
			this.tbDNA.TabIndex = 23;
			this.tbDNA.TabStop = false;
			this.tbDNA.Text = "dna\r\nproperties";
			// 
			// pbPortrait
			// 
			this.pbPortrait.Location = new System.Drawing.Point(6, 102);
			this.pbPortrait.Name = "pbPortrait";
			this.pbPortrait.Size = new System.Drawing.Size(176, 176);
			this.pbPortrait.TabIndex = 0;
			this.pbPortrait.TabStop = false;
			// 
			// cbRank
			// 
			this.cbRank.FormattingEnabled = true;
			this.cbRank.Items.AddRange(new object[] {
            "None",
            "Baron",
            "Count",
            "Duke",
            "King",
            "Emperor"});
			this.cbRank.Location = new System.Drawing.Point(45, 46);
			this.cbRank.Name = "cbRank";
			this.cbRank.Size = new System.Drawing.Size(136, 21);
			this.cbRank.TabIndex = 21;
			this.cbRank.SelectedIndexChanged += new System.EventHandler(this.onChangeRank);
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(6, 49);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(36, 13);
			this.label20.TabIndex = 2;
			this.label20.Text = "Rank:";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabDNA);
			this.tabControl1.Controls.Add(this.tabProperties);
			this.tabControl1.Location = new System.Drawing.Point(6, 96);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(228, 362);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControl1.TabIndex = 3;
			// 
			// tabDNA
			// 
			this.tabDNA.Controls.Add(this.panelDNA);
			this.tabDNA.Location = new System.Drawing.Point(4, 22);
			this.tabDNA.Name = "tabDNA";
			this.tabDNA.Padding = new System.Windows.Forms.Padding(3);
			this.tabDNA.Size = new System.Drawing.Size(220, 336);
			this.tabDNA.TabIndex = 0;
			this.tabDNA.Text = "DNA";
			this.tabDNA.UseVisualStyleBackColor = true;
			// 
			// panelDNA
			// 
			this.panelDNA.AutoScroll = true;
			this.panelDNA.Location = new System.Drawing.Point(3, 6);
			this.panelDNA.Name = "panelDNA";
			this.panelDNA.Size = new System.Drawing.Size(211, 327);
			this.panelDNA.TabIndex = 1;
			// 
			// tabProperties
			// 
			this.tabProperties.Controls.Add(this.panelProperties);
			this.tabProperties.Location = new System.Drawing.Point(4, 22);
			this.tabProperties.Name = "tabProperties";
			this.tabProperties.Padding = new System.Windows.Forms.Padding(3);
			this.tabProperties.Size = new System.Drawing.Size(220, 336);
			this.tabProperties.TabIndex = 1;
			this.tabProperties.Text = "Properties*";
			this.tabProperties.UseVisualStyleBackColor = true;
			// 
			// panelProperties
			// 
			this.panelProperties.AutoScroll = true;
			this.panelProperties.Location = new System.Drawing.Point(4, 6);
			this.panelProperties.Name = "panelProperties";
			this.panelProperties.Size = new System.Drawing.Size(210, 325);
			this.panelProperties.TabIndex = 2;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.cbPeriod);
			this.groupBox2.Controls.Add(this.cbAge);
			this.groupBox2.Controls.Add(this.cbSex);
			this.groupBox2.Controls.Add(this.cbCulturePortraitTypes);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.label21);
			this.groupBox2.Controls.Add(this.btnRandom);
			this.groupBox2.Controls.Add(this.btnImport);
			this.groupBox2.Controls.Add(this.cbPortraitTypes);
			this.groupBox2.Controls.Add(this.tabControl1);
			this.groupBox2.Location = new System.Drawing.Point(245, 10);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(240, 492);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Input";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(114, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 13);
			this.label2.TabIndex = 30;
			this.label2.Text = "Sex:";
			// 
			// cbPeriod
			// 
			this.cbPeriod.FormattingEnabled = true;
			this.cbPeriod.Location = new System.Drawing.Point(191, 38);
			this.cbPeriod.Name = "cbPeriod";
			this.cbPeriod.Size = new System.Drawing.Size(43, 21);
			this.cbPeriod.TabIndex = 29;
			// 
			// cbAge
			// 
			this.cbAge.FormattingEnabled = true;
			this.cbAge.Location = new System.Drawing.Point(154, 38);
			this.cbAge.Name = "cbAge";
			this.cbAge.Size = new System.Drawing.Size(31, 21);
			this.cbAge.TabIndex = 28;
			// 
			// cbSex
			// 
			this.cbSex.FormattingEnabled = true;
			this.cbSex.Location = new System.Drawing.Point(117, 38);
			this.cbSex.Name = "cbSex";
			this.cbSex.Size = new System.Drawing.Size(31, 21);
			this.cbSex.TabIndex = 27;
			// 
			// cbCulturePortraitTypes
			// 
			this.cbCulturePortraitTypes.FormattingEnabled = true;
			this.cbCulturePortraitTypes.Location = new System.Drawing.Point(50, 65);
			this.cbCulturePortraitTypes.Name = "cbCulturePortraitTypes";
			this.cbCulturePortraitTypes.Size = new System.Drawing.Size(184, 21);
			this.cbCulturePortraitTypes.TabIndex = 26;
			this.cbCulturePortraitTypes.SelectedIndexChanged += new System.EventHandler(this.onChangePortraitType);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 13);
			this.label1.TabIndex = 25;
			this.label1.Text = "Clothing:";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(3, 22);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(43, 13);
			this.label21.TabIndex = 24;
			this.label21.Text = "Portrait:";
			// 
			// btnRandom
			// 
			this.btnRandom.Location = new System.Drawing.Point(155, 462);
			this.btnRandom.Name = "btnRandom";
			this.btnRandom.Size = new System.Drawing.Size(75, 23);
			this.btnRandom.TabIndex = 11;
			this.btnRandom.Text = "Randomize";
			this.btnRandom.UseVisualStyleBackColor = true;
			this.btnRandom.Click += new System.EventHandler(this.onClickRandomize);
			// 
			// btnImport
			// 
			this.btnImport.Location = new System.Drawing.Point(9, 462);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(75, 23);
			this.btnImport.TabIndex = 11;
			this.btnImport.Text = "Import";
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new System.EventHandler(this.onClickImport);
			// 
			// cbPortraitTypes
			// 
			this.cbPortraitTypes.FormattingEnabled = true;
			this.cbPortraitTypes.Location = new System.Drawing.Point(6, 38);
			this.cbPortraitTypes.Name = "cbPortraitTypes";
			this.cbPortraitTypes.Size = new System.Drawing.Size(105, 21);
			this.cbPortraitTypes.TabIndex = 2;
			this.cbPortraitTypes.SelectedIndexChanged += new System.EventHandler(this.onChangePortraitType);
			// 
			// tabContent
			// 
			this.tabContent.Controls.Add(this.tabDLCs);
			this.tabContent.Controls.Add(this.tabMods);
			this.tabContent.Location = new System.Drawing.Point(6, 17);
			this.tabContent.Name = "tabContent";
			this.tabContent.SelectedIndex = 0;
			this.tabContent.Size = new System.Drawing.Size(224, 441);
			this.tabContent.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabContent.TabIndex = 4;
			// 
			// tabDLCs
			// 
			this.tabDLCs.AutoScroll = true;
			this.tabDLCs.Controls.Add(this.panelDLCs);
			this.tabDLCs.Location = new System.Drawing.Point(4, 22);
			this.tabDLCs.Name = "tabDLCs";
			this.tabDLCs.Padding = new System.Windows.Forms.Padding(3);
			this.tabDLCs.Size = new System.Drawing.Size(216, 415);
			this.tabDLCs.TabIndex = 1;
			this.tabDLCs.Text = "DLCs";
			this.tabDLCs.UseVisualStyleBackColor = true;
			// 
			// panelDLCs
			// 
			this.panelDLCs.AutoScroll = true;
			this.panelDLCs.Location = new System.Drawing.Point(4, 3);
			this.panelDLCs.Name = "panelDLCs";
			this.panelDLCs.Size = new System.Drawing.Size(207, 409);
			this.panelDLCs.TabIndex = 0;
			// 
			// tabMods
			// 
			this.tabMods.AutoScroll = true;
			this.tabMods.Controls.Add(this.panelMods);
			this.tabMods.Location = new System.Drawing.Point(4, 22);
			this.tabMods.Name = "tabMods";
			this.tabMods.Size = new System.Drawing.Size(216, 415);
			this.tabMods.TabIndex = 2;
			this.tabMods.Text = "Mods";
			this.tabMods.UseVisualStyleBackColor = true;
			// 
			// panelMods
			// 
			this.panelMods.AutoScroll = true;
			this.panelMods.Location = new System.Drawing.Point(5, 3);
			this.panelMods.Name = "panelMods";
			this.panelMods.Size = new System.Drawing.Size(208, 409);
			this.panelMods.TabIndex = 1;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnToogleAll);
			this.groupBox3.Controls.Add(this.btnReload);
			this.groupBox3.Controls.Add(this.tabContent);
			this.groupBox3.Location = new System.Drawing.Point(4, 10);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(237, 492);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Content";
			// 
			// btnToogleAll
			// 
			this.btnToogleAll.Location = new System.Drawing.Point(6, 462);
			this.btnToogleAll.Name = "btnToogleAll";
			this.btnToogleAll.Size = new System.Drawing.Size(75, 23);
			this.btnToogleAll.TabIndex = 6;
			this.btnToogleAll.Text = "Toggle All";
			this.btnToogleAll.UseVisualStyleBackColor = true;
			this.btnToogleAll.Click += new System.EventHandler(this.onClickToogleAll);
			// 
			// btnReload
			// 
			this.btnReload.Location = new System.Drawing.Point(155, 462);
			this.btnReload.Name = "btnReload";
			this.btnReload.Size = new System.Drawing.Size(75, 23);
			this.btnReload.TabIndex = 5;
			this.btnReload.Text = "Reload";
			this.btnReload.UseVisualStyleBackColor = true;
			this.btnReload.Click += new System.EventHandler(this.onClickReload);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(152, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 31;
			this.label3.Text = "Age:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(188, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 32;
			this.label4.Text = "Period:";
			// 
			// PortraitBuilderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(685, 507);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "PortraitBuilderForm";
			this.Text = "Portrait Builder";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbPortrait)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabDNA.ResumeLayout(false);
			this.tabProperties.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.tabContent.ResumeLayout(false);
			this.tabDLCs.ResumeLayout(false);
			this.tabMods.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pbPortrait;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabProperties;
		private System.Windows.Forms.TextBox tbDNA;
		private System.Windows.Forms.ComboBox cbRank;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.Button btnImport;
		private System.Windows.Forms.Button btnRandom;
		private System.Windows.Forms.ComboBox cbPortraitTypes;
		private System.Windows.Forms.TabControl tabContent;
		private System.Windows.Forms.TabPage tabMods;
		private System.Windows.Forms.TabPage tabDLCs;
		private System.Windows.Forms.FlowLayoutPanel panelDLCs;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.FlowLayoutPanel panelMods;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnToogleAll;
		private System.Windows.Forms.Button btnReload;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.ComboBox cbGovernment;
		private System.Windows.Forms.TabPage tabDNA;
		private System.Windows.Forms.FlowLayoutPanel panelDNA;
		private System.Windows.Forms.FlowLayoutPanel panelProperties;
		private System.Windows.Forms.ComboBox cbCulturePortraitTypes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbAge;
		private System.Windows.Forms.ComboBox cbSex;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbPeriod;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
	}
}

