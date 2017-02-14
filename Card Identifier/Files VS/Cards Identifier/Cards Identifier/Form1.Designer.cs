namespace Cards_Identifier
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
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.ThreeClubsPictureBox = new System.Windows.Forms.PictureBox();
            this.SixDiamondsPictureBox = new System.Windows.Forms.PictureBox();
            this.SevenClubsPictureBox = new System.Windows.Forms.PictureBox();
            this.QueenSpadesPictureBox = new System.Windows.Forms.PictureBox();
            this.AceHeartsPictureBox = new System.Windows.Forms.PictureBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ProgrammerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ThreeClubsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SixDiamondsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SevenClubsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueenSpadesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AceHeartsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.Location = new System.Drawing.Point(243, 71);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(210, 22);
            this.InstructionsLabel.TabIndex = 0;
            this.InstructionsLabel.Text = "Click a card to see its name";
            this.InstructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InstructionsLabel.Click += new System.EventHandler(this.InstructionsLabel_Click);
            // 
            // ThreeClubsPictureBox
            // 
            this.ThreeClubsPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThreeClubsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ThreeClubsPictureBox.Image")));
            this.ThreeClubsPictureBox.Location = new System.Drawing.Point(52, 143);
            this.ThreeClubsPictureBox.Name = "ThreeClubsPictureBox";
            this.ThreeClubsPictureBox.Size = new System.Drawing.Size(113, 103);
            this.ThreeClubsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ThreeClubsPictureBox.TabIndex = 2;
            this.ThreeClubsPictureBox.TabStop = false;
            this.ThreeClubsPictureBox.Click += new System.EventHandler(this.ThreeClubsPictureBox_Click);
            // 
            // SixDiamondsPictureBox
            // 
            this.SixDiamondsPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SixDiamondsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SixDiamondsPictureBox.Image")));
            this.SixDiamondsPictureBox.Location = new System.Drawing.Point(171, 142);
            this.SixDiamondsPictureBox.Name = "SixDiamondsPictureBox";
            this.SixDiamondsPictureBox.Size = new System.Drawing.Size(113, 103);
            this.SixDiamondsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SixDiamondsPictureBox.TabIndex = 3;
            this.SixDiamondsPictureBox.TabStop = false;
            this.SixDiamondsPictureBox.Click += new System.EventHandler(this.SixDiamondsPictureBox_Click);
            // 
            // SevenClubsPictureBox
            // 
            this.SevenClubsPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SevenClubsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SevenClubsPictureBox.Image")));
            this.SevenClubsPictureBox.Location = new System.Drawing.Point(293, 141);
            this.SevenClubsPictureBox.Name = "SevenClubsPictureBox";
            this.SevenClubsPictureBox.Size = new System.Drawing.Size(113, 103);
            this.SevenClubsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SevenClubsPictureBox.TabIndex = 4;
            this.SevenClubsPictureBox.TabStop = false;
            this.SevenClubsPictureBox.Click += new System.EventHandler(this.SevenClubsPictureBox_Click);
            // 
            // QueenSpadesPictureBox
            // 
            this.QueenSpadesPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QueenSpadesPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("QueenSpadesPictureBox.Image")));
            this.QueenSpadesPictureBox.Location = new System.Drawing.Point(400, 140);
            this.QueenSpadesPictureBox.Name = "QueenSpadesPictureBox";
            this.QueenSpadesPictureBox.Size = new System.Drawing.Size(113, 103);
            this.QueenSpadesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QueenSpadesPictureBox.TabIndex = 5;
            this.QueenSpadesPictureBox.TabStop = false;
            this.QueenSpadesPictureBox.Click += new System.EventHandler(this.QueenSpadesPictureBox_Click);
            // 
            // AceHeartsPictureBox
            // 
            this.AceHeartsPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AceHeartsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AceHeartsPictureBox.Image")));
            this.AceHeartsPictureBox.Location = new System.Drawing.Point(507, 139);
            this.AceHeartsPictureBox.Name = "AceHeartsPictureBox";
            this.AceHeartsPictureBox.Size = new System.Drawing.Size(113, 103);
            this.AceHeartsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AceHeartsPictureBox.TabIndex = 6;
            this.AceHeartsPictureBox.TabStop = false;
            this.AceHeartsPictureBox.Click += new System.EventHandler(this.AceHeartsPictureBox_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(270, 274);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(150, 23);
            this.OutputLabel.TabIndex = 7;
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OutputLabel.Click += new System.EventHandler(this.OutputLabel_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(320, 325);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(59, 33);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ProgrammerLabel
            // 
            this.ProgrammerLabel.AutoSize = true;
            this.ProgrammerLabel.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgrammerLabel.Location = new System.Drawing.Point(465, 414);
            this.ProgrammerLabel.Name = "ProgrammerLabel";
            this.ProgrammerLabel.Size = new System.Drawing.Size(181, 16);
            this.ProgrammerLabel.TabIndex = 9;
            this.ProgrammerLabel.Text = "Programmed by Merlin Bierekofen";
            this.ProgrammerLabel.Click += new System.EventHandler(this.ProgrammerLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 439);
            this.Controls.Add(this.ProgrammerLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.AceHeartsPictureBox);
            this.Controls.Add(this.QueenSpadesPictureBox);
            this.Controls.Add(this.SevenClubsPictureBox);
            this.Controls.Add(this.SixDiamondsPictureBox);
            this.Controls.Add(this.ThreeClubsPictureBox);
            this.Controls.Add(this.InstructionsLabel);
            this.Name = "Form1";
            this.Text = "Cards Identifier";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThreeClubsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SixDiamondsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SevenClubsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueenSpadesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AceHeartsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.PictureBox ThreeClubsPictureBox;
        private System.Windows.Forms.PictureBox SixDiamondsPictureBox;
        private System.Windows.Forms.PictureBox SevenClubsPictureBox;
        private System.Windows.Forms.PictureBox QueenSpadesPictureBox;
        private System.Windows.Forms.PictureBox AceHeartsPictureBox;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label ProgrammerLabel;
    }
}

