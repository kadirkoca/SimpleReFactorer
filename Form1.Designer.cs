
namespace Refactorer
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
            this.open_btn = new System.Windows.Forms.Button();
            this.selected_txt = new System.Windows.Forms.TextBox();
            this.find_txt = new System.Windows.Forms.TextBox();
            this.replace_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.refactor_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // open_btn
            // 
            this.open_btn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.open_btn.Font = new System.Drawing.Font("Abel", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_btn.Location = new System.Drawing.Point(661, 12);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(127, 52);
            this.open_btn.TabIndex = 0;
            this.open_btn.Text = "Open";
            this.open_btn.UseVisualStyleBackColor = false;
            this.open_btn.Click += new System.EventHandler(this.OpenDir);
            // 
            // selected_txt
            // 
            this.selected_txt.BackColor = System.Drawing.SystemColors.Control;
            this.selected_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selected_txt.Font = new System.Drawing.Font("Abel", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_txt.Location = new System.Drawing.Point(12, 12);
            this.selected_txt.Name = "selected_txt";
            this.selected_txt.Size = new System.Drawing.Size(643, 50);
            this.selected_txt.TabIndex = 1;
            // 
            // find_txt
            // 
            this.find_txt.BackColor = System.Drawing.Color.Gainsboro;
            this.find_txt.Font = new System.Drawing.Font("Abel", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find_txt.Location = new System.Drawing.Point(12, 151);
            this.find_txt.Multiline = true;
            this.find_txt.Name = "find_txt";
            this.find_txt.Size = new System.Drawing.Size(776, 94);
            this.find_txt.TabIndex = 2;
            // 
            // replace_txt
            // 
            this.replace_txt.BackColor = System.Drawing.Color.Gainsboro;
            this.replace_txt.Font = new System.Drawing.Font("Abel", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replace_txt.Location = new System.Drawing.Point(12, 299);
            this.replace_txt.Multiline = true;
            this.replace_txt.Name = "replace_txt";
            this.replace_txt.Size = new System.Drawing.Size(776, 94);
            this.replace_txt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Abel", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Find";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Abel", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 43);
            this.label2.TabIndex = 5;
            this.label2.Text = "Replace";
            // 
            // refactor_btn
            // 
            this.refactor_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.refactor_btn.Font = new System.Drawing.Font("Abel", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refactor_btn.Location = new System.Drawing.Point(12, 416);
            this.refactor_btn.Name = "refactor_btn";
            this.refactor_btn.Size = new System.Drawing.Size(776, 78);
            this.refactor_btn.TabIndex = 6;
            this.refactor_btn.Text = "Refactor";
            this.refactor_btn.UseVisualStyleBackColor = false;
            this.refactor_btn.Click += new System.EventHandler(this.StartRefactoring);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.refactor_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.replace_txt);
            this.Controls.Add(this.find_txt);
            this.Controls.Add(this.selected_txt);
            this.Controls.Add(this.open_btn);
            this.Name = "Form1";
            this.Text = "Refactorer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox selected_txt;
        private System.Windows.Forms.TextBox find_txt;
        private System.Windows.Forms.TextBox replace_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refactor_btn;
        private System.Windows.Forms.Button open_btn;
    }
}

