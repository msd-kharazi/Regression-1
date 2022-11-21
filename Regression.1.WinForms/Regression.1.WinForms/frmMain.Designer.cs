namespace Regression._1.WinForms
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblGuide = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.dgInputData = new System.Windows.Forms.DataGridView();
            this.clX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xlY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnLinear = new System.Windows.Forms.Button();
            this.btnExponential = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.rtResult = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgInputData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGuide
            // 
            this.lblGuide.AutoSize = true;
            this.lblGuide.Location = new System.Drawing.Point(12, 9);
            this.lblGuide.Name = "lblGuide";
            this.lblGuide.Size = new System.Drawing.Size(116, 15);
            this.lblGuide.TabIndex = 0;
            this.lblGuide.Text = "First fill in some data";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(297, 34);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 23);
            this.txtX.TabIndex = 1;
            // 
            // dgInputData
            // 
            this.dgInputData.AllowUserToAddRows = false;
            this.dgInputData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInputData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgInputData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInputData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clX,
            this.xlY});
            this.dgInputData.Location = new System.Drawing.Point(12, 34);
            this.dgInputData.Name = "dgInputData";
            this.dgInputData.ReadOnly = true;
            this.dgInputData.RowTemplate.Height = 25;
            this.dgInputData.Size = new System.Drawing.Size(252, 150);
            this.dgInputData.TabIndex = 2;
            // 
            // clX
            // 
            this.clX.DataPropertyName = "Key";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clX.DefaultCellStyle = dataGridViewCellStyle2;
            this.clX.HeaderText = "X";
            this.clX.Name = "clX";
            this.clX.ReadOnly = true;
            // 
            // xlY
            // 
            this.xlY.DataPropertyName = "Value";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.xlY.DefaultCellStyle = dataGridViewCellStyle3;
            this.xlY.HeaderText = "Y";
            this.xlY.Name = "xlY";
            this.xlY.ReadOnly = true;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(426, 34);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 23);
            this.txtY.TabIndex = 6;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(274, 37);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 15);
            this.lblX.TabIndex = 8;
            this.lblX.Text = "X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(403, 37);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 15);
            this.lblY.TabIndex = 9;
            this.lblY.Text = "Y:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(274, 63);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(274, 92);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 11;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnLinear
            // 
            this.btnLinear.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLinear.Location = new System.Drawing.Point(12, 202);
            this.btnLinear.Name = "btnLinear";
            this.btnLinear.Size = new System.Drawing.Size(141, 43);
            this.btnLinear.TabIndex = 12;
            this.btnLinear.Text = "Linear";
            this.btnLinear.UseVisualStyleBackColor = true;
            this.btnLinear.Click += new System.EventHandler(this.btnLinear_Click);
            // 
            // btnExponential
            // 
            this.btnExponential.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExponential.Location = new System.Drawing.Point(1020, 202);
            this.btnExponential.Name = "btnExponential";
            this.btnExponential.Size = new System.Drawing.Size(159, 43);
            this.btnExponential.TabIndex = 13;
            this.btnExponential.Text = "Exponential";
            this.btnExponential.UseVisualStyleBackColor = true;
            this.btnExponential.Click += new System.EventHandler(this.btnExponential_Click);
            // 
            // btnPower
            // 
            this.btnPower.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPower.Location = new System.Drawing.Point(516, 202);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(141, 43);
            this.btnPower.TabIndex = 14;
            this.btnPower.Text = "Power";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // rtResult
            // 
            this.rtResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtResult.Location = new System.Drawing.Point(12, 251);
            this.rtResult.Name = "rtResult";
            this.rtResult.Size = new System.Drawing.Size(1168, 537);
            this.rtResult.TabIndex = 15;
            this.rtResult.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 800);
            this.Controls.Add(this.rtResult);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnExponential);
            this.Controls.Add(this.btnLinear);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.dgInputData);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblGuide);
            this.Name = "frmMain";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInputData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblGuide;
        private TextBox txtX;
        private DataGridView dgInputData;
        private TextBox txtY;
        private Label lblX;
        private Label lblY;
        private Button btnAdd;
        private Button btnClearAll;
        private DataGridViewTextBoxColumn clX;
        private DataGridViewTextBoxColumn xlY;
        private Button btnLinear;
        private Button btnExponential;
        private Button btnPower;
        private RichTextBox rtResult;
    }
}