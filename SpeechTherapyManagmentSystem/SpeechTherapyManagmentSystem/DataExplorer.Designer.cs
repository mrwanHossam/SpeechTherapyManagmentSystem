namespace SpeechTherapyManagmentSystem
{
    partial class DataExplorer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.speechManagmentSystemDataSet = new SpeechTherapyManagmentSystem.SpeechManagmentSystemDataSet();
            this.speechManagmentSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speechManagmentSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speechManagmentSystemDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.speechManagmentSystemDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(692, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // speechManagmentSystemDataSet
            // 
            this.speechManagmentSystemDataSet.DataSetName = "SpeechManagmentSystemDataSet";
            this.speechManagmentSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // speechManagmentSystemDataSetBindingSource
            // 
            this.speechManagmentSystemDataSetBindingSource.DataSource = this.speechManagmentSystemDataSet;
            this.speechManagmentSystemDataSetBindingSource.Position = 0;
            // 
            // DataExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 434);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataExplorer";
            this.Text = "Cases Files";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speechManagmentSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speechManagmentSystemDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource speechManagmentSystemDataSetBindingSource;
        private SpeechManagmentSystemDataSet speechManagmentSystemDataSet;
    }
}