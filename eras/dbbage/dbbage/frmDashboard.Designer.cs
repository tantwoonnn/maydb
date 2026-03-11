namespace dbbage
{
    partial class frmDashboard
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
            btnRegister = new Button();
            btnList = new Button();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(136, 178);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(201, 101);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register Student";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnList
            // 
            btnList.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnList.Location = new Point(448, 178);
            btnList.Name = "btnList";
            btnList.Size = new Size(189, 101);
            btnList.TabIndex = 1;
            btnList.Text = "Student List";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 452);
            Controls.Add(btnList);
            Controls.Add(btnRegister);
            Name = "frmDashboard";
            Text = "frmDashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegister;
        private Button btnList;
    }
}