namespace tentamen
{
    partial class Trail
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.importHotels = new System.Windows.Forms.Button();
            this.hotels = new System.Windows.Forms.ListBox();
            this.basic = new System.Windows.Forms.CheckBox();
            this.standard = new System.Windows.Forms.CheckBox();
            this.deluxe = new System.Windows.Forms.CheckBox();
            this.calculateCost = new System.Windows.Forms.Button();
            this.overview = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "CAMINO DE SANTIAGO TRAIL";
            // 
            // importHotels
            // 
            this.importHotels.Location = new System.Drawing.Point(15, 76);
            this.importHotels.Name = "importHotels";
            this.importHotels.Size = new System.Drawing.Size(138, 29);
            this.importHotels.TabIndex = 2;
            this.importHotels.Text = "Import Hotels";
            this.importHotels.UseVisualStyleBackColor = true;
            this.importHotels.Click += new System.EventHandler(this.importHotels_Click);
            // 
            // hotels
            // 
            this.hotels.FormattingEnabled = true;
            this.hotels.ItemHeight = 20;
            this.hotels.Location = new System.Drawing.Point(15, 142);
            this.hotels.Name = "hotels";
            this.hotels.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.hotels.Size = new System.Drawing.Size(362, 104);
            this.hotels.TabIndex = 3;
            // 
            // basic
            // 
            this.basic.AutoSize = true;
            this.basic.Location = new System.Drawing.Point(408, 142);
            this.basic.Name = "basic";
            this.basic.Size = new System.Drawing.Size(65, 24);
            this.basic.TabIndex = 4;
            this.basic.Text = "Basic";
            this.basic.UseVisualStyleBackColor = true;
            // 
            // standard
            // 
            this.standard.AutoSize = true;
            this.standard.Location = new System.Drawing.Point(408, 182);
            this.standard.Name = "standard";
            this.standard.Size = new System.Drawing.Size(91, 24);
            this.standard.TabIndex = 5;
            this.standard.Text = "Standard";
            this.standard.UseVisualStyleBackColor = true;
            // 
            // deluxe
            // 
            this.deluxe.AutoSize = true;
            this.deluxe.Location = new System.Drawing.Point(406, 225);
            this.deluxe.Name = "deluxe";
            this.deluxe.Size = new System.Drawing.Size(77, 24);
            this.deluxe.TabIndex = 6;
            this.deluxe.Text = "Deluxe";
            this.deluxe.UseVisualStyleBackColor = true;
            // 
            // calculateCost
            // 
            this.calculateCost.Location = new System.Drawing.Point(575, 175);
            this.calculateCost.Name = "calculateCost";
            this.calculateCost.Size = new System.Drawing.Size(147, 29);
            this.calculateCost.TabIndex = 7;
            this.calculateCost.Text = "Calculate cost";
            this.calculateCost.UseVisualStyleBackColor = true;
            this.calculateCost.Click += new System.EventHandler(this.calculateCost_Click);
            // 
            // overview
            // 
            this.overview.Location = new System.Drawing.Point(19, 288);
            this.overview.Name = "overview";
            this.overview.Size = new System.Drawing.Size(358, 150);
            this.overview.TabIndex = 8;
            this.overview.Text = "";
            // 
            // Trail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.overview);
            this.Controls.Add(this.calculateCost);
            this.Controls.Add(this.deluxe);
            this.Controls.Add(this.standard);
            this.Controls.Add(this.basic);
            this.Controls.Add(this.hotels);
            this.Controls.Add(this.importHotels);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Trail";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button importHotels;
        private ListBox hotels;
        private CheckBox basic;
        private CheckBox standard;
        private CheckBox deluxe;
        private Button calculateCost;
        private RichTextBox overview;
    }
}