
namespace DVD_Rental_Store_Management_System
{
    partial class Movies_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MovieSearchTextbox = new System.Windows.Forms.TextBox();
            this.SearchMoviesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.Label();
            this.Moviename_Textbox = new System.Windows.Forms.TextBox();
            this.MovieRelease_Textbox = new System.Windows.Forms.TextBox();
            this.MovieGenre_Textbox = new System.Windows.Forms.TextBox();
            this.MovieLanguage_Textbox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.AddNewTuple_Button = new System.Windows.Forms.Button();
            this.DeleteTuple_Button = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MovieIdTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomerId_Textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieSearchTextbox
            // 
            this.MovieSearchTextbox.Location = new System.Drawing.Point(196, 118);
            this.MovieSearchTextbox.Name = "MovieSearchTextbox";
            this.MovieSearchTextbox.Size = new System.Drawing.Size(357, 22);
            this.MovieSearchTextbox.TabIndex = 1;
            // 
            // SearchMoviesButton
            // 
            this.SearchMoviesButton.Location = new System.Drawing.Point(263, 178);
            this.SearchMoviesButton.Name = "SearchMoviesButton";
            this.SearchMoviesButton.Size = new System.Drawing.Size(222, 23);
            this.SearchMoviesButton.TabIndex = 2;
            this.SearchMoviesButton.Text = "Search Movie";
            this.SearchMoviesButton.UseVisualStyleBackColor = true;
            this.SearchMoviesButton.Click += new System.EventHandler(this.SearchMoviesButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 627);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "RELEASE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 696);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "LANG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 570);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Movie ID";
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.Location = new System.Drawing.Point(56, 630);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(57, 17);
            this.NAME.TabIndex = 6;
            this.NAME.Text = "GENRE";
            // 
            // Moviename_Textbox
            // 
            this.Moviename_Textbox.Location = new System.Drawing.Point(59, 590);
            this.Moviename_Textbox.Name = "Moviename_Textbox";
            this.Moviename_Textbox.Size = new System.Drawing.Size(199, 22);
            this.Moviename_Textbox.TabIndex = 7;
            // 
            // MovieRelease_Textbox
            // 
            this.MovieRelease_Textbox.Location = new System.Drawing.Point(521, 651);
            this.MovieRelease_Textbox.Name = "MovieRelease_Textbox";
            this.MovieRelease_Textbox.Size = new System.Drawing.Size(199, 22);
            this.MovieRelease_Textbox.TabIndex = 8;
            // 
            // MovieGenre_Textbox
            // 
            this.MovieGenre_Textbox.Location = new System.Drawing.Point(59, 651);
            this.MovieGenre_Textbox.Name = "MovieGenre_Textbox";
            this.MovieGenre_Textbox.Size = new System.Drawing.Size(199, 22);
            this.MovieGenre_Textbox.TabIndex = 9;
            // 
            // MovieLanguage_Textbox
            // 
            this.MovieLanguage_Textbox.Location = new System.Drawing.Point(59, 716);
            this.MovieLanguage_Textbox.Name = "MovieLanguage_Textbox";
            this.MovieLanguage_Textbox.Size = new System.Drawing.Size(199, 22);
            this.MovieLanguage_Textbox.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddNewTuple_Button
            // 
            this.AddNewTuple_Button.Location = new System.Drawing.Point(59, 492);
            this.AddNewTuple_Button.Name = "AddNewTuple_Button";
            this.AddNewTuple_Button.Size = new System.Drawing.Size(149, 23);
            this.AddNewTuple_Button.TabIndex = 12;
            this.AddNewTuple_Button.Text = "ADD NEW";
            this.AddNewTuple_Button.UseVisualStyleBackColor = true;
            this.AddNewTuple_Button.Click += new System.EventHandler(this.AddNewTuple_Button_Click);
            // 
            // DeleteTuple_Button
            // 
            this.DeleteTuple_Button.Location = new System.Drawing.Point(495, 492);
            this.DeleteTuple_Button.Name = "DeleteTuple_Button";
            this.DeleteTuple_Button.Size = new System.Drawing.Size(118, 23);
            this.DeleteTuple_Button.TabIndex = 13;
            this.DeleteTuple_Button.Text = "DELETE";
            this.DeleteTuple_Button.UseVisualStyleBackColor = true;
            this.DeleteTuple_Button.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(656, 492);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "CLEAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(797, 242);
            this.dataGridView1.TabIndex = 15;
            // 
            // MovieIdTextbox
            // 
            this.MovieIdTextbox.Location = new System.Drawing.Point(521, 590);
            this.MovieIdTextbox.Name = "MovieIdTextbox";
            this.MovieIdTextbox.Size = new System.Drawing.Size(204, 22);
            this.MovieIdTextbox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Movie ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 570);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Movie Name";
            // 
            // CustomerId_Textbox
            // 
            this.CustomerId_Textbox.Location = new System.Drawing.Point(521, 716);
            this.CustomerId_Textbox.Name = "CustomerId_Textbox";
            this.CustomerId_Textbox.Size = new System.Drawing.Size(204, 22);
            this.CustomerId_Textbox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 696);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "CUSTOMER ID";
            // 
            // Movies_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CustomerId_Textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MovieIdTextbox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.DeleteTuple_Button);
            this.Controls.Add(this.AddNewTuple_Button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MovieLanguage_Textbox);
            this.Controls.Add(this.MovieGenre_Textbox);
            this.Controls.Add(this.MovieRelease_Textbox);
            this.Controls.Add(this.Moviename_Textbox);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchMoviesButton);
            this.Controls.Add(this.MovieSearchTextbox);
            this.Name = "Movies_UserControl";
            this.Size = new System.Drawing.Size(908, 856);
            this.Load += new System.EventHandler(this.Movies_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox MovieSearchTextbox;
        private System.Windows.Forms.Button SearchMoviesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.TextBox Moviename_Textbox;
        private System.Windows.Forms.TextBox MovieRelease_Textbox;
        private System.Windows.Forms.TextBox MovieGenre_Textbox;
        private System.Windows.Forms.TextBox MovieLanguage_Textbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddNewTuple_Button;
        private System.Windows.Forms.Button DeleteTuple_Button;
        private System.Windows.Forms.Button button5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox MovieIdTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CustomerId_Textbox;
        private System.Windows.Forms.Label label6;
    }
}
