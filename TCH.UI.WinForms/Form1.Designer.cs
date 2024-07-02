namespace TCH.UI.WinForms
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
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            employeesBindingSource = new BindingSource(components);
            mainViewModelBindingSource = new BindingSource(components);
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)employeesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainViewModelBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBox1.DataSource = employeesBindingSource;
            listBox1.DisplayMember = "FirstName";
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 41;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(213, 578);
            listBox1.TabIndex = 0;
            // 
            // employeesBindingSource
            // 
            employeesBindingSource.DataMember = "Employees";
            employeesBindingSource.DataSource = mainViewModelBindingSource;
            // 
            // mainViewModelBindingSource
            // 
            mainViewModelBindingSource.DataSource = typeof(ViewModels.MainViewModel);
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(252, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(758, 579);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.DataBindings.Add(new Binding("Text", employeesBindingSource, "SaveMessage", true));
            label1.Location = new Point(34, 213);
            label1.Name = "label1";
            label1.Size = new Size(97, 41);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.DataBindings.Add(new Binding("Command", employeesBindingSource, "SaveCommand", true));
            button1.Location = new Point(32, 140);
            button1.Name = "button1";
            button1.Size = new Size(119, 49);
            button1.TabIndex = 2;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.DataBindings.Add(new Binding("Text", employeesBindingSource, "LastName", true));
            textBox2.Location = new Point(27, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(704, 47);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.DataBindings.Add(new Binding("Text", employeesBindingSource, "FirstName", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox1.Location = new Point(27, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(704, 47);
            textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 642);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)employeesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainViewModelBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Panel panel1;
        private Label label1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private BindingSource employeesBindingSource;
        private BindingSource mainViewModelBindingSource;
    }
}