﻿namespace Ventas
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.comprasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.facturaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.facturaToolStripMenuItem.Text = "Factura";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesDeClientesToolStripMenuItem,
            this.reportesDeProductoToolStripMenuItem,
            this.reportesDeVentaToolStripMenuItem,
            this.reportesDeComprasToolStripMenuItem,
            this.reportesDeProveedoresToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reportesDeClientesToolStripMenuItem
            // 
            this.reportesDeClientesToolStripMenuItem.Name = "reportesDeClientesToolStripMenuItem";
            this.reportesDeClientesToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.reportesDeClientesToolStripMenuItem.Text = "Reportes de Clientes";
            this.reportesDeClientesToolStripMenuItem.Click += new System.EventHandler(this.reportesDeClientesToolStripMenuItem_Click);
            // 
            // reportesDeProductoToolStripMenuItem
            // 
            this.reportesDeProductoToolStripMenuItem.Name = "reportesDeProductoToolStripMenuItem";
            this.reportesDeProductoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.reportesDeProductoToolStripMenuItem.Text = "Reportes de Productos";
            this.reportesDeProductoToolStripMenuItem.Click += new System.EventHandler(this.reportesDeProductoToolStripMenuItem_Click);
            // 
            // reportesDeVentaToolStripMenuItem
            // 
            this.reportesDeVentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porClienteToolStripMenuItem,
            this.porProductosToolStripMenuItem,
            this.totalesToolStripMenuItem});
            this.reportesDeVentaToolStripMenuItem.Name = "reportesDeVentaToolStripMenuItem";
            this.reportesDeVentaToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.reportesDeVentaToolStripMenuItem.Text = "Reportes de Ventas";
            // 
            // porClienteToolStripMenuItem
            // 
            this.porClienteToolStripMenuItem.Name = "porClienteToolStripMenuItem";
            this.porClienteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.porClienteToolStripMenuItem.Text = "Por Cliente";
            // 
            // porProductosToolStripMenuItem
            // 
            this.porProductosToolStripMenuItem.Name = "porProductosToolStripMenuItem";
            this.porProductosToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.porProductosToolStripMenuItem.Text = "Por Producto";
            // 
            // totalesToolStripMenuItem
            // 
            this.totalesToolStripMenuItem.Name = "totalesToolStripMenuItem";
            this.totalesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.totalesToolStripMenuItem.Text = "Totales";
            this.totalesToolStripMenuItem.Click += new System.EventHandler(this.totalesToolStripMenuItem_Click);
            // 
            // reportesDeComprasToolStripMenuItem
            // 
            this.reportesDeComprasToolStripMenuItem.Name = "reportesDeComprasToolStripMenuItem";
            this.reportesDeComprasToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.reportesDeComprasToolStripMenuItem.Text = "Reportes de Compras ";
            this.reportesDeComprasToolStripMenuItem.Click += new System.EventHandler(this.reportesDeComprasToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasToolStripMenuItem1,
            this.proveedoresToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // comprasToolStripMenuItem1
            // 
            this.comprasToolStripMenuItem1.Name = "comprasToolStripMenuItem1";
            this.comprasToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.comprasToolStripMenuItem1.Text = "Compras";
            this.comprasToolStripMenuItem1.Click += new System.EventHandler(this.comprasToolStripMenuItem1_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // reportesDeProveedoresToolStripMenuItem
            // 
            this.reportesDeProveedoresToolStripMenuItem.Name = "reportesDeProveedoresToolStripMenuItem";
            this.reportesDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.reportesDeProveedoresToolStripMenuItem.Text = "Reportes de Proveedores";
            this.reportesDeProveedoresToolStripMenuItem.Click += new System.EventHandler(this.reportesDeProveedoresToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 583);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeProveedoresToolStripMenuItem;
    }
}