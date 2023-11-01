namespace laba1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            username = new TextBox();
            userAge = new TextBox();
            userRegistrDate = new DateTimePicker();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SearchByName = new Button();
            SearchByAge = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(30, 108);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 0;
            button1.Text = "Добавить пользователя";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(30, 164);
            button2.Name = "button2";
            button2.Size = new Size(150, 50);
            button2.TabIndex = 1;
            button2.Text = "Удалить пользователя";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(30, 220);
            button3.Name = "button3";
            button3.Size = new Size(150, 50);
            button3.TabIndex = 2;
            button3.Text = "Изменить пользователя";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(187, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(601, 423);
            dataGridView1.TabIndex = 5;
            // 
            // username
            // 
            username.Location = new Point(30, 21);
            username.Name = "username";
            username.PlaceholderText = "username";
            username.Size = new Size(150, 23);
            username.TabIndex = 6;
            // 
            // userAge
            // 
            userAge.Location = new Point(30, 50);
            userAge.Name = "userAge";
            userAge.PlaceholderText = "Age";
            userAge.Size = new Size(150, 23);
            userAge.TabIndex = 8;
            // 
            // userRegistrDate
            // 
            userRegistrDate.Location = new Point(30, 79);
            userRegistrDate.Name = "userRegistrDate";
            userRegistrDate.Size = new Size(150, 23);
            userRegistrDate.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 276);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Поиск по имени...";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(31, 340);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Поиск по возрасту...";
            textBox2.Size = new Size(150, 23);
            textBox2.TabIndex = 11;
            // 
            // SearchByName
            // 
            SearchByName.Location = new Point(31, 305);
            SearchByName.Name = "SearchByName";
            SearchByName.Size = new Size(150, 29);
            SearchByName.TabIndex = 12;
            SearchByName.Text = "Поиск по Имени";
            SearchByName.UseVisualStyleBackColor = true;
            SearchByName.Click += SearchByName_Click;
            // 
            // SearchByAge
            // 
            SearchByAge.Location = new Point(30, 369);
            SearchByAge.Name = "SearchByAge";
            SearchByAge.Size = new Size(150, 33);
            SearchByAge.TabIndex = 13;
            SearchByAge.Text = "Поиск по возрасту";
            SearchByAge.UseVisualStyleBackColor = true;
            SearchByAge.Click += SearchByAge_Click;
            // 
            // button4
            // 
            button4.Location = new Point(31, 408);
            button4.Name = "button4";
            button4.Size = new Size(149, 36);
            button4.TabIndex = 14;
            button4.Text = "Сброс фильтров";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(button4);
            Controls.Add(SearchByAge);
            Controls.Add(SearchByName);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(userRegistrDate);
            Controls.Add(userAge);
            Controls.Add(username);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private TextBox username;
        private TextBox userAge;
        private DateTimePicker userRegistrDate;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button SearchByName;
        private Button SearchByAge;
        private Button button4;
    }
}