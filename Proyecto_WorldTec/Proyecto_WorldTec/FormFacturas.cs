using BL.Tecnologia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_WorldTec
{
    public partial class FormFacturas : Form
    {

        FacturaBL _facturaBL;
        ClientesBL _clientesBL;
        ProductosBL _productosBL;

        private BindingSource listaFacturaBindingSource;
        private IContainer components;
        private BindingNavigator listaFacturaBindingNavigator;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private ToolStripButton listaFacturaBindingNavigatorSaveItem;
        private CheckBox activoCheckBox;
        private DateTimePicker fechaDateTimePicker;
        private TextBox idTextBox;
        private TextBox impuestoTextBox;
        private TextBox subtotalTextBox;
        private BindingSource listaClientesBindingSource;
        private BindingSource listaProductoBindingSource;
        private ComboBox clienteIdComboBox;
        private BindingSource facturaDetalleBindingSource;
        private DataGridView facturaDetalleDataGridView;
        private ToolStripButton toolStripButtonCancelar;
        private Button button1;
        private Button button2;
        private DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Label label1;
        private TextBox totalTextBox;

        public FormFacturas()
        {
            InitializeComponent();


            _facturaBL = new FacturaBL();
            listaFacturaBindingSource.DataSource = _facturaBL.ObtenerFacturas();

            _clientesBL = new ClientesBL();
            listaClientesBindingSource.DataSource = _clientesBL.ObtenerClientes();


            _productosBL = new ProductosBL();
            listaProductoBindingSource.DataSource = _productosBL.ObtenerProducto();


        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label clienteIdLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label impuestoLabel;
            System.Windows.Forms.Label subtotalLabel;
            System.Windows.Forms.Label totalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacturas));
            this.listaFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaFacturaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaFacturaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.impuestoTextBox = new System.Windows.Forms.TextBox();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.listaClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteIdComboBox = new System.Windows.Forms.ComboBox();
            this.facturaDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturaDetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            activoLabel = new System.Windows.Forms.Label();
            clienteIdLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            impuestoLabel = new System.Windows.Forms.Label();
            subtotalLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFacturaBindingNavigator)).BeginInit();
            this.listaFacturaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDetalleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(219, 42);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 1;
            activoLabel.Text = "Activo:";
            // 
            // clienteIdLabel
            // 
            clienteIdLabel.AutoSize = true;
            clienteIdLabel.Location = new System.Drawing.Point(44, 89);
            clienteIdLabel.Name = "clienteIdLabel";
            clienteIdLabel.Size = new System.Drawing.Size(42, 13);
            clienteIdLabel.TabIndex = 3;
            clienteIdLabel.Text = "Cliente:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(329, 85);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 5;
            fechaLabel.Text = "Fecha:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(53, 45);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 7;
            idLabel.Text = "Id:";
            // 
            // impuestoLabel
            // 
            impuestoLabel.AutoSize = true;
            impuestoLabel.Location = new System.Drawing.Point(44, 369);
            impuestoLabel.Name = "impuestoLabel";
            impuestoLabel.Size = new System.Drawing.Size(53, 13);
            impuestoLabel.TabIndex = 9;
            impuestoLabel.Text = "Impuesto:";
            // 
            // subtotalLabel
            // 
            subtotalLabel.AutoSize = true;
            subtotalLabel.Location = new System.Drawing.Point(44, 395);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new System.Drawing.Size(49, 13);
            subtotalLabel.TabIndex = 11;
            subtotalLabel.Text = "Subtotal:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(44, 421);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(34, 13);
            totalLabel.TabIndex = 13;
            totalLabel.Text = "Total:";
            // 
            // listaFacturaBindingSource
            // 
            this.listaFacturaBindingSource.DataSource = typeof(BL.Tecnologia.Factura);
            this.listaFacturaBindingSource.CurrentItemChanged += new System.EventHandler(this.listaFacturaBindingSource_CurrentItemChanged);
            // 
            // listaFacturaBindingNavigator
            // 
            this.listaFacturaBindingNavigator.AddNewItem = null;
            this.listaFacturaBindingNavigator.BindingSource = this.listaFacturaBindingSource;
            this.listaFacturaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaFacturaBindingNavigator.DeleteItem = null;
            this.listaFacturaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaFacturaBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaFacturaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaFacturaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaFacturaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaFacturaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaFacturaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaFacturaBindingNavigator.Name = "listaFacturaBindingNavigator";
            this.listaFacturaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaFacturaBindingNavigator.Size = new System.Drawing.Size(1029, 25);
            this.listaFacturaBindingNavigator.TabIndex = 0;
            this.listaFacturaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Anular";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaFacturaBindingNavigatorSaveItem
            // 
            this.listaFacturaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaFacturaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaFacturaBindingNavigatorSaveItem.Image")));
            this.listaFacturaBindingNavigatorSaveItem.Name = "listaFacturaBindingNavigatorSaveItem";
            this.listaFacturaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaFacturaBindingNavigatorSaveItem.Text = "Save Data";
            this.listaFacturaBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaFacturaBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaFacturaBindingSource, "Activo", true));
            this.activoCheckBox.Enabled = false;
            this.activoCheckBox.Location = new System.Drawing.Point(279, 37);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(18, 24);
            this.activoCheckBox.TabIndex = 2;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listaFacturaBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(389, 81);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 6;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaFacturaBindingSource, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "00000"));
            this.idTextBox.Location = new System.Drawing.Point(104, 42);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(54, 20);
            this.idTextBox.TabIndex = 8;
            // 
            // impuestoTextBox
            // 
            this.impuestoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaFacturaBindingSource, "Impuesto", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.impuestoTextBox.Location = new System.Drawing.Point(104, 366);
            this.impuestoTextBox.Name = "impuestoTextBox";
            this.impuestoTextBox.ReadOnly = true;
            this.impuestoTextBox.Size = new System.Drawing.Size(155, 20);
            this.impuestoTextBox.TabIndex = 10;
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaFacturaBindingSource, "Subtotal", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.subtotalTextBox.Location = new System.Drawing.Point(104, 392);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.ReadOnly = true;
            this.subtotalTextBox.Size = new System.Drawing.Size(155, 20);
            this.subtotalTextBox.TabIndex = 12;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaFacturaBindingSource, "Total", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.totalTextBox.Location = new System.Drawing.Point(104, 418);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(155, 20);
            this.totalTextBox.TabIndex = 14;
            // 
            // listaClientesBindingSource
            // 
            this.listaClientesBindingSource.DataSource = typeof(BL.Tecnologia.Cliente);
            // 
            // listaProductoBindingSource
            // 
            this.listaProductoBindingSource.DataSource = typeof(BL.Tecnologia.ProductosBL.Producto);
            // 
            // clienteIdComboBox
            // 
            this.clienteIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaFacturaBindingSource, "ClienteId", true));
            this.clienteIdComboBox.DataSource = this.listaClientesBindingSource;
            this.clienteIdComboBox.DisplayMember = "Nombre";
            this.clienteIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clienteIdComboBox.FormattingEnabled = true;
            this.clienteIdComboBox.Location = new System.Drawing.Point(104, 81);
            this.clienteIdComboBox.Name = "clienteIdComboBox";
            this.clienteIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.clienteIdComboBox.TabIndex = 15;
            this.clienteIdComboBox.ValueMember = "Id";
            // 
            // facturaDetalleBindingSource
            // 
            this.facturaDetalleBindingSource.AllowNew = false;
            this.facturaDetalleBindingSource.DataMember = "FacturaDetalle";
            this.facturaDetalleBindingSource.DataSource = this.listaFacturaBindingSource;
            // 
            // facturaDetalleDataGridView
            // 
            this.facturaDetalleDataGridView.AutoGenerateColumns = false;
            this.facturaDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturaDetalleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.facturaDetalleDataGridView.DataSource = this.facturaDetalleBindingSource;
            this.facturaDetalleDataGridView.Location = new System.Drawing.Point(47, 129);
            this.facturaDetalleDataGridView.Name = "facturaDetalleDataGridView";
            this.facturaDetalleDataGridView.Size = new System.Drawing.Size(644, 220);
            this.facturaDetalleDataGridView.TabIndex = 15;
            this.facturaDetalleDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.facturaDetalleDataGridView_CellEndEdit);
            this.facturaDetalleDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.facturaDetalleDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProductoId";
            this.dataGridViewTextBoxColumn3.DataSource = this.listaProductoBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "producto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Id";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn4.HeaderText = "cantidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn6.HeaderText = "Total";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(608, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 27);
            this.button1.TabIndex = 16;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(642, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 27);
            this.button2.TabIndex = 17;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(530, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "ANULADA";
            this.label1.Visible = false;
            // 
            // FormFacturas
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1029, 731);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.facturaDetalleDataGridView);
            this.Controls.Add(this.clienteIdComboBox);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(clienteIdLabel);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(impuestoLabel);
            this.Controls.Add(this.impuestoTextBox);
            this.Controls.Add(subtotalLabel);
            this.Controls.Add(this.subtotalTextBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.listaFacturaBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFacturas";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.FormFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFacturaBindingNavigator)).EndInit();
            this.listaFacturaBindingNavigator.ResumeLayout(false);
            this.listaFacturaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDetalleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FormFacturas_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _facturaBL.AgregarFactura();
            listaFacturaBindingSource.MoveLast();

            HabilitarDeshabilitarBotones(false);

        }
        private void HabilitarDeshabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;

            toolStripButtonCancelar.Visible = !valor;

        }

        private void listaFacturaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaFacturaBindingSource.EndEdit();
            var factura = (Factura)listaFacturaBindingSource.Current;
            var resultado = _facturaBL.GuardarFactura(factura);

            if (resultado.Exitoso == true)
            {
                listaFacturaBindingSource.ResetBindings(false);
                HabilitarDeshabilitarBotones(true);
                MessageBox.Show("Factura Guardada Exitosamente!!");
            } else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            HabilitarDeshabilitarBotones(true);
            _facturaBL.AgregarFactura();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var factura = (Factura)listaFacturaBindingSource.Current;
            _facturaBL.AgregarFacturaDetalle(factura);

            HabilitarDeshabilitarBotones(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var factura = (Factura)listaFacturaBindingSource.Current;
            var facturaDetalle = (FacturaDetalle)facturaDetalleBindingSource.Current;

            _facturaBL.RemoverFacturaDetalle(factura, facturaDetalle);
            HabilitarDeshabilitarBotones(false);
        }

        private void facturaDetalleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = (false);
        }

        private void facturaDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var factura = (Factura)listaFacturaBindingSource.Current;
            _facturaBL.CalcularFactura(factura);

            listaFacturaBindingSource.ResetBindings(false);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != " ")
            {
                var resultado = MessageBox.Show("Desea anular esta factura?", "Anular", MessageBoxButtons.YesNo);
                if ( resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Anular(id);
                }
            }
        }

        private void  Anular(int id)
        {
            var resultado = _facturaBL.AnularFactura(id);

            if (resultado == true)
            {
                listaFacturaBindingSource.ResetBindings(false);
            }else
            {
                MessageBox.Show("Ocurrio Un error al Anular la factura");
            }
        }

        private void listaFacturaBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            var factura = (Factura)listaFacturaBindingSource.Current;

            if (factura != null && factura.Id != 0 && factura.Activo == false)
            {
                label1.Visible = true;
            }else
            {
                label1.Visible = false;
            }
        }
    }
}
