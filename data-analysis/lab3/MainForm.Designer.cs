namespace lab3
{
    partial class MainForm
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
            this.groupBoxTools = new System.Windows.Forms.GroupBox();
            this.tbBrushSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBrushSize = new System.Windows.Forms.TrackBar();
            this.rbBrush = new System.Windows.Forms.RadioButton();
            this.rbPut = new System.Windows.Forms.RadioButton();
            this.bClear = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.listViewColors = new System.Windows.Forms.ListView();
            this.columnColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictBoxDotsArea = new System.Windows.Forms.PictureBox();
            this.numUpDownClusters = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.bToCluster = new System.Windows.Forms.Button();
            this.groupBoxTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBrushSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxDotsArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownClusters)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTools
            // 
            this.groupBoxTools.Controls.Add(this.tbBrushSize);
            this.groupBoxTools.Controls.Add(this.label2);
            this.groupBoxTools.Controls.Add(this.trackBrushSize);
            this.groupBoxTools.Controls.Add(this.rbBrush);
            this.groupBoxTools.Controls.Add(this.rbPut);
            this.groupBoxTools.Controls.Add(this.bClear);
            this.groupBoxTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTools.Location = new System.Drawing.Point(12, 167);
            this.groupBoxTools.Name = "groupBoxTools";
            this.groupBoxTools.Size = new System.Drawing.Size(224, 193);
            this.groupBoxTools.TabIndex = 1;
            this.groupBoxTools.TabStop = false;
            this.groupBoxTools.Text = "Tools";
            // 
            // tbBrushSize
            // 
            this.tbBrushSize.Location = new System.Drawing.Point(110, 80);
            this.tbBrushSize.Name = "tbBrushSize";
            this.tbBrushSize.ReadOnly = true;
            this.tbBrushSize.Size = new System.Drawing.Size(100, 22);
            this.tbBrushSize.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Brush size";
            // 
            // trackBrushSize
            // 
            this.trackBrushSize.Location = new System.Drawing.Point(6, 102);
            this.trackBrushSize.Maximum = 100;
            this.trackBrushSize.Minimum = 20;
            this.trackBrushSize.Name = "trackBrushSize";
            this.trackBrushSize.Size = new System.Drawing.Size(212, 42);
            this.trackBrushSize.TabIndex = 5;
            this.trackBrushSize.TickFrequency = 5;
            this.trackBrushSize.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBrushSize.Value = 20;
            this.trackBrushSize.ValueChanged += new System.EventHandler(this.trackBrushSize_ValueChanged);
            // 
            // rbBrush
            // 
            this.rbBrush.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbBrush.AutoSize = true;
            this.rbBrush.Image = global::lab3.Properties.Resources.imageBrush;
            this.rbBrush.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbBrush.Location = new System.Drawing.Point(52, 21);
            this.rbBrush.MinimumSize = new System.Drawing.Size(40, 40);
            this.rbBrush.Name = "rbBrush";
            this.rbBrush.Size = new System.Drawing.Size(52, 40);
            this.rbBrush.TabIndex = 5;
            this.rbBrush.TabStop = true;
            this.rbBrush.Text = "Brush";
            this.rbBrush.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbBrush.UseVisualStyleBackColor = true;
            // 
            // rbPut
            // 
            this.rbPut.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPut.AutoSize = true;
            this.rbPut.Image = global::lab3.Properties.Resources.imagePut;
            this.rbPut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbPut.Location = new System.Drawing.Point(6, 21);
            this.rbPut.MinimumSize = new System.Drawing.Size(40, 40);
            this.rbPut.Name = "rbPut";
            this.rbPut.Size = new System.Drawing.Size(40, 40);
            this.rbPut.TabIndex = 4;
            this.rbPut.TabStop = true;
            this.rbPut.Text = "Put";
            this.rbPut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbPut.UseVisualStyleBackColor = true;
            // 
            // bClear
            // 
            this.bClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bClear.Image = global::lab3.Properties.Resources.imageClear;
            this.bClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bClear.Location = new System.Drawing.Point(110, 21);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(52, 40);
            this.bClear.TabIndex = 1;
            this.bClear.Text = "Clear";
            this.bClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // listViewColors
            // 
            this.listViewColors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnColor,
            this.columnText});
            this.listViewColors.FullRowSelect = true;
            this.listViewColors.HideSelection = false;
            this.listViewColors.Location = new System.Drawing.Point(13, 13);
            this.listViewColors.MultiSelect = false;
            this.listViewColors.Name = "listViewColors";
            this.listViewColors.Size = new System.Drawing.Size(223, 97);
            this.listViewColors.TabIndex = 2;
            this.listViewColors.UseCompatibleStateImageBehavior = false;
            this.listViewColors.View = System.Windows.Forms.View.Details;
            // 
            // columnColor
            // 
            this.columnColor.Text = "Color";
            // 
            // columnText
            // 
            this.columnText.Text = "Text";
            // 
            // pictBoxDotsArea
            // 
            this.pictBoxDotsArea.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictBoxDotsArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictBoxDotsArea.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictBoxDotsArea.Location = new System.Drawing.Point(323, 12);
            this.pictBoxDotsArea.Name = "pictBoxDotsArea";
            this.pictBoxDotsArea.Size = new System.Drawing.Size(465, 426);
            this.pictBoxDotsArea.TabIndex = 0;
            this.pictBoxDotsArea.TabStop = false;
            this.pictBoxDotsArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictBoxDotsArea_MouseDown);
            this.pictBoxDotsArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictBoxDotsArea_MouseMove);
            // 
            // numUpDownClusters
            // 
            this.numUpDownClusters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDownClusters.Location = new System.Drawing.Point(158, 135);
            this.numUpDownClusters.Name = "numUpDownClusters";
            this.numUpDownClusters.ReadOnly = true;
            this.numUpDownClusters.Size = new System.Drawing.Size(78, 26);
            this.numUpDownClusters.TabIndex = 3;
            this.numUpDownClusters.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of Clusters";
            // 
            // bToCluster
            // 
            this.bToCluster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bToCluster.Location = new System.Drawing.Point(12, 367);
            this.bToCluster.Name = "bToCluster";
            this.bToCluster.Size = new System.Drawing.Size(224, 33);
            this.bToCluster.TabIndex = 5;
            this.bToCluster.Text = "to Cluster";
            this.bToCluster.UseVisualStyleBackColor = true;
            this.bToCluster.Click += new System.EventHandler(this.bToCluster_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bToCluster);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUpDownClusters);
            this.Controls.Add(this.listViewColors);
            this.Controls.Add(this.groupBoxTools);
            this.Controls.Add(this.pictBoxDotsArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "k-Means";
            this.groupBoxTools.ResumeLayout(false);
            this.groupBoxTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBrushSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxDotsArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownClusters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxDotsArea;
        private System.Windows.Forms.GroupBox groupBoxTools;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListView listViewColors;
        private System.Windows.Forms.ColumnHeader columnColor;
        private System.Windows.Forms.ColumnHeader columnText;
        private System.Windows.Forms.RadioButton rbBrush;
        private System.Windows.Forms.RadioButton rbPut;
        private System.Windows.Forms.NumericUpDown numUpDownClusters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBrushSize;
        private System.Windows.Forms.TextBox tbBrushSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bToCluster;
    }
}

