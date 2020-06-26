namespace MatrixCalc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LeftMatrix = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RightMatrix = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ResultMatrix = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Mul = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LeftCols = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.LeftRows = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.RightCols = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.RightRows = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.LeftMulValuebtn = new System.Windows.Forms.Button();
            this.RightMulValuebtn = new System.Windows.Forms.Button();
            this.LeftMulValue = new System.Windows.Forms.NumericUpDown();
            this.RightMulValue = new System.Windows.Forms.NumericUpDown();
            this.InverseLeft = new System.Windows.Forms.Button();
            this.InverseRight = new System.Windows.Forms.Button();
            this.DetLeft = new System.Windows.Forms.Button();
            this.DetRight = new System.Windows.Forms.Button();
            this.CopyLeft = new System.Windows.Forms.Button();
            this.CopyRight = new System.Windows.Forms.Button();
            this.InverseResult = new System.Windows.Forms.Button();
            this.DetResult = new System.Windows.Forms.Button();
            this.LeftRigth = new System.Windows.Forms.Button();
            this.RandomA = new System.Windows.Forms.Button();
            this.RandomB = new System.Windows.Forms.Button();
            this.ClearA = new System.Windows.Forms.Button();
            this.ClearB = new System.Windows.Forms.Button();
            this.ClearResult = new System.Windows.Forms.Button();
            this.TransA = new System.Windows.Forms.Button();
            this.TransB = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftMatrix)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightMatrix)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftMulValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightMulValue)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LeftMatrix);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 350);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Матрица A";
            // 
            // LeftMatrix
            // 
            this.LeftMatrix.AllowUserToAddRows = false;
            this.LeftMatrix.AllowUserToDeleteRows = false;
            this.LeftMatrix.AllowUserToResizeColumns = false;
            this.LeftMatrix.AllowUserToResizeRows = false;
            this.LeftMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LeftMatrix.BackgroundColor = System.Drawing.Color.Gray;
            this.LeftMatrix.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.LeftMatrix.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.LeftMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.LeftMatrix.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LeftMatrix.DefaultCellStyle = dataGridViewCellStyle1;
            this.LeftMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftMatrix.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.LeftMatrix.Location = new System.Drawing.Point(3, 16);
            this.LeftMatrix.Name = "LeftMatrix";
            this.LeftMatrix.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LeftMatrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.LeftMatrix.RowHeadersVisible = false;
            this.LeftMatrix.RowTemplate.Height = 23;
            this.LeftMatrix.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LeftMatrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.LeftMatrix.Size = new System.Drawing.Size(344, 331);
            this.LeftMatrix.TabIndex = 89;
            this.LeftMatrix.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.LeftMatrix_EditingControlShowing);
            this.LeftMatrix.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.LeftMatrix_RowsAdded);
            this.LeftMatrix.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.LeftMatrix_RowsRemoved);
            this.LeftMatrix.Resize += new System.EventHandler(this.LeftMatrix_Resize);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RightMatrix);
            this.groupBox2.Location = new System.Drawing.Point(438, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 350);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Матрица B";
            // 
            // RightMatrix
            // 
            this.RightMatrix.AllowUserToAddRows = false;
            this.RightMatrix.AllowUserToDeleteRows = false;
            this.RightMatrix.AllowUserToResizeColumns = false;
            this.RightMatrix.AllowUserToResizeRows = false;
            this.RightMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RightMatrix.BackgroundColor = System.Drawing.Color.Gray;
            this.RightMatrix.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.RightMatrix.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.RightMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.RightMatrix.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RightMatrix.DefaultCellStyle = dataGridViewCellStyle3;
            this.RightMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightMatrix.Location = new System.Drawing.Point(3, 16);
            this.RightMatrix.Name = "RightMatrix";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RightMatrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.RightMatrix.RowHeadersVisible = false;
            this.RightMatrix.RowTemplate.Height = 23;
            this.RightMatrix.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RightMatrix.Size = new System.Drawing.Size(344, 331);
            this.RightMatrix.TabIndex = 90;
            this.RightMatrix.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.LeftMatrix_RowsAdded);
            this.RightMatrix.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.LeftMatrix_RowsRemoved);
            this.RightMatrix.Resize += new System.EventHandler(this.LeftMatrix_Resize);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ResultMatrix);
            this.groupBox3.Location = new System.Drawing.Point(861, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 350);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Результирующая матрица";
            // 
            // ResultMatrix
            // 
            this.ResultMatrix.AllowUserToAddRows = false;
            this.ResultMatrix.AllowUserToDeleteRows = false;
            this.ResultMatrix.AllowUserToResizeColumns = false;
            this.ResultMatrix.AllowUserToResizeRows = false;
            this.ResultMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ResultMatrix.BackgroundColor = System.Drawing.Color.Gray;
            this.ResultMatrix.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ResultMatrix.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ResultMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ResultMatrix.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.NullValue = "0";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultMatrix.DefaultCellStyle = dataGridViewCellStyle5;
            this.ResultMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultMatrix.Location = new System.Drawing.Point(3, 16);
            this.ResultMatrix.Name = "ResultMatrix";
            this.ResultMatrix.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultMatrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ResultMatrix.RowHeadersVisible = false;
            this.ResultMatrix.RowTemplate.Height = 23;
            this.ResultMatrix.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultMatrix.Size = new System.Drawing.Size(344, 331);
            this.ResultMatrix.TabIndex = 91;
            this.ResultMatrix.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.LeftMatrix_RowsAdded);
            this.ResultMatrix.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.LeftMatrix_RowsRemoved);
            this.ResultMatrix.Resize += new System.EventHandler(this.LeftMatrix_Resize);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(368, 89);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(64, 64);
            this.Add.TabIndex = 3;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Sub
            // 
            this.Sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sub.Location = new System.Drawing.Point(368, 159);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(64, 64);
            this.Sub.TabIndex = 4;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Mul
            // 
            this.Mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mul.Location = new System.Drawing.Point(368, 229);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(64, 64);
            this.Mul.TabIndex = 5;
            this.Mul.Text = "*";
            this.Mul.UseVisualStyleBackColor = true;
            this.Mul.Click += new System.EventHandler(this.Mul_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(142, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Столбцы:";
            // 
            // LeftCols
            // 
            this.LeftCols.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftCols.Location = new System.Drawing.Point(210, 367);
            this.LeftCols.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.LeftCols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LeftCols.Name = "LeftCols";
            this.LeftCols.Size = new System.Drawing.Size(60, 21);
            this.LeftCols.TabIndex = 14;
            this.LeftCols.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.LeftCols.ValueChanged += new System.EventHandler(this.LeftCols_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Строки:";
            // 
            // LeftRows
            // 
            this.LeftRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftRows.Location = new System.Drawing.Point(70, 367);
            this.LeftRows.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.LeftRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LeftRows.Name = "LeftRows";
            this.LeftRows.Size = new System.Drawing.Size(60, 21);
            this.LeftRows.TabIndex = 12;
            this.LeftRows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.LeftRows.ValueChanged += new System.EventHandler(this.LeftRows_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(568, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Столбцы:";
            // 
            // RightCols
            // 
            this.RightCols.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightCols.Location = new System.Drawing.Point(636, 365);
            this.RightCols.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RightCols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RightCols.Name = "RightCols";
            this.RightCols.Size = new System.Drawing.Size(60, 21);
            this.RightCols.TabIndex = 18;
            this.RightCols.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.RightCols.ValueChanged += new System.EventHandler(this.RightCols_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(438, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Строки:";
            // 
            // RightRows
            // 
            this.RightRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightRows.Location = new System.Drawing.Point(496, 367);
            this.RightRows.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RightRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RightRows.Name = "RightRows";
            this.RightRows.Size = new System.Drawing.Size(60, 21);
            this.RightRows.TabIndex = 16;
            this.RightRows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.RightRows.ValueChanged += new System.EventHandler(this.RightRows_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(810, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 31);
            this.label5.TabIndex = 20;
            this.label5.Text = "=";
            // 
            // LeftMulValuebtn
            // 
            this.LeftMulValuebtn.Location = new System.Drawing.Point(15, 394);
            this.LeftMulValuebtn.Name = "LeftMulValuebtn";
            this.LeftMulValuebtn.Size = new System.Drawing.Size(144, 23);
            this.LeftMulValuebtn.TabIndex = 21;
            this.LeftMulValuebtn.Text = "Умножить матрицу A на:";
            this.LeftMulValuebtn.UseVisualStyleBackColor = true;
            this.LeftMulValuebtn.Click += new System.EventHandler(this.LeftMulValuebtn_Click);
            // 
            // RightMulValuebtn
            // 
            this.RightMulValuebtn.Location = new System.Drawing.Point(441, 394);
            this.RightMulValuebtn.Name = "RightMulValuebtn";
            this.RightMulValuebtn.Size = new System.Drawing.Size(144, 23);
            this.RightMulValuebtn.TabIndex = 22;
            this.RightMulValuebtn.Text = "Умножить матрицу B на:";
            this.RightMulValuebtn.UseVisualStyleBackColor = true;
            this.RightMulValuebtn.Click += new System.EventHandler(this.RightMulValuebtn_Click);
            // 
            // LeftMulValue
            // 
            this.LeftMulValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftMulValue.Location = new System.Drawing.Point(165, 396);
            this.LeftMulValue.Name = "LeftMulValue";
            this.LeftMulValue.Size = new System.Drawing.Size(105, 21);
            this.LeftMulValue.TabIndex = 23;
            // 
            // RightMulValue
            // 
            this.RightMulValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightMulValue.Location = new System.Drawing.Point(591, 396);
            this.RightMulValue.Name = "RightMulValue";
            this.RightMulValue.Size = new System.Drawing.Size(105, 21);
            this.RightMulValue.TabIndex = 24;
            // 
            // InverseLeft
            // 
            this.InverseLeft.Location = new System.Drawing.Point(15, 423);
            this.InverseLeft.Name = "InverseLeft";
            this.InverseLeft.Size = new System.Drawing.Size(124, 23);
            this.InverseLeft.TabIndex = 25;
            this.InverseLeft.Text = "Обратная матрица";
            this.InverseLeft.UseVisualStyleBackColor = true;
            this.InverseLeft.Click += new System.EventHandler(this.InverseLeft_Click);
            // 
            // InverseRight
            // 
            this.InverseRight.Location = new System.Drawing.Point(441, 421);
            this.InverseRight.Name = "InverseRight";
            this.InverseRight.Size = new System.Drawing.Size(124, 23);
            this.InverseRight.TabIndex = 26;
            this.InverseRight.Text = "Обратная матрица";
            this.InverseRight.UseVisualStyleBackColor = true;
            this.InverseRight.Click += new System.EventHandler(this.InverseRight_Click);
            // 
            // DetLeft
            // 
            this.DetLeft.Location = new System.Drawing.Point(145, 423);
            this.DetLeft.Name = "DetLeft";
            this.DetLeft.Size = new System.Drawing.Size(125, 23);
            this.DetLeft.TabIndex = 27;
            this.DetLeft.Text = "Определитель";
            this.DetLeft.UseVisualStyleBackColor = true;
            this.DetLeft.Click += new System.EventHandler(this.DetLeft_Click);
            // 
            // DetRight
            // 
            this.DetRight.Location = new System.Drawing.Point(571, 421);
            this.DetRight.Name = "DetRight";
            this.DetRight.Size = new System.Drawing.Size(125, 23);
            this.DetRight.TabIndex = 28;
            this.DetRight.Text = "Определитель";
            this.DetRight.UseVisualStyleBackColor = true;
            this.DetRight.Click += new System.EventHandler(this.DetRight_Click);
            // 
            // CopyLeft
            // 
            this.CopyLeft.Location = new System.Drawing.Point(916, 367);
            this.CopyLeft.Name = "CopyLeft";
            this.CopyLeft.Size = new System.Drawing.Size(255, 23);
            this.CopyLeft.TabIndex = 29;
            this.CopyLeft.Text = "Скопировать результат в матрицу A";
            this.CopyLeft.UseVisualStyleBackColor = true;
            this.CopyLeft.Click += new System.EventHandler(this.CopyLeft_Click);
            // 
            // CopyRight
            // 
            this.CopyRight.Location = new System.Drawing.Point(916, 395);
            this.CopyRight.Name = "CopyRight";
            this.CopyRight.Size = new System.Drawing.Size(255, 23);
            this.CopyRight.TabIndex = 30;
            this.CopyRight.Text = "Скопировать результат в матрицу B";
            this.CopyRight.UseVisualStyleBackColor = true;
            this.CopyRight.Click += new System.EventHandler(this.CopyRight_Click);
            // 
            // InverseResult
            // 
            this.InverseResult.Location = new System.Drawing.Point(916, 424);
            this.InverseResult.Name = "InverseResult";
            this.InverseResult.Size = new System.Drawing.Size(255, 23);
            this.InverseResult.TabIndex = 31;
            this.InverseResult.Text = "Обратная матрица";
            this.InverseResult.UseVisualStyleBackColor = true;
            this.InverseResult.Click += new System.EventHandler(this.InverseResult_Click);
            // 
            // DetResult
            // 
            this.DetResult.Location = new System.Drawing.Point(916, 450);
            this.DetResult.Name = "DetResult";
            this.DetResult.Size = new System.Drawing.Size(125, 23);
            this.DetResult.TabIndex = 32;
            this.DetResult.Text = "Определитель";
            this.DetResult.UseVisualStyleBackColor = true;
            this.DetResult.Click += new System.EventHandler(this.DetResult_Click);
            // 
            // LeftRigth
            // 
            this.LeftRigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftRigth.Location = new System.Drawing.Point(368, 19);
            this.LeftRigth.Name = "LeftRigth";
            this.LeftRigth.Size = new System.Drawing.Size(64, 64);
            this.LeftRigth.TabIndex = 33;
            this.LeftRigth.Text = "->\r\n<-";
            this.LeftRigth.UseVisualStyleBackColor = true;
            this.LeftRigth.Click += new System.EventHandler(this.LeftRigth_Click);
            // 
            // RandomA
            // 
            this.RandomA.Location = new System.Drawing.Point(368, 299);
            this.RandomA.Name = "RandomA";
            this.RandomA.Size = new System.Drawing.Size(64, 32);
            this.RandomA.TabIndex = 34;
            this.RandomA.Text = "Рандом A";
            this.RandomA.UseVisualStyleBackColor = true;
            this.RandomA.Click += new System.EventHandler(this.RandomA_Click);
            // 
            // RandomB
            // 
            this.RandomB.Location = new System.Drawing.Point(368, 330);
            this.RandomB.Name = "RandomB";
            this.RandomB.Size = new System.Drawing.Size(64, 32);
            this.RandomB.TabIndex = 35;
            this.RandomB.Text = "Рандом B";
            this.RandomB.UseVisualStyleBackColor = true;
            this.RandomB.Click += new System.EventHandler(this.RandomB_Click);
            // 
            // ClearA
            // 
            this.ClearA.Location = new System.Drawing.Point(15, 479);
            this.ClearA.Name = "ClearA";
            this.ClearA.Size = new System.Drawing.Size(255, 23);
            this.ClearA.TabIndex = 36;
            this.ClearA.Text = "Очистить матрицу A";
            this.ClearA.UseVisualStyleBackColor = true;
            this.ClearA.Click += new System.EventHandler(this.ClearA_Click);
            // 
            // ClearB
            // 
            this.ClearB.Location = new System.Drawing.Point(441, 479);
            this.ClearB.Name = "ClearB";
            this.ClearB.Size = new System.Drawing.Size(255, 23);
            this.ClearB.TabIndex = 37;
            this.ClearB.Text = "Очистить матрицу B";
            this.ClearB.UseVisualStyleBackColor = true;
            this.ClearB.Click += new System.EventHandler(this.ClearB_Click);
            // 
            // ClearResult
            // 
            this.ClearResult.Location = new System.Drawing.Point(916, 479);
            this.ClearResult.Name = "ClearResult";
            this.ClearResult.Size = new System.Drawing.Size(255, 23);
            this.ClearResult.TabIndex = 38;
            this.ClearResult.Text = "Очистить результирующую матрицу";
            this.ClearResult.UseVisualStyleBackColor = true;
            this.ClearResult.Click += new System.EventHandler(this.ClearResult_Click);
            // 
            // TransA
            // 
            this.TransA.Location = new System.Drawing.Point(15, 450);
            this.TransA.Name = "TransA";
            this.TransA.Size = new System.Drawing.Size(255, 23);
            this.TransA.TabIndex = 39;
            this.TransA.Text = "Транспонировать матрицу A";
            this.TransA.UseVisualStyleBackColor = true;
            this.TransA.Click += new System.EventHandler(this.TransA_Click);
            // 
            // TransB
            // 
            this.TransB.Location = new System.Drawing.Point(441, 450);
            this.TransB.Name = "TransB";
            this.TransB.Size = new System.Drawing.Size(255, 23);
            this.TransB.TabIndex = 40;
            this.TransB.Text = "Транспонировать матрицу B";
            this.TransB.UseVisualStyleBackColor = true;
            this.TransB.Click += new System.EventHandler(this.TransB_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(702, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1047, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 514);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TransB);
            this.Controls.Add(this.TransA);
            this.Controls.Add(this.ClearResult);
            this.Controls.Add(this.ClearB);
            this.Controls.Add(this.ClearA);
            this.Controls.Add(this.RandomB);
            this.Controls.Add(this.RandomA);
            this.Controls.Add(this.LeftRigth);
            this.Controls.Add(this.InverseLeft);
            this.Controls.Add(this.DetResult);
            this.Controls.Add(this.InverseResult);
            this.Controls.Add(this.CopyRight);
            this.Controls.Add(this.CopyLeft);
            this.Controls.Add(this.DetRight);
            this.Controls.Add(this.DetLeft);
            this.Controls.Add(this.InverseRight);
            this.Controls.Add(this.RightMulValue);
            this.Controls.Add(this.LeftMulValue);
            this.Controls.Add(this.RightMulValuebtn);
            this.Controls.Add(this.LeftMulValuebtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RightCols);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RightRows);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LeftCols);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LeftRows);
            this.Controls.Add(this.Mul);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Матричный Калькулятор - Сделал: Рахманов Артур";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeftMatrix)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RightMatrix)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftMulValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightMulValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView LeftMatrix;
        private System.Windows.Forms.DataGridView RightMatrix;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView ResultMatrix;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Mul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown LeftCols;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown LeftRows;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown RightCols;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown RightRows;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button LeftMulValuebtn;
        private System.Windows.Forms.Button RightMulValuebtn;
        private System.Windows.Forms.NumericUpDown LeftMulValue;
        private System.Windows.Forms.NumericUpDown RightMulValue;
        private System.Windows.Forms.Button InverseLeft;
        private System.Windows.Forms.Button InverseRight;
        private System.Windows.Forms.Button DetLeft;
        private System.Windows.Forms.Button DetRight;
        private System.Windows.Forms.Button CopyLeft;
        private System.Windows.Forms.Button CopyRight;
        private System.Windows.Forms.Button InverseResult;
        private System.Windows.Forms.Button DetResult;
        private System.Windows.Forms.Button LeftRigth;
        private System.Windows.Forms.Button RandomA;
        private System.Windows.Forms.Button RandomB;
        private System.Windows.Forms.Button ClearA;
        private System.Windows.Forms.Button ClearB;
        private System.Windows.Forms.Button ClearResult;
        private System.Windows.Forms.Button TransA;
        private System.Windows.Forms.Button TransB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

