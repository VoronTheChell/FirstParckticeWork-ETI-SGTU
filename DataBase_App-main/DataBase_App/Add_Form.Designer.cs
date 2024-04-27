namespace DataBase_App
{
    partial class Add_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Clean = new System.Windows.Forms.PictureBox();
            this.btn_Info = new System.Windows.Forms.PictureBox();
            this.textBox_type2 = new System.Windows.Forms.TextBox();
            this.textBox_count2 = new System.Windows.Forms.TextBox();
            this.textBox_postavchik2 = new System.Windows.Forms.TextBox();
            this.textBox_price2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Clean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Info)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_Clean);
            this.panel1.Controls.Add(this.btn_Info);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(58, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 69);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(4, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(448, 51);
            this.label5.TabIndex = 13;
            this.label5.Text = "Создание записи:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Clean
            // 
            this.btn_Clean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clean.Image = global::DataBase_App.Properties.Resources.Tool_Free_PNG;
            this.btn_Clean.Location = new System.Drawing.Point(513, 16);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(42, 38);
            this.btn_Clean.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Clean.TabIndex = 11;
            this.btn_Clean.TabStop = false;
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click);
            // 
            // btn_Info
            // 
            this.btn_Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Info.Image = global::DataBase_App.Properties.Resources.img_519962_61897;
            this.btn_Info.Location = new System.Drawing.Point(458, 16);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(39, 38);
            this.btn_Info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Info.TabIndex = 10;
            this.btn_Info.TabStop = false;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // textBox_type2
            // 
            this.textBox_type2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_type2.Location = new System.Drawing.Point(280, 115);
            this.textBox_type2.Multiline = true;
            this.textBox_type2.Name = "textBox_type2";
            this.textBox_type2.Size = new System.Drawing.Size(276, 30);
            this.textBox_type2.TabIndex = 1;
            // 
            // textBox_count2
            // 
            this.textBox_count2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_count2.Location = new System.Drawing.Point(280, 151);
            this.textBox_count2.Multiline = true;
            this.textBox_count2.Name = "textBox_count2";
            this.textBox_count2.Size = new System.Drawing.Size(276, 30);
            this.textBox_count2.TabIndex = 2;
            // 
            // textBox_postavchik2
            // 
            this.textBox_postavchik2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_postavchik2.Location = new System.Drawing.Point(280, 187);
            this.textBox_postavchik2.Multiline = true;
            this.textBox_postavchik2.Name = "textBox_postavchik2";
            this.textBox_postavchik2.Size = new System.Drawing.Size(276, 30);
            this.textBox_postavchik2.TabIndex = 3;
            // 
            // textBox_price2
            // 
            this.textBox_price2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_price2.Location = new System.Drawing.Point(280, 223);
            this.textBox_price2.Multiline = true;
            this.textBox_price2.Name = "textBox_price2";
            this.textBox_price2.Size = new System.Drawing.Size(276, 30);
            this.textBox_price2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(122, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Тип товара:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(122, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Колличество:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(122, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Поставщик:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(122, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цена:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(80, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(534, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DataBase_App.Properties.Resources._1674964623_top_fon_com_p_serii_gradientnii_fon_dlya_prezentatsii_97;
            this.ClientSize = new System.Drawing.Size(696, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_price2);
            this.Controls.Add(this.textBox_postavchik2);
            this.Controls.Add(this.textBox_count2);
            this.Controls.Add(this.textBox_type2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Form";
            this.Text = "Add_Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add_Form_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Clean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_type2;
        private System.Windows.Forms.TextBox textBox_count2;
        private System.Windows.Forms.TextBox textBox_postavchik2;
        private System.Windows.Forms.TextBox textBox_price2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btn_Clean;
        private System.Windows.Forms.PictureBox btn_Info;
    }
}