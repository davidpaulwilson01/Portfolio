namespace BookInventorySystem
{
    partial class MainScreen
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
            field1lbl = new Label();
            field1txt = new TextBox();
            field2txt = new TextBox();
            field2lbl = new Label();
            field4txt = new TextBox();
            field4lbl = new Label();
            field3txt = new TextBox();
            field3lbl = new Label();
            field6txt = new TextBox();
            field6lbl = new Label();
            field5txt = new TextBox();
            field5lbl = new Label();
            label5 = new Label();
            bookbtn = new Button();
            customerbtn = new Button();
            employeebtn = new Button();
            orderbtn = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            addbtn = new Button();
            label6 = new Label();
            removebtn = new Button();
            adjustbtn = new Button();
            searchbtn = new Button();
            listbtn = new Button();
            quitbtn = new Button();
            currRecTypeLbl = new Label();
            curRecTypeShow = new Label();
            curOpShow = new Label();
            curOplbl = new Label();
            field8txt = new TextBox();
            field8lbl = new Label();
            field7txt = new TextBox();
            field7lbl = new Label();
            SuspendLayout();
            // 
            // field1lbl
            // 
            field1lbl.AutoSize = true;
            field1lbl.Location = new Point(30, 34);
            field1lbl.MinimumSize = new Size(200, 0);
            field1lbl.Name = "field1lbl";
            field1lbl.Size = new Size(200, 15);
            field1lbl.TabIndex = 0;
            field1lbl.Text = "ISBN";
            field1lbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // field1txt
            // 
            field1txt.Location = new Point(236, 31);
            field1txt.MinimumSize = new Size(250, 0);
            field1txt.Name = "field1txt";
            field1txt.Size = new Size(250, 23);
            field1txt.TabIndex = 1;
            // 
            // field2txt
            // 
            field2txt.Location = new Point(698, 31);
            field2txt.MinimumSize = new Size(250, 0);
            field2txt.Name = "field2txt";
            field2txt.Size = new Size(250, 23);
            field2txt.TabIndex = 3;
            // 
            // field2lbl
            // 
            field2lbl.AutoSize = true;
            field2lbl.Location = new Point(492, 34);
            field2lbl.MinimumSize = new Size(200, 0);
            field2lbl.Name = "field2lbl";
            field2lbl.Size = new Size(200, 15);
            field2lbl.TabIndex = 2;
            field2lbl.Text = "Authors";
            field2lbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // field4txt
            // 
            field4txt.Location = new Point(698, 88);
            field4txt.MinimumSize = new Size(250, 0);
            field4txt.Name = "field4txt";
            field4txt.Size = new Size(250, 23);
            field4txt.TabIndex = 7;
            // 
            // field4lbl
            // 
            field4lbl.AutoSize = true;
            field4lbl.Location = new Point(492, 91);
            field4lbl.MinimumSize = new Size(200, 0);
            field4lbl.Name = "field4lbl";
            field4lbl.Size = new Size(200, 15);
            field4lbl.TabIndex = 6;
            field4lbl.Text = "Edition";
            field4lbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // field3txt
            // 
            field3txt.Location = new Point(236, 88);
            field3txt.MinimumSize = new Size(250, 0);
            field3txt.Name = "field3txt";
            field3txt.Size = new Size(250, 23);
            field3txt.TabIndex = 5;
            // 
            // field3lbl
            // 
            field3lbl.AutoSize = true;
            field3lbl.Location = new Point(30, 91);
            field3lbl.MinimumSize = new Size(200, 0);
            field3lbl.Name = "field3lbl";
            field3lbl.Size = new Size(200, 15);
            field3lbl.TabIndex = 4;
            field3lbl.Text = "Title";
            field3lbl.TextAlign = ContentAlignment.MiddleRight;
            field3lbl.Click += field3lbl_Click;
            // 
            // field6txt
            // 
            field6txt.Location = new Point(698, 151);
            field6txt.MinimumSize = new Size(250, 0);
            field6txt.Name = "field6txt";
            field6txt.Size = new Size(250, 23);
            field6txt.TabIndex = 11;
            // 
            // field6lbl
            // 
            field6lbl.AutoSize = true;
            field6lbl.Location = new Point(492, 154);
            field6lbl.MinimumSize = new Size(200, 0);
            field6lbl.Name = "field6lbl";
            field6lbl.Size = new Size(200, 15);
            field6lbl.TabIndex = 10;
            field6lbl.Text = "Stock";
            field6lbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // field5txt
            // 
            field5txt.Location = new Point(236, 151);
            field5txt.MinimumSize = new Size(250, 0);
            field5txt.Name = "field5txt";
            field5txt.Size = new Size(250, 23);
            field5txt.TabIndex = 9;
            // 
            // field5lbl
            // 
            field5lbl.AutoSize = true;
            field5lbl.Location = new Point(30, 154);
            field5lbl.MinimumSize = new Size(200, 0);
            field5lbl.Name = "field5lbl";
            field5lbl.Size = new Size(200, 15);
            field5lbl.TabIndex = 8;
            field5lbl.Text = "Format";
            field5lbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(268, 344);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 12;
            label5.Text = "Select Record Type";
            // 
            // bookbtn
            // 
            bookbtn.Location = new Point(281, 362);
            bookbtn.Name = "bookbtn";
            bookbtn.Size = new Size(75, 23);
            bookbtn.TabIndex = 13;
            bookbtn.Text = "Book";
            bookbtn.UseVisualStyleBackColor = true;
            // 
            // customerbtn
            // 
            customerbtn.Location = new Point(281, 391);
            customerbtn.Name = "customerbtn";
            customerbtn.Size = new Size(75, 23);
            customerbtn.TabIndex = 14;
            customerbtn.Text = "Customer";
            customerbtn.UseVisualStyleBackColor = true;
            // 
            // employeebtn
            // 
            employeebtn.Location = new Point(281, 420);
            employeebtn.Name = "employeebtn";
            employeebtn.Size = new Size(75, 23);
            employeebtn.TabIndex = 15;
            employeebtn.Text = "Employee";
            employeebtn.UseVisualStyleBackColor = true;
            // 
            // orderbtn
            // 
            orderbtn.Location = new Point(281, 449);
            orderbtn.Name = "orderbtn";
            orderbtn.Size = new Size(75, 23);
            orderbtn.TabIndex = 16;
            orderbtn.Text = "Order";
            orderbtn.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(630, 449);
            button5.Name = "button5";
            button5.Size = new Size(0, 0);
            button5.TabIndex = 21;
            button5.Text = "Select Operation";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(630, 420);
            button6.Name = "button6";
            button6.Size = new Size(0, 0);
            button6.TabIndex = 20;
            button6.Text = "Select Operation";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(630, 391);
            button7.Name = "button7";
            button7.Size = new Size(0, 0);
            button7.TabIndex = 19;
            button7.Text = "Select Operation";
            button7.UseVisualStyleBackColor = true;
            // 
            // addbtn
            // 
            addbtn.Location = new Point(630, 362);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(100, 23);
            addbtn.TabIndex = 18;
            addbtn.Text = "Add Record";
            addbtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(630, 344);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 17;
            label6.Text = "Select Operation";
            // 
            // removebtn
            // 
            removebtn.Location = new Point(630, 391);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(100, 23);
            removebtn.TabIndex = 22;
            removebtn.Text = "Remove Record";
            removebtn.UseVisualStyleBackColor = true;
            // 
            // adjustbtn
            // 
            adjustbtn.Location = new Point(630, 420);
            adjustbtn.Name = "adjustbtn";
            adjustbtn.Size = new Size(100, 23);
            adjustbtn.TabIndex = 23;
            adjustbtn.Text = "Adjust Record";
            adjustbtn.UseVisualStyleBackColor = true;
            // 
            // searchbtn
            // 
            searchbtn.Location = new Point(630, 449);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(100, 23);
            searchbtn.TabIndex = 24;
            searchbtn.Text = "Search Records";
            searchbtn.UseVisualStyleBackColor = true;
            // 
            // listbtn
            // 
            listbtn.Location = new Point(630, 478);
            listbtn.Name = "listbtn";
            listbtn.Size = new Size(100, 23);
            listbtn.TabIndex = 25;
            listbtn.Text = "List Records";
            listbtn.UseVisualStyleBackColor = true;
            // 
            // quitbtn
            // 
            quitbtn.Location = new Point(955, 490);
            quitbtn.Name = "quitbtn";
            quitbtn.Size = new Size(75, 23);
            quitbtn.TabIndex = 27;
            quitbtn.Text = "Quit";
            quitbtn.UseVisualStyleBackColor = true;
            // 
            // currRecTypeLbl
            // 
            currRecTypeLbl.AutoSize = true;
            currRecTypeLbl.Location = new Point(219, 306);
            currRecTypeLbl.Name = "currRecTypeLbl";
            currRecTypeLbl.Size = new Size(117, 15);
            currRecTypeLbl.TabIndex = 28;
            currRecTypeLbl.Text = "Current Record Type:";
            // 
            // curRecTypeShow
            // 
            curRecTypeShow.AutoSize = true;
            curRecTypeShow.Location = new Point(342, 306);
            curRecTypeShow.MinimumSize = new Size(100, 0);
            curRecTypeShow.Name = "curRecTypeShow";
            curRecTypeShow.Size = new Size(100, 15);
            curRecTypeShow.TabIndex = 29;
            curRecTypeShow.Text = "Book";
            // 
            // curOpShow
            // 
            curOpShow.AutoSize = true;
            curOpShow.Location = new Point(687, 306);
            curOpShow.MinimumSize = new Size(100, 0);
            curOpShow.Name = "curOpShow";
            curOpShow.Size = new Size(100, 15);
            curOpShow.TabIndex = 31;
            curOpShow.Text = "Add Record";
            // 
            // curOplbl
            // 
            curOplbl.AutoSize = true;
            curOplbl.Location = new Point(575, 306);
            curOplbl.Name = "curOplbl";
            curOplbl.Size = new Size(106, 15);
            curOplbl.TabIndex = 30;
            curOplbl.Text = "Current Operation:";
            // 
            // field8txt
            // 
            field8txt.Location = new Point(698, 205);
            field8txt.MinimumSize = new Size(250, 0);
            field8txt.Name = "field8txt";
            field8txt.Size = new Size(250, 23);
            field8txt.TabIndex = 35;
            // 
            // field8lbl
            // 
            field8lbl.AutoSize = true;
            field8lbl.Location = new Point(492, 208);
            field8lbl.MinimumSize = new Size(200, 0);
            field8lbl.Name = "field8lbl";
            field8lbl.Size = new Size(200, 15);
            field8lbl.TabIndex = 34;
            field8lbl.Text = "Store Price";
            field8lbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // field7txt
            // 
            field7txt.Location = new Point(236, 205);
            field7txt.MinimumSize = new Size(250, 0);
            field7txt.Name = "field7txt";
            field7txt.Size = new Size(250, 23);
            field7txt.TabIndex = 33;
            // 
            // field7lbl
            // 
            field7lbl.AutoSize = true;
            field7lbl.Location = new Point(30, 208);
            field7lbl.MinimumSize = new Size(200, 0);
            field7lbl.Name = "field7lbl";
            field7lbl.Size = new Size(200, 15);
            field7lbl.TabIndex = 32;
            field7lbl.Text = "Cover Price";
            field7lbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 525);
            Controls.Add(field8txt);
            Controls.Add(field8lbl);
            Controls.Add(field7txt);
            Controls.Add(field7lbl);
            Controls.Add(curOpShow);
            Controls.Add(curOplbl);
            Controls.Add(curRecTypeShow);
            Controls.Add(currRecTypeLbl);
            Controls.Add(quitbtn);
            Controls.Add(listbtn);
            Controls.Add(searchbtn);
            Controls.Add(adjustbtn);
            Controls.Add(removebtn);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(addbtn);
            Controls.Add(label6);
            Controls.Add(orderbtn);
            Controls.Add(employeebtn);
            Controls.Add(customerbtn);
            Controls.Add(bookbtn);
            Controls.Add(label5);
            Controls.Add(field6txt);
            Controls.Add(field6lbl);
            Controls.Add(field5txt);
            Controls.Add(field5lbl);
            Controls.Add(field4txt);
            Controls.Add(field4lbl);
            Controls.Add(field3txt);
            Controls.Add(field3lbl);
            Controls.Add(field2txt);
            Controls.Add(field2lbl);
            Controls.Add(field1txt);
            Controls.Add(field1lbl);
            Name = "MainScreen";
            Text = "BookInventorySystem";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label field1lbl;
        private TextBox field1txt;
        private TextBox field2txt;
        private Label field2lbl;
        private TextBox field4txt;
        private Label field4lbl;
        private TextBox field3txt;
        private Label field3lbl;
        private TextBox field6txt;
        private Label field6lbl;
        private TextBox field5txt;
        private Label field5lbl;
        private Label label5;
        private Button bookbtn;
        private Button customerbtn;
        private Button employeebtn;
        private Button orderbtn;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button addbtn;
        private Label label6;
        private Button removebtn;
        private Button adjustbtn;
        private Button searchbtn;
        private Button listbtn;
        private Button quitbtn;
        private Label currRecTypeLbl;
        private Label curRecTypeShow;
        private Label curOpShow;
        private Label curOplbl;
        private TextBox field8txt;
        private Label field8lbl;
        private TextBox field7txt;
        private Label field7lbl;
    }
}