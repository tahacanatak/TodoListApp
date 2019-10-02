namespace TodoListApp
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
            this.clbToDos = new System.Windows.Forms.CheckedListBox();
            this.txtToDo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clbToDos
            // 
            this.clbToDos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbToDos.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clbToDos.FormattingEnabled = true;
            this.clbToDos.Location = new System.Drawing.Point(7, 82);
            this.clbToDos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clbToDos.Name = "clbToDos";
            this.clbToDos.Size = new System.Drawing.Size(343, 340);
            this.clbToDos.TabIndex = 0;
            this.clbToDos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbToDos_ItemCheck);
            this.clbToDos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clbToDos_KeyDown);
            // 
            // txtToDo
            // 
            this.txtToDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToDo.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToDo.Location = new System.Drawing.Point(7, 41);
            this.txtToDo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtToDo.Name = "txtToDo";
            this.txtToDo.Size = new System.Drawing.Size(343, 28);
            this.txtToDo.TabIndex = 1;
            this.txtToDo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToDo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yapılacak:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToDo);
            this.Controls.Add(this.clbToDos);
            this.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Yapılacaklar Listesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbToDos;
        private System.Windows.Forms.TextBox txtToDo;
        private System.Windows.Forms.Label label1;
    }
}

