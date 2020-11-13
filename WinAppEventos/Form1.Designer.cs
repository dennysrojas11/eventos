namespace WinAppEventos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEvento = new System.Windows.Forms.Button();
            this.textBoxEvento1 = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelEvento1 = new System.Windows.Forms.Label();
            this.labelEvento2 = new System.Windows.Forms.Label();
            this.groupBoxEventos12 = new System.Windows.Forms.GroupBox();
            this.groupBoxEventos345 = new System.Windows.Forms.GroupBox();
            this.labelEvento3 = new System.Windows.Forms.Label();
            this.labelEvento4 = new System.Windows.Forms.Label();
            this.textBoxEvento4 = new System.Windows.Forms.TextBox();
            this.labelEvento5 = new System.Windows.Forms.Label();
            this.buttonEvento5 = new System.Windows.Forms.Button();
            this.buttonEvento2 = new System.Windows.Forms.Button();
            this.groupBoxEventos12.SuspendLayout();
            this.groupBoxEventos345.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEvento
            // 
            this.buttonEvento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEvento.Font = new System.Drawing.Font("Momcake", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEvento.Location = new System.Drawing.Point(151, 130);
            this.buttonEvento.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEvento.Name = "buttonEvento";
            this.buttonEvento.Size = new System.Drawing.Size(219, 36);
            this.buttonEvento.TabIndex = 0;
            this.buttonEvento.Text = "Ejecutar eventos";
            this.buttonEvento.UseVisualStyleBackColor = true;
            this.buttonEvento.Click += new System.EventHandler(this.buttonEventos_Click);
            // 
            // textBoxEvento1
            // 
            this.textBoxEvento1.Font = new System.Drawing.Font("Momcake", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEvento1.Location = new System.Drawing.Point(14, 80);
            this.textBoxEvento1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEvento1.Name = "textBoxEvento1";
            this.textBoxEvento1.Size = new System.Drawing.Size(248, 22);
            this.textBoxEvento1.TabIndex = 1;
            this.textBoxEvento1.BackColorChanged += new System.EventHandler(this.textBoxEvento1_BackColorChanged);
            this.textBoxEvento1.TextChanged += new System.EventHandler(this.textBoxEvento1_TextChanged);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Momcake", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(196, 20);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(182, 48);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "EVENTOS";
            // 
            // labelEvento1
            // 
            this.labelEvento1.AutoSize = true;
            this.labelEvento1.Font = new System.Drawing.Font("Momcake", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvento1.Location = new System.Drawing.Point(33, 36);
            this.labelEvento1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEvento1.Name = "labelEvento1";
            this.labelEvento1.Size = new System.Drawing.Size(205, 16);
            this.labelEvento1.TabIndex = 3;
            this.labelEvento1.Text = "Evento 1: BackColorChanged";
            // 
            // labelEvento2
            // 
            this.labelEvento2.AutoSize = true;
            this.labelEvento2.Font = new System.Drawing.Font("Momcake", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvento2.Location = new System.Drawing.Point(297, 36);
            this.labelEvento2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEvento2.Name = "labelEvento2";
            this.labelEvento2.Size = new System.Drawing.Size(252, 16);
            this.labelEvento2.TabIndex = 4;
            this.labelEvento2.Text = "Evento 2: BackgroundImageChanged";
            this.labelEvento2.Click += new System.EventHandler(this.labelEvento2_Click);
            // 
            // groupBoxEventos12
            // 
            this.groupBoxEventos12.Controls.Add(this.labelEvento1);
            this.groupBoxEventos12.Controls.Add(this.buttonEvento2);
            this.groupBoxEventos12.Controls.Add(this.buttonEvento);
            this.groupBoxEventos12.Controls.Add(this.textBoxEvento1);
            this.groupBoxEventos12.Controls.Add(this.labelEvento2);
            this.groupBoxEventos12.Font = new System.Drawing.Font("Momcake", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEventos12.Location = new System.Drawing.Point(22, 80);
            this.groupBoxEventos12.Name = "groupBoxEventos12";
            this.groupBoxEventos12.Size = new System.Drawing.Size(554, 180);
            this.groupBoxEventos12.TabIndex = 6;
            this.groupBoxEventos12.TabStop = false;
            this.groupBoxEventos12.Text = "Eventos 1 y 2";
            // 
            // groupBoxEventos345
            // 
            this.groupBoxEventos345.Controls.Add(this.buttonEvento5);
            this.groupBoxEventos345.Controls.Add(this.labelEvento5);
            this.groupBoxEventos345.Controls.Add(this.textBoxEvento4);
            this.groupBoxEventos345.Controls.Add(this.labelEvento4);
            this.groupBoxEventos345.Controls.Add(this.labelEvento3);
            this.groupBoxEventos345.Font = new System.Drawing.Font("Momcake", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEventos345.Location = new System.Drawing.Point(22, 282);
            this.groupBoxEventos345.Name = "groupBoxEventos345";
            this.groupBoxEventos345.Size = new System.Drawing.Size(554, 132);
            this.groupBoxEventos345.TabIndex = 7;
            this.groupBoxEventos345.TabStop = false;
            this.groupBoxEventos345.Text = "Eventos 3, 4 y 5";
            // 
            // labelEvento3
            // 
            this.labelEvento3.AutoSize = true;
            this.labelEvento3.Font = new System.Drawing.Font("Momcake", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvento3.Location = new System.Drawing.Point(22, 42);
            this.labelEvento3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEvento3.Name = "labelEvento3";
            this.labelEvento3.Size = new System.Drawing.Size(157, 16);
            this.labelEvento3.TabIndex = 6;
            this.labelEvento3.Text = "Evento 3: MouseHover";
            this.labelEvento3.MouseHover += new System.EventHandler(this.labelEvento3_MouseHover);
            // 
            // labelEvento4
            // 
            this.labelEvento4.AutoSize = true;
            this.labelEvento4.Font = new System.Drawing.Font("Momcake", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvento4.Location = new System.Drawing.Point(22, 90);
            this.labelEvento4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEvento4.Name = "labelEvento4";
            this.labelEvento4.Size = new System.Drawing.Size(133, 16);
            this.labelEvento4.TabIndex = 7;
            this.labelEvento4.Text = "Evento 4: KeyPress";
            this.labelEvento4.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxEvento4
            // 
            this.textBoxEvento4.Font = new System.Drawing.Font("Momcake", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEvento4.Location = new System.Drawing.Point(182, 89);
            this.textBoxEvento4.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEvento4.Name = "textBoxEvento4";
            this.textBoxEvento4.Size = new System.Drawing.Size(128, 22);
            this.textBoxEvento4.TabIndex = 6;
            this.textBoxEvento4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEvento4_KeyPress);
            // 
            // labelEvento5
            // 
            this.labelEvento5.AutoSize = true;
            this.labelEvento5.Font = new System.Drawing.Font("Momcake", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvento5.Location = new System.Drawing.Point(374, 26);
            this.labelEvento5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEvento5.Name = "labelEvento5";
            this.labelEvento5.Size = new System.Drawing.Size(151, 16);
            this.labelEvento5.TabIndex = 8;
            this.labelEvento5.Text = "Evento 5: MouseMove";
            // 
            // buttonEvento5
            // 
            this.buttonEvento5.BackgroundImage = global::WinAppEventos.Properties.Resources.mouse;
            this.buttonEvento5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEvento5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEvento5.Location = new System.Drawing.Point(418, 45);
            this.buttonEvento5.Name = "buttonEvento5";
            this.buttonEvento5.Size = new System.Drawing.Size(72, 74);
            this.buttonEvento5.TabIndex = 6;
            this.buttonEvento5.UseVisualStyleBackColor = true;
            this.buttonEvento5.Click += new System.EventHandler(this.button1_Click);
            this.buttonEvento5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonEvento5_MouseMove);
            // 
            // buttonEvento2
            // 
            this.buttonEvento2.BackgroundImage = global::WinAppEventos.Properties.Resources.apagar;
            this.buttonEvento2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEvento2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEvento2.Location = new System.Drawing.Point(377, 55);
            this.buttonEvento2.Name = "buttonEvento2";
            this.buttonEvento2.Size = new System.Drawing.Size(83, 63);
            this.buttonEvento2.TabIndex = 5;
            this.buttonEvento2.UseVisualStyleBackColor = true;
            this.buttonEvento2.BackgroundImageChanged += new System.EventHandler(this.buttonEvento2_BackgroundImageChanged);
            this.buttonEvento2.Click += new System.EventHandler(this.buttonEvento2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(606, 426);
            this.Controls.Add(this.groupBoxEventos345);
            this.Controls.Add(this.groupBoxEventos12);
            this.Controls.Add(this.labelTitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxEventos12.ResumeLayout(false);
            this.groupBoxEventos12.PerformLayout();
            this.groupBoxEventos345.ResumeLayout(false);
            this.groupBoxEventos345.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEvento;
        private System.Windows.Forms.TextBox textBoxEvento1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelEvento1;
        private System.Windows.Forms.Label labelEvento2;
        private System.Windows.Forms.Button buttonEvento2;
        private System.Windows.Forms.GroupBox groupBoxEventos12;
        private System.Windows.Forms.GroupBox groupBoxEventos345;
        private System.Windows.Forms.Label labelEvento3;
        private System.Windows.Forms.Label labelEvento4;
        private System.Windows.Forms.TextBox textBoxEvento4;
        private System.Windows.Forms.Label labelEvento5;
        private System.Windows.Forms.Button buttonEvento5;
    }
}

