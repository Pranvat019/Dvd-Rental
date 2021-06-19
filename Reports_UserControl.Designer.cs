
namespace DVD_Rental_Store_Management_System
{
    partial class Reports_UserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchCustomerTextbox = new System.Windows.Forms.TextBox();
            this.SearchMovieTextbox = new System.Windows.Forms.TextBox();
            this.SearchCustomerButton = new System.Windows.Forms.Button();
            this.SearchMovieButton = new System.Windows.Forms.Button();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.RentMovieButton = new System.Windows.Forms.Button();
            this.ReturnMovieButton = new System.Windows.Forms.Button();
            this.Movie_label = new System.Windows.Forms.Label();
            this.MoviePurchased_Label = new System.Windows.Forms.Label();
            this.PurchasedByCustomer_Label = new System.Windows.Forms.Label();
            this.CustomerPurchased_Label = new System.Windows.Forms.Label();
            this.CustomerPurchasedID_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer\'s ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Movie Name";
            // 
            // SearchCustomerTextbox
            // 
            this.SearchCustomerTextbox.Location = new System.Drawing.Point(172, 127);
            this.SearchCustomerTextbox.Name = "SearchCustomerTextbox";
            this.SearchCustomerTextbox.Size = new System.Drawing.Size(368, 22);
            this.SearchCustomerTextbox.TabIndex = 2;
            // 
            // SearchMovieTextbox
            // 
            this.SearchMovieTextbox.Location = new System.Drawing.Point(172, 319);
            this.SearchMovieTextbox.Name = "SearchMovieTextbox";
            this.SearchMovieTextbox.Size = new System.Drawing.Size(368, 22);
            this.SearchMovieTextbox.TabIndex = 3;
            // 
            // SearchCustomerButton
            // 
            this.SearchCustomerButton.Location = new System.Drawing.Point(583, 130);
            this.SearchCustomerButton.Name = "SearchCustomerButton";
            this.SearchCustomerButton.Size = new System.Drawing.Size(174, 23);
            this.SearchCustomerButton.TabIndex = 4;
            this.SearchCustomerButton.Text = "SEARCH CUSTOMER";
            this.SearchCustomerButton.UseVisualStyleBackColor = true;
            this.SearchCustomerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchMovieButton
            // 
            this.SearchMovieButton.Location = new System.Drawing.Point(583, 319);
            this.SearchMovieButton.Name = "SearchMovieButton";
            this.SearchMovieButton.Size = new System.Drawing.Size(120, 23);
            this.SearchMovieButton.TabIndex = 5;
            this.SearchMovieButton.Text = "SEARCH MOVIE";
            this.SearchMovieButton.UseVisualStyleBackColor = true;
            this.SearchMovieButton.Click += new System.EventHandler(this.SearchMovieButton_Click);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Location = new System.Drawing.Point(289, 497);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(120, 23);
            this.ClearAllButton.TabIndex = 6;
            this.ClearAllButton.Text = "CLEAR ALL";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // RentMovieButton
            // 
            this.RentMovieButton.Location = new System.Drawing.Point(88, 604);
            this.RentMovieButton.Name = "RentMovieButton";
            this.RentMovieButton.Size = new System.Drawing.Size(109, 23);
            this.RentMovieButton.TabIndex = 7;
            this.RentMovieButton.Text = "RENT MOVIE";
            this.RentMovieButton.UseVisualStyleBackColor = true;
            this.RentMovieButton.Click += new System.EventHandler(this.RentMovieButton_Click);
            // 
            // ReturnMovieButton
            // 
            this.ReturnMovieButton.Location = new System.Drawing.Point(491, 604);
            this.ReturnMovieButton.Name = "ReturnMovieButton";
            this.ReturnMovieButton.Size = new System.Drawing.Size(131, 23);
            this.ReturnMovieButton.TabIndex = 8;
            this.ReturnMovieButton.Text = "RETURN MOVIE";
            this.ReturnMovieButton.UseVisualStyleBackColor = true;
            // 
            // Movie_label
            // 
            this.Movie_label.AutoSize = true;
            this.Movie_label.Location = new System.Drawing.Point(364, 190);
            this.Movie_label.Name = "Movie_label";
            this.Movie_label.Size = new System.Drawing.Size(45, 17);
            this.Movie_label.TabIndex = 9;
            this.Movie_label.Text = "Movie";
            this.Movie_label.Click += new System.EventHandler(this.Movie_label_Click);
            // 
            // MoviePurchased_Label
            // 
            this.MoviePurchased_Label.AutoSize = true;
            this.MoviePurchased_Label.Location = new System.Drawing.Point(232, 190);
            this.MoviePurchased_Label.Name = "MoviePurchased_Label";
            this.MoviePurchased_Label.Size = new System.Drawing.Size(125, 17);
            this.MoviePurchased_Label.TabIndex = 10;
            this.MoviePurchased_Label.Text = "Movie Purchased :";
            this.MoviePurchased_Label.Click += new System.EventHandler(this.MoviePurchased_Label_Click);
            // 
            // PurchasedByCustomer_Label
            // 
            this.PurchasedByCustomer_Label.AutoSize = true;
            this.PurchasedByCustomer_Label.Location = new System.Drawing.Point(232, 411);
            this.PurchasedByCustomer_Label.Name = "PurchasedByCustomer_Label";
            this.PurchasedByCustomer_Label.Size = new System.Drawing.Size(100, 17);
            this.PurchasedByCustomer_Label.TabIndex = 11;
            this.PurchasedByCustomer_Label.Text = "Prchased By : ";
            // 
            // CustomerPurchased_Label
            // 
            this.CustomerPurchased_Label.AutoSize = true;
            this.CustomerPurchased_Label.Location = new System.Drawing.Point(364, 411);
            this.CustomerPurchased_Label.Name = "CustomerPurchased_Label";
            this.CustomerPurchased_Label.Size = new System.Drawing.Size(0, 17);
            this.CustomerPurchased_Label.TabIndex = 12;
            // 
            // CustomerPurchasedID_label
            // 
            this.CustomerPurchasedID_label.AutoSize = true;
            this.CustomerPurchasedID_label.Location = new System.Drawing.Point(348, 411);
            this.CustomerPurchasedID_label.Name = "CustomerPurchasedID_label";
            this.CustomerPurchasedID_label.Size = new System.Drawing.Size(136, 17);
            this.CustomerPurchasedID_label.TabIndex = 13;
            this.CustomerPurchasedID_label.Text = "CustomerPurchased";
            // 
            // Reports_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CustomerPurchasedID_label);
            this.Controls.Add(this.CustomerPurchased_Label);
            this.Controls.Add(this.PurchasedByCustomer_Label);
            this.Controls.Add(this.MoviePurchased_Label);
            this.Controls.Add(this.Movie_label);
            this.Controls.Add(this.ReturnMovieButton);
            this.Controls.Add(this.RentMovieButton);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.SearchMovieButton);
            this.Controls.Add(this.SearchCustomerButton);
            this.Controls.Add(this.SearchMovieTextbox);
            this.Controls.Add(this.SearchCustomerTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Reports_UserControl";
            this.Size = new System.Drawing.Size(853, 856);
            this.Load += new System.EventHandler(this.Reports_UserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchCustomerTextbox;
        private System.Windows.Forms.TextBox SearchMovieTextbox;
        private System.Windows.Forms.Button SearchCustomerButton;
        private System.Windows.Forms.Button SearchMovieButton;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.Button RentMovieButton;
        private System.Windows.Forms.Button ReturnMovieButton;
        private System.Windows.Forms.Label Movie_label;
        private System.Windows.Forms.Label MoviePurchased_Label;
        private System.Windows.Forms.Label PurchasedByCustomer_Label;
        private System.Windows.Forms.Label CustomerPurchased_Label;
        private System.Windows.Forms.Label CustomerPurchasedID_label;
    }
}
