using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmsAssignment
{
    public partial class Form1 : Form
    {
        MyLinkedList<Pokemon> linkedList = new MyLinkedList<Pokemon>();
        MyArrayList<Pokemon> arrayList = new MyArrayList<Pokemon>();
        MyStack<Pokemon> stack = new MyStack<Pokemon>();
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1169, 755);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1169, 722);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "File overview";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "File has been uploaded successfully!\r\nHere\'s an overview of the file.\r\nNavigate t" +
    "he tabs to work with individual data structures\r\n";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(346, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(820, 695);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.richTextBox4);
            this.tabPage2.Controls.Add(this.richTextBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1161, 726);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Linked List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(761, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Time elapsed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(785, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(25, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 58);
            this.button3.TabIndex = 6;
            this.button3.Text = "Selection sort ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 53);
            this.button2.TabIndex = 5;
            this.button2.Text = "Bubble sort ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(962, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "After sort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Before sort";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(465, 56);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(327, 660);
            this.richTextBox4.TabIndex = 2;
            this.richTextBox4.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(827, 55);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(327, 660);
            this.richTextBox3.TabIndex = 1;
            this.richTextBox3.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.button9);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.button10);
            this.tabPage3.Controls.Add(this.button11);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.richTextBox2);
            this.tabPage3.Controls.Add(this.richTextBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1161, 726);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Array List";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button12);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.button13);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.button14);
            this.tabPage4.Controls.Add(this.textBox3);
            this.tabPage4.Controls.Add(this.label22);
            this.tabPage4.Controls.Add(this.label23);
            this.tabPage4.Controls.Add(this.label24);
            this.tabPage4.Controls.Add(this.button15);
            this.tabPage4.Controls.Add(this.button16);
            this.tabPage4.Controls.Add(this.label25);
            this.tabPage4.Controls.Add(this.label26);
            this.tabPage4.Controls.Add(this.richTextBox6);
            this.tabPage4.Controls.Add(this.richTextBox7);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1161, 726);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Stack";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 96);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "UPLOAD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Insert pokemon name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 320);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 22);
            this.textBox1.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(25, 349);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 43);
            this.button4.TabIndex = 11;
            this.button4.Text = "Find using linear search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Your pokemon is on line:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Time elapsed:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(28, 399);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 48);
            this.button5.TabIndex = 14;
            this.button5.Text = "Find using binary search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(167, 415);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 32);
            this.label10.TabIndex = 15;
            this.label10.Text = "Sorts out the dataset first,\r\nbecause binary search requires it";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(25, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 24);
            this.button6.TabIndex = 16;
            this.button6.Text = "Reset dataset";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(16, 23);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 24);
            this.button7.TabIndex = 32;
            this.button7.Text = "Reset dataset";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(158, 419);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 32);
            this.label11.TabIndex = 31;
            this.label11.Text = "Sorts out the dataset first,\r\nbecause binary search requires it";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(19, 403);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(133, 48);
            this.button8.TabIndex = 30;
            this.button8.Text = "Find using binary search";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(249, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "Time elapsed:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(249, 304);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "Your pokemon is on line:";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(16, 353);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(136, 43);
            this.button9.TabIndex = 27;
            this.button9.Text = "Find using linear search";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 324);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 22);
            this.textBox2.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 304);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 16);
            this.label14.TabIndex = 25;
            this.label14.Text = "Insert pokemon name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(748, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 16);
            this.label15.TabIndex = 24;
            this.label15.Text = "Time elapsed";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(776, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 16);
            this.label16.TabIndex = 23;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(16, 150);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(142, 58);
            this.button10.TabIndex = 22;
            this.button10.Text = "Selection sort ";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(16, 75);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(142, 53);
            this.button11.TabIndex = 21;
            this.button11.Text = "Bubble sort ";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(953, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 16);
            this.label17.TabIndex = 20;
            this.label17.Text = "After sort";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(591, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 16);
            this.label18.TabIndex = 19;
            this.label18.Text = "Before sort";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(456, 60);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(327, 660);
            this.richTextBox2.TabIndex = 18;
            this.richTextBox2.Text = "";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(818, 59);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(327, 660);
            this.richTextBox5.TabIndex = 17;
            this.richTextBox5.Text = "";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(16, 23);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(120, 24);
            this.button12.TabIndex = 32;
            this.button12.Text = "Reset dataset";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(158, 419);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(205, 32);
            this.label19.TabIndex = 31;
            this.label19.Text = "Sorts out the dataset first,\r\nbecause binary search requires it";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(19, 403);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(133, 48);
            this.button13.TabIndex = 30;
            this.button13.Text = "Find using binary search";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(249, 330);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 16);
            this.label20.TabIndex = 29;
            this.label20.Text = "Time elapsed:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(249, 304);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(153, 16);
            this.label21.TabIndex = 28;
            this.label21.Text = "Your pokemon is on line:";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(16, 353);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(136, 43);
            this.button14.TabIndex = 27;
            this.button14.Text = "Find using linear search";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 324);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 22);
            this.textBox3.TabIndex = 26;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(16, 304);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(136, 16);
            this.label22.TabIndex = 25;
            this.label22.Text = "Insert pokemon name";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(752, 7);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(91, 16);
            this.label23.TabIndex = 24;
            this.label23.Text = "Time elapsed";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(776, 31);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(0, 16);
            this.label24.TabIndex = 23;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(16, 150);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(142, 58);
            this.button15.TabIndex = 22;
            this.button15.Text = "Selection sort ";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(16, 75);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(142, 53);
            this.button16.TabIndex = 21;
            this.button16.Text = "Bubble sort ";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(953, 31);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 16);
            this.label25.TabIndex = 20;
            this.label25.Text = "After sort";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(591, 31);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(72, 16);
            this.label26.TabIndex = 19;
            this.label26.Text = "Before sort";
            // 
            // richTextBox6
            // 
            this.richTextBox6.Location = new System.Drawing.Point(456, 60);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(327, 660);
            this.richTextBox6.TabIndex = 18;
            this.richTextBox6.Text = "";
            // 
            // richTextBox7
            // 
            this.richTextBox7.Location = new System.Drawing.Point(818, 59);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(327, 660);
            this.richTextBox7.TabIndex = 17;
            this.richTextBox7.Text = "";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void parseCSV(string filename)
        {
            using (TextFieldParser parser = new TextFieldParser(filename))
            {
                linkedList.Clear();
                arrayList.Clear();
                stack.Clear();
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    if (fields[0] != "name")
                    {
                        Pokemon addedPokemon = new Pokemon(fields[0], fields[1], fields[2], Int32.Parse(fields[3]), Int32.Parse(fields[4]), Int32.Parse(fields[5]));
                        linkedList.Add(addedPokemon);
                        arrayList.Add(addedPokemon);
                        stack.Push(addedPokemon);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parseCSV("insert/convertcsv.csv");
            label1.Visible = false;
            button1.Visible = false;
            tabControl1.Visible = true;
            richTextBox1.Text = linkedList.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox4.Text = linkedList.ToString();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            linkedList.BubbleSort();
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            label5.Text = elapsed_time.ToString() + " miliseconds";
            richTextBox3.Text = linkedList.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox4.Text = linkedList.ToString();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            linkedList.SelectionSort();
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            label5.Text = elapsed_time.ToString() + " miliseconds";
            richTextBox3.Text = linkedList.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int foundLine = linkedList.LinearSearch(new Pokemon(textBox1.Text, "", "", 1, 1, 1));
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            label8.Text = "Your pokemon is on line: " + foundLine;
            label9.Text ="Time elapsed: " + elapsed_time.ToString() + " miliseconds";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int foundLine = linkedList.BinarySearch(new Pokemon(textBox1.Text, "", "", 1, 1, 1));
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            label8.Text = "Your pokemon is on line: " + foundLine;
            label9.Text = "Time elapsed: " + elapsed_time.ToString() + " miliseconds";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            parseCSV("./././insert/convertcsv.csv");
            richTextBox4.Text = linkedList.ToString();
            richTextBox3.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            parseCSV("./././insert/convertcsv.csv");
            richTextBox2.Text = arrayList.ToString();
            richTextBox5.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            parseCSV("./././insert/convertcsv.csv");
            richTextBox6.Text = stack.ToString();
            richTextBox7.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = arrayList.ToString();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            arrayList.BubbleSort();
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            label16.Text = elapsed_time.ToString() + " miliseconds";
            richTextBox5.Text = arrayList.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = arrayList.ToString();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            arrayList.SelectionSort();
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            label16.Text = elapsed_time.ToString() + " miliseconds";
            richTextBox5.Text = arrayList.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                int foundLine = arrayList.LinearSearch(new Pokemon(textBox2.Text, "", "", 1, 1, 1));
                stopwatch.Stop();
                long elapsed_time = stopwatch.ElapsedMilliseconds;
                label13.Text = "Your pokemon is on line: " + foundLine;
                label12.Text = "Time elapsed: " + elapsed_time.ToString() + " miliseconds";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int foundLine = arrayList.BinarySearch(new Pokemon(textBox2.Text, "", "", 1, 1, 1));
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            label13.Text = "Your pokemon is on line: " + foundLine;
            label12.Text = "Time elapsed: " + elapsed_time.ToString() + " miliseconds";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox6.Text = stack.ToString();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stack.BubbleSort();
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            label24.Text = elapsed_time.ToString() + " miliseconds";
            richTextBox7.Text = stack.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox6.Text = stack.ToString();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stack.SelectionSort();
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            label24.Text = elapsed_time.ToString() + " miliseconds";
            richTextBox7.Text = stack.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int foundLine = stack.LinearSearch(new Pokemon(textBox3.Text, "", "", 1, 1, 1));
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            label21.Text = "Your pokemon is on line: " + foundLine;
            label20.Text = "Time elapsed: " + elapsed_time.ToString() + " miliseconds";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int foundLine = stack.BinarySearch(new Pokemon(textBox3.Text, "", "", 1, 1, 1));
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            label21.Text = "Your pokemon is on line: " + foundLine;
            label20.Text = "Time elapsed: " + elapsed_time.ToString() + " miliseconds";
        }
    }
}
