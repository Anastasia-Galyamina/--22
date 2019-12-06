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
            this.buttonSetMotorShip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.buttonTakeShip = new System.Windows.Forms.Button();
            this.pictureBoxTakeShip = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShip)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(-2, 2);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(735, 452);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonSetShip
            // 
            this.buttonSetShip.Location = new System.Drawing.Point(858, 12);
            this.buttonSetShip.Name = "buttonSetShip";
            this.buttonSetShip.Size = new System.Drawing.Size(105, 48);
            this.buttonSetShip.TabIndex = 1;
            this.buttonSetShip.Text = "Припарковать корабль";
            this.buttonSetShip.UseVisualStyleBackColor = true;
            this.buttonSetShip.Click += new System.EventHandler(this.buttonSetShip_Click);
            // 
            // buttonSetMotorShip
            // 
            this.buttonSetMotorShip.Location = new System.Drawing.Point(858, 66);
            this.buttonSetMotorShip.Name = "buttonSetMotorShip";
            this.buttonSetMotorShip.Size = new System.Drawing.Size(101, 53);
            this.buttonSetMotorShip.TabIndex = 2;
            this.buttonSetMotorShip.Text = "Припарковать теплоход";
            this.buttonSetMotorShip.UseVisualStyleBackColor = true;
            this.buttonSetMotorShip.Click += new System.EventHandler(this.buttonSetMotorShip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(855, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Забрать корабль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(844, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Место";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(889, 238);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(74, 20);
            this.maskedTextBox.TabIndex = 5;
            // 
            // buttonTakeShip
            // 
            this.buttonTakeShip.Location = new System.Drawing.Point(847, 264);
            this.buttonTakeShip.Name = "buttonTakeShip";
            this.buttonTakeShip.Size = new System.Drawing.Size(109, 30);
            this.buttonTakeShip.TabIndex = 6;
            this.buttonTakeShip.Text = "Забрать корабль";
            this.buttonTakeShip.UseVisualStyleBackColor = true;
            this.buttonTakeShip.Click += new System.EventHandler(this.buttonTakeShip_Click);
            // 
            // pictureBoxTakeShip
            // 
            this.pictureBoxTakeShip.Location = new System.Drawing.Point(787, 300);
            this.pictureBoxTakeShip.Name = "pictureBoxTakeShip";
            this.pictureBoxTakeShip.Size = new System.Drawing.Size(176, 92);
            this.pictureBoxTakeShip.TabIndex = 7;
            this.pictureBoxTakeShip.TabStop = false;
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 450);
            this.Controls.Add(this.pictureBoxTakeShip);
            this.Controls.Add(this.buttonTakeShip);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSetMotorShip);
            this.Controls.Add(this.buttonSetShip);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonSetShip;
        private System.Windows.Forms.Button buttonSetMotorShip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Button buttonTakeShip;
        private System.Windows.Forms.PictureBox pictureBoxTakeShip;
    }
}