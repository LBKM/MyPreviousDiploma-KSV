
namespace DiplomaProjectActEmp_KSV
{
    partial class FormAuthorization
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorization));
            this.buttonGo = new System.Windows.Forms.Button();
            this.actEmpDataSet = new DiplomaProjectActEmp_KSV.ActEmpDataSet();
            this.uSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSERTableAdapter = new DiplomaProjectActEmp_KSV.ActEmpDataSetTableAdapters.USERTableAdapter();
            this.tableAdapterManager = new DiplomaProjectActEmp_KSV.ActEmpDataSetTableAdapters.TableAdapterManager();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2GradientButtonExit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.checkBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2TextBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBoxLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.actEmpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGo
            // 
            this.buttonGo.BackColor = System.Drawing.Color.Transparent;
            this.buttonGo.BackgroundImage = global::DiplomaProjectActEmp_KSV.Properties.Resources._1307883;
            this.buttonGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGo.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGo.ForeColor = System.Drawing.Color.Indigo;
            this.buttonGo.Location = new System.Drawing.Point(739, 0);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(116, 408);
            this.buttonGo.TabIndex = 4;
            this.buttonGo.Text = "\r\n\r\n\r\n\r\n\r\n\r\nВойти\r\n";
            this.buttonGo.UseVisualStyleBackColor = false;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // actEmpDataSet
            // 
            this.actEmpDataSet.DataSetName = "ActEmpDataSet";
            this.actEmpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERBindingSource
            // 
            this.uSERBindingSource.DataMember = "USER";
            this.uSERBindingSource.DataSource = this.actEmpDataSet;
            // 
            // uSERTableAdapter
            // 
            this.uSERTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACCESS_LEVELTableAdapter = null;
            this.tableAdapterManager.ACTIVITY_EMPLOYEETableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DISCIPLINETableAdapter = null;
            this.tableAdapterManager.EDUCATION_FORMTableAdapter = null;
            this.tableAdapterManager.EVENT_MATERIALSTableAdapter = null;
            this.tableAdapterManager.EVENTTableAdapter = null;
            this.tableAdapterManager.POSTTableAdapter = null;
            this.tableAdapterManager.SPECIALITYTableAdapter = null;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DiplomaProjectActEmp_KSV.ActEmpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERTableAdapter = this.uSERTableAdapter;
            this.tableAdapterManager.WORKERTableAdapter = null;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderThickness = 10;
            this.guna2GradientPanel1.Controls.Add(this.guna2CustomGradientPanel1);
            this.guna2GradientPanel1.Controls.Add(this.buttonGo);
            this.guna2GradientPanel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Indigo;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.AliceBlue;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(855, 408);
            this.guna2GradientPanel1.TabIndex = 13;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2GradientButtonExit);
            this.guna2CustomGradientPanel1.Controls.Add(this.checkBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2TextBoxPassword);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2TextBoxLogin);
            this.guna2CustomGradientPanel1.Controls.Add(this.button2);
            this.guna2CustomGradientPanel1.Controls.Add(this.label6);
            this.guna2CustomGradientPanel1.Controls.Add(this.textBox2);
            this.guna2CustomGradientPanel1.Controls.Add(this.linkLabel2);
            this.guna2CustomGradientPanel1.Controls.Add(this.pictureBox2);
            this.guna2CustomGradientPanel1.Controls.Add(this.checkBox2);
            this.guna2CustomGradientPanel1.Controls.Add(this.label7);
            this.guna2CustomGradientPanel1.Controls.Add(this.label8);
            this.guna2CustomGradientPanel1.Controls.Add(this.label5);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.GhostWhite;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Lavender;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.LightSteelBlue;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.LavenderBlush;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(739, 408);
            this.guna2CustomGradientPanel1.TabIndex = 13;
            // 
            // guna2GradientButtonExit
            // 
            this.guna2GradientButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2GradientButtonExit.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButtonExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButtonExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButtonExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButtonExit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButtonExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButtonExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2GradientButtonExit.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButtonExit.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.guna2GradientButtonExit.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButtonExit.Location = new System.Drawing.Point(706, 0);
            this.guna2GradientButtonExit.Name = "guna2GradientButtonExit";
            this.guna2GradientButtonExit.Size = new System.Drawing.Size(33, 32);
            this.guna2GradientButtonExit.TabIndex = 23;
            this.guna2GradientButtonExit.Text = "X";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox1.CheckedState.BorderRadius = 0;
            this.checkBox1.CheckedState.BorderThickness = 0;
            this.checkBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.checkBox1.Location = new System.Drawing.Point(104, 263);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 25);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Войти как гость";
            this.checkBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBox1.UncheckedState.BorderRadius = 0;
            this.checkBox1.UncheckedState.BorderThickness = 0;
            this.checkBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // guna2TextBoxPassword
            // 
            this.guna2TextBoxPassword.Animated = true;
            this.guna2TextBoxPassword.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBoxPassword.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBoxPassword.BorderRadius = 10;
            this.guna2TextBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxPassword.DefaultText = "";
            this.guna2TextBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxPassword.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2TextBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2TextBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxPassword.Location = new System.Drawing.Point(341, 127);
            this.guna2TextBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBoxPassword.Name = "guna2TextBoxPassword";
            this.guna2TextBoxPassword.PasswordChar = '*';
            this.guna2TextBoxPassword.PlaceholderText = "";
            this.guna2TextBoxPassword.SelectedText = "";
            this.guna2TextBoxPassword.ShadowDecoration.BorderRadius = 10;
            this.guna2TextBoxPassword.Size = new System.Drawing.Size(249, 27);
            this.guna2TextBoxPassword.TabIndex = 22;
            // 
            // guna2TextBoxLogin
            // 
            this.guna2TextBoxLogin.Animated = true;
            this.guna2TextBoxLogin.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBoxLogin.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBoxLogin.BorderRadius = 10;
            this.guna2TextBoxLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxLogin.DefaultText = "";
            this.guna2TextBoxLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxLogin.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2TextBoxLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2TextBoxLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxLogin.Location = new System.Drawing.Point(341, 183);
            this.guna2TextBoxLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBoxLogin.Name = "guna2TextBoxLogin";
            this.guna2TextBoxLogin.PasswordChar = '\0';
            this.guna2TextBoxLogin.PlaceholderText = "";
            this.guna2TextBoxLogin.SelectedText = "";
            this.guna2TextBoxLogin.ShadowDecoration.BorderRadius = 10;
            this.guna2TextBoxLogin.Size = new System.Drawing.Size(249, 26);
            this.guna2TextBoxLogin.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Indigo;
            this.button2.Location = new System.Drawing.Point(12, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 34);
            this.button2.TabIndex = 20;
            this.button2.Text = "Зашифровать пароль";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(229, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Зашифрованный пароль:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(478, 364);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(200, 21);
            this.textBox2.TabIndex = 18;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.DisabledLinkColor = System.Drawing.Color.Indigo;
            this.linkLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Indigo;
            this.linkLabel2.Location = new System.Drawing.Point(379, 225);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(174, 21);
            this.linkLabel2.TabIndex = 17;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Зарегистрироваться";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(104, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 136);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.ForeColor = System.Drawing.Color.Indigo;
            this.checkBox2.Location = new System.Drawing.Point(117, 534);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(149, 25);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Войти как гость";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(260, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Пароль:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(260, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Логин:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(739, 97);
            this.label5.TabIndex = 1;
            this.label5.Text = "АВТОРИЗАЦИЯ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 50;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 406);
            this.Controls.Add(this.guna2GradientPanel1);
            this.DoubleBuffered = true;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(433, 192);
            this.Name = "FormAuthorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация. Учёт метдической активности педагогов Камышловского педагогического " +
    "колледжа";
            this.Load += new System.EventHandler(this.FormAuthorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.actEmpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonGo;
        private ActEmpDataSet actEmpDataSet;
        private System.Windows.Forms.BindingSource uSERBindingSource;
        private ActEmpDataSetTableAdapters.USERTableAdapter uSERTableAdapter;
        private ActEmpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxPassword;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxLogin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2CheckBox checkBox1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButtonExit;
    }
}

