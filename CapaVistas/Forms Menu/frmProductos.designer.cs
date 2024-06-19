using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CapaVistas
{
    partial class frmProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelConteProd = new System.Windows.Forms.Panel();
            this.dGVProd = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblListaProd = new System.Windows.Forms.Label();
            this.panelBtnProd = new System.Windows.Forms.Panel();
            this.btnEliminarProd = new System.Windows.Forms.Button();
            this.btnEditarProd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenuProd = new System.Windows.Forms.Panel();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.btnGuardarProd = new System.Windows.Forms.Button();
            this.pictureBoxProd = new System.Windows.Forms.PictureBox();
            this.lblMantProd = new System.Windows.Forms.Label();
            this.lblStockProd = new System.Windows.Forms.Label();
            this.lblPrecioProd = new System.Windows.Forms.Label();
            this.lblMarcaProd = new System.Windows.Forms.Label();
            this.lblDescProd = new System.Windows.Forms.Label();
            this.textBoxDescProd = new System.Windows.Forms.TextBox();
            this.lblNombreProd = new System.Windows.Forms.Label();
            this.textBoxNombreProd = new System.Windows.Forms.TextBox();
            this.panelBarraProd = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.labelProd = new System.Windows.Forms.Label();
            this.panelFondoProd = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            this.panelConteProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProd)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelBtnProd.SuspendLayout();
            this.panelMenuProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProd)).BeginInit();
            this.panelBarraProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelFondoProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panelConteProd);
            this.panel6.Controls.Add(this.panelBtnProd);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.panelMenuProd);
            this.panel6.Controls.Add(this.panelBarraProd);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1280, 685);
            this.panel6.TabIndex = 18;
            // 
            // panelConteProd
            // 
            this.panelConteProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelConteProd.Controls.Add(this.dGVProd);
            this.panelConteProd.Controls.Add(this.panel5);
            this.panelConteProd.Controls.Add(this.panel4);
            this.panelConteProd.Controls.Add(this.panel3);
            this.panelConteProd.Controls.Add(this.panel2);
            this.panelConteProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteProd.Location = new System.Drawing.Point(240, 35);
            this.panelConteProd.Margin = new System.Windows.Forms.Padding(2);
            this.panelConteProd.Name = "panelConteProd";
            this.panelConteProd.Size = new System.Drawing.Size(780, 538);
            this.panelConteProd.TabIndex = 5;
            // 
            // dGVProd
            // 
            this.dGVProd.AllowUserToAddRows = false;
            this.dGVProd.AllowUserToDeleteRows = false;
            this.dGVProd.AllowUserToResizeRows = false;
            this.dGVProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dGVProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVProd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dGVProd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.818182F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVProd.ColumnHeadersHeight = 30;
            this.dGVProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.163636F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVProd.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVProd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGVProd.EnableHeadersVisualStyles = false;
            this.dGVProd.GridColor = System.Drawing.Color.SteelBlue;
            this.dGVProd.Location = new System.Drawing.Point(22, 21);
            this.dGVProd.Margin = new System.Windows.Forms.Padding(2);
            this.dGVProd.MultiSelect = false;
            this.dGVProd.Name = "dGVProd";
            this.dGVProd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.818182F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVProd.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGVProd.RowHeadersVisible = false;
            this.dGVProd.RowHeadersWidth = 47;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.818182F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dGVProd.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dGVProd.RowTemplate.Height = 28;
            this.dGVProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVProd.Size = new System.Drawing.Size(736, 496);
            this.dGVProd.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(22, 517);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(736, 21);
            this.panel5.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(758, 21);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(22, 517);
            this.panel4.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 21);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(22, 517);
            this.panel3.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblListaProd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 21);
            this.panel2.TabIndex = 14;
            // 
            // lblListaProd
            // 
            this.lblListaProd.AutoSize = true;
            this.lblListaProd.BackColor = System.Drawing.Color.Transparent;
            this.lblListaProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblListaProd.Enabled = false;
            this.lblListaProd.Font = new System.Drawing.Font("Century Gothic", 11.12727F, System.Drawing.FontStyle.Bold);
            this.lblListaProd.ForeColor = System.Drawing.Color.White;
            this.lblListaProd.Location = new System.Drawing.Point(22, 0);
            this.lblListaProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListaProd.Name = "lblListaProd";
            this.lblListaProd.Size = new System.Drawing.Size(180, 21);
            this.lblListaProd.TabIndex = 13;
            this.lblListaProd.Text = "Listado de Productos";
            // 
            // panelBtnProd
            // 
            this.panelBtnProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelBtnProd.Controls.Add(this.btnEliminarProd);
            this.panelBtnProd.Controls.Add(this.btnEditarProd);
            this.panelBtnProd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBtnProd.Location = new System.Drawing.Point(240, 573);
            this.panelBtnProd.Margin = new System.Windows.Forms.Padding(2);
            this.panelBtnProd.Name = "panelBtnProd";
            this.panelBtnProd.Size = new System.Drawing.Size(780, 112);
            this.panelBtnProd.TabIndex = 2;
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEliminarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarProd.FlatAppearance.BorderSize = 3;
            this.btnEliminarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEliminarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProd.Font = new System.Drawing.Font("Century Gothic", 13.74545F);
            this.btnEliminarProd.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProd.Location = new System.Drawing.Point(219, 37);
            this.btnEliminarProd.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.Size = new System.Drawing.Size(167, 40);
            this.btnEliminarProd.TabIndex = 14;
            this.btnEliminarProd.Text = "Eliminar";
            this.btnEliminarProd.UseVisualStyleBackColor = false;
            this.btnEliminarProd.Click += new System.EventHandler(this.btnEliminarProd_Click);
            // 
            // btnEditarProd
            // 
            this.btnEditarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEditarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarProd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarProd.FlatAppearance.BorderSize = 3;
            this.btnEditarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEditarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProd.Font = new System.Drawing.Font("Century Gothic", 13.74545F);
            this.btnEditarProd.ForeColor = System.Drawing.Color.White;
            this.btnEditarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarProd.Location = new System.Drawing.Point(30, 37);
            this.btnEditarProd.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarProd.Name = "btnEditarProd";
            this.btnEditarProd.Size = new System.Drawing.Size(167, 40);
            this.btnEditarProd.TabIndex = 13;
            this.btnEditarProd.Text = "Editar";
            this.btnEditarProd.UseVisualStyleBackColor = false;
            this.btnEditarProd.Click += new System.EventHandler(this.btnEditarProd_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 650);
            this.panel1.TabIndex = 4;
            // 
            // panelMenuProd
            // 
            this.panelMenuProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelMenuProd.Controls.Add(this.textBoxStock);
            this.panelMenuProd.Controls.Add(this.textBoxPrecio);
            this.panelMenuProd.Controls.Add(this.textBoxMarca);
            this.panelMenuProd.Controls.Add(this.btnGuardarProd);
            this.panelMenuProd.Controls.Add(this.pictureBoxProd);
            this.panelMenuProd.Controls.Add(this.lblMantProd);
            this.panelMenuProd.Controls.Add(this.lblStockProd);
            this.panelMenuProd.Controls.Add(this.lblPrecioProd);
            this.panelMenuProd.Controls.Add(this.lblMarcaProd);
            this.panelMenuProd.Controls.Add(this.lblDescProd);
            this.panelMenuProd.Controls.Add(this.textBoxDescProd);
            this.panelMenuProd.Controls.Add(this.lblNombreProd);
            this.panelMenuProd.Controls.Add(this.textBoxNombreProd);
            this.panelMenuProd.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenuProd.Location = new System.Drawing.Point(1020, 35);
            this.panelMenuProd.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenuProd.Name = "panelMenuProd";
            this.panelMenuProd.Size = new System.Drawing.Size(260, 650);
            this.panelMenuProd.TabIndex = 1;
            // 
            // textBoxStock
            // 
            this.textBoxStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxStock.Font = new System.Drawing.Font("Century Gothic", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStock.Location = new System.Drawing.Point(17, 487);
            this.textBoxStock.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(226, 30);
            this.textBoxStock.TabIndex = 15;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxPrecio.Font = new System.Drawing.Font("Century Gothic", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecio.Location = new System.Drawing.Point(17, 405);
            this.textBoxPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(226, 30);
            this.textBoxPrecio.TabIndex = 14;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxMarca.Font = new System.Drawing.Font("Century Gothic", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMarca.Location = new System.Drawing.Point(17, 323);
            this.textBoxMarca.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(226, 30);
            this.textBoxMarca.TabIndex = 13;
            // 
            // btnGuardarProd
            // 
            this.btnGuardarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGuardarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarProd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarProd.FlatAppearance.BorderSize = 3;
            this.btnGuardarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGuardarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProd.Font = new System.Drawing.Font("Century Gothic", 13.74545F);
            this.btnGuardarProd.ForeColor = System.Drawing.Color.White;
            this.btnGuardarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarProd.Location = new System.Drawing.Point(17, 567);
            this.btnGuardarProd.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarProd.Name = "btnGuardarProd";
            this.btnGuardarProd.Size = new System.Drawing.Size(226, 56);
            this.btnGuardarProd.TabIndex = 12;
            this.btnGuardarProd.Text = "Guardar";
            this.btnGuardarProd.UseVisualStyleBackColor = false;
            this.btnGuardarProd.Click += new System.EventHandler(this.btnGuardarProd_Click);
            // 
            // pictureBoxProd
            // 
            this.pictureBoxProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxProd.Enabled = false;
            this.pictureBoxProd.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProd.Image")));
            this.pictureBoxProd.Location = new System.Drawing.Point(98, 55);
            this.pictureBoxProd.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProd.Name = "pictureBoxProd";
            this.pictureBoxProd.Size = new System.Drawing.Size(63, 57);
            this.pictureBoxProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProd.TabIndex = 11;
            this.pictureBoxProd.TabStop = false;
            // 
            // lblMantProd
            // 
            this.lblMantProd.AutoSize = true;
            this.lblMantProd.BackColor = System.Drawing.Color.Transparent;
            this.lblMantProd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMantProd.Enabled = false;
            this.lblMantProd.Font = new System.Drawing.Font("Century Gothic", 11.12727F, System.Drawing.FontStyle.Bold);
            this.lblMantProd.ForeColor = System.Drawing.Color.White;
            this.lblMantProd.Location = new System.Drawing.Point(8, 12);
            this.lblMantProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMantProd.Name = "lblMantProd";
            this.lblMantProd.Size = new System.Drawing.Size(245, 21);
            this.lblMantProd.TabIndex = 10;
            this.lblMantProd.Text = "Mantenimiento de Productos";
            // 
            // lblStockProd
            // 
            this.lblStockProd.AutoSize = true;
            this.lblStockProd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStockProd.Enabled = false;
            this.lblStockProd.Font = new System.Drawing.Font("Century Gothic", 11.78182F, System.Drawing.FontStyle.Bold);
            this.lblStockProd.ForeColor = System.Drawing.Color.White;
            this.lblStockProd.Location = new System.Drawing.Point(17, 462);
            this.lblStockProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockProd.Name = "lblStockProd";
            this.lblStockProd.Size = new System.Drawing.Size(68, 25);
            this.lblStockProd.TabIndex = 9;
            this.lblStockProd.Text = "Stock:";
            // 
            // lblPrecioProd
            // 
            this.lblPrecioProd.AutoSize = true;
            this.lblPrecioProd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrecioProd.Enabled = false;
            this.lblPrecioProd.Font = new System.Drawing.Font("Century Gothic", 11.78182F, System.Drawing.FontStyle.Bold);
            this.lblPrecioProd.ForeColor = System.Drawing.Color.White;
            this.lblPrecioProd.Location = new System.Drawing.Point(17, 379);
            this.lblPrecioProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioProd.Name = "lblPrecioProd";
            this.lblPrecioProd.Size = new System.Drawing.Size(75, 25);
            this.lblPrecioProd.TabIndex = 7;
            this.lblPrecioProd.Text = "Precio:";
            // 
            // lblMarcaProd
            // 
            this.lblMarcaProd.AutoSize = true;
            this.lblMarcaProd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMarcaProd.Enabled = false;
            this.lblMarcaProd.Font = new System.Drawing.Font("Century Gothic", 11.78182F, System.Drawing.FontStyle.Bold);
            this.lblMarcaProd.ForeColor = System.Drawing.Color.White;
            this.lblMarcaProd.Location = new System.Drawing.Point(17, 297);
            this.lblMarcaProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarcaProd.Name = "lblMarcaProd";
            this.lblMarcaProd.Size = new System.Drawing.Size(78, 25);
            this.lblMarcaProd.TabIndex = 5;
            this.lblMarcaProd.Text = "Marca:";
            // 
            // lblDescProd
            // 
            this.lblDescProd.AutoSize = true;
            this.lblDescProd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescProd.Enabled = false;
            this.lblDescProd.Font = new System.Drawing.Font("Century Gothic", 11.78182F, System.Drawing.FontStyle.Bold);
            this.lblDescProd.ForeColor = System.Drawing.Color.White;
            this.lblDescProd.Location = new System.Drawing.Point(17, 218);
            this.lblDescProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescProd.Name = "lblDescProd";
            this.lblDescProd.Size = new System.Drawing.Size(126, 25);
            this.lblDescProd.TabIndex = 3;
            this.lblDescProd.Text = "Descripción:";
            // 
            // textBoxDescProd
            // 
            this.textBoxDescProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxDescProd.Font = new System.Drawing.Font("Century Gothic", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescProd.Location = new System.Drawing.Point(17, 245);
            this.textBoxDescProd.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDescProd.Name = "textBoxDescProd";
            this.textBoxDescProd.Size = new System.Drawing.Size(226, 30);
            this.textBoxDescProd.TabIndex = 2;
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreProd.Enabled = false;
            this.lblNombreProd.Font = new System.Drawing.Font("Century Gothic", 11.78182F, System.Drawing.FontStyle.Bold);
            this.lblNombreProd.ForeColor = System.Drawing.Color.White;
            this.lblNombreProd.Location = new System.Drawing.Point(17, 137);
            this.lblNombreProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(92, 25);
            this.lblNombreProd.TabIndex = 1;
            this.lblNombreProd.Text = "Nombre:";
            // 
            // textBoxNombreProd
            // 
            this.textBoxNombreProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxNombreProd.Font = new System.Drawing.Font("Century Gothic", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreProd.Location = new System.Drawing.Point(17, 164);
            this.textBoxNombreProd.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNombreProd.Name = "textBoxNombreProd";
            this.textBoxNombreProd.Size = new System.Drawing.Size(226, 30);
            this.textBoxNombreProd.TabIndex = 0;
            // 
            // panelBarraProd
            // 
            this.panelBarraProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.panelBarraProd.Controls.Add(this.panel7);
            this.panelBarraProd.Controls.Add(this.btnCerrar);
            this.panelBarraProd.Controls.Add(this.labelProd);
            this.panelBarraProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraProd.Location = new System.Drawing.Point(0, 0);
            this.panelBarraProd.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraProd.Name = "panelBarraProd";
            this.panelBarraProd.Size = new System.Drawing.Size(1280, 35);
            this.panelBarraProd.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(240, 35);
            this.panel7.TabIndex = 7;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1248, 4);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // labelProd
            // 
            this.labelProd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelProd.AutoSize = true;
            this.labelProd.Enabled = false;
            this.labelProd.Font = new System.Drawing.Font("Stencil", 18.32727F, System.Drawing.FontStyle.Bold);
            this.labelProd.ForeColor = System.Drawing.Color.White;
            this.labelProd.Location = new System.Drawing.Point(692, 2);
            this.labelProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProd.Name = "labelProd";
            this.labelProd.Size = new System.Drawing.Size(184, 33);
            this.labelProd.TabIndex = 5;
            this.labelProd.Text = "PRODUCTOS";
            this.labelProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFondoProd
            // 
            this.panelFondoProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelFondoProd.Controls.Add(this.panel6);
            this.panelFondoProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondoProd.Location = new System.Drawing.Point(0, 0);
            this.panelFondoProd.Margin = new System.Windows.Forms.Padding(2);
            this.panelFondoProd.Name = "panelFondoProd";
            this.panelFondoProd.Size = new System.Drawing.Size(1280, 685);
            this.panelFondoProd.TabIndex = 15;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 685);
            this.Controls.Add(this.panelFondoProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            this.panel6.ResumeLayout(false);
            this.panelConteProd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVProd)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelBtnProd.ResumeLayout(false);
            this.panelMenuProd.ResumeLayout(false);
            this.panelMenuProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProd)).EndInit();
            this.panelBarraProd.ResumeLayout(false);
            this.panelBarraProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelFondoProd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel6;
        private Panel panelConteProd;
        private DataGridView dGVProd;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label lblListaProd;
        private Panel panelBtnProd;
        private Button btnEliminarProd;
        private Button btnEditarProd;
        private Panel panel1;
        private Panel panelMenuProd;
        private TextBox textBoxStock;
        private TextBox textBoxPrecio;
        private TextBox textBoxMarca;
        private Button btnGuardarProd;
        private PictureBox pictureBoxProd;
        private Label lblMantProd;
        private Label lblStockProd;
        private Label lblPrecioProd;
        private Label lblMarcaProd;
        private Label lblDescProd;
        private TextBox textBoxDescProd;
        private Label lblNombreProd;
        private TextBox textBoxNombreProd;
        private Panel panelBarraProd;
        private Panel panel7;
        private PictureBox btnCerrar;
        private Label labelProd;
        private Panel panelFondoProd;
    }
}