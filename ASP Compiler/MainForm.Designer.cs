namespace ASP_Compiler
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.FDialog_Source = new System.Windows.Forms.FolderBrowserDialog();
            this.FDialog_Target = new System.Windows.Forms.FolderBrowserDialog();
            this.Pan_Compiler = new System.Windows.Forms.Panel();
            this.Txt_VPath = new System.Windows.Forms.TextBox();
            this.Lbl_VPath = new System.Windows.Forms.Label();
            this.Btn_Compile = new System.Windows.Forms.Button();
            this.Txt_Target = new System.Windows.Forms.TextBox();
            this.Lbl_Target = new System.Windows.Forms.Label();
            this.Txt_Source = new System.Windows.Forms.TextBox();
            this.Lbl_source = new System.Windows.Forms.Label();
            this.RTxt_Result = new System.Windows.Forms.RichTextBox();
            this.Pan_Compiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pan_Compiler
            // 
            this.Pan_Compiler.Controls.Add(this.Txt_VPath);
            this.Pan_Compiler.Controls.Add(this.Lbl_VPath);
            this.Pan_Compiler.Controls.Add(this.Btn_Compile);
            this.Pan_Compiler.Controls.Add(this.Txt_Target);
            this.Pan_Compiler.Controls.Add(this.Lbl_Target);
            this.Pan_Compiler.Controls.Add(this.Txt_Source);
            this.Pan_Compiler.Controls.Add(this.Lbl_source);
            this.Pan_Compiler.Location = new System.Drawing.Point(13, 13);
            this.Pan_Compiler.Name = "Pan_Compiler";
            this.Pan_Compiler.Size = new System.Drawing.Size(268, 122);
            this.Pan_Compiler.TabIndex = 7;
            // 
            // Txt_VPath
            // 
            this.Txt_VPath.Location = new System.Drawing.Point(68, 61);
            this.Txt_VPath.Name = "Txt_VPath";
            this.Txt_VPath.Size = new System.Drawing.Size(191, 20);
            this.Txt_VPath.TabIndex = 39;
            // 
            // Lbl_VPath
            // 
            this.Lbl_VPath.AutoSize = true;
            this.Lbl_VPath.Location = new System.Drawing.Point(0, 64);
            this.Lbl_VPath.Name = "Lbl_VPath";
            this.Lbl_VPath.Size = new System.Drawing.Size(61, 13);
            this.Lbl_VPath.TabIndex = 40;
            this.Lbl_VPath.Text = "Virtual Path";
            // 
            // Btn_Compile
            // 
            this.Btn_Compile.Location = new System.Drawing.Point(98, 87);
            this.Btn_Compile.Name = "Btn_Compile";
            this.Btn_Compile.Size = new System.Drawing.Size(75, 23);
            this.Btn_Compile.TabIndex = 36;
            this.Btn_Compile.Text = "Compile";
            this.Btn_Compile.UseVisualStyleBackColor = true;
            this.Btn_Compile.Click += new System.EventHandler(this.Btn_Compile_Click);
            // 
            // Txt_Target
            // 
            this.Txt_Target.Location = new System.Drawing.Point(68, 35);
            this.Txt_Target.Name = "Txt_Target";
            this.Txt_Target.Size = new System.Drawing.Size(191, 20);
            this.Txt_Target.TabIndex = 35;
            this.Txt_Target.TextChanged += new System.EventHandler(this.Txt_Target_Leave);
            this.Txt_Target.Leave += new System.EventHandler(this.Txt_Target_Leave);
            this.Txt_Target.Enter += new System.EventHandler(this.Txt_Target_Enter);
            // 
            // Lbl_Target
            // 
            this.Lbl_Target.AutoSize = true;
            this.Lbl_Target.Location = new System.Drawing.Point(0, 38);
            this.Lbl_Target.Name = "Lbl_Target";
            this.Lbl_Target.Size = new System.Drawing.Size(38, 13);
            this.Lbl_Target.TabIndex = 37;
            this.Lbl_Target.Text = "Target";
            // 
            // Txt_Source
            // 
            this.Txt_Source.Location = new System.Drawing.Point(68, 9);
            this.Txt_Source.Name = "Txt_Source";
            this.Txt_Source.Size = new System.Drawing.Size(191, 20);
            this.Txt_Source.TabIndex = 34;
            this.Txt_Source.Enter += new System.EventHandler(this.Txt_Source_Enter);
            // 
            // Lbl_source
            // 
            this.Lbl_source.AutoSize = true;
            this.Lbl_source.Location = new System.Drawing.Point(0, 12);
            this.Lbl_source.Name = "Lbl_source";
            this.Lbl_source.Size = new System.Drawing.Size(41, 13);
            this.Lbl_source.TabIndex = 38;
            this.Lbl_source.Text = "Source";
            // 
            // RTxt_Result
            // 
            this.RTxt_Result.Location = new System.Drawing.Point(16, 151);
            this.RTxt_Result.Name = "RTxt_Result";
            this.RTxt_Result.Size = new System.Drawing.Size(256, 96);
            this.RTxt_Result.TabIndex = 8;
            this.RTxt_Result.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 259);
            this.Controls.Add(this.RTxt_Result);
            this.Controls.Add(this.Pan_Compiler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "ASP Compiler";
            this.Pan_Compiler.ResumeLayout(false);
            this.Pan_Compiler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog FDialog_Source;
        private System.Windows.Forms.FolderBrowserDialog FDialog_Target;
        private System.Windows.Forms.Panel Pan_Compiler;
        private System.Windows.Forms.Button Btn_Compile;
        private System.Windows.Forms.TextBox Txt_Target;
        private System.Windows.Forms.Label Lbl_Target;
        private System.Windows.Forms.TextBox Txt_Source;
        private System.Windows.Forms.Label Lbl_source;
        private System.Windows.Forms.TextBox Txt_VPath;
        private System.Windows.Forms.Label Lbl_VPath;
        private System.Windows.Forms.RichTextBox RTxt_Result;
    }
}

