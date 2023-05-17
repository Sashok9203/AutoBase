namespace WinFormsApp1
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
            groupBox1 = new GroupBox();
            colorComboBox = new ComboBox();
            modelComboBox = new ComboBox();
            brandCombotBox = new ComboBox();
            vNumberTextBox = new MaskedTextBox();
            cNumberTextBox = new MaskedTextBox();
            autoCreate = new Button();
            label6 = new Label();
            label5 = new Label();
            yearNumericUpDown = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            autosComboBox = new ListBox();
            groupBox2 = new GroupBox();
            findButton = new Button();
            findComboBox = new ComboBox();
            showAuto = new Button();
            autoDelete = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yearNumericUpDown).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(colorComboBox);
            groupBox1.Controls.Add(modelComboBox);
            groupBox1.Controls.Add(brandCombotBox);
            groupBox1.Controls.Add(vNumberTextBox);
            groupBox1.Controls.Add(cNumberTextBox);
            groupBox1.Controls.Add(autoCreate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(yearNumericUpDown);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 311);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Створити авто";
            // 
            // colorComboBox
            // 
            colorComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            colorComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            colorComboBox.FormattingEnabled = true;
            colorComboBox.Items.AddRange(new object[] { "Червоний", "Помаранчевий", "Жовтий", "Зелений", "Блакитний", "Синій", "Фіолетовий", "Рожевий", "Білий", "Сірий", "Чорний", "Коричневий", "Бежевий", "Золотий", "Срібний" });
            colorComboBox.Location = new Point(113, 98);
            colorComboBox.Name = "colorComboBox";
            colorComboBox.Size = new Size(149, 23);
            colorComboBox.TabIndex = 18;
            colorComboBox.SelectedIndexChanged += colorChanged;
            colorComboBox.Leave += colorChanged;
            // 
            // modelComboBox
            // 
            modelComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            modelComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            modelComboBox.FormattingEnabled = true;
            modelComboBox.Location = new Point(114, 65);
            modelComboBox.Name = "modelComboBox";
            modelComboBox.Size = new Size(149, 23);
            modelComboBox.TabIndex = 17;
            modelComboBox.Text = "   ";
            modelComboBox.SelectedIndexChanged += modelChanged;
            modelComboBox.Leave += modelChanged;
            // 
            // brandCombotBox
            // 
            brandCombotBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            brandCombotBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            brandCombotBox.FormattingEnabled = true;
            brandCombotBox.Items.AddRange(new object[] { "Volkswagen", "Chevrolet", "Toyota", "Ford", "BMW", "Mercedes-Benz", "Fiat", "Honda", "Hyundai", "Nissan", "Subaru", "Mazda", "Volvo", "Jaguar", "Audi", "Porsche", "Skoda", "SEAT" });
            brandCombotBox.Location = new Point(114, 32);
            brandCombotBox.Name = "brandCombotBox";
            brandCombotBox.Size = new Size(149, 23);
            brandCombotBox.TabIndex = 16;
            brandCombotBox.SelectedIndexChanged += brandChanged;
            brandCombotBox.Leave += brandChanged;
            // 
            // vNumberTextBox
            // 
            vNumberTextBox.BeepOnError = true;
            vNumberTextBox.HidePromptOnLeave = true;
            vNumberTextBox.Location = new Point(113, 174);
            vNumberTextBox.Mask = "LLLL00L0LLL000000";
            vNumberTextBox.Name = "vNumberTextBox";
            vNumberTextBox.PromptChar = ' ';
            vNumberTextBox.Size = new Size(150, 23);
            vNumberTextBox.TabIndex = 15;
            vNumberTextBox.Leave += vNumberLeave;
            // 
            // cNumberTextBox
            // 
            cNumberTextBox.BeepOnError = true;
            cNumberTextBox.HidePromptOnLeave = true;
            cNumberTextBox.Location = new Point(113, 134);
            cNumberTextBox.Mask = "LL0000LL";
            cNumberTextBox.Name = "cNumberTextBox";
            cNumberTextBox.PromptChar = ' ';
            cNumberTextBox.Size = new Size(150, 23);
            cNumberTextBox.TabIndex = 14;
            cNumberTextBox.Leave += cNumberLeave;
            // 
            // autoCreate
            // 
            autoCreate.Enabled = false;
            autoCreate.Location = new Point(55, 261);
            autoCreate.Name = "autoCreate";
            autoCreate.Size = new Size(175, 26);
            autoCreate.TabIndex = 13;
            autoCreate.Text = "Створити";
            autoCreate.UseVisualStyleBackColor = true;
            autoCreate.Click += autoCreateButton;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(19, 174);
            label6.Name = "label6";
            label6.Size = new Size(77, 19);
            label6.TabIndex = 11;
            label6.Text = "VIN номер";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(19, 135);
            label5.Name = "label5";
            label5.Size = new Size(88, 19);
            label5.TabIndex = 9;
            label5.Text = "Держ.номер";
            // 
            // yearNumericUpDown
            // 
            yearNumericUpDown.Location = new Point(113, 217);
            yearNumericUpDown.Maximum = new decimal(new int[] { 2023, 0, 0, 0 });
            yearNumericUpDown.Minimum = new decimal(new int[] { 1970, 0, 0, 0 });
            yearNumericUpDown.Name = "yearNumericUpDown";
            yearNumericUpDown.Size = new Size(56, 23);
            yearNumericUpDown.TabIndex = 8;
            yearNumericUpDown.TextAlign = HorizontalAlignment.Center;
            yearNumericUpDown.Value = new decimal(new int[] { 1970, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(19, 217);
            label4.Name = "label4";
            label4.Size = new Size(27, 19);
            label4.TabIndex = 6;
            label4.Text = "Рік";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 102);
            label3.Name = "label3";
            label3.Size = new Size(43, 19);
            label3.TabIndex = 4;
            label3.Text = "Колір";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 66);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 2;
            label2.Text = "Модель";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 35);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 0;
            label1.Text = "Марка";
            // 
            // autosComboBox
            // 
            autosComboBox.Enabled = false;
            autosComboBox.ItemHeight = 15;
            autosComboBox.Location = new Point(6, 22);
            autosComboBox.Name = "autosComboBox";
            autosComboBox.ScrollAlwaysVisible = true;
            autosComboBox.Size = new Size(202, 184);
            autosComboBox.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(findButton);
            groupBox2.Controls.Add(findComboBox);
            groupBox2.Controls.Add(showAuto);
            groupBox2.Controls.Add(autosComboBox);
            groupBox2.Controls.Add(autoDelete);
            groupBox2.Location = new Point(308, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(217, 311);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Доступні авто";
            // 
            // findButton
            // 
            findButton.Enabled = false;
            findButton.Location = new Point(153, 220);
            findButton.Name = "findButton";
            findButton.Size = new Size(57, 23);
            findButton.TabIndex = 17;
            findButton.Text = "Знайти";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // findComboBox
            // 
            findComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            findComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            findComboBox.Enabled = false;
            findComboBox.Location = new Point(8, 220);
            findComboBox.Name = "findComboBox";
            findComboBox.Size = new Size(139, 23);
            findComboBox.TabIndex = 16;
            // 
            // showAuto
            // 
            showAuto.Enabled = false;
            showAuto.Location = new Point(118, 261);
            showAuto.Name = "showAuto";
            showAuto.Size = new Size(93, 26);
            showAuto.TabIndex = 15;
            showAuto.Text = "Показати";
            showAuto.UseVisualStyleBackColor = true;
            showAuto.Click += showAutoButton;
            // 
            // autoDelete
            // 
            autoDelete.Enabled = false;
            autoDelete.Location = new Point(8, 261);
            autoDelete.Name = "autoDelete";
            autoDelete.Size = new Size(93, 26);
            autoDelete.TabIndex = 14;
            autoDelete.Text = "Видалити";
            autoDelete.UseVisualStyleBackColor = true;
            autoDelete.Click += deleteAutoButton;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 346);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            MaximumSize = new Size(570, 385);
            MinimumSize = new Size(570, 385);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "База автомобілів";
            Load += brandChanged;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)yearNumericUpDown).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button autoCreate;
        private Label label6;
        private Label label5;
        private NumericUpDown yearNumericUpDown;
        private ListBox autosComboBox;
        private GroupBox groupBox2;
        private Button autoDelete;
        private MaskedTextBox vNumberTextBox;
        private MaskedTextBox cNumberTextBox;
        private Button showAuto;
        private ComboBox modelComboBox;
        private ComboBox brandCombotBox;
        private ComboBox colorComboBox;
        private Button findButton;
        private ComboBox findComboBox;
    }
}