namespace IP_calc
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ip1 = new TextBox();
            ip2 = new TextBox();
            ip3 = new TextBox();
            ip4 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            masc1 = new TextBox();
            decimalMaskTextBox = new TextBox();
            masc2 = new TextBox();
            masc3 = new TextBox();
            masc4 = new TextBox();
            computerNumberTextBox = new TextBox();
            netAddr4 = new TextBox();
            netAddr3 = new TextBox();
            netAddr2 = new TextBox();
            netAddr1 = new TextBox();
            nodeAddr4 = new TextBox();
            nodeAddr3 = new TextBox();
            nodeAddr2 = new TextBox();
            nodeAddr1 = new TextBox();
            numberOfNodesTextBox = new TextBox();
            networkClassTextBox = new TextBox();
            decimalNetworkAddrTextBox = new TextBox();
            decimalNodeAddrTextBox = new TextBox();
            button1 = new Button();
            label13 = new Label();
            label14 = new Label();
            ip24 = new TextBox();
            ip23 = new TextBox();
            ip22 = new TextBox();
            ip21 = new TextBox();
            label15 = new Label();
            masc_pref = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaption;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(289, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 0;
            label1.Text = "IP-адреса:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InactiveCaption;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(583, 20);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(200, 23);
            label2.TabIndex = 1;
            label2.Text = "Префікс підмережі:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(31, 263);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 2;
            label3.Text = "Маска:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(31, 340);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 3;
            label4.Text = "Адреса мережі:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label5.Location = new Point(31, 380);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 4;
            label5.Text = "Адреса вузла:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label6.Location = new Point(31, 472);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(183, 20);
            label6.TabIndex = 5;
            label6.Text = "Номер вузла в мережі";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label7.Location = new Point(349, 472);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(215, 20);
            label7.TabIndex = 6;
            label7.Text = "Загальна кількість вузлів";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label8.Location = new Point(725, 471);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(112, 20);
            label8.TabIndex = 7;
            label8.Text = "Клас мережі ";
            // 
            // ip1
            // 
            ip1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ip1.ForeColor = Color.Navy;
            ip1.Location = new Point(121, 63);
            ip1.Margin = new Padding(4, 5, 4, 5);
            ip1.Name = "ip1";
            ip1.Size = new Size(69, 26);
            ip1.TabIndex = 8;
            ip1.TextAlign = HorizontalAlignment.Center;
            // 
            // ip2
            // 
            ip2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ip2.ForeColor = Color.Navy;
            ip2.Location = new Point(237, 65);
            ip2.Margin = new Padding(4, 5, 4, 5);
            ip2.Name = "ip2";
            ip2.Size = new Size(69, 26);
            ip2.TabIndex = 9;
            ip2.TextAlign = HorizontalAlignment.Center;
            // 
            // ip3
            // 
            ip3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ip3.ForeColor = Color.Navy;
            ip3.Location = new Point(345, 65);
            ip3.Margin = new Padding(4, 5, 4, 5);
            ip3.Name = "ip3";
            ip3.Size = new Size(69, 26);
            ip3.TabIndex = 10;
            ip3.TextAlign = HorizontalAlignment.Center;
            // 
            // ip4
            // 
            ip4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ip4.ForeColor = Color.Navy;
            ip4.Location = new Point(461, 65);
            ip4.Margin = new Padding(4, 5, 4, 5);
            ip4.Name = "ip4";
            ip4.Size = new Size(69, 26);
            ip4.TabIndex = 10;
            ip4.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.InactiveCaption;
            label9.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label9.Location = new Point(204, 66);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(22, 32);
            label9.TabIndex = 12;
            label9.Text = ".";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.InactiveCaption;
            label10.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label10.Location = new Point(316, 66);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(22, 32);
            label10.TabIndex = 13;
            label10.Text = ".";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.InactiveCaption;
            label11.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label11.Location = new Point(432, 66);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(22, 32);
            label11.TabIndex = 14;
            label11.Text = ".";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.InactiveCaption;
            label12.Font = new Font("Arial", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label12.Location = new Point(580, 57);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(23, 34);
            label12.TabIndex = 15;
            label12.Text = "/";
            // 
            // masc1
            // 
            masc1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            masc1.Location = new Point(189, 257);
            masc1.Margin = new Padding(4, 5, 4, 5);
            masc1.Name = "masc1";
            masc1.Size = new Size(129, 26);
            masc1.TabIndex = 16;
            masc1.TextAlign = HorizontalAlignment.Center;
            // 
            // decimalMaskTextBox
            // 
            decimalMaskTextBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            decimalMaskTextBox.Location = new Point(800, 255);
            decimalMaskTextBox.Margin = new Padding(4, 5, 4, 5);
            decimalMaskTextBox.Name = "decimalMaskTextBox";
            decimalMaskTextBox.Size = new Size(261, 26);
            decimalMaskTextBox.TabIndex = 17;
            decimalMaskTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // masc2
            // 
            masc2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            masc2.Location = new Point(328, 258);
            masc2.Margin = new Padding(4, 5, 4, 5);
            masc2.Name = "masc2";
            masc2.Size = new Size(129, 26);
            masc2.TabIndex = 17;
            masc2.TextAlign = HorizontalAlignment.Center;
            // 
            // masc3
            // 
            masc3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            masc3.Location = new Point(467, 258);
            masc3.Margin = new Padding(4, 5, 4, 5);
            masc3.Name = "masc3";
            masc3.Size = new Size(129, 26);
            masc3.TabIndex = 18;
            masc3.TextAlign = HorizontalAlignment.Center;
            // 
            // masc4
            // 
            masc4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            masc4.Location = new Point(605, 258);
            masc4.Margin = new Padding(4, 5, 4, 5);
            masc4.Name = "masc4";
            masc4.Size = new Size(129, 26);
            masc4.TabIndex = 19;
            masc4.TextAlign = HorizontalAlignment.Center;
            // 
            // computerNumberTextBox
            // 
            computerNumberTextBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            computerNumberTextBox.ForeColor = Color.Red;
            computerNumberTextBox.Location = new Point(222, 469);
            computerNumberTextBox.Margin = new Padding(4, 5, 4, 5);
            computerNumberTextBox.Name = "computerNumberTextBox";
            computerNumberTextBox.Size = new Size(104, 26);
            computerNumberTextBox.TabIndex = 21;
            computerNumberTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // netAddr4
            // 
            netAddr4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            netAddr4.Location = new Point(608, 340);
            netAddr4.Margin = new Padding(4, 5, 4, 5);
            netAddr4.Name = "netAddr4";
            netAddr4.Size = new Size(129, 26);
            netAddr4.TabIndex = 25;
            netAddr4.TextAlign = HorizontalAlignment.Center;
            // 
            // netAddr3
            // 
            netAddr3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            netAddr3.Location = new Point(469, 340);
            netAddr3.Margin = new Padding(4, 5, 4, 5);
            netAddr3.Name = "netAddr3";
            netAddr3.Size = new Size(129, 26);
            netAddr3.TabIndex = 24;
            netAddr3.TextAlign = HorizontalAlignment.Center;
            // 
            // netAddr2
            // 
            netAddr2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            netAddr2.Location = new Point(331, 340);
            netAddr2.Margin = new Padding(4, 5, 4, 5);
            netAddr2.Name = "netAddr2";
            netAddr2.Size = new Size(129, 26);
            netAddr2.TabIndex = 23;
            netAddr2.TextAlign = HorizontalAlignment.Center;
            // 
            // netAddr1
            // 
            netAddr1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            netAddr1.Location = new Point(189, 340);
            netAddr1.Margin = new Padding(4, 5, 4, 5);
            netAddr1.Name = "netAddr1";
            netAddr1.Size = new Size(129, 26);
            netAddr1.TabIndex = 22;
            netAddr1.TextAlign = HorizontalAlignment.Center;
            // 
            // nodeAddr4
            // 
            nodeAddr4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nodeAddr4.Location = new Point(608, 380);
            nodeAddr4.Margin = new Padding(4, 5, 4, 5);
            nodeAddr4.Name = "nodeAddr4";
            nodeAddr4.Size = new Size(129, 26);
            nodeAddr4.TabIndex = 29;
            nodeAddr4.TextAlign = HorizontalAlignment.Center;
            // 
            // nodeAddr3
            // 
            nodeAddr3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nodeAddr3.Location = new Point(469, 380);
            nodeAddr3.Margin = new Padding(4, 5, 4, 5);
            nodeAddr3.Name = "nodeAddr3";
            nodeAddr3.Size = new Size(129, 26);
            nodeAddr3.TabIndex = 28;
            nodeAddr3.TextAlign = HorizontalAlignment.Center;
            // 
            // nodeAddr2
            // 
            nodeAddr2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nodeAddr2.Location = new Point(331, 380);
            nodeAddr2.Margin = new Padding(4, 5, 4, 5);
            nodeAddr2.Name = "nodeAddr2";
            nodeAddr2.Size = new Size(129, 26);
            nodeAddr2.TabIndex = 27;
            nodeAddr2.TextAlign = HorizontalAlignment.Center;
            // 
            // nodeAddr1
            // 
            nodeAddr1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nodeAddr1.Location = new Point(189, 380);
            nodeAddr1.Margin = new Padding(4, 5, 4, 5);
            nodeAddr1.Name = "nodeAddr1";
            nodeAddr1.Size = new Size(129, 26);
            nodeAddr1.TabIndex = 26;
            nodeAddr1.TextAlign = HorizontalAlignment.Center;
            // 
            // numberOfNodesTextBox
            // 
            numberOfNodesTextBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numberOfNodesTextBox.ForeColor = Color.Red;
            numberOfNodesTextBox.Location = new Point(572, 469);
            numberOfNodesTextBox.Margin = new Padding(4, 5, 4, 5);
            numberOfNodesTextBox.Name = "numberOfNodesTextBox";
            numberOfNodesTextBox.Size = new Size(145, 26);
            numberOfNodesTextBox.TabIndex = 30;
            numberOfNodesTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // networkClassTextBox
            // 
            networkClassTextBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            networkClassTextBox.ForeColor = Color.Red;
            networkClassTextBox.Location = new Point(848, 466);
            networkClassTextBox.Margin = new Padding(4, 5, 4, 5);
            networkClassTextBox.Name = "networkClassTextBox";
            networkClassTextBox.Size = new Size(250, 26);
            networkClassTextBox.TabIndex = 31;
            networkClassTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // decimalNetworkAddrTextBox
            // 
            decimalNetworkAddrTextBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            decimalNetworkAddrTextBox.Location = new Point(800, 340);
            decimalNetworkAddrTextBox.Margin = new Padding(4, 5, 4, 5);
            decimalNetworkAddrTextBox.Name = "decimalNetworkAddrTextBox";
            decimalNetworkAddrTextBox.Size = new Size(261, 26);
            decimalNetworkAddrTextBox.TabIndex = 32;
            decimalNetworkAddrTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // decimalNodeAddrTextBox
            // 
            decimalNodeAddrTextBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            decimalNodeAddrTextBox.Location = new Point(800, 380);
            decimalNodeAddrTextBox.Margin = new Padding(4, 5, 4, 5);
            decimalNodeAddrTextBox.Name = "decimalNodeAddrTextBox";
            decimalNodeAddrTextBox.Size = new Size(261, 26);
            decimalNodeAddrTextBox.TabIndex = 33;
            decimalNodeAddrTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.SandyBrown;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(425, 529);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(215, 63);
            button1.TabIndex = 34;
            button1.Text = "Розрахувати";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label13.Location = new Point(297, 165);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(268, 24);
            label13.TabIndex = 35;
            label13.Text = "Двійкове представлення:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label14.Location = new Point(31, 223);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(90, 20);
            label14.TabIndex = 36;
            label14.Text = "IP-адреса:";
            // 
            // ip24
            // 
            ip24.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ip24.Location = new Point(605, 218);
            ip24.Margin = new Padding(4, 5, 4, 5);
            ip24.Name = "ip24";
            ip24.Size = new Size(129, 26);
            ip24.TabIndex = 41;
            ip24.TextAlign = HorizontalAlignment.Center;
            // 
            // ip23
            // 
            ip23.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ip23.Location = new Point(467, 218);
            ip23.Margin = new Padding(4, 5, 4, 5);
            ip23.Name = "ip23";
            ip23.Size = new Size(129, 26);
            ip23.TabIndex = 40;
            ip23.TextAlign = HorizontalAlignment.Center;
            // 
            // ip22
            // 
            ip22.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ip22.Location = new Point(328, 218);
            ip22.Margin = new Padding(4, 5, 4, 5);
            ip22.Name = "ip22";
            ip22.Size = new Size(129, 26);
            ip22.TabIndex = 39;
            ip22.TextAlign = HorizontalAlignment.Center;
            // 
            // ip21
            // 
            ip21.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ip21.Location = new Point(189, 217);
            ip21.Margin = new Padding(4, 5, 4, 5);
            ip21.Name = "ip21";
            ip21.Size = new Size(129, 26);
            ip21.TabIndex = 38;
            ip21.TextAlign = HorizontalAlignment.Center;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.DarkSeaGreen;
            label15.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label15.Location = new Point(777, 211);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(288, 24);
            label15.TabIndex = 37;
            label15.Text = "Десяткове представлення:";
            // 
            // masc_pref
            // 
            masc_pref.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            masc_pref.ForeColor = Color.Navy;
            masc_pref.FormattingEnabled = true;
            masc_pref.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32" });
            masc_pref.Location = new Point(693, 82);
            masc_pref.Margin = new Padding(4, 5, 4, 5);
            masc_pref.Name = "masc_pref";
            masc_pref.Size = new Size(56, 28);
            masc_pref.TabIndex = 42;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(ip1);
            panel1.Controls.Add(ip3);
            panel1.Controls.Add(ip4);
            panel1.Controls.Add(ip2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(35, 18);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1063, 120);
            panel1.TabIndex = 43;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSeaGreen;
            panel2.Location = new Point(761, 177);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(336, 271);
            panel2.TabIndex = 44;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 609);
            Controls.Add(masc_pref);
            Controls.Add(ip24);
            Controls.Add(ip23);
            Controls.Add(ip22);
            Controls.Add(ip21);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(button1);
            Controls.Add(decimalNodeAddrTextBox);
            Controls.Add(decimalNetworkAddrTextBox);
            Controls.Add(networkClassTextBox);
            Controls.Add(numberOfNodesTextBox);
            Controls.Add(nodeAddr4);
            Controls.Add(nodeAddr3);
            Controls.Add(nodeAddr2);
            Controls.Add(nodeAddr1);
            Controls.Add(netAddr4);
            Controls.Add(netAddr3);
            Controls.Add(netAddr2);
            Controls.Add(netAddr1);
            Controls.Add(computerNumberTextBox);
            Controls.Add(masc4);
            Controls.Add(masc3);
            Controls.Add(masc2);
            Controls.Add(decimalMaskTextBox);
            Controls.Add(masc1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "IP-калькулятор";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ip1;
        private System.Windows.Forms.TextBox ip2;
        private System.Windows.Forms.TextBox ip3;
        private System.Windows.Forms.TextBox ip4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox masc1;
        private System.Windows.Forms.TextBox decimalMaskTextBox;
        private System.Windows.Forms.TextBox masc2;
        private System.Windows.Forms.TextBox masc3;
        private System.Windows.Forms.TextBox masc4;
        private System.Windows.Forms.TextBox computerNumberTextBox;
        private System.Windows.Forms.TextBox netAddr4;
        private System.Windows.Forms.TextBox netAddr3;
        private System.Windows.Forms.TextBox netAddr2;
        private System.Windows.Forms.TextBox netAddr1;
        private System.Windows.Forms.TextBox nodeAddr4;
        private System.Windows.Forms.TextBox nodeAddr3;
        private System.Windows.Forms.TextBox nodeAddr2;
        private System.Windows.Forms.TextBox nodeAddr1;
        private System.Windows.Forms.TextBox numberOfNodesTextBox;
        private System.Windows.Forms.TextBox networkClassTextBox;
        private System.Windows.Forms.TextBox decimalNetworkAddrTextBox;
        private System.Windows.Forms.TextBox decimalNodeAddrTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ip24;
        private System.Windows.Forms.TextBox ip23;
        private System.Windows.Forms.TextBox ip22;
        private System.Windows.Forms.TextBox ip21;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox masc_pref;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

