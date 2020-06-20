namespace Ankets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ApplicationTextBox = new System.Windows.Forms.RichTextBox();
            this.ButtonApproved = new System.Windows.Forms.Button();
            this.ButtonMeeting = new System.Windows.Forms.Button();
            this.ButtonNotApproved = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ApplicationTextBox
            // 
            this.ApplicationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplicationTextBox.Location = new System.Drawing.Point(449, 27);
            this.ApplicationTextBox.Name = "ApplicationTextBox";
            this.ApplicationTextBox.ReadOnly = true;
            this.ApplicationTextBox.Size = new System.Drawing.Size(545, 479);
            this.ApplicationTextBox.TabIndex = 0;
            this.ApplicationTextBox.Text = "";
            this.ApplicationTextBox.Visible = false;
            // 
            // ButtonApproved
            // 
            this.ButtonApproved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButtonApproved.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonApproved.Location = new System.Drawing.Point(161, 44);
            this.ButtonApproved.Name = "ButtonApproved";
            this.ButtonApproved.Size = new System.Drawing.Size(144, 59);
            this.ButtonApproved.TabIndex = 1;
            this.ButtonApproved.Text = "Принят";
            this.ButtonApproved.UseVisualStyleBackColor = false;
            this.ButtonApproved.Visible = false;
            this.ButtonApproved.Click += new System.EventHandler(this.ButtonApproved_Click);
            // 
            // ButtonMeeting
            // 
            this.ButtonMeeting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ButtonMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMeeting.Location = new System.Drawing.Point(144, 223);
            this.ButtonMeeting.Name = "ButtonMeeting";
            this.ButtonMeeting.Size = new System.Drawing.Size(183, 69);
            this.ButtonMeeting.TabIndex = 2;
            this.ButtonMeeting.Text = "Собеседование";
            this.ButtonMeeting.UseVisualStyleBackColor = false;
            this.ButtonMeeting.Visible = false;
            this.ButtonMeeting.Click += new System.EventHandler(this.ButtonMeeting_Click);
            // 
            // ButtonNotApproved
            // 
            this.ButtonNotApproved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButtonNotApproved.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNotApproved.Location = new System.Drawing.Point(161, 425);
            this.ButtonNotApproved.Name = "ButtonNotApproved";
            this.ButtonNotApproved.Size = new System.Drawing.Size(144, 59);
            this.ButtonNotApproved.TabIndex = 3;
            this.ButtonNotApproved.Text = "Отказано";
            this.ButtonNotApproved.UseVisualStyleBackColor = false;
            this.ButtonNotApproved.Visible = false;
            this.ButtonNotApproved.Click += new System.EventHandler(this.ButtonNotApproved_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 554);
            this.Controls.Add(this.ButtonNotApproved);
            this.Controls.Add(this.ButtonMeeting);
            this.Controls.Add(this.ButtonApproved);
            this.Controls.Add(this.ApplicationTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Проверялка анкет";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ApplicationTextBox;
        private System.Windows.Forms.Button ButtonApproved;
        private System.Windows.Forms.Button ButtonMeeting;
        private System.Windows.Forms.Button ButtonNotApproved;
    }
}

