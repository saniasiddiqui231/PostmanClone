namespace PostmanCloneUI
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
            buttonLabel = new Button();
            HeaderLabel = new Label();
            apiLabel = new Label();
            apiText = new TextBox();
            statusStrip = new StatusStrip();
            httpVerbSelection = new ComboBox();
            callData = new TabControl();
            resultTextLabel = new TextBox();
            outputTab = new TabPage();
            callData.SuspendLayout();
            outputTab.SuspendLayout();
            SuspendLayout();
            // 
            // buttonLabel
            // 
            buttonLabel.Font = new Font("Segoe UI", 12F);
            buttonLabel.Location = new Point(1090, 180);
            buttonLabel.Margin = new Padding(1);
            buttonLabel.Name = "buttonLabel";
            buttonLabel.Size = new Size(145, 49);
            buttonLabel.TabIndex = 0;
            buttonLabel.Text = "Search";
            buttonLabel.UseVisualStyleBackColor = true;
            buttonLabel.Click += buttonLabel_Click;
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 22F);
            HeaderLabel.Location = new Point(724, 36);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(269, 50);
            HeaderLabel.TabIndex = 1;
            HeaderLabel.Text = "Postman Clone";
            HeaderLabel.Click += HeaderLabel_Click;
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Font = new Font("Segoe UI", 19F);
            apiLabel.Location = new Point(290, 184);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(112, 45);
            apiLabel.TabIndex = 2;
            apiLabel.Text = "API ->";
            apiLabel.Click += apiLabel_Click;
            // 
            // apiText
            // 
            apiText.BackColor = SystemColors.InactiveCaption;
            apiText.Location = new Point(416, 184);
            apiText.Name = "apiText";
            apiText.Size = new Size(509, 47);
            apiText.TabIndex = 3;
            apiText.TextChanged += textBox1_TextChanged;
            // 
            // statusStrip
            // 
            statusStrip.AllowDrop = true;
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Location = new Point(0, 900);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1815, 22);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "Ready";
            statusStrip.ItemClicked += statusStrip_ItemClicked;
            // 
            // httpVerbSelection
            // 
            httpVerbSelection.BackColor = SystemColors.InactiveCaption;
            httpVerbSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            httpVerbSelection.FormattingEnabled = true;
            httpVerbSelection.Items.AddRange(new object[] { "GET", "POST", "DELETE", "PUT", "PATCH" });
            httpVerbSelection.Location = new Point(955, 180);
            httpVerbSelection.Name = "httpVerbSelection";
            httpVerbSelection.Size = new Size(113, 49);
            httpVerbSelection.TabIndex = 7;
            // 
            // callData
            // 
            callData.Controls.Add(outputTab);
            callData.Location = new Point(416, 344);
            callData.Name = "callData";
            callData.SelectedIndex = 0;
            callData.Size = new Size(769, 464);
            callData.TabIndex = 8;
            // 
            // resultTextLabel
            // 
            resultTextLabel.BackColor = SystemColors.InactiveCaption;
            resultTextLabel.Dock = DockStyle.Fill;
            resultTextLabel.Location = new Point(3, 3);
            resultTextLabel.Multiline = true;
            resultTextLabel.Name = "resultTextLabel";
            resultTextLabel.ReadOnly = true;
            resultTextLabel.ScrollBars = ScrollBars.Vertical;
            resultTextLabel.Size = new Size(755, 404);
            resultTextLabel.TabIndex = 5;
            // 
            // outputTab
            // 
            outputTab.Controls.Add(resultTextLabel);
            outputTab.Location = new Point(4, 50);
            outputTab.Name = "outputTab";
            outputTab.Padding = new Padding(3);
            outputTab.Size = new Size(761, 410);
            outputTab.TabIndex = 1;
            outputTab.Text = "Result";
            outputTab.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1815, 922);
            Controls.Add(callData);
            Controls.Add(httpVerbSelection);
            Controls.Add(statusStrip);
            Controls.Add(apiText);
            Controls.Add(apiLabel);
            Controls.Add(HeaderLabel);
            Controls.Add(buttonLabel);
            Font = new Font("Segoe UI", 18F);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Postman Clone";
            callData.ResumeLayout(false);
            outputTab.ResumeLayout(false);
            outputTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLabel;
        private Label HeaderLabel;
        private Label apiLabel;
        private TextBox apiText;
        private StatusStrip statusStrip;
        private ComboBox httpVerbSelection;
        private TabControl callData;
        private TabPage outputTab;
        private TextBox resultTextLabel;
    }
}
