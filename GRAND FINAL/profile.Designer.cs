
namespace GRAND_FINAL
{
    partial class profile
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
            this.name_box = new System.Windows.Forms.ComboBox();
            this.manuf_box = new System.Windows.Forms.ComboBox();
            this.name_lab = new System.Windows.Forms.Label();
            this.manuf_lab = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.chng_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_box
            // 
            this.name_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.name_box.FormattingEnabled = true;
            this.name_box.Location = new System.Drawing.Point(175, 68);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(121, 22);
            this.name_box.TabIndex = 0;
            // 
            // manuf_box
            // 
            this.manuf_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manuf_box.FormattingEnabled = true;
            this.manuf_box.Location = new System.Drawing.Point(175, 117);
            this.manuf_box.Name = "manuf_box";
            this.manuf_box.Size = new System.Drawing.Size(121, 21);
            this.manuf_box.TabIndex = 1;
            // 
            // name_lab
            // 
            this.name_lab.AutoSize = true;
            this.name_lab.Location = new System.Drawing.Point(93, 68);
            this.name_lab.Name = "name_lab";
            this.name_lab.Size = new System.Drawing.Size(35, 13);
            this.name_lab.TabIndex = 2;
            this.name_lab.Text = "label1";
            // 
            // manuf_lab
            // 
            this.manuf_lab.AutoSize = true;
            this.manuf_lab.Location = new System.Drawing.Point(93, 117);
            this.manuf_lab.Name = "manuf_lab";
            this.manuf_lab.Size = new System.Drawing.Size(35, 13);
            this.manuf_lab.TabIndex = 3;
            this.manuf_lab.Text = "label2";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(698, 405);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 4;
            this.back_btn.Text = "Вернуться";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // chng_btn
            // 
            this.chng_btn.Location = new System.Drawing.Point(319, 92);
            this.chng_btn.Name = "chng_btn";
            this.chng_btn.Size = new System.Drawing.Size(75, 23);
            this.chng_btn.TabIndex = 5;
            this.chng_btn.Text = "Изменить";
            this.chng_btn.UseVisualStyleBackColor = true;
            this.chng_btn.Click += new System.EventHandler(this.chng_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(196, 173);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(75, 23);
            this.del_btn.TabIndex = 6;
            this.del_btn.Text = "Удалить";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.chng_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.manuf_lab);
            this.Controls.Add(this.name_lab);
            this.Controls.Add(this.manuf_box);
            this.Controls.Add(this.name_box);
            this.Name = "profile";
            this.Text = "Профиль товара";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox name_box;
        private System.Windows.Forms.ComboBox manuf_box;
        private System.Windows.Forms.Label name_lab;
        private System.Windows.Forms.Label manuf_lab;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button chng_btn;
        private System.Windows.Forms.Button del_btn;
    }
}