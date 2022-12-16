
namespace Глазки_ООП
{
    partial class FORMA
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
            this.push = new System.Windows.Forms.Button();
            this.pop = new System.Windows.Forms.Button();
            this.top = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.pushBox = new System.Windows.Forms.TextBox();
            this.popBox = new System.Windows.Forms.TextBox();
            this.topBox = new System.Windows.Forms.TextBox();
            this.errorBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // push
            // 
            this.push.Location = new System.Drawing.Point(453, 129);
            this.push.Name = "push";
            this.push.Size = new System.Drawing.Size(75, 23);
            this.push.TabIndex = 0;
            this.push.Text = "Push";
            this.push.UseVisualStyleBackColor = true;
            this.push.Click += new System.EventHandler(this.push_Click);
            // 
            // pop
            // 
            this.pop.Location = new System.Drawing.Point(453, 202);
            this.pop.Name = "pop";
            this.pop.Size = new System.Drawing.Size(75, 23);
            this.pop.TabIndex = 1;
            this.pop.Text = "Pop";
            this.pop.UseVisualStyleBackColor = true;
            this.pop.Click += new System.EventHandler(this.pop_Click);
            // 
            // top
            // 
            this.top.Location = new System.Drawing.Point(453, 276);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(75, 23);
            this.top.TabIndex = 2;
            this.top.Text = "Top";
            this.top.UseVisualStyleBackColor = true;
            this.top.Click += new System.EventHandler(this.top_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.Honeydew;
            this.richTextBox.Location = new System.Drawing.Point(45, 81);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(250, 349);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            // 
            // pushBox
            // 
            this.pushBox.Location = new System.Drawing.Point(339, 129);
            this.pushBox.Name = "pushBox";
            this.pushBox.Size = new System.Drawing.Size(108, 20);
            this.pushBox.TabIndex = 4;
            // 
            // popBox
            // 
            this.popBox.Location = new System.Drawing.Point(339, 204);
            this.popBox.Name = "popBox";
            this.popBox.Size = new System.Drawing.Size(108, 20);
            this.popBox.TabIndex = 5;
            // 
            // topBox
            // 
            this.topBox.Location = new System.Drawing.Point(339, 278);
            this.topBox.Name = "topBox";
            this.topBox.Size = new System.Drawing.Size(108, 20);
            this.topBox.TabIndex = 6;
            // 
            // errorBox
            // 
            this.errorBox.Location = new System.Drawing.Point(45, 39);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(693, 20);
            this.errorBox.TabIndex = 7;
            // 
            // FORMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(765, 476);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.topBox);
            this.Controls.Add(this.popBox);
            this.Controls.Add(this.pushBox);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.top);
            this.Controls.Add(this.pop);
            this.Controls.Add(this.push);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "FORMA";
            this.Opacity = 0.95D;
            this.Text = "Очередь";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button push;
        private System.Windows.Forms.Button pop;
        private System.Windows.Forms.Button top;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.TextBox pushBox;
        private System.Windows.Forms.TextBox popBox;
        private System.Windows.Forms.TextBox topBox;
        private System.Windows.Forms.TextBox errorBox;
    }
}

