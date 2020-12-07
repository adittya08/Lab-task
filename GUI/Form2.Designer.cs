namespace GUI
{
    partial class Form2
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
            this.buttonAdduser = new System.Windows.Forms.Button();
            this.buttonEdituser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdduser
            // 
            this.buttonAdduser.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdduser.Location = new System.Drawing.Point(206, 184);
            this.buttonAdduser.Name = "buttonAdduser";
            this.buttonAdduser.Size = new System.Drawing.Size(130, 43);
            this.buttonAdduser.TabIndex = 0;
            this.buttonAdduser.Text = "Add User";
            this.buttonAdduser.UseVisualStyleBackColor = true;
            this.buttonAdduser.Click += new System.EventHandler(this.adduser);
            // 
            // buttonEdituser
            // 
            this.buttonEdituser.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdituser.Location = new System.Drawing.Point(416, 184);
            this.buttonEdituser.Name = "buttonEdituser";
            this.buttonEdituser.Size = new System.Drawing.Size(135, 43);
            this.buttonEdituser.TabIndex = 1;
            this.buttonEdituser.Text = "Edit User";
            this.buttonEdituser.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(900, 596);
            this.Controls.Add(this.buttonEdituser);
            this.Controls.Add(this.buttonAdduser);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdduser;
        private System.Windows.Forms.Button buttonEdituser;
    }
}