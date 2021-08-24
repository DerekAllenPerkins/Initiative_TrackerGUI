
namespace Initiative_Tracker
{
    partial class Combat
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
            this.label1 = new System.Windows.Forms.Label();
            this.lboFighters = new System.Windows.Forms.ListBox();
            this.tboTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboActive = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboNext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTurn = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fighters";
            // 
            // lboFighters
            // 
            this.lboFighters.FormattingEnabled = true;
            this.lboFighters.Location = new System.Drawing.Point(12, 32);
            this.lboFighters.Name = "lboFighters";
            this.lboFighters.Size = new System.Drawing.Size(120, 251);
            this.lboFighters.TabIndex = 1;
            // 
            // tboTime
            // 
            this.tboTime.Location = new System.Drawing.Point(518, 11);
            this.tboTime.Name = "tboTime";
            this.tboTime.ReadOnly = true;
            this.tboTime.Size = new System.Drawing.Size(159, 20);
            this.tboTime.TabIndex = 2;
            this.tboTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time:";
            // 
            // tboActive
            // 
            this.tboActive.Location = new System.Drawing.Point(274, 30);
            this.tboActive.Name = "tboActive";
            this.tboActive.Size = new System.Drawing.Size(138, 20);
            this.tboActive.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Active Turn";
            // 
            // tboNext
            // 
            this.tboNext.Location = new System.Drawing.Point(274, 125);
            this.tboNext.Multiline = true;
            this.tboNext.Name = "tboNext";
            this.tboNext.Size = new System.Drawing.Size(138, 82);
            this.tboNext.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Next";
            // 
            // btnTurn
            // 
            this.btnTurn.Location = new System.Drawing.Point(233, 266);
            this.btnTurn.Name = "btnTurn";
            this.btnTurn.Size = new System.Drawing.Size(75, 23);
            this.btnTurn.TabIndex = 8;
            this.btnTurn.Text = "End Turn";
            this.btnTurn.UseVisualStyleBackColor = true;
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(375, 266);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(93, 23);
            this.btnEnd.TabIndex = 9;
            this.btnEnd.Text = "End Encounter";
            this.btnEnd.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(152, 106);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(43, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(152, 136);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(43, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(146, 166);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(55, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Combat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 323);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnTurn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboNext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboActive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboTime);
            this.Controls.Add(this.lboFighters);
            this.Controls.Add(this.label1);
            this.Name = "Combat";
            this.Text = "Combat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lboFighters;
        private System.Windows.Forms.TextBox tboTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboNext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTurn;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}