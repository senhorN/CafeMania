
namespace CafeMania
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
            this.components = new System.ComponentModel.Container();
            this.TtlCafeMania = new System.Windows.Forms.Label();
            this.AdmDesenvolvedor = new System.Windows.Forms.Label();
            this.Versao = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LogoCafe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoCafe)).BeginInit();
            this.SuspendLayout();
            // 
            // TtlCafeMania
            // 
            this.TtlCafeMania.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TtlCafeMania.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TtlCafeMania.Location = new System.Drawing.Point(0, 1);
            this.TtlCafeMania.Name = "TtlCafeMania";
            this.TtlCafeMania.Size = new System.Drawing.Size(797, 96);
            this.TtlCafeMania.TabIndex = 0;
            this.TtlCafeMania.Text = "Café Mania ";
            this.TtlCafeMania.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TtlCafeMania.Click += new System.EventHandler(this.TtlCafeMania_Click);
            // 
            // AdmDesenvolvedor
            // 
            this.AdmDesenvolvedor.AutoSize = true;
            this.AdmDesenvolvedor.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdmDesenvolvedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AdmDesenvolvedor.Location = new System.Drawing.Point(545, 432);
            this.AdmDesenvolvedor.Name = "AdmDesenvolvedor";
            this.AdmDesenvolvedor.Size = new System.Drawing.Size(252, 18);
            this.AdmDesenvolvedor.TabIndex = 2;
            this.AdmDesenvolvedor.Text = "Desenvolvido por Nícolas Carloto";
            // 
            // Versao
            // 
            this.Versao.AutoSize = true;
            this.Versao.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Versao.Location = new System.Drawing.Point(12, 432);
            this.Versao.Name = "Versao";
            this.Versao.Size = new System.Drawing.Size(103, 18);
            this.Versao.TabIndex = 3;
            this.Versao.Text = "versão 0.1.6";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LogoCafe
            // 
            this.LogoCafe.Image = global::CafeMania.Properties.Resources.café_quente_removebg_preview;
            this.LogoCafe.Location = new System.Drawing.Point(252, 127);
            this.LogoCafe.Name = "LogoCafe";
            this.LogoCafe.Size = new System.Drawing.Size(280, 216);
            this.LogoCafe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoCafe.TabIndex = 1;
            this.LogoCafe.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Versao);
            this.Controls.Add(this.AdmDesenvolvedor);
            this.Controls.Add(this.LogoCafe);
            this.Controls.Add(this.TtlCafeMania);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.TtlCafeMania_Click);
            ((System.ComponentModel.ISupportInitialize)(this.LogoCafe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TtlCafeMania;
        private System.Windows.Forms.PictureBox LogoCafe;
        private System.Windows.Forms.Label AdmDesenvolvedor;
        private System.Windows.Forms.Label Versao;
        private System.Windows.Forms.Timer timer1;
    }
}