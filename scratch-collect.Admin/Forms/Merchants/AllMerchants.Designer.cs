﻿namespace scratch_collect.Admin.Forms.Merchants
{
    partial class AllMerchants
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
            this.all_users_main_layout = new System.Windows.Forms.TableLayoutPanel();
            this.all_users_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.merchants_country_filter = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.merchants_delete_button = new System.Windows.Forms.Button();
            this.merchants_edit_button = new System.Windows.Forms.Button();
            this.merchants_new_button = new System.Windows.Forms.Button();
            this.merchants_text_filter = new System.Windows.Forms.TextBox();
            this.merchants_filter_button = new System.Windows.Forms.Button();
            this.users_layout_content_panel = new System.Windows.Forms.Panel();
            this.merchants_datagrid = new System.Windows.Forms.DataGridView();
            this.all_users_main_layout.SuspendLayout();
            this.all_users_panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.users_layout_content_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.merchants_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // all_users_main_layout
            // 
            this.all_users_main_layout.AutoSize = true;
            this.all_users_main_layout.ColumnCount = 1;
            this.all_users_main_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.all_users_main_layout.Controls.Add(this.all_users_panel, 0, 0);
            this.all_users_main_layout.Controls.Add(this.users_layout_content_panel, 0, 1);
            this.all_users_main_layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.all_users_main_layout.Location = new System.Drawing.Point(32, 26);
            this.all_users_main_layout.Margin = new System.Windows.Forms.Padding(2);
            this.all_users_main_layout.Name = "all_users_main_layout";
            this.all_users_main_layout.RowCount = 2;
            this.all_users_main_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.40351F));
            this.all_users_main_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.59649F));
            this.all_users_main_layout.Size = new System.Drawing.Size(1261, 583);
            this.all_users_main_layout.TabIndex = 1;
            // 
            // all_users_panel
            // 
            this.all_users_panel.Controls.Add(this.label2);
            this.all_users_panel.Controls.Add(this.label1);
            this.all_users_panel.Controls.Add(this.merchants_country_filter);
            this.all_users_panel.Controls.Add(this.panel2);
            this.all_users_panel.Controls.Add(this.panel3);
            this.all_users_panel.Controls.Add(this.merchants_text_filter);
            this.all_users_panel.Controls.Add(this.merchants_filter_button);
            this.all_users_panel.Location = new System.Drawing.Point(2, 2);
            this.all_users_panel.Margin = new System.Windows.Forms.Padding(2);
            this.all_users_panel.Name = "all_users_panel";
            this.all_users_panel.Size = new System.Drawing.Size(1256, 62);
            this.all_users_panel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Country:";
            // 
            // merchants_country_filter
            // 
            this.merchants_country_filter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.merchants_country_filter.Location = new System.Drawing.Point(397, 15);
            this.merchants_country_filter.Margin = new System.Windows.Forms.Padding(2);
            this.merchants_country_filter.Name = "merchants_country_filter";
            this.merchants_country_filter.Size = new System.Drawing.Size(194, 29);
            this.merchants_country_filter.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(865, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 38);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.merchants_delete_button);
            this.panel3.Controls.Add(this.merchants_edit_button);
            this.panel3.Controls.Add(this.merchants_new_button);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(894, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(362, 62);
            this.panel3.TabIndex = 3;
            // 
            // merchants_delete_button
            // 
            this.merchants_delete_button.BackColor = System.Drawing.Color.Brown;
            this.merchants_delete_button.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.merchants_delete_button.ForeColor = System.Drawing.Color.LightCoral;
            this.merchants_delete_button.Location = new System.Drawing.Point(33, 13);
            this.merchants_delete_button.Margin = new System.Windows.Forms.Padding(2);
            this.merchants_delete_button.Name = "merchants_delete_button";
            this.merchants_delete_button.Size = new System.Drawing.Size(90, 38);
            this.merchants_delete_button.TabIndex = 6;
            this.merchants_delete_button.Text = "Delete";
            this.merchants_delete_button.UseVisualStyleBackColor = false;
            this.merchants_delete_button.Click += new System.EventHandler(this.merchants_delete_button_Click);
            // 
            // merchants_edit_button
            // 
            this.merchants_edit_button.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.merchants_edit_button.Location = new System.Drawing.Point(158, 12);
            this.merchants_edit_button.Margin = new System.Windows.Forms.Padding(2);
            this.merchants_edit_button.Name = "merchants_edit_button";
            this.merchants_edit_button.Size = new System.Drawing.Size(90, 36);
            this.merchants_edit_button.TabIndex = 5;
            this.merchants_edit_button.Text = "Edit";
            this.merchants_edit_button.UseVisualStyleBackColor = true;
            this.merchants_edit_button.Click += new System.EventHandler(this.merchants_edit_button_Click);
            // 
            // merchants_new_button
            // 
            this.merchants_new_button.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.merchants_new_button.Location = new System.Drawing.Point(269, 13);
            this.merchants_new_button.Margin = new System.Windows.Forms.Padding(2);
            this.merchants_new_button.Name = "merchants_new_button";
            this.merchants_new_button.Size = new System.Drawing.Size(90, 36);
            this.merchants_new_button.TabIndex = 4;
            this.merchants_new_button.Text = "New";
            this.merchants_new_button.UseVisualStyleBackColor = true;
            this.merchants_new_button.Click += new System.EventHandler(this.merchants_new_button_Click);
            // 
            // merchants_text_filter
            // 
            this.merchants_text_filter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.merchants_text_filter.Location = new System.Drawing.Point(54, 15);
            this.merchants_text_filter.Margin = new System.Windows.Forms.Padding(2);
            this.merchants_text_filter.Name = "merchants_text_filter";
            this.merchants_text_filter.Size = new System.Drawing.Size(194, 29);
            this.merchants_text_filter.TabIndex = 2;
            // 
            // merchants_filter_button
            // 
            this.merchants_filter_button.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.merchants_filter_button.Location = new System.Drawing.Point(690, 10);
            this.merchants_filter_button.Margin = new System.Windows.Forms.Padding(2);
            this.merchants_filter_button.Name = "merchants_filter_button";
            this.merchants_filter_button.Size = new System.Drawing.Size(90, 39);
            this.merchants_filter_button.TabIndex = 1;
            this.merchants_filter_button.Text = "Filter";
            this.merchants_filter_button.UseVisualStyleBackColor = true;
            this.merchants_filter_button.Click += new System.EventHandler(this.merchants_filter_button_Click);
            // 
            // users_layout_content_panel
            // 
            this.users_layout_content_panel.Controls.Add(this.merchants_datagrid);
            this.users_layout_content_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.users_layout_content_panel.Location = new System.Drawing.Point(2, 68);
            this.users_layout_content_panel.Margin = new System.Windows.Forms.Padding(2);
            this.users_layout_content_panel.Name = "users_layout_content_panel";
            this.users_layout_content_panel.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.users_layout_content_panel.Size = new System.Drawing.Size(1257, 513);
            this.users_layout_content_panel.TabIndex = 3;
            // 
            // merchants_datagrid
            // 
            this.merchants_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.merchants_datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.merchants_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.merchants_datagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.merchants_datagrid.Location = new System.Drawing.Point(4, 3);
            this.merchants_datagrid.Margin = new System.Windows.Forms.Padding(2);
            this.merchants_datagrid.MultiSelect = false;
            this.merchants_datagrid.Name = "merchants_datagrid";
            this.merchants_datagrid.ReadOnly = true;
            this.merchants_datagrid.RowHeadersWidth = 62;
            this.merchants_datagrid.RowTemplate.Height = 33;
            this.merchants_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.merchants_datagrid.Size = new System.Drawing.Size(1249, 507);
            this.merchants_datagrid.TabIndex = 0;
            this.merchants_datagrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.merchants_datagrid_DataBindingComplete);
            this.merchants_datagrid.SelectionChanged += new System.EventHandler(this.merchants_datagrid_SelectionChanged);
            // 
            // AllMerchants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 635);
            this.Controls.Add(this.all_users_main_layout);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AllMerchants";
            this.Padding = new System.Windows.Forms.Padding(32, 26, 32, 26);
            this.Text = "All Merchants";
            this.Load += new System.EventHandler(this.AllMerchants_Load);
            this.all_users_main_layout.ResumeLayout(false);
            this.all_users_panel.ResumeLayout(false);
            this.all_users_panel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.users_layout_content_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.merchants_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel all_users_main_layout;
        private System.Windows.Forms.Panel all_users_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button merchants_delete_button;
        private System.Windows.Forms.Button merchants_edit_button;
        private System.Windows.Forms.Button merchants_new_button;
        private System.Windows.Forms.TextBox merchants_text_filter;
        private System.Windows.Forms.Button merchants_filter_button;
        private System.Windows.Forms.Panel users_layout_content_panel;
        private System.Windows.Forms.DataGridView merchants_datagrid;
        private System.Windows.Forms.TextBox merchants_country_filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}