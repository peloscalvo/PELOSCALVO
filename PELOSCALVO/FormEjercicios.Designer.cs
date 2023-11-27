
namespace PELOSCALVO
{
    partial class FormEjercicios
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
            System.Windows.Forms.Label tipoInpuestoIVALabel;
            System.Windows.Forms.Label configuraccionBasicaLabel;
            System.Windows.Forms.Label ejerciciosDeAñoLabel;
            System.Windows.Forms.Label empresaENLACELabel;
            System.Windows.Forms.Label idConexionConfiLabel;
            System.Windows.Forms.Label añoDeEjercicioLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEjercicios));
            this.dsCONFIGURACCION = new PELOSCALVO.DsCONFIGURACCION();
            this.dtConfiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtConfiguracionPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtInicioMultiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMultidatos = new PELOSCALVO.DsMultidatos();
            this.ErrorEjercicios = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtConfiguracionPrincipalDtConfiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnCancelarEjercicio = new System.Windows.Forms.Button();
            this.BtnGuardarEjercicio = new System.Windows.Forms.Button();
            this.panel1Ejercicio = new System.Windows.Forms.Panel();
            this.BtnEliminarEjercicio = new System.Windows.Forms.Button();
            this.BtnBuscarEjercicio = new System.Windows.Forms.Button();
            this.BtnNuevoEjercicio = new System.Windows.Forms.Button();
            this.BtnModificarEjercicio = new System.Windows.Forms.Button();
            this.tipoInpuestoIVANumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.configuraccionBasicaTextBox = new System.Windows.Forms.TextBox();
            this.ejerciciosDeAñoTextBox = new System.Windows.Forms.TextBox();
            this.empresaENLACETextBox = new System.Windows.Forms.TextBox();
            this.IdConfi = new System.Windows.Forms.TextBox();
            this.añoDeEjercicioTextBox = new System.Windows.Forms.TextBox();
            this.dtConfiDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AñoDeEjercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CambiarDeEmpresa1 = new System.Windows.Forms.ComboBox();
            tipoInpuestoIVALabel = new System.Windows.Forms.Label();
            configuraccionBasicaLabel = new System.Windows.Forms.Label();
            ejerciciosDeAñoLabel = new System.Windows.Forms.Label();
            empresaENLACELabel = new System.Windows.Forms.Label();
            idConexionConfiLabel = new System.Windows.Forms.Label();
            añoDeEjercicioLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEjercicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalDtConfiBindingSource)).BeginInit();
            this.panel1Ejercicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoInpuestoIVANumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dsCONFIGURACCION
            // 
            this.dsCONFIGURACCION.DataSetName = "DsCONFIGURACCION";
            this.dsCONFIGURACCION.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtConfiBindingSource
            // 
            this.dtConfiBindingSource.DataMember = "DtConfi";
            this.dtConfiBindingSource.DataSource = this.dsCONFIGURACCION;
            // 
            // dtConfiguracionPrincipalBindingSource
            // 
            this.dtConfiguracionPrincipalBindingSource.DataMember = "DtConfiguracionPrincipal";
            this.dtConfiguracionPrincipalBindingSource.DataSource = this.dsCONFIGURACCION;
            // 
            // dtInicioMultiBindingSource
            // 
            this.dtInicioMultiBindingSource.DataMember = "DtInicioMulti";
            this.dtInicioMultiBindingSource.DataSource = this.dsMultidatos;
            // 
            // dsMultidatos
            // 
            this.dsMultidatos.DataSetName = "DsMultidatos";
            this.dsMultidatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ErrorEjercicios
            // 
            this.ErrorEjercicios.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.ErrorEjercicios.ContainerControl = this;
            // 
            // dtConfiguracionPrincipalDtConfiBindingSource
            // 
            this.dtConfiguracionPrincipalDtConfiBindingSource.DataMember = "DtConfiguracionPrincipal_DtConfi";
            this.dtConfiguracionPrincipalDtConfiBindingSource.DataSource = this.dtConfiguracionPrincipalBindingSource;
            // 
            // BtnCancelarEjercicio
            // 
            this.BtnCancelarEjercicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelarEjercicio.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelarEjercicio.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelarEjercicio.Enabled = false;
            this.BtnCancelarEjercicio.FlatAppearance.BorderSize = 0;
            this.BtnCancelarEjercicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnCancelarEjercicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnCancelarEjercicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarEjercicio.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarEjercicio.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_x_mark_8_24;
            this.BtnCancelarEjercicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarEjercicio.Location = new System.Drawing.Point(804, 476);
            this.BtnCancelarEjercicio.Name = "BtnCancelarEjercicio";
            this.BtnCancelarEjercicio.Size = new System.Drawing.Size(89, 42);
            this.BtnCancelarEjercicio.TabIndex = 73;
            this.BtnCancelarEjercicio.Text = "Cancelar";
            this.BtnCancelarEjercicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelarEjercicio.UseVisualStyleBackColor = false;
            this.BtnCancelarEjercicio.Click += new System.EventHandler(this.BtnCancelarEjercicio_Click);
            // 
            // BtnGuardarEjercicio
            // 
            this.BtnGuardarEjercicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarEjercicio.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarEjercicio.Enabled = false;
            this.BtnGuardarEjercicio.FlatAppearance.BorderSize = 0;
            this.BtnGuardarEjercicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnGuardarEjercicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnGuardarEjercicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarEjercicio.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarEjercicio.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_check_mark_9_24;
            this.BtnGuardarEjercicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarEjercicio.Location = new System.Drawing.Point(589, 476);
            this.BtnGuardarEjercicio.Name = "BtnGuardarEjercicio";
            this.BtnGuardarEjercicio.Size = new System.Drawing.Size(89, 42);
            this.BtnGuardarEjercicio.TabIndex = 72;
            this.BtnGuardarEjercicio.Text = "Aceptar";
            this.BtnGuardarEjercicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarEjercicio.UseVisualStyleBackColor = false;
            this.BtnGuardarEjercicio.Click += new System.EventHandler(this.BtnGuardarEjercicio_Click);
            // 
            // panel1Ejercicio
            // 
            this.panel1Ejercicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1Ejercicio.BackColor = System.Drawing.Color.Transparent;
            this.panel1Ejercicio.Controls.Add(this.BtnEliminarEjercicio);
            this.panel1Ejercicio.Controls.Add(this.BtnBuscarEjercicio);
            this.panel1Ejercicio.Controls.Add(this.BtnNuevoEjercicio);
            this.panel1Ejercicio.Controls.Add(this.BtnModificarEjercicio);
            this.panel1Ejercicio.Location = new System.Drawing.Point(12, 455);
            this.panel1Ejercicio.Name = "panel1Ejercicio";
            this.panel1Ejercicio.Size = new System.Drawing.Size(396, 63);
            this.panel1Ejercicio.TabIndex = 71;
            // 
            // BtnEliminarEjercicio
            // 
            this.BtnEliminarEjercicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminarEjercicio.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarEjercicio.FlatAppearance.BorderSize = 0;
            this.BtnEliminarEjercicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnEliminarEjercicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnEliminarEjercicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarEjercicio.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarEjercicio.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_trash_can_17_32;
            this.BtnEliminarEjercicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminarEjercicio.Location = new System.Drawing.Point(238, 3);
            this.BtnEliminarEjercicio.Name = "BtnEliminarEjercicio";
            this.BtnEliminarEjercicio.Size = new System.Drawing.Size(77, 63);
            this.BtnEliminarEjercicio.TabIndex = 9;
            this.BtnEliminarEjercicio.Text = "Eliminar";
            this.BtnEliminarEjercicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminarEjercicio.UseVisualStyleBackColor = false;
            this.BtnEliminarEjercicio.Click += new System.EventHandler(this.BtnEliminarEjercicio_Click);
            // 
            // BtnBuscarEjercicio
            // 
            this.BtnBuscarEjercicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarEjercicio.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscarEjercicio.FlatAppearance.BorderSize = 0;
            this.BtnBuscarEjercicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnBuscarEjercicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnBuscarEjercicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarEjercicio.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarEjercicio.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_magnifier_4_32;
            this.BtnBuscarEjercicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscarEjercicio.Location = new System.Drawing.Point(161, 3);
            this.BtnBuscarEjercicio.Name = "BtnBuscarEjercicio";
            this.BtnBuscarEjercicio.Size = new System.Drawing.Size(77, 63);
            this.BtnBuscarEjercicio.TabIndex = 8;
            this.BtnBuscarEjercicio.Text = "Buscar";
            this.BtnBuscarEjercicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscarEjercicio.UseVisualStyleBackColor = false;
            // 
            // BtnNuevoEjercicio
            // 
            this.BtnNuevoEjercicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNuevoEjercicio.BackColor = System.Drawing.Color.Transparent;
            this.BtnNuevoEjercicio.FlatAppearance.BorderSize = 0;
            this.BtnNuevoEjercicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnNuevoEjercicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnNuevoEjercicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoEjercicio.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoEjercicio.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_file_14_32;
            this.BtnNuevoEjercicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevoEjercicio.Location = new System.Drawing.Point(7, 3);
            this.BtnNuevoEjercicio.Name = "BtnNuevoEjercicio";
            this.BtnNuevoEjercicio.Size = new System.Drawing.Size(77, 63);
            this.BtnNuevoEjercicio.TabIndex = 6;
            this.BtnNuevoEjercicio.Tag = "stop";
            this.BtnNuevoEjercicio.Text = "Nuevo";
            this.BtnNuevoEjercicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNuevoEjercicio.UseVisualStyleBackColor = false;
            this.BtnNuevoEjercicio.Click += new System.EventHandler(this.BtnNuevoEjercicio_Click);
            // 
            // BtnModificarEjercicio
            // 
            this.BtnModificarEjercicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModificarEjercicio.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificarEjercicio.FlatAppearance.BorderSize = 0;
            this.BtnModificarEjercicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.BtnModificarEjercicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnModificarEjercicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarEjercicio.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarEjercicio.Image = global::PELOSCALVO.Properties.Resources.iconmonstr_pen_8_32;
            this.BtnModificarEjercicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnModificarEjercicio.Location = new System.Drawing.Point(84, 3);
            this.BtnModificarEjercicio.Name = "BtnModificarEjercicio";
            this.BtnModificarEjercicio.Size = new System.Drawing.Size(77, 63);
            this.BtnModificarEjercicio.TabIndex = 7;
            this.BtnModificarEjercicio.Text = "Modificar";
            this.BtnModificarEjercicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificarEjercicio.UseVisualStyleBackColor = false;
            this.BtnModificarEjercicio.Click += new System.EventHandler(this.BtnModificarEjercicio_Click);
            // 
            // tipoInpuestoIVALabel
            // 
            tipoInpuestoIVALabel.AutoSize = true;
            tipoInpuestoIVALabel.Location = new System.Drawing.Point(15, 417);
            tipoInpuestoIVALabel.Name = "tipoInpuestoIVALabel";
            tipoInpuestoIVALabel.Size = new System.Drawing.Size(71, 13);
            tipoInpuestoIVALabel.TabIndex = 69;
            tipoInpuestoIVALabel.Text = "Inpuesto IVA:";
            // 
            // tipoInpuestoIVANumericUpDown
            // 
            this.tipoInpuestoIVANumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dtConfiguracionPrincipalDtConfiBindingSource, "TipoInpuestoIVA", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.tipoInpuestoIVANumericUpDown.Enabled = false;
            this.tipoInpuestoIVANumericUpDown.Location = new System.Drawing.Point(92, 413);
            this.tipoInpuestoIVANumericUpDown.Name = "tipoInpuestoIVANumericUpDown";
            this.tipoInpuestoIVANumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.tipoInpuestoIVANumericUpDown.TabIndex = 70;
            this.tipoInpuestoIVANumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // configuraccionBasicaLabel
            // 
            configuraccionBasicaLabel.AutoSize = true;
            configuraccionBasicaLabel.Location = new System.Drawing.Point(18, 355);
            configuraccionBasicaLabel.Name = "configuraccionBasicaLabel";
            configuraccionBasicaLabel.Size = new System.Drawing.Size(72, 13);
            configuraccionBasicaLabel.TabIndex = 59;
            configuraccionBasicaLabel.Text = "Descripccion:";
            // 
            // configuraccionBasicaTextBox
            // 
            this.configuraccionBasicaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtConfiguracionPrincipalDtConfiBindingSource, "ConfiguraccionBasica", true));
            this.configuraccionBasicaTextBox.Location = new System.Drawing.Point(92, 352);
            this.configuraccionBasicaTextBox.MaxLength = 50;
            this.configuraccionBasicaTextBox.Name = "configuraccionBasicaTextBox";
            this.configuraccionBasicaTextBox.ReadOnly = true;
            this.configuraccionBasicaTextBox.Size = new System.Drawing.Size(377, 20);
            this.configuraccionBasicaTextBox.TabIndex = 60;
            // 
            // ejerciciosDeAñoTextBox
            // 
            this.ejerciciosDeAñoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtConfiguracionPrincipalDtConfiBindingSource, "EjerciciosDeAño", true));
            this.ejerciciosDeAñoTextBox.Location = new System.Drawing.Point(542, 349);
            this.ejerciciosDeAñoTextBox.MaxLength = 50;
            this.ejerciciosDeAñoTextBox.Name = "ejerciciosDeAñoTextBox";
            this.ejerciciosDeAñoTextBox.ReadOnly = true;
            this.ejerciciosDeAñoTextBox.Size = new System.Drawing.Size(221, 20);
            this.ejerciciosDeAñoTextBox.TabIndex = 62;
            // 
            // empresaENLACETextBox
            // 
            this.empresaENLACETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtConfiguracionPrincipalDtConfiBindingSource, "EmpresaENLACE", true));
            this.empresaENLACETextBox.Enabled = false;
            this.empresaENLACETextBox.Location = new System.Drawing.Point(92, 382);
            this.empresaENLACETextBox.MaxLength = 40;
            this.empresaENLACETextBox.Name = "empresaENLACETextBox";
            this.empresaENLACETextBox.ReadOnly = true;
            this.empresaENLACETextBox.Size = new System.Drawing.Size(235, 20);
            this.empresaENLACETextBox.TabIndex = 64;
            // 
            // IdConfi
            // 
            this.IdConfi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtConfiguracionPrincipalDtConfiBindingSource, "Id", true));
            this.IdConfi.Enabled = false;
            this.IdConfi.Location = new System.Drawing.Point(92, 326);
            this.IdConfi.MaxLength = 300;
            this.IdConfi.Name = "IdConfi";
            this.IdConfi.ReadOnly = true;
            this.IdConfi.Size = new System.Drawing.Size(158, 20);
            this.IdConfi.TabIndex = 66;
            this.IdConfi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // añoDeEjercicioTextBox
            // 
            this.añoDeEjercicioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtConfiguracionPrincipalDtConfiBindingSource, "AñoDeEjercicio", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.añoDeEjercicioTextBox.Location = new System.Drawing.Point(542, 323);
            this.añoDeEjercicioTextBox.MaxLength = 4;
            this.añoDeEjercicioTextBox.Name = "añoDeEjercicioTextBox";
            this.añoDeEjercicioTextBox.ReadOnly = true;
            this.añoDeEjercicioTextBox.Size = new System.Drawing.Size(100, 20);
            this.añoDeEjercicioTextBox.TabIndex = 68;
            // 
            // ejerciciosDeAñoLabel
            // 
            ejerciciosDeAñoLabel.AutoSize = true;
            ejerciciosDeAñoLabel.Location = new System.Drawing.Point(481, 352);
            ejerciciosDeAñoLabel.Name = "ejerciciosDeAñoLabel";
            ejerciciosDeAñoLabel.Size = new System.Drawing.Size(55, 13);
            ejerciciosDeAñoLabel.TabIndex = 61;
            ejerciciosDeAñoLabel.Text = "Ejercicios:";
            // 
            // empresaENLACELabel
            // 
            empresaENLACELabel.AutoSize = true;
            empresaENLACELabel.Location = new System.Drawing.Point(35, 385);
            empresaENLACELabel.Name = "empresaENLACELabel";
            empresaENLACELabel.Size = new System.Drawing.Size(51, 13);
            empresaENLACELabel.TabIndex = 63;
            empresaENLACELabel.Text = "Empresa:";
            // 
            // idConexionConfiLabel
            // 
            idConexionConfiLabel.AutoSize = true;
            idConexionConfiLabel.Location = new System.Drawing.Point(67, 329);
            idConexionConfiLabel.Name = "idConexionConfiLabel";
            idConexionConfiLabel.Size = new System.Drawing.Size(19, 13);
            idConexionConfiLabel.TabIndex = 65;
            idConexionConfiLabel.Text = "Id:";
            // 
            // añoDeEjercicioLabel
            // 
            añoDeEjercicioLabel.AutoSize = true;
            añoDeEjercicioLabel.Location = new System.Drawing.Point(498, 326);
            añoDeEjercicioLabel.Name = "añoDeEjercicioLabel";
            añoDeEjercicioLabel.Size = new System.Drawing.Size(29, 13);
            añoDeEjercicioLabel.TabIndex = 67;
            añoDeEjercicioLabel.Text = "Año:";
            // 
            // dtConfiDataGridView
            // 
            this.dtConfiDataGridView.AllowUserToAddRows = false;
            this.dtConfiDataGridView.AllowUserToResizeRows = false;
            this.dtConfiDataGridView.AutoGenerateColumns = false;
            this.dtConfiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtConfiDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtConfiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtConfiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.AñoDeEjercicio});
            this.dtConfiDataGridView.DataSource = this.dtConfiguracionPrincipalDtConfiBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtConfiDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtConfiDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtConfiDataGridView.Location = new System.Drawing.Point(0, 0);
            this.dtConfiDataGridView.Name = "dtConfiDataGridView";
            this.dtConfiDataGridView.ReadOnly = true;
            this.dtConfiDataGridView.RowHeadersVisible = false;
            this.dtConfiDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtConfiDataGridView.Size = new System.Drawing.Size(927, 299);
            this.dtConfiDataGridView.TabIndex = 58;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ConfiguraccionBasica";
            this.dataGridViewTextBoxColumn4.FillWeight = 180F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "EjerciciosDeAño";
            this.dataGridViewTextBoxColumn6.FillWeight = 130F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Ejercicios";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // AñoDeEjercicio
            // 
            this.AñoDeEjercicio.DataPropertyName = "AñoDeEjercicio";
            this.AñoDeEjercicio.HeaderText = "AñoDeEjercicio";
            this.AñoDeEjercicio.Name = "AñoDeEjercicio";
            this.AñoDeEjercicio.ReadOnly = true;
            this.AñoDeEjercicio.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(517, 417);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 13);
            label1.TabIndex = 56;
            label1.Text = "Empresa:";
            // 
            // CambiarDeEmpresa1
            // 
            this.CambiarDeEmpresa1.DataSource = this.dtConfiguracionPrincipalBindingSource;
            this.CambiarDeEmpresa1.DisplayMember = "EmpresaConfi";
            this.CambiarDeEmpresa1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CambiarDeEmpresa1.FormattingEnabled = true;
            this.CambiarDeEmpresa1.Location = new System.Drawing.Point(574, 414);
            this.CambiarDeEmpresa1.Name = "CambiarDeEmpresa1";
            this.CambiarDeEmpresa1.Size = new System.Drawing.Size(278, 21);
            this.CambiarDeEmpresa1.TabIndex = 57;
            // 
            // FormEjercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 530);
            this.Controls.Add(this.BtnCancelarEjercicio);
            this.Controls.Add(this.BtnGuardarEjercicio);
            this.Controls.Add(this.panel1Ejercicio);
            this.Controls.Add(tipoInpuestoIVALabel);
            this.Controls.Add(this.tipoInpuestoIVANumericUpDown);
            this.Controls.Add(configuraccionBasicaLabel);
            this.Controls.Add(this.configuraccionBasicaTextBox);
            this.Controls.Add(this.ejerciciosDeAñoTextBox);
            this.Controls.Add(this.empresaENLACETextBox);
            this.Controls.Add(this.IdConfi);
            this.Controls.Add(this.añoDeEjercicioTextBox);
            this.Controls.Add(ejerciciosDeAñoLabel);
            this.Controls.Add(empresaENLACELabel);
            this.Controls.Add(idConexionConfiLabel);
            this.Controls.Add(añoDeEjercicioLabel);
            this.Controls.Add(this.dtConfiDataGridView);
            this.Controls.Add(label1);
            this.Controls.Add(this.CambiarDeEmpresa1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEjercicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ejercicios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEjercicios_FormClosing);
            this.Load += new System.EventHandler(this.FormEjercicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCONFIGURACCION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioMultiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMultidatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEjercicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiguracionPrincipalDtConfiBindingSource)).EndInit();
            this.panel1Ejercicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tipoInpuestoIVANumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConfiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DsCONFIGURACCION dsCONFIGURACCION;
        private System.Windows.Forms.BindingSource dtConfiBindingSource;
        private System.Windows.Forms.BindingSource dtConfiguracionPrincipalBindingSource;
        private System.Windows.Forms.BindingSource dtInicioMultiBindingSource;
        private DsMultidatos dsMultidatos;
        private System.Windows.Forms.ErrorProvider ErrorEjercicios;
        private System.Windows.Forms.BindingSource dtConfiguracionPrincipalDtConfiBindingSource;
        private System.Windows.Forms.Button BtnCancelarEjercicio;
        public System.Windows.Forms.Button BtnGuardarEjercicio;
        private System.Windows.Forms.Panel panel1Ejercicio;
        private System.Windows.Forms.Button BtnEliminarEjercicio;
        private System.Windows.Forms.Button BtnBuscarEjercicio;
        private System.Windows.Forms.Button BtnNuevoEjercicio;
        private System.Windows.Forms.Button BtnModificarEjercicio;
        private System.Windows.Forms.NumericUpDown tipoInpuestoIVANumericUpDown;
        private System.Windows.Forms.TextBox configuraccionBasicaTextBox;
        private System.Windows.Forms.TextBox ejerciciosDeAñoTextBox;
        private System.Windows.Forms.TextBox empresaENLACETextBox;
        private System.Windows.Forms.TextBox IdConfi;
        private System.Windows.Forms.TextBox añoDeEjercicioTextBox;
        private System.Windows.Forms.DataGridView dtConfiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn AñoDeEjercicio;
        private System.Windows.Forms.ComboBox CambiarDeEmpresa1;
    }
}