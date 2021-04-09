namespace FinalProject
{
    partial class SimpleCalender
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TheDate = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.MoreDate = new System.Windows.Forms.Button();
            this.AddMoreList = new System.Windows.Forms.Button();
            this.ToDoList = new System.Windows.Forms.Label();
            this.btnfont = new System.Windows.Forms.Button();
            this.btnfontcolor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TheDate
            // 
            this.TheDate.AutoSize = true;
            this.TheDate.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TheDate.Location = new System.Drawing.Point(98, 9);
            this.TheDate.Name = "TheDate";
            this.TheDate.Size = new System.Drawing.Size(197, 40);
            this.TheDate.TabIndex = 0;
            this.TheDate.Text = "2019/12/30";
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.line.Location = new System.Drawing.Point(7, 49);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(471, 19);
            this.line.TabIndex = 1;
            this.line.Text = "-----------------------------------------------------------------------------";
            // 
            // MoreDate
            // 
            this.MoreDate.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.MoreDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MoreDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoreDate.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MoreDate.Location = new System.Drawing.Point(380, 12);
            this.MoreDate.Name = "MoreDate";
            this.MoreDate.Size = new System.Drawing.Size(88, 33);
            this.MoreDate.TabIndex = 2;
            this.MoreDate.Text = "其他日期";
            this.MoreDate.UseVisualStyleBackColor = true;
            this.MoreDate.Click += new System.EventHandler(this.MoreDate_Click);
            // 
            // AddMoreList
            // 
            this.AddMoreList.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.AddMoreList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddMoreList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMoreList.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AddMoreList.Location = new System.Drawing.Point(380, 337);
            this.AddMoreList.Name = "AddMoreList";
            this.AddMoreList.Size = new System.Drawing.Size(88, 33);
            this.AddMoreList.TabIndex = 3;
            this.AddMoreList.Text = "新增記事";
            this.AddMoreList.UseVisualStyleBackColor = true;
            this.AddMoreList.Click += new System.EventHandler(this.AddMoreList_Click);
            // 
            // ToDoList
            // 
            this.ToDoList.AutoSize = true;
            this.ToDoList.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ToDoList.Location = new System.Drawing.Point(7, 73);
            this.ToDoList.MaximumSize = new System.Drawing.Size(485, 257);
            this.ToDoList.Name = "ToDoList";
            this.ToDoList.Size = new System.Drawing.Size(0, 16);
            this.ToDoList.TabIndex = 4;
            // 
            // btnfont
            // 
            this.btnfont.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnfont.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnfont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfont.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnfont.Location = new System.Drawing.Point(11, 337);
            this.btnfont.Name = "btnfont";
            this.btnfont.Size = new System.Drawing.Size(88, 33);
            this.btnfont.TabIndex = 5;
            this.btnfont.Text = "字體樣式";
            this.btnfont.UseVisualStyleBackColor = true;
            this.btnfont.Click += new System.EventHandler(this.btnfont_Click);
            // 
            // btnfontcolor
            // 
            this.btnfontcolor.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnfontcolor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnfontcolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfontcolor.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnfontcolor.Location = new System.Drawing.Point(105, 337);
            this.btnfontcolor.Name = "btnfontcolor";
            this.btnfontcolor.Size = new System.Drawing.Size(88, 33);
            this.btnfontcolor.TabIndex = 6;
            this.btnfontcolor.Text = "字體顏色";
            this.btnfontcolor.UseVisualStyleBackColor = true;
            this.btnfontcolor.Click += new System.EventHandler(this.btnfontcolor_Click);
            // 
            // SimpleCalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(483, 382);
            this.Controls.Add(this.btnfontcolor);
            this.Controls.Add(this.btnfont);
            this.Controls.Add(this.ToDoList);
            this.Controls.Add(this.AddMoreList);
            this.Controls.Add(this.MoreDate);
            this.Controls.Add(this.line);
            this.Controls.Add(this.TheDate);
            this.MinimizeBox = false;
            this.Name = "SimpleCalender";
            this.Text = "簡易行事曆";
            this.Load += new System.EventHandler(this.SimpleCalender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TheDate;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Button MoreDate;
        private System.Windows.Forms.Button AddMoreList;
        private System.Windows.Forms.Label ToDoList;
        private System.Windows.Forms.Button btnfont;
        private System.Windows.Forms.Button btnfontcolor;
    }
}

