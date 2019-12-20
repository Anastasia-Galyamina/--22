namespace WindowsFormsCars
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonSetShip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.buttonTakeShip = new System.Windows.Forms.Button();
            this.pictureBoxTakeShip = new System.Windows.Forms.PictureBox();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.load = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShip)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(-2, 39);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(826, 415);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonSetShip
            // 
            this.buttonSetShip.Location = new System.Drawing.Point(908, 89);
            this.buttonSetShip.Name = "buttonSetShip";
            this.buttonSetShip.Size = new System.Drawing.Size(105, 48);
            this.buttonSetShip.TabIndex = 1;
            this.buttonSetShip.Text = "Припарковать корабль";
            this.buttonSetShip.UseVisualStyleBackColor = true;
            this.buttonSetShip.Click += new System.EventHandler(this.buttonSetShip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(905, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Забрать корабль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(880, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Место";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(925, 238);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(74, 20);
            this.maskedTextBox.TabIndex = 5;
            // 
            // buttonTakeShip
            // 
            this.buttonTakeShip.Location = new System.Drawing.Point(890, 264);
            this.buttonTakeShip.Name = "buttonTakeShip";
            this.buttonTakeShip.Size = new System.Drawing.Size(109, 30);
            this.buttonTakeShip.TabIndex = 6;
            this.buttonTakeShip.Text = "Забрать корабль";
            this.buttonTakeShip.UseVisualStyleBackColor = true;
            this.buttonTakeShip.Click += new System.EventHandler(this.buttonTakeShip_Click);
            // 
            // pictureBoxTakeShip
            // 
            this.pictureBoxTakeShip.Location = new System.Drawing.Point(830, 300);
            this.pictureBoxTakeShip.Name = "pictureBoxTakeShip";
            this.pictureBoxTakeShip.Size = new System.Drawing.Size(169, 92);
            this.pictureBoxTakeShip.TabIndex = 7;
            this.pictureBoxTakeShip.TabStop = false;
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(906, 2);
            this.listBoxLevels.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(107, 82);
            this.listBoxLevels.TabIndex = 8;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1011, 24);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.save,
            this.load});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // save
            // 
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(132, 22);
            this.save.Text = "Сохранить";
            this.save.Click += new System.EventHandler(this.СохранитьToolStripMenuItem_Click);
            // 
            // load
            // 
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(132, 22);
            this.load.Text = "Загрузить";
            this.load.Click += new System.EventHandler(this.ЗагрузитьToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 450);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.pictureBoxTakeShip);
            this.Controls.Add(this.buttonTakeShip);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSetShip);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShip)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonSetShip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Button buttonTakeShip;
        private System.Windows.Forms.PictureBox pictureBoxTakeShip;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem load;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}