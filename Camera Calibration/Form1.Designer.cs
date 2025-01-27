﻿namespace SomeCalibrations
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
            this.components = new System.ComponentModel.Container();
            this.Main_Picturebox = new Emgu.CV.UI.ImageBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numSquareSize = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numChessWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numChessHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Start_BTN = new System.Windows.Forms.Button();
            this.numFrameBuffer = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Sub_PicturBox = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Picturebox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSquareSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChessWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChessHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrameBuffer)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sub_PicturBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_Picturebox
            // 
            this.Main_Picturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Picturebox.Location = new System.Drawing.Point(10, 40);
            this.Main_Picturebox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Main_Picturebox.Name = "Main_Picturebox";
            this.Main_Picturebox.Size = new System.Drawing.Size(794, 580);
            this.Main_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Main_Picturebox.TabIndex = 2;
            this.Main_Picturebox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Main_Picturebox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1000, 1000);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numSquareSize);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numChessWidth);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numChessHeight);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Start_BTN);
            this.groupBox2.Controls.Add(this.numFrameBuffer);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(835, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(327, 345);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Config";
            // 
            // numSquareSize
            // 
            this.numSquareSize.DecimalPlaces = 2;
            this.numSquareSize.Location = new System.Drawing.Point(162, 194);
            this.numSquareSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numSquareSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSquareSize.Name = "numSquareSize";
            this.numSquareSize.Size = new System.Drawing.Size(100, 26);
            this.numSquareSize.TabIndex = 14;
            this.numSquareSize.Value = new decimal(new int[] {
            472,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Square Size";
            // 
            // numChessWidth
            // 
            this.numChessWidth.Location = new System.Drawing.Point(162, 92);
            this.numChessWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numChessWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numChessWidth.Name = "numChessWidth";
            this.numChessWidth.Size = new System.Drawing.Size(100, 26);
            this.numChessWidth.TabIndex = 12;
            this.numChessWidth.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Chess Width";
            // 
            // numChessHeight
            // 
            this.numChessHeight.Location = new System.Drawing.Point(162, 143);
            this.numChessHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numChessHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numChessHeight.Name = "numChessHeight";
            this.numChessHeight.Size = new System.Drawing.Size(100, 26);
            this.numChessHeight.TabIndex = 10;
            this.numChessHeight.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Chess Height";
            // 
            // Start_BTN
            // 
            this.Start_BTN.Location = new System.Drawing.Point(206, 280);
            this.Start_BTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Start_BTN.Name = "Start_BTN";
            this.Start_BTN.Size = new System.Drawing.Size(112, 35);
            this.Start_BTN.TabIndex = 8;
            this.Start_BTN.Text = "Go...";
            this.Start_BTN.UseVisualStyleBackColor = true;
            this.Start_BTN.Click += new System.EventHandler(this.Start_BTN_Click);
            // 
            // numFrameBuffer
            // 
            this.numFrameBuffer.Location = new System.Drawing.Point(162, 42);
            this.numFrameBuffer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numFrameBuffer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFrameBuffer.Name = "numFrameBuffer";
            this.numFrameBuffer.Size = new System.Drawing.Size(100, 26);
            this.numFrameBuffer.TabIndex = 7;
            this.numFrameBuffer.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Frame Buffer";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Sub_PicturBox);
            this.groupBox3.Location = new System.Drawing.Point(835, 392);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(332, 255);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Original";
            // 
            // Sub_PicturBox
            // 
            this.Sub_PicturBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sub_PicturBox.Location = new System.Drawing.Point(4, 24);
            this.Sub_PicturBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sub_PicturBox.Name = "Sub_PicturBox";
            this.Sub_PicturBox.Size = new System.Drawing.Size(500, 500);
            this.Sub_PicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sub_PicturBox.TabIndex = 3;
            this.Sub_PicturBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3165, 1375);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Main_Picturebox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSquareSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChessWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChessHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrameBuffer)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Sub_PicturBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox Main_Picturebox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Emgu.CV.UI.ImageBox Sub_PicturBox;
        private System.Windows.Forms.Button Start_BTN;
        private System.Windows.Forms.NumericUpDown numFrameBuffer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numSquareSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numChessWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numChessHeight;
        private System.Windows.Forms.Label label1;
    }
}

