namespace to_do_list
{
    partial class TaskEntryFrame
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
            this.Create = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelInput = new System.Windows.Forms.TextBox();
            this.CommentInput = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.Create.SuspendLayout();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Controls.Add(this.CreateButton);
            this.Create.Controls.Add(this.CommentInput);
            this.Create.Controls.Add(this.LabelInput);
            this.Create.Controls.Add(this.label2);
            this.Create.Controls.Add(this.label1);
            this.Create.Location = new System.Drawing.Point(12, 12);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(1088, 559);
            this.Create.TabIndex = 1;
            this.Create.TabStop = false;
            this.Create.Text = "Créer une tâche";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(361, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(361, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // LabelInput
            // 
            this.LabelInput.Location = new System.Drawing.Point(516, 108);
            this.LabelInput.Name = "LabelInput";
            this.LabelInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelInput.Size = new System.Drawing.Size(232, 27);
            this.LabelInput.TabIndex = 2;
            this.LabelInput.TextChanged += new System.EventHandler(this.LabelInput_TextChanged);
            // 
            // CommentInput
            // 
            this.CommentInput.Location = new System.Drawing.Point(516, 162);
            this.CommentInput.Name = "CommentInput";
            this.CommentInput.Size = new System.Drawing.Size(232, 27);
            this.CommentInput.TabIndex = 3;
            this.CommentInput.TextChanged += new System.EventHandler(this.CommentInput_TextChanged);
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateButton.Location = new System.Drawing.Point(582, 231);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(145, 41);
            this.CreateButton.TabIndex = 4;
            this.CreateButton.Text = "Créer";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TaskEntryFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 583);
            this.Controls.Add(this.Create);
            this.Name = "TaskEntryFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskManager";
            this.Create.ResumeLayout(false);
            this.Create.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public GroupBox Create;
        public Label label1;
        public Button CreateButton;
        public TextBox CommentInput;
        public TextBox LabelInput;
        public Label label2;
    }
}