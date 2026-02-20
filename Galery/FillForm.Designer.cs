namespace lab1
{
    partial class FillForm
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
            System.Windows.Forms.Button btnFilter;
            this.listView = new System.Windows.Forms.ListView();
            this.cbMuveszFilter = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.btnFilter2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mualkotasokKezeleseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keresesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modositasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelKereses = new System.Windows.Forms.Panel();
            this.panelModositas = new System.Windows.Forms.Panel();
            this.modositButton = new System.Windows.Forms.Button();
            this.textBoxModosit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTorles = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.panelRadio = new System.Windows.Forms.Panel();
            this.radioModosit = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            btnFilter = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.panelKereses.SuspendLayout();
            this.panelModositas.SuspendLayout();
            this.panelTorles.SuspendLayout();
            this.panelRadio.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFilter
            // 
            btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnFilter.Location = new System.Drawing.Point(262, 53);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new System.Drawing.Size(144, 44);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "Szűkít";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // listView
            // 
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(210, 412);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1242, 410);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
          
            // 
            // cbMuveszFilter
            // 
            this.cbMuveszFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMuveszFilter.FormattingEnabled = true;
            this.cbMuveszFilter.Location = new System.Drawing.Point(24, 53);
            this.cbMuveszFilter.Name = "cbMuveszFilter";
            this.cbMuveszFilter.Size = new System.Drawing.Size(205, 33);
            this.cbMuveszFilter.TabIndex = 1;
           
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1584, 775);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 65);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Kilép";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(12, 187);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(217, 30);
            this.textBox.TabIndex = 4;
        
            // 
            // btnFilter2
            // 
            this.btnFilter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter2.Location = new System.Drawing.Point(279, 174);
            this.btnFilter2.Name = "btnFilter2";
            this.btnFilter2.Size = new System.Drawing.Size(106, 43);
            this.btnFilter2.TabIndex = 5;
            this.btnFilter2.Text = "Szűkít";
            this.btnFilter2.UseVisualStyleBackColor = true;
            this.btnFilter2.Click += new System.EventHandler(this.btnFilter2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Művész:";
      
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Műalkotás neve:";
          
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1848, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mualkotasokKezeleseToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1848, 33);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mualkotasokKezeleseToolStripMenuItem
            // 
            this.mualkotasokKezeleseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keresesToolStripMenuItem,
            this.torlesToolStripMenuItem,
            this.modositasToolStripMenuItem});
            this.mualkotasokKezeleseToolStripMenuItem.Name = "mualkotasokKezeleseToolStripMenuItem";
            this.mualkotasokKezeleseToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.mualkotasokKezeleseToolStripMenuItem.Text = "Műalkotások kezelése";
            // 
            // keresesToolStripMenuItem
            // 
            this.keresesToolStripMenuItem.Name = "keresesToolStripMenuItem";
            this.keresesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.keresesToolStripMenuItem.Text = "Keresés";
            this.keresesToolStripMenuItem.Click += new System.EventHandler(this.keresesMenuItem_Click);
            // 
            // torlesToolStripMenuItem
            // 
            this.torlesToolStripMenuItem.Name = "torlesToolStripMenuItem";
            this.torlesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.torlesToolStripMenuItem.Text = "Törlés";
            this.torlesToolStripMenuItem.Click += new System.EventHandler(this.torlesMenuItem_Click);
            // 
            // modositasToolStripMenuItem
            // 
            this.modositasToolStripMenuItem.Name = "modositasToolStripMenuItem";
            this.modositasToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.modositasToolStripMenuItem.Text = "Módosítás";
            this.modositasToolStripMenuItem.Click += new System.EventHandler(this.modositasMenuItem_Click);
            // 
            // panelKereses
            // 
            this.panelKereses.Controls.Add(this.cbMuveszFilter);
            this.panelKereses.Controls.Add(this.btnFilter2);
            this.panelKereses.Controls.Add(this.label2);
            this.panelKereses.Controls.Add(this.label1);
            this.panelKereses.Controls.Add(btnFilter);
            this.panelKereses.Controls.Add(this.textBox);
            this.panelKereses.Location = new System.Drawing.Point(36, 74);
            this.panelKereses.Name = "panelKereses";
            this.panelKereses.Size = new System.Drawing.Size(463, 248);
            this.panelKereses.TabIndex = 10;
            // 
            // panelModositas
            // 
            this.panelModositas.Controls.Add(this.modositButton);
            this.panelModositas.Controls.Add(this.textBoxModosit);
            this.panelModositas.Controls.Add(this.label3);
            this.panelModositas.Location = new System.Drawing.Point(1120, 84);
            this.panelModositas.Name = "panelModositas";
            this.panelModositas.Size = new System.Drawing.Size(332, 267);
            this.panelModositas.TabIndex = 8;
            // 
            // modositButton
            // 
            this.modositButton.Location = new System.Drawing.Point(32, 97);
            this.modositButton.Name = "modositButton";
            this.modositButton.Size = new System.Drawing.Size(87, 36);
            this.modositButton.TabIndex = 2;
            this.modositButton.Text = "Módosít";
            this.modositButton.UseVisualStyleBackColor = true;
            this.modositButton.Click += new System.EventHandler(this.modositButton_Click);
            // 
            // textBoxModosit
            // 
            this.textBoxModosit.Location = new System.Drawing.Point(194, 43);
            this.textBoxModosit.Name = "textBoxModosit";
            this.textBoxModosit.Size = new System.Drawing.Size(100, 26);
            this.textBoxModosit.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Műalkotás ára:";
           
            // 
            // panelTorles
            // 
            this.panelTorles.Controls.Add(this.deleteButton);
            this.panelTorles.Location = new System.Drawing.Point(557, 60);
            this.panelTorles.Name = "panelTorles";
            this.panelTorles.Size = new System.Drawing.Size(146, 262);
            this.panelTorles.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(18, 92);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(114, 54);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "Törlés";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // panelRadio
            // 
            this.panelRadio.Controls.Add(this.radioModosit);
            this.panelRadio.Controls.Add(this.radioButton3);
            this.panelRadio.Controls.Add(this.radioButton2);
            this.panelRadio.Controls.Add(this.radioButton1);
            this.panelRadio.Controls.Add(this.label5);
            this.panelRadio.Controls.Add(this.label6);
            this.panelRadio.Controls.Add(this.label4);
            this.panelRadio.Location = new System.Drawing.Point(1524, 84);
            this.panelRadio.Name = "panelRadio";
            this.panelRadio.Size = new System.Drawing.Size(287, 267);
            this.panelRadio.TabIndex = 11;
            // 
            // radioModosit
            // 
            this.radioModosit.Location = new System.Drawing.Point(78, 204);
            this.radioModosit.Name = "radioModosit";
            this.radioModosit.Size = new System.Drawing.Size(97, 34);
            this.radioModosit.TabIndex = 7;
            this.radioModosit.Text = "Módosít";
            this.radioModosit.UseVisualStyleBackColor = true;
            this.radioModosit.Click += new System.EventHandler(this.radioModosit_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(137, 147);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(126, 24);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(137, 85);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(126, 24);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(137, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 24);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Új érték:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Aktuális érték:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Régi érték:";
            // 
            // FillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 885);
            this.Controls.Add(this.panelRadio);
            this.Controls.Add(this.panelModositas);
            this.Controls.Add(this.panelTorles);
            this.Controls.Add(this.panelKereses);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FillForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FillForm_Load);
            this.Shown += new System.EventHandler(this.FillForm_Shown);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panelKereses.ResumeLayout(false);
            this.panelKereses.PerformLayout();
            this.panelModositas.ResumeLayout(false);
            this.panelModositas.PerformLayout();
            this.panelTorles.ResumeLayout(false);
            this.panelRadio.ResumeLayout(false);
            this.panelRadio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ComboBox cbMuveszFilter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btnFilter2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mualkotasokKezeleseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keresesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modositasToolStripMenuItem;
        private System.Windows.Forms.Panel panelKereses;
        private System.Windows.Forms.Panel panelModositas;
        private System.Windows.Forms.Panel panelTorles;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button modositButton;
        private System.Windows.Forms.TextBox textBoxModosit;
        private System.Windows.Forms.Panel panelRadio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button radioModosit;
    }
}

