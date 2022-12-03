
namespace NewList
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Append_button = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Append_box = new System.Windows.Forms.TextBox();
            this.Remove_button = new System.Windows.Forms.Button();
            this.Remove_box = new System.Windows.Forms.TextBox();
            this.Prepend_button = new System.Windows.Forms.Button();
            this.Index_Box = new System.Windows.Forms.TextBox();
            this.Insert_button = new System.Windows.Forms.Button();
            this.Remove_index_button = new System.Windows.Forms.Button();
            this.Find_button = new System.Windows.Forms.Button();
            this.Find_index_button = new System.Windows.Forms.Button();
            this.Find_Box = new System.Windows.Forms.TextBox();
            this.Find_Index_Box = new System.Windows.Forms.TextBox();
            this.error_Box = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Append_button
            // 
            this.Append_button.Location = new System.Drawing.Point(257, 32);
            this.Append_button.Name = "Append_button";
            this.Append_button.Size = new System.Drawing.Size(147, 23);
            this.Append_button.TabIndex = 0;
            this.Append_button.Text = "Добавить в конец";
            this.Append_button.UseVisualStyleBackColor = true;
            this.Append_button.Click += new System.EventHandler(this.Append_button_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(191, 318);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Append_box
            // 
            this.Append_box.Location = new System.Drawing.Point(410, 34);
            this.Append_box.Name = "Append_box";
            this.Append_box.Size = new System.Drawing.Size(151, 20);
            this.Append_box.TabIndex = 2;
            // 
            // Remove_button
            // 
            this.Remove_button.Location = new System.Drawing.Point(257, 149);
            this.Remove_button.Name = "Remove_button";
            this.Remove_button.Size = new System.Drawing.Size(147, 23);
            this.Remove_button.TabIndex = 3;
            this.Remove_button.Text = "Удалить по значению";
            this.Remove_button.UseVisualStyleBackColor = true;
            this.Remove_button.Click += new System.EventHandler(this.Remove_button_Click);
            // 
            // Remove_box
            // 
            this.Remove_box.Location = new System.Drawing.Point(410, 151);
            this.Remove_box.Name = "Remove_box";
            this.Remove_box.Size = new System.Drawing.Size(151, 20);
            this.Remove_box.TabIndex = 4;
            // 
            // Prepend_button
            // 
            this.Prepend_button.Location = new System.Drawing.Point(257, 61);
            this.Prepend_button.Name = "Prepend_button";
            this.Prepend_button.Size = new System.Drawing.Size(147, 23);
            this.Prepend_button.TabIndex = 5;
            this.Prepend_button.Text = "Добавить в начало";
            this.Prepend_button.UseVisualStyleBackColor = true;
            this.Prepend_button.Click += new System.EventHandler(this.Prepend_button_Click);
            // 
            // Index_Box
            // 
            this.Index_Box.Location = new System.Drawing.Point(410, 104);
            this.Index_Box.Name = "Index_Box";
            this.Index_Box.Size = new System.Drawing.Size(54, 20);
            this.Index_Box.TabIndex = 6;
            // 
            // Insert_button
            // 
            this.Insert_button.Location = new System.Drawing.Point(257, 90);
            this.Insert_button.Name = "Insert_button";
            this.Insert_button.Size = new System.Drawing.Size(147, 23);
            this.Insert_button.TabIndex = 7;
            this.Insert_button.Text = "Добавить по индексу";
            this.Insert_button.UseVisualStyleBackColor = true;
            this.Insert_button.Click += new System.EventHandler(this.Insert_button_Click);
            // 
            // Remove_index_button
            // 
            this.Remove_index_button.Location = new System.Drawing.Point(257, 119);
            this.Remove_index_button.Name = "Remove_index_button";
            this.Remove_index_button.Size = new System.Drawing.Size(147, 23);
            this.Remove_index_button.TabIndex = 8;
            this.Remove_index_button.Text = "Удалить по индексу";
            this.Remove_index_button.UseVisualStyleBackColor = true;
            this.Remove_index_button.Click += new System.EventHandler(this.Remove_index_button_Click);
            // 
            // Find_button
            // 
            this.Find_button.Location = new System.Drawing.Point(257, 198);
            this.Find_button.Name = "Find_button";
            this.Find_button.Size = new System.Drawing.Size(147, 23);
            this.Find_button.TabIndex = 9;
            this.Find_button.Text = "Искать по значению";
            this.Find_button.UseVisualStyleBackColor = true;
            this.Find_button.Click += new System.EventHandler(this.Find_button_Click);
            // 
            // Find_index_button
            // 
            this.Find_index_button.Location = new System.Drawing.Point(257, 227);
            this.Find_index_button.Name = "Find_index_button";
            this.Find_index_button.Size = new System.Drawing.Size(147, 23);
            this.Find_index_button.TabIndex = 10;
            this.Find_index_button.Text = "Искать по индексу";
            this.Find_index_button.UseVisualStyleBackColor = true;
            this.Find_index_button.Click += new System.EventHandler(this.Find_index_button_Click);
            // 
            // Find_Box
            // 
            this.Find_Box.Location = new System.Drawing.Point(410, 200);
            this.Find_Box.Name = "Find_Box";
            this.Find_Box.Size = new System.Drawing.Size(151, 20);
            this.Find_Box.TabIndex = 11;
            // 
            // Find_Index_Box
            // 
            this.Find_Index_Box.Location = new System.Drawing.Point(410, 230);
            this.Find_Index_Box.Name = "Find_Index_Box";
            this.Find_Index_Box.Size = new System.Drawing.Size(54, 20);
            this.Find_Index_Box.TabIndex = 12;
            // 
            // error_Box
            // 
            this.error_Box.Location = new System.Drawing.Point(257, 6);
            this.error_Box.Name = "error_Box";
            this.error_Box.Size = new System.Drawing.Size(304, 20);
            this.error_Box.TabIndex = 13;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(470, 230);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(91, 20);
            this.textBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.error_Box);
            this.Controls.Add(this.Find_Index_Box);
            this.Controls.Add(this.Find_Box);
            this.Controls.Add(this.Find_index_button);
            this.Controls.Add(this.Find_button);
            this.Controls.Add(this.Remove_index_button);
            this.Controls.Add(this.Insert_button);
            this.Controls.Add(this.Index_Box);
            this.Controls.Add(this.Prepend_button);
            this.Controls.Add(this.Remove_box);
            this.Controls.Add(this.Remove_button);
            this.Controls.Add(this.Append_box);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Append_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Append_button;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox Append_box;
        private System.Windows.Forms.Button Remove_button;
        private System.Windows.Forms.TextBox Remove_box;
        private System.Windows.Forms.Button Prepend_button;
        private System.Windows.Forms.TextBox Index_Box;
        private System.Windows.Forms.Button Insert_button;
        private System.Windows.Forms.Button Remove_index_button;
        private System.Windows.Forms.Button Find_button;
        private System.Windows.Forms.Button Find_index_button;
        private System.Windows.Forms.TextBox Find_Box;
        private System.Windows.Forms.TextBox Find_Index_Box;
        private System.Windows.Forms.TextBox error_Box;
        private System.Windows.Forms.TextBox textBox;
    }
}

