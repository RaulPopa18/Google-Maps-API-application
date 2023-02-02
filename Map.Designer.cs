namespace Map
{
    partial class Map
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
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtLatitudine = new System.Windows.Forms.TextBox();
            this.txtLongitudine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMark = new System.Windows.Forms.Button();
            this.btnGetRoute = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cautareP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cautareS = new System.Windows.Forms.Button();
            this.txtPlecare = new System.Windows.Forms.TextBox();
            this.txtSosire = new System.Windows.Forms.TextBox();
            this.Restore = new System.Windows.Forms.Button();
            this.LblTextSpeed = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gMap
            // 
            this.gMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.EmptyTileColor = System.Drawing.Color.Blue;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemory = 5;
            this.gMap.Location = new System.Drawing.Point(0, 0);
            this.gMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 2;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(775, 571);
            this.gMap.TabIndex = 0;
            this.gMap.Zoom = 0D;
            this.gMap.Load += new System.EventHandler(this.gMap_Load);
            this.gMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseClick);
            // 
            // btnAdd
            // 
            this.btnAdd.AllowDrop = true;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(911, 208);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 60);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Adauga";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AllowDrop = true;
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(911, 297);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 60);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Stergere";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtLatitudine
            // 
            this.txtLatitudine.AllowDrop = true;
            this.txtLatitudine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLatitudine.Location = new System.Drawing.Point(908, 57);
            this.txtLatitudine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLatitudine.Name = "txtLatitudine";
            this.txtLatitudine.Size = new System.Drawing.Size(81, 22);
            this.txtLatitudine.TabIndex = 4;
            // 
            // txtLongitudine
            // 
            this.txtLongitudine.AllowDrop = true;
            this.txtLongitudine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLongitudine.Location = new System.Drawing.Point(1023, 59);
            this.txtLongitudine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLongitudine.Name = "txtLongitudine";
            this.txtLongitudine.Size = new System.Drawing.Size(81, 22);
            this.txtLongitudine.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1023, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Longitudine";
            // 
            // btnMark
            // 
            this.btnMark.AllowDrop = true;
            this.btnMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMark.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMark.Location = new System.Drawing.Point(1051, 208);
            this.btnMark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(90, 60);
            this.btnMark.TabIndex = 10;
            this.btnMark.Text = "Marcaj";
            this.btnMark.UseVisualStyleBackColor = true;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // btnGetRoute
            // 
            this.btnGetRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetRoute.Font = new System.Drawing.Font("MS PGothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetRoute.Location = new System.Drawing.Point(986, 387);
            this.btnGetRoute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetRoute.Name = "btnGetRoute";
            this.btnGetRoute.Size = new System.Drawing.Size(80, 40);
            this.btnGetRoute.TabIndex = 11;
            this.btnGetRoute.Text = "Ruta";
            this.btnGetRoute.UseVisualStyleBackColor = true;
            this.btnGetRoute.Click += new System.EventHandler(this.btnGetRoute_Click);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(908, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Latitudine";
            // 
            // txtDistance
            // 
            this.txtDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDistance.Location = new System.Drawing.Point(973, 445);
            this.txtDistance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.ReadOnly = true;
            this.txtDistance.Size = new System.Drawing.Size(100, 22);
            this.txtDistance.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(829, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Introduceti punctul de plecare: ";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // btn_cautareP
            // 
            this.btn_cautareP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cautareP.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cautareP.Location = new System.Drawing.Point(1216, 117);
            this.btn_cautareP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cautareP.Name = "btn_cautareP";
            this.btn_cautareP.Size = new System.Drawing.Size(59, 28);
            this.btn_cautareP.TabIndex = 15;
            this.btn_cautareP.Text = "Ok";
            this.btn_cautareP.UseVisualStyleBackColor = true;
            this.btn_cautareP.Click += new System.EventHandler(this.btn_cautareP_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS PGothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(829, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Introduceti punctul de sosire: ";
            // 
            // btn_cautareS
            // 
            this.btn_cautareS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cautareS.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cautareS.Location = new System.Drawing.Point(1216, 152);
            this.btn_cautareS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cautareS.Name = "btn_cautareS";
            this.btn_cautareS.Size = new System.Drawing.Size(59, 28);
            this.btn_cautareS.TabIndex = 17;
            this.btn_cautareS.Text = "Ok";
            this.btn_cautareS.UseVisualStyleBackColor = true;
            this.btn_cautareS.Click += new System.EventHandler(this.btn_cautareS_Click);
            // 
            // txtPlecare
            // 
            this.txtPlecare.AllowDrop = true;
            this.txtPlecare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlecare.Location = new System.Drawing.Point(1107, 117);
            this.txtPlecare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlecare.Name = "txtPlecare";
            this.txtPlecare.Size = new System.Drawing.Size(91, 22);
            this.txtPlecare.TabIndex = 18;
            // 
            // txtSosire
            // 
            this.txtSosire.AllowDrop = true;
            this.txtSosire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSosire.Location = new System.Drawing.Point(1107, 155);
            this.txtSosire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSosire.Name = "txtSosire";
            this.txtSosire.Size = new System.Drawing.Size(91, 22);
            this.txtSosire.TabIndex = 19;
            // 
            // Restore
            // 
            this.Restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restore.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restore.Location = new System.Drawing.Point(1051, 297);
            this.Restore.Name = "Restore";
            this.Restore.Size = new System.Drawing.Size(90, 60);
            this.Restore.TabIndex = 20;
            this.Restore.Text = "Restore";
            this.Restore.UseVisualStyleBackColor = true;
            this.Restore.Click += new System.EventHandler(this.Restore_Click);
            // 
            // LblTextSpeed
            // 
            this.LblTextSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTextSpeed.AutoSize = true;
            this.LblTextSpeed.Font = new System.Drawing.Font("MS PGothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTextSpeed.Location = new System.Drawing.Point(939, 486);
            this.LblTextSpeed.Name = "LblTextSpeed";
            this.LblTextSpeed.Size = new System.Drawing.Size(202, 40);
            this.LblTextSpeed.TabIndex = 21;
            this.LblTextSpeed.Text = "Durata medie a calatoriei:\r\n\r\n";
            this.LblTextSpeed.UseCompatibleTextRendering = true;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpeed.Location = new System.Drawing.Point(973, 536);
            this.txtSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.ReadOnly = true;
            this.txtSpeed.Size = new System.Drawing.Size(100, 22);
            this.txtSpeed.TabIndex = 25;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(180)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1291, 569);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.LblTextSpeed);
            this.Controls.Add(this.Restore);
            this.Controls.Add(this.txtSosire);
            this.Controls.Add(this.txtPlecare);
            this.Controls.Add(this.btn_cautareS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_cautareP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.btnGetRoute);
            this.Controls.Add(this.btnMark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLongitudine);
            this.Controls.Add(this.txtLatitudine);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gMap);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Map";
            this.Text = "Map";
            this.Load += new System.EventHandler(this.Map_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Map_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtLatitudine;
        private System.Windows.Forms.TextBox txtLongitudine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.Button btnGetRoute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cautareP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cautareS;
        private System.Windows.Forms.TextBox txtPlecare;
        private System.Windows.Forms.TextBox txtSosire;
        private System.Windows.Forms.Button Restore;
        private System.Windows.Forms.Label LblTextSpeed;
        private System.Windows.Forms.TextBox txtSpeed;
    }
}

