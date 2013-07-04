namespace AndroidClient
{
    partial class formSettings
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbOrganization = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbExportTemplate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbExportTargetfile = new System.Windows.Forms.TextBox();
            this.tbAPIKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dlgChangeTargetfile = new System.Windows.Forms.SaveFileDialog();
            this.btnChangeTargetFile = new System.Windows.Forms.Button();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbImportFile = new System.Windows.Forms.TextBox();
            this.btnChangeImportFile = new System.Windows.Forms.Button();
            this.tbExportTargetlanguage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(179, 258);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(260, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbOrganization
            // 
            this.tbOrganization.Location = new System.Drawing.Point(108, 22);
            this.tbOrganization.Name = "tbOrganization";
            this.tbOrganization.Size = new System.Drawing.Size(245, 20);
            this.tbOrganization.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Organization";
            // 
            // tbProject
            // 
            this.tbProject.Location = new System.Drawing.Point(108, 48);
            this.tbProject.Name = "tbProject";
            this.tbProject.Size = new System.Drawing.Size(245, 20);
            this.tbProject.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Project";
            // 
            // tbExportTemplate
            // 
            this.tbExportTemplate.Location = new System.Drawing.Point(108, 100);
            this.tbExportTemplate.Name = "tbExportTemplate";
            this.tbExportTemplate.Size = new System.Drawing.Size(245, 20);
            this.tbExportTemplate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "API-Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Target-File";
            // 
            // tbExportTargetfile
            // 
            this.tbExportTargetfile.Location = new System.Drawing.Point(108, 126);
            this.tbExportTargetfile.Name = "tbExportTargetfile";
            this.tbExportTargetfile.Size = new System.Drawing.Size(186, 20);
            this.tbExportTargetfile.TabIndex = 9;
            // 
            // tbAPIKey
            // 
            this.tbAPIKey.Location = new System.Drawing.Point(108, 74);
            this.tbAPIKey.Name = "tbAPIKey";
            this.tbAPIKey.Size = new System.Drawing.Size(245, 20);
            this.tbAPIKey.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Export-Template";
            // 
            // dlgChangeTargetfile
            // 
            this.dlgChangeTargetfile.Filter = "All files (*.*)|*.*";
            // 
            // btnChangeTargetFile
            // 
            this.btnChangeTargetFile.Location = new System.Drawing.Point(300, 126);
            this.btnChangeTargetFile.Name = "btnChangeTargetFile";
            this.btnChangeTargetFile.Size = new System.Drawing.Size(53, 23);
            this.btnChangeTargetFile.TabIndex = 12;
            this.btnChangeTargetFile.Text = "Change";
            this.btnChangeTargetFile.UseVisualStyleBackColor = true;
            this.btnChangeTargetFile.Click += new System.EventHandler(this.btnChangeTargetFile_Click);
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(24, 258);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(94, 23);
            this.btnTestConnection.TabIndex = 13;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Import-File";
            // 
            // tbImportFile
            // 
            this.tbImportFile.Location = new System.Drawing.Point(108, 178);
            this.tbImportFile.Name = "tbImportFile";
            this.tbImportFile.Size = new System.Drawing.Size(186, 20);
            this.tbImportFile.TabIndex = 15;
            // 
            // btnChangeImportFile
            // 
            this.btnChangeImportFile.Location = new System.Drawing.Point(300, 174);
            this.btnChangeImportFile.Name = "btnChangeImportFile";
            this.btnChangeImportFile.Size = new System.Drawing.Size(53, 23);
            this.btnChangeImportFile.TabIndex = 16;
            this.btnChangeImportFile.Text = "Change";
            this.btnChangeImportFile.UseVisualStyleBackColor = true;
            this.btnChangeImportFile.Click += new System.EventHandler(this.btnChangeImportFile_Click);
            // 
            // tbExportTargetlanguage
            // 
            this.tbExportTargetlanguage.Location = new System.Drawing.Point(108, 152);
            this.tbExportTargetlanguage.Name = "tbExportTargetlanguage";
            this.tbExportTargetlanguage.Size = new System.Drawing.Size(49, 20);
            this.tbExportTargetlanguage.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Target-Language";
            // 
            // formSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 293);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbExportTargetlanguage);
            this.Controls.Add(this.btnChangeImportFile);
            this.Controls.Add(this.tbImportFile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.btnChangeTargetFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAPIKey);
            this.Controls.Add(this.tbExportTargetfile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbExportTemplate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOrganization);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "formSettings";
            this.Text = "Settings";
            this.Shown += new System.EventHandler(this.formSettings_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbOrganization;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbExportTemplate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbExportTargetfile;
        private System.Windows.Forms.TextBox tbAPIKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog dlgChangeTargetfile;
        private System.Windows.Forms.Button btnChangeTargetFile;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbImportFile;
        private System.Windows.Forms.Button btnChangeImportFile;
        private System.Windows.Forms.TextBox tbExportTargetlanguage;
        private System.Windows.Forms.Label label7;
    }
}