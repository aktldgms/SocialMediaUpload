namespace SocialMediaProject
{
    partial class Form1
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
            titleLabel = new Label();
            title = new TextBox();
            description = new TextBox();
            descriptionLabel = new Label();
            tagsLabel = new Label();
            tags = new TextBox();
            category = new ComboBox();
            categoryLabel = new Label();
            privacyLabel = new Label();
            privacy = new ComboBox();
            filePath = new TextBox();
            filePathLabel = new Label();
            thumbnailPath = new TextBox();
            thumbnailPathLabel = new Label();
            submit = new Button();
            csPath = new TextBox();
            csPathLabel = new Label();
            araF = new Button();
            araT = new Button();
            araCS = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(21, 22);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(42, 20);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Title:";
            // 
            // title
            // 
            title.Location = new Point(166, 23);
            title.Name = "title";
            title.Size = new Size(458, 23);
            title.TabIndex = 1;
            // 
            // description
            // 
            description.Location = new Point(166, 64);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(458, 107);
            description.TabIndex = 3;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(21, 63);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(93, 20);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // tagsLabel
            // 
            tagsLabel.AutoSize = true;
            tagsLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tagsLabel.Location = new Point(21, 196);
            tagsLabel.Name = "tagsLabel";
            tagsLabel.Size = new Size(48, 20);
            tagsLabel.TabIndex = 4;
            tagsLabel.Text = "Tags:";
            // 
            // tags
            // 
            tags.Location = new Point(166, 197);
            tags.Name = "tags";
            tags.Size = new Size(458, 23);
            tags.TabIndex = 5;
            // 
            // category
            // 
            category.FormattingEnabled = true;
            category.Location = new Point(166, 245);
            category.Name = "category";
            category.Size = new Size(154, 23);
            category.TabIndex = 6;
            category.SelectedIndexChanged += category_SelectedIndexChanged;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            categoryLabel.Location = new Point(21, 244);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(77, 20);
            categoryLabel.TabIndex = 7;
            categoryLabel.Text = "Category:";
            // 
            // privacyLabel
            // 
            privacyLabel.AutoSize = true;
            privacyLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            privacyLabel.Location = new Point(355, 244);
            privacyLabel.Name = "privacyLabel";
            privacyLabel.Size = new Size(62, 20);
            privacyLabel.TabIndex = 9;
            privacyLabel.Text = "Privacy:";
            // 
            // privacy
            // 
            privacy.FormattingEnabled = true;
            privacy.Items.AddRange(new object[] { "public", "unlisted", "private" });
            privacy.Location = new Point(470, 245);
            privacy.Name = "privacy";
            privacy.Size = new Size(154, 23);
            privacy.TabIndex = 8;
            // 
            // filePath
            // 
            filePath.Location = new Point(166, 299);
            filePath.Name = "filePath";
            filePath.Size = new Size(419, 23);
            filePath.TabIndex = 11;
            // 
            // filePathLabel
            // 
            filePathLabel.AutoSize = true;
            filePathLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            filePathLabel.Location = new Point(21, 298);
            filePathLabel.Name = "filePathLabel";
            filePathLabel.Size = new Size(75, 20);
            filePathLabel.TabIndex = 10;
            filePathLabel.Text = "File Path:";
            // 
            // thumbnailPath
            // 
            thumbnailPath.Location = new Point(166, 344);
            thumbnailPath.Name = "thumbnailPath";
            thumbnailPath.Size = new Size(419, 23);
            thumbnailPath.TabIndex = 13;
            // 
            // thumbnailPathLabel
            // 
            thumbnailPathLabel.AutoSize = true;
            thumbnailPathLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            thumbnailPathLabel.Location = new Point(21, 343);
            thumbnailPathLabel.Name = "thumbnailPathLabel";
            thumbnailPathLabel.Size = new Size(123, 20);
            thumbnailPathLabel.TabIndex = 12;
            thumbnailPathLabel.Text = "Thumbnail Path:";
            // 
            // submit
            // 
            submit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            submit.Location = new Point(166, 435);
            submit.Name = "submit";
            submit.Size = new Size(458, 39);
            submit.TabIndex = 14;
            submit.Text = "Upload";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // csPath
            // 
            csPath.Location = new Point(166, 387);
            csPath.Name = "csPath";
            csPath.Size = new Size(419, 23);
            csPath.TabIndex = 16;
            // 
            // csPathLabel
            // 
            csPathLabel.AutoSize = true;
            csPathLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            csPathLabel.Location = new Point(21, 386);
            csPathLabel.Name = "csPathLabel";
            csPathLabel.Size = new Size(141, 20);
            csPathLabel.TabIndex = 15;
            csPathLabel.Text = "Client Secret Path:";
            // 
            // araF
            // 
            araF.Location = new Point(591, 299);
            araF.Name = "araF";
            araF.Size = new Size(33, 23);
            araF.TabIndex = 17;
            araF.Text = "ara";
            araF.UseVisualStyleBackColor = true;
            araF.Click += araF_Click;
            // 
            // araT
            // 
            araT.Location = new Point(591, 344);
            araT.Name = "araT";
            araT.Size = new Size(33, 23);
            araT.TabIndex = 18;
            araT.Text = "ara";
            araT.UseVisualStyleBackColor = true;
            araT.Click += araT_Click;
            // 
            // araCS
            // 
            araCS.Location = new Point(591, 387);
            araCS.Name = "araCS";
            araCS.Size = new Size(33, 23);
            araCS.TabIndex = 19;
            araCS.Text = "ara";
            araCS.UseVisualStyleBackColor = true;
            araCS.Click += araCS_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 496);
            Controls.Add(araCS);
            Controls.Add(araT);
            Controls.Add(araF);
            Controls.Add(csPath);
            Controls.Add(csPathLabel);
            Controls.Add(submit);
            Controls.Add(thumbnailPath);
            Controls.Add(thumbnailPathLabel);
            Controls.Add(filePath);
            Controls.Add(filePathLabel);
            Controls.Add(privacyLabel);
            Controls.Add(privacy);
            Controls.Add(categoryLabel);
            Controls.Add(category);
            Controls.Add(tags);
            Controls.Add(tagsLabel);
            Controls.Add(description);
            Controls.Add(descriptionLabel);
            Controls.Add(title);
            Controls.Add(titleLabel);
            Name = "Form1";
            Text = "All in One Social Media";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private TextBox title;
        private TextBox description;
        private Label descriptionLabel;
        private Label tagsLabel;
        private TextBox tags;
        private ComboBox category;
        private Label categoryLabel;
        private Label privacyLabel;
        private ComboBox privacy;
        private TextBox filePath;
        private Label filePathLabel;
        private TextBox thumbnailPath;
        private Label thumbnailPathLabel;
        private Button submit;
        private TextBox csPath;
        private Label csPathLabel;
        private Button araF;
        private Button araT;
        private Button araCS;
    }
}