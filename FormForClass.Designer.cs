
namespace DiplomaProjectActEmp_KSV
{
    partial class FormForClass
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label worker_IDLabel;
            System.Windows.Forms.Label label1;
            this.actEmpDataSet = new DiplomaProjectActEmp_KSV.ActEmpDataSet();
            this.aCTIVITY_EMPLOYEETableAdapter = new DiplomaProjectActEmp_KSV.ActEmpDataSetTableAdapters.ACTIVITY_EMPLOYEETableAdapter();
            this.tableAdapterManager = new DiplomaProjectActEmp_KSV.ActEmpDataSetTableAdapters.TableAdapterManager();
            this.wORKERTableAdapter = new DiplomaProjectActEmp_KSV.ActEmpDataSetTableAdapters.WORKERTableAdapter();
            this.wORKERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worker_IDComboBox = new System.Windows.Forms.ComboBox();
            this.wORKERDataGridView = new System.Windows.Forms.DataGridView();
            this.pOSTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSTTableAdapter = new DiplomaProjectActEmp_KSV.ActEmpDataSetTableAdapters.POSTTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            worker_IDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.actEmpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wORKERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wORKERDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // actEmpDataSet
            // 
            this.actEmpDataSet.DataSetName = "ActEmpDataSet";
            this.actEmpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aCTIVITY_EMPLOYEETableAdapter
            // 
            this.aCTIVITY_EMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACCESS_LEVELTableAdapter = null;
            this.tableAdapterManager.ACTIVITY_EMPLOYEETableAdapter = this.aCTIVITY_EMPLOYEETableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DISCIPLINETableAdapter = null;
            this.tableAdapterManager.EDUCATION_FORMTableAdapter = null;
            this.tableAdapterManager.EVENT_MATERIALSTableAdapter = null;
            this.tableAdapterManager.EVENTTableAdapter = null;
            this.tableAdapterManager.POSTTableAdapter = this.pOSTTableAdapter;
            this.tableAdapterManager.SPECIALITYTableAdapter = null;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DiplomaProjectActEmp_KSV.ActEmpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERTableAdapter = null;
            this.tableAdapterManager.WORKERTableAdapter = this.wORKERTableAdapter;
            // 
            // wORKERTableAdapter
            // 
            this.wORKERTableAdapter.ClearBeforeFill = true;
            // 
            // wORKERBindingSource
            // 
            this.wORKERBindingSource.DataMember = "WORKER";
            this.wORKERBindingSource.DataSource = this.actEmpDataSet;
            // 
            // worker_IDLabel
            // 
            worker_IDLabel.AutoSize = true;
            worker_IDLabel.Location = new System.Drawing.Point(15, 35);
            worker_IDLabel.Name = "worker_IDLabel";
            worker_IDLabel.Size = new System.Drawing.Size(90, 13);
            worker_IDLabel.TabIndex = 0;
            worker_IDLabel.Text = "Код сотрудника:";
            // 
            // worker_IDComboBox
            // 
            this.worker_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wORKERBindingSource, "Worker_ID", true));
            this.worker_IDComboBox.FormattingEnabled = true;
            this.worker_IDComboBox.Location = new System.Drawing.Point(105, 32);
            this.worker_IDComboBox.Name = "worker_IDComboBox";
            this.worker_IDComboBox.Size = new System.Drawing.Size(121, 21);
            this.worker_IDComboBox.TabIndex = 1;
            // 
            // wORKERDataGridView
            // 
            this.wORKERDataGridView.AutoGenerateColumns = false;
            this.wORKERDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.wORKERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wORKERDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.wORKERDataGridView.DataSource = this.wORKERBindingSource;
            this.wORKERDataGridView.Location = new System.Drawing.Point(232, 12);
            this.wORKERDataGridView.Name = "wORKERDataGridView";
            this.wORKERDataGridView.RowHeadersVisible = false;
            this.wORKERDataGridView.Size = new System.Drawing.Size(556, 109);
            this.wORKERDataGridView.TabIndex = 2;
            // 
            // pOSTBindingSource
            // 
            this.pOSTBindingSource.DataMember = "POST";
            this.pOSTBindingSource.DataSource = this.actEmpDataSet;
            // 
            // pOSTTableAdapter
            // 
            this.pOSTTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Worker_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Worker_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Lastname";
            this.dataGridViewTextBoxColumn4.HeaderText = "Lastname";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 78;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Post_ID";
            this.dataGridViewTextBoxColumn5.DataSource = this.pOSTBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn5.HeaderText = "Post";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "Post_ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 266);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 266);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 13);
            label1.TabIndex = 4;
            label1.Text = "Код мет. акт.:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(245, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Проверить правильность";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormForClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.wORKERDataGridView);
            this.Controls.Add(worker_IDLabel);
            this.Controls.Add(this.worker_IDComboBox);
            this.Name = "FormForClass";
            this.Text = "FormForClass";
            this.Load += new System.EventHandler(this.FormForClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.actEmpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wORKERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wORKERDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ActEmpDataSet actEmpDataSet;
        private ActEmpDataSetTableAdapters.ACTIVITY_EMPLOYEETableAdapter aCTIVITY_EMPLOYEETableAdapter;
        private ActEmpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ActEmpDataSetTableAdapters.WORKERTableAdapter wORKERTableAdapter;
        private ActEmpDataSetTableAdapters.POSTTableAdapter pOSTTableAdapter;
        private System.Windows.Forms.BindingSource wORKERBindingSource;
        private System.Windows.Forms.ComboBox worker_IDComboBox;
        private System.Windows.Forms.DataGridView wORKERDataGridView;
        private System.Windows.Forms.BindingSource pOSTBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}