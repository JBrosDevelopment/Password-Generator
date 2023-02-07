namespace Password_Generator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Output = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Re = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox0 = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Output.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.ForeColor = System.Drawing.Color.SteelBlue;
            this.Output.Location = new System.Drawing.Point(12, 23);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(538, 38);
            this.Output.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDown1.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(430, 133);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 32);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Click += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Re
            // 
            this.Re.BackColor = System.Drawing.Color.SteelBlue;
            this.Re.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Re.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Re.ForeColor = System.Drawing.SystemColors.Control;
            this.Re.Location = new System.Drawing.Point(430, 184);
            this.Re.Name = "Re";
            this.Re.Size = new System.Drawing.Size(120, 47);
            this.Re.TabIndex = 2;
            this.Re.Text = "Regenerate";
            this.Re.UseVisualStyleBackColor = false;
            this.Re.Click += new System.EventHandler(this.Re_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.checkBox1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(12, 120);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 33);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Upper-Case";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.checkBox2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox2.Location = new System.Drawing.Point(12, 159);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(102, 33);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Numbers";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.checkBox3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox3.Location = new System.Drawing.Point(12, 198);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(171, 33);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Special Characters";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox0
            // 
            this.checkBox0.AutoSize = true;
            this.checkBox0.BackColor = System.Drawing.Color.SteelBlue;
            this.checkBox0.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox0.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox0.Location = new System.Drawing.Point(12, 81);
            this.checkBox0.Name = "checkBox0";
            this.checkBox0.Size = new System.Drawing.Size(119, 33);
            this.checkBox0.TabIndex = 6;
            this.checkBox0.Text = "Lower-Case";
            this.checkBox0.UseVisualStyleBackColor = false;
            this.checkBox0.CheckedChanged += new System.EventHandler(this.checkBox0_CheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Password Generator";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(559, 242);
            this.Controls.Add(this.checkBox0);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Re);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Output);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Re;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox0;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

