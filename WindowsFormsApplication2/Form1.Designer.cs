namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.kilo = new System.Windows.Forms.CheckBox();
            this.kum = new System.Windows.Forms.CheckBox();
            this.tun = new System.Windows.Forms.CheckBox();
            this.pon = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kilobox = new System.Windows.Forms.TextBox();
            this.Box2 = new System.Windows.Forms.TextBox();
            this.Box3 = new System.Windows.Forms.TextBox();
            this.Box4 = new System.Windows.Forms.TextBox();
            this.num = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kilo
            // 
            this.kilo.AutoSize = true;
            this.kilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.kilo.Location = new System.Drawing.Point(92, 190);
            this.kilo.Name = "kilo";
            this.kilo.Size = new System.Drawing.Size(63, 20);
            this.kilo.TabIndex = 0;
            this.kilo.Text = "กิโลกรัม";
            this.kilo.UseVisualStyleBackColor = true;
            this.kilo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // kum
            // 
            this.kum.AutoSize = true;
            this.kum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.kum.Location = new System.Drawing.Point(201, 190);
            this.kum.Name = "kum";
            this.kum.Size = new System.Drawing.Size(46, 20);
            this.kum.TabIndex = 1;
            this.kum.Text = "กรัม";
            this.kum.UseVisualStyleBackColor = true;
            this.kum.CheckedChanged += new System.EventHandler(this.kum_CheckedChanged);
            // 
            // tun
            // 
            this.tun.AutoSize = true;
            this.tun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tun.Location = new System.Drawing.Point(293, 190);
            this.tun.Name = "tun";
            this.tun.Size = new System.Drawing.Size(41, 20);
            this.tun.TabIndex = 2;
            this.tun.Text = "ตัน";
            this.tun.UseVisualStyleBackColor = true;
            this.tun.CheckedChanged += new System.EventHandler(this.tun_CheckedChanged);
            // 
            // pon
            // 
            this.pon.AutoSize = true;
            this.pon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.pon.Location = new System.Drawing.Point(395, 190);
            this.pon.Name = "pon";
            this.pon.Size = new System.Drawing.Size(54, 20);
            this.pon.TabIndex = 3;
            this.pon.Text = "ปอนด์";
            this.pon.UseVisualStyleBackColor = true;
            this.pon.CheckedChanged += new System.EventHandler(this.pon_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(89, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "กิโลกรัม";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(198, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "กรัม";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(309, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "ตัน";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(426, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "ปอนด์";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(233, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "( หน่วยที่ป้อนค่า )";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(246, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "( ใส่ตัวเลข )";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(208, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "แปลงค่าน้ำหนัก";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // kilobox
            // 
            this.kilobox.Location = new System.Drawing.Point(56, 365);
            this.kilobox.Name = "kilobox";
            this.kilobox.Size = new System.Drawing.Size(100, 20);
            this.kilobox.TabIndex = 12;
            // 
            // Box2
            // 
            this.Box2.Location = new System.Drawing.Point(168, 365);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(100, 20);
            this.Box2.TabIndex = 13;
            // 
            // Box3
            // 
            this.Box3.Location = new System.Drawing.Point(286, 365);
            this.Box3.Name = "Box3";
            this.Box3.Size = new System.Drawing.Size(100, 20);
            this.Box3.TabIndex = 14;
            // 
            // Box4
            // 
            this.Box4.Location = new System.Drawing.Point(401, 365);
            this.Box4.Name = "Box4";
            this.Box4.Size = new System.Drawing.Size(100, 20);
            this.Box4.TabIndex = 15;
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(226, 108);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(119, 20);
            this.num.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(221, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "แสดงผลลัพธ์";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(201, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "ออกจากโปรแกรม";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 498);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.num);
            this.Controls.Add(this.Box4);
            this.Controls.Add(this.Box3);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.kilobox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pon);
            this.Controls.Add(this.tun);
            this.Controls.Add(this.kum);
            this.Controls.Add(this.kilo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox kilo;
        private System.Windows.Forms.CheckBox kum;
        private System.Windows.Forms.CheckBox tun;
        private System.Windows.Forms.CheckBox pon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kilobox;
        private System.Windows.Forms.TextBox Box2;
        private System.Windows.Forms.TextBox Box3;
        private System.Windows.Forms.TextBox Box4;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

