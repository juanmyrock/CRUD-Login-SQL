namespace CapaVistas
{
    partial class frmPrincipal
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
            this.pnlMenuLateral = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.pnlSubMenuEmp = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pnlMenuLateral.SuspendLayout();
            this.pnlSubMenuEmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuLateral
            // 
            this.pnlMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pnlMenuLateral.Controls.Add(this.pnlSubMenuEmp);
            this.pnlMenuLateral.Controls.Add(this.btnEmpleados);
            this.pnlMenuLateral.Controls.Add(this.pnlLogo);
            this.pnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuLateral.Name = "pnlMenuLateral";
            this.pnlMenuLateral.Size = new System.Drawing.Size(250, 461);
            this.pnlMenuLateral.TabIndex = 0;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(27)))), ((int)(((byte)(37)))));
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(250, 100);
            this.pnlLogo.TabIndex = 0;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 100);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(250, 45);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            // 
            // pnlSubMenuEmp
            // 
            this.pnlSubMenuEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlSubMenuEmp.Controls.Add(this.button4);
            this.pnlSubMenuEmp.Controls.Add(this.button3);
            this.pnlSubMenuEmp.Controls.Add(this.button2);
            this.pnlSubMenuEmp.Controls.Add(this.button1);
            this.pnlSubMenuEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuEmp.Location = new System.Drawing.Point(0, 145);
            this.pnlSubMenuEmp.Name = "pnlSubMenuEmp";
            this.pnlSubMenuEmp.Size = new System.Drawing.Size(250, 145);
            this.pnlSubMenuEmp.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Listado";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Listado";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Listado";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 105);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Listado";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 461);
            this.Controls.Add(this.pnlMenuLateral);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.pnlMenuLateral.ResumeLayout(false);
            this.pnlSubMenuEmp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuLateral;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlSubMenuEmp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}