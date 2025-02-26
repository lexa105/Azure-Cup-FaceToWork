﻿
namespace FaceToWork
{
	partial class FormAddPersonGroup
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddPersonGroup));
			this.groupId_txtBox = new System.Windows.Forms.TextBox();
			this.AcceptBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupName_txtBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupId_txtBox
			// 
			this.groupId_txtBox.Location = new System.Drawing.Point(56, 170);
			this.groupId_txtBox.Name = "groupId_txtBox";
			this.groupId_txtBox.Size = new System.Drawing.Size(330, 20);
			this.groupId_txtBox.TabIndex = 0;
			// 
			// AcceptBtn
			// 
			this.AcceptBtn.Location = new System.Drawing.Point(294, 272);
			this.AcceptBtn.Name = "AcceptBtn";
			this.AcceptBtn.Size = new System.Drawing.Size(94, 31);
			this.AcceptBtn.TabIndex = 2;
			this.AcceptBtn.Text = "OK";
			this.AcceptBtn.UseVisualStyleBackColor = true;
			this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(55, 150);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Person Group ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(55, 208);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Person Group Name";
			// 
			// groupName_txtBox
			// 
			this.groupName_txtBox.Location = new System.Drawing.Point(56, 228);
			this.groupName_txtBox.Name = "groupName_txtBox";
			this.groupName_txtBox.Size = new System.Drawing.Size(330, 20);
			this.groupName_txtBox.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(53, 358);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(322, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "*Pro platné Person Group ID používejte malá písmena nebo číslice ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(53, 371);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "bez diakritiky a mezer.";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(56, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(330, 121);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// FormAddPersonGroup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(454, 407);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AcceptBtn);
			this.Controls.Add(this.groupName_txtBox);
			this.Controls.Add(this.groupId_txtBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormAddPersonGroup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormAddPersonGroup";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddPersonGroup_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox groupId_txtBox;
		private System.Windows.Forms.Button AcceptBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox groupName_txtBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}