namespace runtimeClass
{
    partial class Form1
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
            this.allProps = new System.Windows.Forms.CheckedListBox();
            this.pushPropButton = new System.Windows.Forms.Button();
            this.createClass = new System.Windows.Forms.Button();
            this.getInstance = new System.Windows.Forms.Button();
            this.customClassProps = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // allProps
            // 
            this.allProps.FormattingEnabled = true;
            this.allProps.Location = new System.Drawing.Point(22, 12);
            this.allProps.Name = "allProps";
            this.allProps.Size = new System.Drawing.Size(194, 242);
            this.allProps.TabIndex = 0;
            // 
            // pushPropButton
            // 
            this.pushPropButton.Location = new System.Drawing.Point(22, 260);
            this.pushPropButton.Name = "pushPropButton";
            this.pushPropButton.Size = new System.Drawing.Size(194, 37);
            this.pushPropButton.TabIndex = 1;
            this.pushPropButton.Text = ">";
            this.pushPropButton.UseVisualStyleBackColor = true;
            this.pushPropButton.Click += new System.EventHandler(this.pushPropButton_Click);
            // 
            // createClass
            // 
            this.createClass.Location = new System.Drawing.Point(231, 260);
            this.createClass.Name = "createClass";
            this.createClass.Size = new System.Drawing.Size(213, 37);
            this.createClass.TabIndex = 3;
            this.createClass.Text = "Create Class";
            this.createClass.UseVisualStyleBackColor = true;
            this.createClass.Click += new System.EventHandler(this.createClass_Click);
            // 
            // getInstance
            // 
            this.getInstance.Location = new System.Drawing.Point(130, 303);
            this.getInstance.Name = "getInstance";
            this.getInstance.Size = new System.Drawing.Size(174, 38);
            this.getInstance.TabIndex = 4;
            this.getInstance.Text = "Get Instance";
            this.getInstance.UseVisualStyleBackColor = true;
            this.getInstance.Click += new System.EventHandler(this.getInstance_Click);
            // 
            // customClassProps
            // 
            this.customClassProps.FormattingEnabled = true;
            this.customClassProps.ItemHeight = 16;
            this.customClassProps.Location = new System.Drawing.Point(231, 10);
            this.customClassProps.Name = "customClassProps";
            this.customClassProps.Size = new System.Drawing.Size(213, 244);
            this.customClassProps.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 395);
            this.Controls.Add(this.getInstance);
            this.Controls.Add(this.createClass);
            this.Controls.Add(this.customClassProps);
            this.Controls.Add(this.pushPropButton);
            this.Controls.Add(this.allProps);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox allProps;
        private System.Windows.Forms.Button pushPropButton;
        private System.Windows.Forms.Button createClass;
        private System.Windows.Forms.Button getInstance;
        private System.Windows.Forms.ListBox customClassProps;
    }
}

