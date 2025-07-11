using WDBXEditor.Common;

namespace WDBXEditor
{
    partial class LoadDefinition
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
            components = new System.ComponentModel.Container();
            btnClose = new System.Windows.Forms.Button();
            btnLoad = new System.Windows.Forms.Button();
            openFileDialog = new System.Windows.Forms.OpenFileDialog();
            label3 = new System.Windows.Forms.Label();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            lblFiles = new System.Windows.Forms.Label();
            chkBuildFilter = new System.Windows.Forms.CheckBox();
            lbDefinitions = new BufferedListBox();
            SuspendLayout();
            //
            // btnClose
            //
            btnClose.Location = new System.Drawing.Point(269, 358);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(100, 35);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            //
            // btnLoad
            //
            btnLoad.Location = new System.Drawing.Point(161, 358);
            btnLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(100, 35);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            //
            // openFileDialog
            //
            openFileDialog.Filter = "XML Files|*.xml";
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 14);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(284, 20);
            label3.TabIndex = 11;
            label3.Text = "Builds will be limited to available options";
            //
            // lblFiles
            //
            lblFiles.Location = new System.Drawing.Point(283, 14);
            lblFiles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFiles.Name = "lblFiles";
            lblFiles.Size = new System.Drawing.Size(85, 20);
            lblFiles.TabIndex = 13;
            lblFiles.Text = "0 Files";
            lblFiles.TextAlign = System.Drawing.ContentAlignment.TopRight;
            //
            // chkBuildFilter
            //
            chkBuildFilter.AutoSize = true;
            chkBuildFilter.Location = new System.Drawing.Point(63, 365);
            chkBuildFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            chkBuildFilter.Name = "chkBuildFilter";
            chkBuildFilter.Size = new System.Drawing.Size(93, 24);
            chkBuildFilter.TabIndex = 14;
            chkBuildFilter.Text = "All Builds";
            chkBuildFilter.UseVisualStyleBackColor = true;
            chkBuildFilter.CheckedChanged += chkBuildFilter_CheckedChanged;
            //
            // lbDefinitions
            //
            lbDefinitions.FormattingEnabled = true;
            lbDefinitions.Location = new System.Drawing.Point(16, 43);
            lbDefinitions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            lbDefinitions.Name = "lbDefinitions";
            lbDefinitions.Size = new System.Drawing.Size(352, 304);
            lbDefinitions.TabIndex = 0;
            lbDefinitions.SelectedValueChanged += lbDefinitions_SelectedValueChanged;
            lbDefinitions.MouseDoubleClick += lbDefinitions_MouseDoubleClick;
            //
            // LoadDefinition
            //
            AcceptButton = btnLoad;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(384, 389);
            Controls.Add(chkBuildFilter);
            Controls.Add(lblFiles);
            Controls.Add(label3);
            Controls.Add(btnLoad);
            Controls.Add(btnClose);
            Controls.Add(lbDefinitions);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(402, 436);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(402, 436);
            Name = "LoadDefinition";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Load Definition";
            Load += LoadDefinition_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private BufferedListBox lbDefinitions;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblFiles;
		private System.Windows.Forms.CheckBox chkBuildFilter;
	}
}
