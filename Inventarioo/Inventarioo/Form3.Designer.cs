namespace Inventarioo
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label contadorLabel;
            System.Windows.Forms.Label nombre_del_productoLabel;
            this.database11DataSet = new Inventarioo.Database11DataSet();
            this.base_de_datosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.base_de_datosTableAdapter = new Inventarioo.Database11DataSetTableAdapters.Base_de_datosTableAdapter();
            this.tableAdapterManager = new Inventarioo.Database11DataSetTableAdapters.TableAdapterManager();
            this.base_de_datosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.base_de_datosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.base_de_datosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            contadorLabel = new System.Windows.Forms.Label();
            nombre_del_productoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_de_datosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_de_datosBindingNavigator)).BeginInit();
            this.base_de_datosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.base_de_datosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // database11DataSet
            // 
            this.database11DataSet.DataSetName = "Database11DataSet";
            this.database11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // base_de_datosBindingSource
            // 
            this.base_de_datosBindingSource.DataMember = "Base de datos";
            this.base_de_datosBindingSource.DataSource = this.database11DataSet;
            // 
            // base_de_datosTableAdapter
            // 
            this.base_de_datosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Base_de_datosTableAdapter = this.base_de_datosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Inventarioo.Database11DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // base_de_datosBindingNavigator
            // 
            this.base_de_datosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.base_de_datosBindingNavigator.BindingSource = this.base_de_datosBindingSource;
            this.base_de_datosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.base_de_datosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.base_de_datosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.base_de_datosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.base_de_datosBindingNavigatorSaveItem});
            this.base_de_datosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.base_de_datosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.base_de_datosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.base_de_datosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.base_de_datosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.base_de_datosBindingNavigator.Name = "base_de_datosBindingNavigator";
            this.base_de_datosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.base_de_datosBindingNavigator.Size = new System.Drawing.Size(370, 27);
            this.base_de_datosBindingNavigator.TabIndex = 0;
            this.base_de_datosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // base_de_datosBindingNavigatorSaveItem
            // 
            this.base_de_datosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.base_de_datosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("base_de_datosBindingNavigatorSaveItem.Image")));
            this.base_de_datosBindingNavigatorSaveItem.Name = "base_de_datosBindingNavigatorSaveItem";
            this.base_de_datosBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.base_de_datosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.base_de_datosBindingNavigatorSaveItem.Click += new System.EventHandler(this.base_de_datosBindingNavigatorSaveItem_Click);
            // 
            // base_de_datosDataGridView
            // 
            this.base_de_datosDataGridView.AutoGenerateColumns = false;
            this.base_de_datosDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.base_de_datosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.base_de_datosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.base_de_datosDataGridView.DataSource = this.base_de_datosBindingSource;
            this.base_de_datosDataGridView.Location = new System.Drawing.Point(0, 30);
            this.base_de_datosDataGridView.Name = "base_de_datosDataGridView";
            this.base_de_datosDataGridView.RowTemplate.Height = 24;
            this.base_de_datosDataGridView.Size = new System.Drawing.Size(371, 246);
            this.base_de_datosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Contador";
            this.dataGridViewTextBoxColumn1.HeaderText = "Contador";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre del producto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre del producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Codigo del producto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Codigo del producto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // contadorLabel
            // 
            contadorLabel.AutoSize = true;
            contadorLabel.Location = new System.Drawing.Point(44, 97);
            contadorLabel.Name = "contadorLabel";
            contadorLabel.Size = new System.Drawing.Size(0, 17);
            contadorLabel.TabIndex = 2;
            // 
            // nombre_del_productoLabel
            // 
            nombre_del_productoLabel.AutoSize = true;
            nombre_del_productoLabel.Location = new System.Drawing.Point(12, 114);
            nombre_del_productoLabel.Name = "nombre_del_productoLabel";
            nombre_del_productoLabel.Size = new System.Drawing.Size(0, 17);
            nombre_del_productoLabel.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(283, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Inventarioo.Properties.Resources.fondo_receta;
            this.ClientSize = new System.Drawing.Size(370, 274);
            this.Controls.Add(this.button1);
            this.Controls.Add(nombre_del_productoLabel);
            this.Controls.Add(contadorLabel);
            this.Controls.Add(this.base_de_datosDataGridView);
            this.Controls.Add(this.base_de_datosBindingNavigator);
            this.Name = "Form3";
            this.Text = "Base de datos";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_de_datosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_de_datosBindingNavigator)).EndInit();
            this.base_de_datosBindingNavigator.ResumeLayout(false);
            this.base_de_datosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.base_de_datosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database11DataSet database11DataSet;
        private System.Windows.Forms.BindingSource base_de_datosBindingSource;
        private Database11DataSetTableAdapters.Base_de_datosTableAdapter base_de_datosTableAdapter;
        private Database11DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator base_de_datosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton base_de_datosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView base_de_datosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
    }
}