namespace Музыкальный_плеер
{
    partial class AddSongFromSite
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
            this.LabelURL = new MetroFramework.Controls.MetroLabel();
            this.TextFieldURL = new MetroFramework.Controls.MetroTextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.LabelClose = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // LabelURL
            // 
            this.LabelURL.AutoSize = true;
            this.LabelURL.Location = new System.Drawing.Point(147, 52);
            this.LabelURL.Name = "LabelURL";
            this.LabelURL.Size = new System.Drawing.Size(129, 19);
            this.LabelURL.TabIndex = 1;
            this.LabelURL.Text = "Введите URL-адрес:";
            // 
            // TextFieldURL
            // 
            this.TextFieldURL.Location = new System.Drawing.Point(309, 52);
            this.TextFieldURL.Name = "TextFieldURL";
            this.TextFieldURL.Size = new System.Drawing.Size(172, 23);
            this.TextFieldURL.TabIndex = 3;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAdd.Location = new System.Drawing.Point(233, 107);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(178, 35);
            this.ButtonAdd.TabIndex = 6;
            this.ButtonAdd.Text = "Добавить песню";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // LabelClose
            // 
            this.LabelClose.AutoSize = true;
            this.LabelClose.Location = new System.Drawing.Point(587, 5);
            this.LabelClose.Name = "LabelClose";
            this.LabelClose.Size = new System.Drawing.Size(58, 19);
            this.LabelClose.TabIndex = 7;
            this.LabelClose.Text = "Закрыть";
            this.LabelClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // AddSongFromSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 165);
            this.ControlBox = false;
            this.Controls.Add(this.LabelClose);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TextFieldURL);
            this.Controls.Add(this.LabelURL);
            this.MaximumSize = new System.Drawing.Size(645, 165);
            this.MinimumSize = new System.Drawing.Size(645, 165);
            this.Name = "AddSongFromSite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel LabelURL;
        private MetroFramework.Controls.MetroTextBox TextFieldURL;
        private System.Windows.Forms.Button ButtonAdd;
        private MetroFramework.Controls.MetroLabel LabelClose;
    }
}