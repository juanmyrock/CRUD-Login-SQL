using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistas
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panelBarraClose = new System.Windows.Forms.Panel();
            this.labelTittle = new System.Windows.Forms.Label();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnOcultar = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.picLogOut = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.picReportes = new System.Windows.Forms.PictureBox();
            this.picFacturas = new System.Windows.Forms.PictureBox();
            this.picClientes = new System.Windows.Forms.PictureBox();
            this.picVentas = new System.Windows.Forms.PictureBox();
            this.picProductos = new System.Windows.Forms.PictureBox();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProductos = new System.Windows.Forms.Button();
            this.logoISFT = new System.Windows.Forms.PictureBox();
            this.panelBarraClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoISFT)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarraClose
            // 
            this.panelBarraClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelBarraClose.Controls.Add(this.labelTittle);
            this.panelBarraClose.Controls.Add(this.btnMaximize);
            this.panelBarraClose.Controls.Add(this.btnCerrar);
            this.panelBarraClose.Controls.Add(this.btnOcultar);
            this.panelBarraClose.Controls.Add(this.btnMinimize);
            this.panelBarraClose.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelBarraClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraClose.Location = new System.Drawing.Point(0, 0);
            this.panelBarraClose.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraClose.Name = "panelBarraClose";
            this.panelBarraClose.Size = new System.Drawing.Size(1280, 35);
            this.panelBarraClose.TabIndex = 0;
            this.panelBarraClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraClose_MouseDown);
            // 
            // labelTittle
            // 
            this.labelTittle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTittle.AutoSize = true;
            this.labelTittle.Enabled = false;
            this.labelTittle.Font = new System.Drawing.Font("Stencil", 20.29091F, System.Drawing.FontStyle.Bold);
            this.labelTittle.ForeColor = System.Drawing.Color.Black;
            this.labelTittle.Location = new System.Drawing.Point(380, 1);
            this.labelTittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(535, 38);
            this.labelTittle.TabIndex = 4;
            this.labelTittle.Text = "DISTRIBUIDORA: Los Mellis 1.0";
            this.labelTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(1215, 4);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(25, 25);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1244, 4);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnOcultar
            // 
            this.btnOcultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOcultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOcultar.Image = ((System.Drawing.Image)(resources.GetObject("btnOcultar.Image")));
            this.btnOcultar.Location = new System.Drawing.Point(1186, 4);
            this.btnOcultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(25, 25);
            this.btnOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOcultar.TabIndex = 2;
            this.btnOcultar.TabStop = false;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1215, 4);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelContenedor.Controls.Add(this.picFondo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 35);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1280, 685);
            this.panelContenedor.TabIndex = 2;
            // 
            // picFondo
            // 
            this.picFondo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picFondo.Enabled = false;
            this.picFondo.Image = ((System.Drawing.Image)(resources.GetObject("picFondo.Image")));
            this.picFondo.Location = new System.Drawing.Point(535, 120);
            this.picFondo.Margin = new System.Windows.Forms.Padding(2);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(506, 433);
            this.picFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFondo.TabIndex = 1;
            this.picFondo.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.panelMenu.Controls.Add(this.picLogOut);
            this.panelMenu.Controls.Add(this.btnSlide);
            this.panelMenu.Controls.Add(this.picReportes);
            this.panelMenu.Controls.Add(this.picFacturas);
            this.panelMenu.Controls.Add(this.picClientes);
            this.panelMenu.Controls.Add(this.picVentas);
            this.panelMenu.Controls.Add(this.picProductos);
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.btnFacturas);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.btnVentas);
            this.panelMenu.Controls.Add(this.panel5);
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btnProductos);
            this.panelMenu.Controls.Add(this.logoISFT);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 35);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(240, 685);
            this.panelMenu.TabIndex = 3;
            // 
            // picLogOut
            // 
            this.picLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogOut.Image = ((System.Drawing.Image)(resources.GetObject("picLogOut.Image")));
            this.picLogOut.Location = new System.Drawing.Point(192, 640);
            this.picLogOut.Name = "picLogOut";
            this.picLogOut.Size = new System.Drawing.Size(45, 45);
            this.picLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogOut.TabIndex = 20;
            this.picLogOut.TabStop = false;
            this.picLogOut.Click += new System.EventHandler(this.picLogOut_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide.Image = ((System.Drawing.Image)(resources.GetObject("btnSlide.Image")));
            this.btnSlide.Location = new System.Drawing.Point(96, 640);
            this.btnSlide.Margin = new System.Windows.Forms.Padding(2);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(45, 45);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlide.TabIndex = 19;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // picReportes
            // 
            this.picReportes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReportes.Enabled = false;
            this.picReportes.Image = ((System.Drawing.Image)(resources.GetObject("picReportes.Image")));
            this.picReportes.Location = new System.Drawing.Point(25, 549);
            this.picReportes.Margin = new System.Windows.Forms.Padding(2);
            this.picReportes.Name = "picReportes";
            this.picReportes.Size = new System.Drawing.Size(40, 40);
            this.picReportes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReportes.TabIndex = 18;
            this.picReportes.TabStop = false;
            // 
            // picFacturas
            // 
            this.picFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFacturas.Enabled = false;
            this.picFacturas.Image = ((System.Drawing.Image)(resources.GetObject("picFacturas.Image")));
            this.picFacturas.Location = new System.Drawing.Point(25, 486);
            this.picFacturas.Margin = new System.Windows.Forms.Padding(2);
            this.picFacturas.Name = "picFacturas";
            this.picFacturas.Size = new System.Drawing.Size(40, 40);
            this.picFacturas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFacturas.TabIndex = 17;
            this.picFacturas.TabStop = false;
            // 
            // picClientes
            // 
            this.picClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClientes.Enabled = false;
            this.picClientes.Image = ((System.Drawing.Image)(resources.GetObject("picClientes.Image")));
            this.picClientes.Location = new System.Drawing.Point(25, 425);
            this.picClientes.Margin = new System.Windows.Forms.Padding(2);
            this.picClientes.Name = "picClientes";
            this.picClientes.Size = new System.Drawing.Size(40, 40);
            this.picClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClientes.TabIndex = 16;
            this.picClientes.TabStop = false;
            // 
            // picVentas
            // 
            this.picVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVentas.Enabled = false;
            this.picVentas.Image = ((System.Drawing.Image)(resources.GetObject("picVentas.Image")));
            this.picVentas.Location = new System.Drawing.Point(25, 363);
            this.picVentas.Margin = new System.Windows.Forms.Padding(2);
            this.picVentas.Name = "picVentas";
            this.picVentas.Size = new System.Drawing.Size(40, 40);
            this.picVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVentas.TabIndex = 15;
            this.picVentas.TabStop = false;
            // 
            // picProductos
            // 
            this.picProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picProductos.Enabled = false;
            this.picProductos.Image = ((System.Drawing.Image)(resources.GetObject("picProductos.Image")));
            this.picProductos.Location = new System.Drawing.Point(25, 301);
            this.picProductos.Margin = new System.Windows.Forms.Padding(2);
            this.picProductos.Name = "picProductos";
            this.picProductos.Size = new System.Drawing.Size(40, 40);
            this.picProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProductos.TabIndex = 4;
            this.picProductos.TabStop = false;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 13.74545F);
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Location = new System.Drawing.Point(12, 549);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(2);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(228, 40);
            this.btnReportes.TabIndex = 14;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnFacturas
            // 
            this.btnFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturas.FlatAppearance.BorderSize = 0;
            this.btnFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturas.Font = new System.Drawing.Font("Century Gothic", 13.74545F);
            this.btnFacturas.ForeColor = System.Drawing.Color.White;
            this.btnFacturas.Location = new System.Drawing.Point(12, 486);
            this.btnFacturas.Margin = new System.Windows.Forms.Padding(2);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(228, 40);
            this.btnFacturas.TabIndex = 13;
            this.btnFacturas.Text = "Facturas";
            this.btnFacturas.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 13.74545F);
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(12, 425);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(228, 40);
            this.btnClientes.TabIndex = 12;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Century Gothic", 13.74545F);
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Location = new System.Drawing.Point(12, 363);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(2);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(228, 40);
            this.btnVentas.TabIndex = 11;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(0, 549);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 40);
            this.panel5.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(0, 486);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 40);
            this.panel4.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(0, 425);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 40);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(0, 363);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 40);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(0, 301);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 40);
            this.panel1.TabIndex = 2;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Century Gothic", 13.74545F);
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(12, 301);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(228, 40);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            // 
            // logoISFT
            // 
            this.logoISFT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoISFT.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoISFT.Image = ((System.Drawing.Image)(resources.GetObject("logoISFT.Image")));
            this.logoISFT.Location = new System.Drawing.Point(0, 0);
            this.logoISFT.Margin = new System.Windows.Forms.Padding(2);
            this.logoISFT.Name = "logoISFT";
            this.logoISFT.Size = new System.Drawing.Size(240, 288);
            this.logoISFT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoISFT.TabIndex = 0;
            this.logoISFT.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelBarraClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.panelBarraClose.ResumeLayout(false);
            this.panelBarraClose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoISFT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelBarraClose;
        private PictureBox btnMaximize;
        private PictureBox btnOcultar;
        private PictureBox btnMinimize;
        private PictureBox btnCerrar;
        private Label labelTittle;
        private Panel panelContenedor;
        private Panel panelMenu;
        private PictureBox btnSlide;
        private PictureBox picReportes;
        private PictureBox picFacturas;
        private PictureBox picClientes;
        private PictureBox picVentas;
        private PictureBox picProductos;
        private Button btnReportes;
        private Button btnFacturas;
        private Button btnClientes;
        private Button btnVentas;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Button btnProductos;
        private PictureBox logoISFT;
        private PictureBox picFondo;
        private PictureBox picLogOut;
    }
}