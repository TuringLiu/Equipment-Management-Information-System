﻿namespace 装备库存管理
{
    partial class 装备入库管理
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.装备入库管理添加 = new System.Windows.Forms.Button();
            this.装备入库管理返回 = new System.Windows.Forms.Button();
            this.装备入库管理修改 = new System.Windows.Forms.Button();
            this.装备入库管理删除 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.装备入库选择时间年 = new System.Windows.Forms.ComboBox();
            this.装备入库选择时间月 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(591, 224);
            this.dataGridView1.TabIndex = 0;
            // 
            // 装备入库管理添加
            // 
            this.装备入库管理添加.Location = new System.Drawing.Point(27, 316);
            this.装备入库管理添加.Name = "装备入库管理添加";
            this.装备入库管理添加.Size = new System.Drawing.Size(101, 48);
            this.装备入库管理添加.TabIndex = 1;
            this.装备入库管理添加.Text = "添加";
            this.装备入库管理添加.UseVisualStyleBackColor = true;
            // 
            // 装备入库管理返回
            // 
            this.装备入库管理返回.Location = new System.Drawing.Point(523, 316);
            this.装备入库管理返回.Name = "装备入库管理返回";
            this.装备入库管理返回.Size = new System.Drawing.Size(95, 48);
            this.装备入库管理返回.TabIndex = 2;
            this.装备入库管理返回.Text = "返回";
            this.装备入库管理返回.UseVisualStyleBackColor = true;
            // 
            // 装备入库管理修改
            // 
            this.装备入库管理修改.Location = new System.Drawing.Point(199, 316);
            this.装备入库管理修改.Name = "装备入库管理修改";
            this.装备入库管理修改.Size = new System.Drawing.Size(92, 48);
            this.装备入库管理修改.TabIndex = 5;
            this.装备入库管理修改.Text = "修改";
            this.装备入库管理修改.UseVisualStyleBackColor = true;
            // 
            // 装备入库管理删除
            // 
            this.装备入库管理删除.Location = new System.Drawing.Point(362, 316);
            this.装备入库管理删除.Name = "装备入库管理删除";
            this.装备入库管理删除.Size = new System.Drawing.Size(90, 48);
            this.装备入库管理删除.TabIndex = 6;
            this.装备入库管理删除.Text = "删除";
            this.装备入库管理删除.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "选择时间";
            // 
            // 装备入库选择时间年
            // 
            this.装备入库选择时间年.FormattingEnabled = true;
            this.装备入库选择时间年.Location = new System.Drawing.Point(102, 12);
            this.装备入库选择时间年.Name = "装备入库选择时间年";
            this.装备入库选择时间年.Size = new System.Drawing.Size(68, 20);
            this.装备入库选择时间年.TabIndex = 8;
            // 
            // 装备入库选择时间月
            // 
            this.装备入库选择时间月.FormattingEnabled = true;
            this.装备入库选择时间月.Location = new System.Drawing.Point(199, 12);
            this.装备入库选择时间月.Name = "装备入库选择时间月";
            this.装备入库选择时间月.Size = new System.Drawing.Size(68, 20);
            this.装备入库选择时间月.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "年";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "月";
            // 
            // 装备入库管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 376);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.装备入库选择时间月);
            this.Controls.Add(this.装备入库选择时间年);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.装备入库管理删除);
            this.Controls.Add(this.装备入库管理修改);
            this.Controls.Add(this.装备入库管理返回);
            this.Controls.Add(this.装备入库管理添加);
            this.Controls.Add(this.dataGridView1);
            this.Name = "装备入库管理";
            this.Text = "装备入库管理";
            this.Load += new System.EventHandler(this.装备入库管理_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button 装备入库管理添加;
        private System.Windows.Forms.Button 装备入库管理返回;
        private System.Windows.Forms.Button 装备入库管理修改;
        private System.Windows.Forms.Button 装备入库管理删除;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox 装备入库选择时间年;
        private System.Windows.Forms.ComboBox 装备入库选择时间月;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}