namespace INFOIBV
{
    partial class INFOIBV
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.imageFileName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.matrix1 = new System.Windows.Forms.TextBox();
            this.matrix6 = new System.Windows.Forms.TextBox();
            this.matrix2 = new System.Windows.Forms.TextBox();
            this.matrix13 = new System.Windows.Forms.TextBox();
            this.matrix12 = new System.Windows.Forms.TextBox();
            this.matrix11 = new System.Windows.Forms.TextBox();
            this.matrix8 = new System.Windows.Forms.TextBox();
            this.matrix7 = new System.Windows.Forms.TextBox();
            this.matrix3 = new System.Windows.Forms.TextBox();
            this.matrix4 = new System.Windows.Forms.TextBox();
            this.matrix18 = new System.Windows.Forms.TextBox();
            this.matrix17 = new System.Windows.Forms.TextBox();
            this.matrix16 = new System.Windows.Forms.TextBox();
            this.matrix23 = new System.Windows.Forms.TextBox();
            this.matrix22 = new System.Windows.Forms.TextBox();
            this.matrix21 = new System.Windows.Forms.TextBox();
            this.matrix19 = new System.Windows.Forms.TextBox();
            this.matrix14 = new System.Windows.Forms.TextBox();
            this.matrix9 = new System.Windows.Forms.TextBox();
            this.matrix20 = new System.Windows.Forms.TextBox();
            this.matrix15 = new System.Windows.Forms.TextBox();
            this.matrix10 = new System.Windows.Forms.TextBox();
            this.matrix5 = new System.Windows.Forms.TextBox();
            this.matrix24 = new System.Windows.Forms.TextBox();
            this.matrix25 = new System.Windows.Forms.TextBox();
            this.histoIn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.isBinaryButton = new System.Windows.Forms.RadioButton();
            this.histoOut = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ValuesBox = new System.Windows.Forms.TextBox();
            this.valuesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histoIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histoOut)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.Location = new System.Drawing.Point(16, 15);
            this.LoadImageButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(131, 28);
            this.LoadImageButton.TabIndex = 0;
            this.LoadImageButton.Text = "Load image...";
            this.LoadImageButton.UseVisualStyleBackColor = true;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // openImageDialog
            // 
            this.openImageDialog.Filter = "Bitmap files (*.bmp;*.gif;*.jpg;*.png;*.tiff;*.jpeg)|*.bmp;*.gif;*.jpg;*.png;*.ti" +
    "ff;*.jpeg";
            this.openImageDialog.InitialDirectory = "..\\..\\images";
            // 
            // imageFileName
            // 
            this.imageFileName.Location = new System.Drawing.Point(155, 17);
            this.imageFileName.Margin = new System.Windows.Forms.Padding(4);
            this.imageFileName.Name = "imageFileName";
            this.imageFileName.ReadOnly = true;
            this.imageFileName.Size = new System.Drawing.Size(368, 22);
            this.imageFileName.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(683, 630);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(856, 15);
            this.applyButton.Margin = new System.Windows.Forms.Padding(4);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(137, 28);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // saveImageDialog
            // 
            this.saveImageDialog.Filter = "Bitmap file (*.bmp)|*.bmp";
            this.saveImageDialog.InitialDirectory = "..\\..\\images";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1264, 14);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(127, 28);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save as BMP...";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(708, 55);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(683, 630);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(1001, 17);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(255, 25);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 6;
            this.progressBar.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "erosion",
            "dilation",
            "opening",
            "closing",
            "complement",
            "and",
            "or",
            "value counting",
            "boundary trace"});
            this.comboBox1.Location = new System.Drawing.Point(688, 17);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // matrix1
            // 
            this.matrix1.Location = new System.Drawing.Point(1407, 55);
            this.matrix1.Margin = new System.Windows.Forms.Padding(4);
            this.matrix1.Name = "matrix1";
            this.matrix1.Size = new System.Drawing.Size(29, 22);
            this.matrix1.TabIndex = 14;
            this.matrix1.Text = "0";
            // 
            // matrix6
            // 
            this.matrix6.Location = new System.Drawing.Point(1407, 87);
            this.matrix6.Margin = new System.Windows.Forms.Padding(4);
            this.matrix6.Name = "matrix6";
            this.matrix6.Size = new System.Drawing.Size(29, 22);
            this.matrix6.TabIndex = 15;
            this.matrix6.Text = "0";
            // 
            // matrix2
            // 
            this.matrix2.Location = new System.Drawing.Point(1445, 55);
            this.matrix2.Margin = new System.Windows.Forms.Padding(4);
            this.matrix2.Name = "matrix2";
            this.matrix2.Size = new System.Drawing.Size(29, 22);
            this.matrix2.TabIndex = 16;
            this.matrix2.Text = "0";
            // 
            // matrix13
            // 
            this.matrix13.Location = new System.Drawing.Point(1484, 119);
            this.matrix13.Margin = new System.Windows.Forms.Padding(4);
            this.matrix13.Name = "matrix13";
            this.matrix13.Size = new System.Drawing.Size(29, 22);
            this.matrix13.TabIndex = 19;
            this.matrix13.Text = "0";
            // 
            // matrix12
            // 
            this.matrix12.Location = new System.Drawing.Point(1445, 119);
            this.matrix12.Margin = new System.Windows.Forms.Padding(4);
            this.matrix12.Name = "matrix12";
            this.matrix12.Size = new System.Drawing.Size(29, 22);
            this.matrix12.TabIndex = 20;
            this.matrix12.Text = "0";
            // 
            // matrix11
            // 
            this.matrix11.Location = new System.Drawing.Point(1407, 119);
            this.matrix11.Margin = new System.Windows.Forms.Padding(4);
            this.matrix11.Name = "matrix11";
            this.matrix11.Size = new System.Drawing.Size(29, 22);
            this.matrix11.TabIndex = 21;
            this.matrix11.Text = "0";
            // 
            // matrix8
            // 
            this.matrix8.Location = new System.Drawing.Point(1484, 87);
            this.matrix8.Margin = new System.Windows.Forms.Padding(4);
            this.matrix8.Name = "matrix8";
            this.matrix8.Size = new System.Drawing.Size(29, 22);
            this.matrix8.TabIndex = 22;
            this.matrix8.Text = "0";
            // 
            // matrix7
            // 
            this.matrix7.Location = new System.Drawing.Point(1445, 87);
            this.matrix7.Margin = new System.Windows.Forms.Padding(4);
            this.matrix7.Name = "matrix7";
            this.matrix7.Size = new System.Drawing.Size(29, 22);
            this.matrix7.TabIndex = 23;
            this.matrix7.Text = "0";
            // 
            // matrix3
            // 
            this.matrix3.Location = new System.Drawing.Point(1484, 55);
            this.matrix3.Margin = new System.Windows.Forms.Padding(4);
            this.matrix3.Name = "matrix3";
            this.matrix3.Size = new System.Drawing.Size(29, 22);
            this.matrix3.TabIndex = 24;
            this.matrix3.Text = "0";
            // 
            // matrix4
            // 
            this.matrix4.Location = new System.Drawing.Point(1523, 55);
            this.matrix4.Margin = new System.Windows.Forms.Padding(4);
            this.matrix4.Name = "matrix4";
            this.matrix4.Size = new System.Drawing.Size(29, 22);
            this.matrix4.TabIndex = 25;
            this.matrix4.Text = "0";
            // 
            // matrix18
            // 
            this.matrix18.Location = new System.Drawing.Point(1484, 151);
            this.matrix18.Margin = new System.Windows.Forms.Padding(4);
            this.matrix18.Name = "matrix18";
            this.matrix18.Size = new System.Drawing.Size(29, 22);
            this.matrix18.TabIndex = 26;
            this.matrix18.Text = "0";
            // 
            // matrix17
            // 
            this.matrix17.Location = new System.Drawing.Point(1445, 151);
            this.matrix17.Margin = new System.Windows.Forms.Padding(4);
            this.matrix17.Name = "matrix17";
            this.matrix17.Size = new System.Drawing.Size(29, 22);
            this.matrix17.TabIndex = 27;
            this.matrix17.Text = "0";
            // 
            // matrix16
            // 
            this.matrix16.Location = new System.Drawing.Point(1407, 151);
            this.matrix16.Margin = new System.Windows.Forms.Padding(4);
            this.matrix16.Name = "matrix16";
            this.matrix16.Size = new System.Drawing.Size(29, 22);
            this.matrix16.TabIndex = 28;
            this.matrix16.Text = "0";
            // 
            // matrix23
            // 
            this.matrix23.Location = new System.Drawing.Point(1484, 183);
            this.matrix23.Margin = new System.Windows.Forms.Padding(4);
            this.matrix23.Name = "matrix23";
            this.matrix23.Size = new System.Drawing.Size(29, 22);
            this.matrix23.TabIndex = 29;
            this.matrix23.Text = "0";
            // 
            // matrix22
            // 
            this.matrix22.Location = new System.Drawing.Point(1445, 183);
            this.matrix22.Margin = new System.Windows.Forms.Padding(4);
            this.matrix22.Name = "matrix22";
            this.matrix22.Size = new System.Drawing.Size(29, 22);
            this.matrix22.TabIndex = 30;
            this.matrix22.Text = "0";
            // 
            // matrix21
            // 
            this.matrix21.Location = new System.Drawing.Point(1407, 183);
            this.matrix21.Margin = new System.Windows.Forms.Padding(4);
            this.matrix21.Name = "matrix21";
            this.matrix21.Size = new System.Drawing.Size(29, 22);
            this.matrix21.TabIndex = 31;
            this.matrix21.Text = "0";
            // 
            // matrix19
            // 
            this.matrix19.Location = new System.Drawing.Point(1523, 151);
            this.matrix19.Margin = new System.Windows.Forms.Padding(4);
            this.matrix19.Name = "matrix19";
            this.matrix19.Size = new System.Drawing.Size(29, 22);
            this.matrix19.TabIndex = 32;
            this.matrix19.Text = "0";
            // 
            // matrix14
            // 
            this.matrix14.Location = new System.Drawing.Point(1523, 119);
            this.matrix14.Margin = new System.Windows.Forms.Padding(4);
            this.matrix14.Name = "matrix14";
            this.matrix14.Size = new System.Drawing.Size(29, 22);
            this.matrix14.TabIndex = 33;
            this.matrix14.Text = "0";
            // 
            // matrix9
            // 
            this.matrix9.Location = new System.Drawing.Point(1523, 87);
            this.matrix9.Margin = new System.Windows.Forms.Padding(4);
            this.matrix9.Name = "matrix9";
            this.matrix9.Size = new System.Drawing.Size(29, 22);
            this.matrix9.TabIndex = 34;
            this.matrix9.Text = "0";
            // 
            // matrix20
            // 
            this.matrix20.Location = new System.Drawing.Point(1561, 151);
            this.matrix20.Margin = new System.Windows.Forms.Padding(4);
            this.matrix20.Name = "matrix20";
            this.matrix20.Size = new System.Drawing.Size(29, 22);
            this.matrix20.TabIndex = 35;
            this.matrix20.Text = "0";
            // 
            // matrix15
            // 
            this.matrix15.Location = new System.Drawing.Point(1561, 119);
            this.matrix15.Margin = new System.Windows.Forms.Padding(4);
            this.matrix15.Name = "matrix15";
            this.matrix15.Size = new System.Drawing.Size(29, 22);
            this.matrix15.TabIndex = 36;
            this.matrix15.Text = "0";
            // 
            // matrix10
            // 
            this.matrix10.Location = new System.Drawing.Point(1561, 87);
            this.matrix10.Margin = new System.Windows.Forms.Padding(4);
            this.matrix10.Name = "matrix10";
            this.matrix10.Size = new System.Drawing.Size(29, 22);
            this.matrix10.TabIndex = 37;
            this.matrix10.Text = "0";
            // 
            // matrix5
            // 
            this.matrix5.Location = new System.Drawing.Point(1561, 55);
            this.matrix5.Margin = new System.Windows.Forms.Padding(4);
            this.matrix5.Name = "matrix5";
            this.matrix5.Size = new System.Drawing.Size(29, 22);
            this.matrix5.TabIndex = 38;
            this.matrix5.Text = "0";
            // 
            // matrix24
            // 
            this.matrix24.Location = new System.Drawing.Point(1523, 183);
            this.matrix24.Margin = new System.Windows.Forms.Padding(4);
            this.matrix24.Name = "matrix24";
            this.matrix24.Size = new System.Drawing.Size(29, 22);
            this.matrix24.TabIndex = 39;
            this.matrix24.Text = "0";
            // 
            // matrix25
            // 
            this.matrix25.Location = new System.Drawing.Point(1561, 183);
            this.matrix25.Margin = new System.Windows.Forms.Padding(4);
            this.matrix25.Name = "matrix25";
            this.matrix25.Size = new System.Drawing.Size(29, 22);
            this.matrix25.TabIndex = 40;
            this.matrix25.Text = "0";
            // 
            // histoIn
            // 
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.Maximum = 255D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.histoIn.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.histoIn.Legends.Add(legend1);
            this.histoIn.Location = new System.Drawing.Point(17, 692);
            this.histoIn.Name = "histoIn";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.histoIn.Series.Add(series1);
            this.histoIn.Size = new System.Drawing.Size(308, 145);
            this.histoIn.TabIndex = 41;
            this.histoIn.Text = "chart1";
            // 
            // isBinaryButton
            // 
            this.isBinaryButton.AutoSize = true;
            this.isBinaryButton.Location = new System.Drawing.Point(548, 18);
            this.isBinaryButton.Name = "isBinaryButton";
            this.isBinaryButton.Size = new System.Drawing.Size(68, 21);
            this.isBinaryButton.TabIndex = 43;
            this.isBinaryButton.TabStop = true;
            this.isBinaryButton.Text = "binary";
            this.isBinaryButton.UseVisualStyleBackColor = true;
            this.isBinaryButton.Visible = false;
            // 
            // histoOut
            // 
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorGrid.LineWidth = 0;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisX.Maximum = 255D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.BorderWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.histoOut.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.histoOut.Legends.Add(legend2);
            this.histoOut.Location = new System.Drawing.Point(1083, 696);
            this.histoOut.Name = "histoOut";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.histoOut.Series.Add(series2);
            this.histoOut.Size = new System.Drawing.Size(308, 145);
            this.histoOut.TabIndex = 44;
            this.histoOut.Text = "chart1";
            // 
            // ValuesBox
            // 
            this.ValuesBox.Location = new System.Drawing.Point(1515, 299);
            this.ValuesBox.Name = "ValuesBox";
            this.ValuesBox.ReadOnly = true;
            this.ValuesBox.Size = new System.Drawing.Size(106, 22);
            this.ValuesBox.TabIndex = 45;
            // 
            // valuesLabel
            // 
            this.valuesLabel.AutoSize = true;
            this.valuesLabel.Location = new System.Drawing.Point(1404, 302);
            this.valuesLabel.Name = "valuesLabel";
            this.valuesLabel.Size = new System.Drawing.Size(105, 17);
            this.valuesLabel.TabIndex = 46;
            this.valuesLabel.Text = "Distinct Values:";
            // 
            // INFOIBV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1696, 1055);
            this.Controls.Add(this.valuesLabel);
            this.Controls.Add(this.ValuesBox);
            this.Controls.Add(this.histoOut);
            this.Controls.Add(this.isBinaryButton);
            this.Controls.Add(this.histoIn);
            this.Controls.Add(this.matrix25);
            this.Controls.Add(this.matrix24);
            this.Controls.Add(this.matrix5);
            this.Controls.Add(this.matrix10);
            this.Controls.Add(this.matrix15);
            this.Controls.Add(this.matrix20);
            this.Controls.Add(this.matrix9);
            this.Controls.Add(this.matrix14);
            this.Controls.Add(this.matrix19);
            this.Controls.Add(this.matrix21);
            this.Controls.Add(this.matrix22);
            this.Controls.Add(this.matrix23);
            this.Controls.Add(this.matrix16);
            this.Controls.Add(this.matrix17);
            this.Controls.Add(this.matrix18);
            this.Controls.Add(this.matrix4);
            this.Controls.Add(this.matrix3);
            this.Controls.Add(this.matrix7);
            this.Controls.Add(this.matrix8);
            this.Controls.Add(this.matrix11);
            this.Controls.Add(this.matrix12);
            this.Controls.Add(this.matrix13);
            this.Controls.Add(this.matrix2);
            this.Controls.Add(this.matrix6);
            this.Controls.Add(this.matrix1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imageFileName);
            this.Controls.Add(this.LoadImageButton);
            this.Location = new System.Drawing.Point(10, 10);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "INFOIBV";
            this.ShowIcon = false;
            this.Text = "INFOIBV";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histoIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histoOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.TextBox imageFileName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.SaveFileDialog saveImageDialog;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox matrix1;
        private System.Windows.Forms.TextBox matrix6;
        private System.Windows.Forms.TextBox matrix2;
        private System.Windows.Forms.TextBox matrix13;
        private System.Windows.Forms.TextBox matrix12;
        private System.Windows.Forms.TextBox matrix11;
        private System.Windows.Forms.TextBox matrix8;
        private System.Windows.Forms.TextBox matrix7;
        private System.Windows.Forms.TextBox matrix3;
        private System.Windows.Forms.TextBox matrix4;
        private System.Windows.Forms.TextBox matrix18;
        private System.Windows.Forms.TextBox matrix17;
        private System.Windows.Forms.TextBox matrix16;
        private System.Windows.Forms.TextBox matrix23;
        private System.Windows.Forms.TextBox matrix22;
        private System.Windows.Forms.TextBox matrix21;
        private System.Windows.Forms.TextBox matrix19;
        private System.Windows.Forms.TextBox matrix14;
        private System.Windows.Forms.TextBox matrix9;
        private System.Windows.Forms.TextBox matrix20;
        private System.Windows.Forms.TextBox matrix15;
        private System.Windows.Forms.TextBox matrix10;
        private System.Windows.Forms.TextBox matrix5;
        private System.Windows.Forms.TextBox matrix24;
        private System.Windows.Forms.TextBox matrix25;
        private System.Windows.Forms.DataVisualization.Charting.Chart histoIn;
        private System.Windows.Forms.RadioButton isBinaryButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart histoOut;
        private System.Windows.Forms.TextBox ValuesBox;
        private System.Windows.Forms.Label valuesLabel;
    }
}

