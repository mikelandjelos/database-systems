﻿namespace MMORPG.Forms
{
    partial class BlessingsForm
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
            listView = new ListView();
            backBtn = new Button();
            addNewBtn = new Button();
            removeBtn = new Button();
            updateBtn = new Button();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listView
            // 
            listView.Alignment = ListViewAlignment.SnapToGrid;
            listView.BackColor = Color.FromArgb(213, 184, 242);
            listView.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listView.FullRowSelect = true;
            listView.Location = new Point(12, 11);
            listView.Margin = new Padding(3, 2, 3, 2);
            listView.MaximumSize = new Size(507, 361);
            listView.Name = "listView";
            listView.Size = new Size(305, 358);
            listView.TabIndex = 1;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(153, 91, 216);
            backBtn.FlatStyle = FlatStyle.Popup;
            backBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(438, 333);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(130, 36);
            backBtn.TabIndex = 2;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // addNewBtn
            // 
            addNewBtn.BackColor = Color.White;
            addNewBtn.FlatStyle = FlatStyle.Popup;
            addNewBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            addNewBtn.Location = new Point(364, 27);
            addNewBtn.Margin = new Padding(3, 2, 3, 2);
            addNewBtn.Name = "addNewBtn";
            addNewBtn.Size = new Size(204, 46);
            addNewBtn.TabIndex = 7;
            addNewBtn.Text = "Add new blessing";
            addNewBtn.UseVisualStyleBackColor = false;
            addNewBtn.Click += addNewBtn_Click;
            // 
            // removeBtn
            // 
            removeBtn.BackColor = Color.FromArgb(195, 157, 224);
            removeBtn.FlatStyle = FlatStyle.Popup;
            removeBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            removeBtn.Location = new Point(364, 113);
            removeBtn.Margin = new Padding(3, 2, 3, 2);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(204, 48);
            removeBtn.TabIndex = 11;
            removeBtn.Text = "Remove selected";
            removeBtn.UseVisualStyleBackColor = false;
            removeBtn.Click += removeBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.FromArgb(68, 34, 94);
            updateBtn.FlatStyle = FlatStyle.Popup;
            updateBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            updateBtn.Location = new Point(364, 201);
            updateBtn.Margin = new Padding(3, 2, 3, 2);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(204, 47);
            updateBtn.TabIndex = 12;
            updateBtn.Text = "Update selected";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.white_star;
            pictureBox3.Location = new Point(300, 304);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(116, 66);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.white_star;
            pictureBox1.Location = new Point(313, 252);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // BlessingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(580, 382);
            Controls.Add(updateBtn);
            Controls.Add(removeBtn);
            Controls.Add(addNewBtn);
            Controls.Add(backBtn);
            Controls.Add(listView);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MaximumSize = new Size(596, 421);
            MinimizeBox = false;
            MinimumSize = new Size(596, 421);
            Name = "BlessingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Blessings";
            FormClosed += BlessingsForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView;
        private Button backBtn;
        private Button addNewBtn;
        private Button removeBtn;
        private Button updateBtn;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}