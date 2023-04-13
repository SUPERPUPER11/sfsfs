namespace Conkurs
{
    partial class Form2
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namemeroprDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameactiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moderatoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juryid1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juryid2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juryid3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juryid4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juryid5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpobedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user17_PetrovDataSet = new Conkurs.user17_PetrovDataSet();
            this.activeTableAdapter = new Conkurs.user17_PetrovDataSetTableAdapters.ActiveTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перейтиНаТаблицуМероприятияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьАктивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user17_PetrovDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 594);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1169, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idakDataGridViewTextBoxColumn,
            this.namemeroprDataGridViewTextBoxColumn,
            this.datenDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.nameactiveDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.moderatoridDataGridViewTextBoxColumn,
            this.juryid1DataGridViewTextBoxColumn,
            this.juryid2DataGridViewTextBoxColumn,
            this.juryid3DataGridViewTextBoxColumn,
            this.juryid4DataGridViewTextBoxColumn,
            this.juryid5DataGridViewTextBoxColumn,
            this.idpobedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.activeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1156, 486);
            this.dataGridView1.TabIndex = 1;
            // 
            // idakDataGridViewTextBoxColumn
            // 
            this.idakDataGridViewTextBoxColumn.DataPropertyName = "Id_ak";
            this.idakDataGridViewTextBoxColumn.HeaderText = "Id_ak";
            this.idakDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idakDataGridViewTextBoxColumn.Name = "idakDataGridViewTextBoxColumn";
            this.idakDataGridViewTextBoxColumn.Width = 125;
            // 
            // namemeroprDataGridViewTextBoxColumn
            // 
            this.namemeroprDataGridViewTextBoxColumn.DataPropertyName = "Name_meropr";
            this.namemeroprDataGridViewTextBoxColumn.HeaderText = "Name_meropr";
            this.namemeroprDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namemeroprDataGridViewTextBoxColumn.Name = "namemeroprDataGridViewTextBoxColumn";
            this.namemeroprDataGridViewTextBoxColumn.Width = 125;
            // 
            // datenDataGridViewTextBoxColumn
            // 
            this.datenDataGridViewTextBoxColumn.DataPropertyName = "Date_n";
            this.datenDataGridViewTextBoxColumn.HeaderText = "Date_n";
            this.datenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datenDataGridViewTextBoxColumn.Name = "datenDataGridViewTextBoxColumn";
            this.datenDataGridViewTextBoxColumn.Width = 125;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            this.dniDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            this.dniDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameactiveDataGridViewTextBoxColumn
            // 
            this.nameactiveDataGridViewTextBoxColumn.DataPropertyName = "Name_active";
            this.nameactiveDataGridViewTextBoxColumn.HeaderText = "Name_active";
            this.nameactiveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameactiveDataGridViewTextBoxColumn.Name = "nameactiveDataGridViewTextBoxColumn";
            this.nameactiveDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // moderatoridDataGridViewTextBoxColumn
            // 
            this.moderatoridDataGridViewTextBoxColumn.DataPropertyName = "Moderator_id";
            this.moderatoridDataGridViewTextBoxColumn.HeaderText = "Moderator_id";
            this.moderatoridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.moderatoridDataGridViewTextBoxColumn.Name = "moderatoridDataGridViewTextBoxColumn";
            this.moderatoridDataGridViewTextBoxColumn.Width = 125;
            // 
            // juryid1DataGridViewTextBoxColumn
            // 
            this.juryid1DataGridViewTextBoxColumn.DataPropertyName = "jury_id1";
            this.juryid1DataGridViewTextBoxColumn.HeaderText = "jury_id1";
            this.juryid1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.juryid1DataGridViewTextBoxColumn.Name = "juryid1DataGridViewTextBoxColumn";
            this.juryid1DataGridViewTextBoxColumn.Width = 125;
            // 
            // juryid2DataGridViewTextBoxColumn
            // 
            this.juryid2DataGridViewTextBoxColumn.DataPropertyName = "jury_id2";
            this.juryid2DataGridViewTextBoxColumn.HeaderText = "jury_id2";
            this.juryid2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.juryid2DataGridViewTextBoxColumn.Name = "juryid2DataGridViewTextBoxColumn";
            this.juryid2DataGridViewTextBoxColumn.Width = 125;
            // 
            // juryid3DataGridViewTextBoxColumn
            // 
            this.juryid3DataGridViewTextBoxColumn.DataPropertyName = "jury_id3";
            this.juryid3DataGridViewTextBoxColumn.HeaderText = "jury_id3";
            this.juryid3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.juryid3DataGridViewTextBoxColumn.Name = "juryid3DataGridViewTextBoxColumn";
            this.juryid3DataGridViewTextBoxColumn.Width = 125;
            // 
            // juryid4DataGridViewTextBoxColumn
            // 
            this.juryid4DataGridViewTextBoxColumn.DataPropertyName = "jury_id4";
            this.juryid4DataGridViewTextBoxColumn.HeaderText = "jury_id4";
            this.juryid4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.juryid4DataGridViewTextBoxColumn.Name = "juryid4DataGridViewTextBoxColumn";
            this.juryid4DataGridViewTextBoxColumn.Width = 125;
            // 
            // juryid5DataGridViewTextBoxColumn
            // 
            this.juryid5DataGridViewTextBoxColumn.DataPropertyName = "jury_id5";
            this.juryid5DataGridViewTextBoxColumn.HeaderText = "jury_id5";
            this.juryid5DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.juryid5DataGridViewTextBoxColumn.Name = "juryid5DataGridViewTextBoxColumn";
            this.juryid5DataGridViewTextBoxColumn.Width = 125;
            // 
            // idpobedDataGridViewTextBoxColumn
            // 
            this.idpobedDataGridViewTextBoxColumn.DataPropertyName = "id_pobed";
            this.idpobedDataGridViewTextBoxColumn.HeaderText = "id_pobed";
            this.idpobedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpobedDataGridViewTextBoxColumn.Name = "idpobedDataGridViewTextBoxColumn";
            this.idpobedDataGridViewTextBoxColumn.Width = 125;
            // 
            // activeBindingSource
            // 
            this.activeBindingSource.DataMember = "Active";
            this.activeBindingSource.DataSource = this.user17_PetrovDataSet;
            // 
            // user17_PetrovDataSet
            // 
            this.user17_PetrovDataSet.DataSetName = "user17_PetrovDataSet";
            this.user17_PetrovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activeTableAdapter
            // 
            this.activeTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.назадToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1169, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перейтиНаТаблицуМероприятияToolStripMenuItem,
            this.добавитьАктивToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // перейтиНаТаблицуМероприятияToolStripMenuItem
            // 
            this.перейтиНаТаблицуМероприятияToolStripMenuItem.Name = "перейтиНаТаблицуМероприятияToolStripMenuItem";
            this.перейтиНаТаблицуМероприятияToolStripMenuItem.Size = new System.Drawing.Size(336, 26);
            this.перейтиНаТаблицуМероприятияToolStripMenuItem.Text = "Перейти на таблицу мероприятия ";
            this.перейтиНаТаблицуМероприятияToolStripMenuItem.Click += new System.EventHandler(this.перейтиНаТаблицуМероприятияToolStripMenuItem_Click);
            // 
            // добавитьАктивToolStripMenuItem
            // 
            this.добавитьАктивToolStripMenuItem.Name = "добавитьАктивToolStripMenuItem";
            this.добавитьАктивToolStripMenuItem.Size = new System.Drawing.Size(336, 26);
            this.добавитьАктивToolStripMenuItem.Text = "Добавить актив";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 620);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user17_PetrovDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private user17_PetrovDataSet user17_PetrovDataSet;
        private System.Windows.Forms.BindingSource activeBindingSource;
        private user17_PetrovDataSetTableAdapters.ActiveTableAdapter activeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namemeroprDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameactiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moderatoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn juryid1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn juryid2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn juryid3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn juryid4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn juryid5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpobedDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перейтиНаТаблицуМероприятияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьАктивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}