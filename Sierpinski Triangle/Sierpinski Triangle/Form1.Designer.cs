namespace Sierpinski_Triangle
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
            this.displaySierpinskiFractalButton = new System.Windows.Forms.Button();
            this.pointAXCoordTextBox = new System.Windows.Forms.TextBox();
            this.pointALabel = new System.Windows.Forms.Label();
            this.pointBLabel = new System.Windows.Forms.Label();
            this.VerticesOfTriangleGroupBox = new System.Windows.Forms.GroupBox();
            this.pointCYCoordTextBox = new System.Windows.Forms.TextBox();
            this.pointBYCoordTextBox = new System.Windows.Forms.TextBox();
            this.pointCXCoordTextBox = new System.Windows.Forms.TextBox();
            this.pointBXCoordTextBox = new System.Windows.Forms.TextBox();
            this.pointAYCoordTextBox = new System.Windows.Forms.TextBox();
            this.pointCLabel = new System.Windows.Forms.Label();
            this.depthOfRecursionTextBox = new System.Windows.Forms.TextBox();
            this.depthOfRecursionLabel = new System.Windows.Forms.Label();
            this.sierpinskiTrianglePictureBox = new System.Windows.Forms.PictureBox();
            this.mouseCoordinatesLabel = new System.Windows.Forms.Label();
            this.mouseCoordinateInfoLabel = new System.Windows.Forms.Label();
            this.colourSelector = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VerticesOfTriangleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sierpinskiTrianglePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // displaySierpinskiFractalButton
            // 
            this.displaySierpinskiFractalButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.displaySierpinskiFractalButton.Location = new System.Drawing.Point(307, 84);
            this.displaySierpinskiFractalButton.Name = "displaySierpinskiFractalButton";
            this.displaySierpinskiFractalButton.Size = new System.Drawing.Size(196, 78);
            this.displaySierpinskiFractalButton.TabIndex = 0;
            this.displaySierpinskiFractalButton.Text = "Display Sierpinski Fractal";
            this.displaySierpinskiFractalButton.UseVisualStyleBackColor = false;
            this.displaySierpinskiFractalButton.Click += new System.EventHandler(this.displaySierpinskiFractalButton_Click);
            // 
            // pointAXCoordTextBox
            // 
            this.pointAXCoordTextBox.Location = new System.Drawing.Point(82, 40);
            this.pointAXCoordTextBox.Name = "pointAXCoordTextBox";
            this.pointAXCoordTextBox.Size = new System.Drawing.Size(47, 22);
            this.pointAXCoordTextBox.TabIndex = 1;
            this.pointAXCoordTextBox.Text = "248";
            // 
            // pointALabel
            // 
            this.pointALabel.AutoSize = true;
            this.pointALabel.Location = new System.Drawing.Point(7, 40);
            this.pointALabel.Name = "pointALabel";
            this.pointALabel.Size = new System.Drawing.Size(53, 17);
            this.pointALabel.TabIndex = 2;
            this.pointALabel.Text = "Point A";
            // 
            // pointBLabel
            // 
            this.pointBLabel.AutoSize = true;
            this.pointBLabel.Location = new System.Drawing.Point(7, 75);
            this.pointBLabel.Name = "pointBLabel";
            this.pointBLabel.Size = new System.Drawing.Size(53, 17);
            this.pointBLabel.TabIndex = 3;
            this.pointBLabel.Text = "Point B";
            // 
            // VerticesOfTriangleGroupBox
            // 
            this.VerticesOfTriangleGroupBox.Controls.Add(this.pointCYCoordTextBox);
            this.VerticesOfTriangleGroupBox.Controls.Add(this.pointBYCoordTextBox);
            this.VerticesOfTriangleGroupBox.Controls.Add(this.pointCXCoordTextBox);
            this.VerticesOfTriangleGroupBox.Controls.Add(this.pointBXCoordTextBox);
            this.VerticesOfTriangleGroupBox.Controls.Add(this.pointAYCoordTextBox);
            this.VerticesOfTriangleGroupBox.Controls.Add(this.pointCLabel);
            this.VerticesOfTriangleGroupBox.Controls.Add(this.pointAXCoordTextBox);
            this.VerticesOfTriangleGroupBox.Controls.Add(this.pointALabel);
            this.VerticesOfTriangleGroupBox.Controls.Add(this.pointBLabel);
            this.VerticesOfTriangleGroupBox.Location = new System.Drawing.Point(27, 37);
            this.VerticesOfTriangleGroupBox.Name = "VerticesOfTriangleGroupBox";
            this.VerticesOfTriangleGroupBox.Size = new System.Drawing.Size(229, 148);
            this.VerticesOfTriangleGroupBox.TabIndex = 5;
            this.VerticesOfTriangleGroupBox.TabStop = false;
            this.VerticesOfTriangleGroupBox.Text = "Vertices Of Triangle";
            // 
            // pointCYCoordTextBox
            // 
            this.pointCYCoordTextBox.Location = new System.Drawing.Point(155, 110);
            this.pointCYCoordTextBox.Name = "pointCYCoordTextBox";
            this.pointCYCoordTextBox.Size = new System.Drawing.Size(47, 22);
            this.pointCYCoordTextBox.TabIndex = 9;
            this.pointCYCoordTextBox.Text = "408";
            // 
            // pointBYCoordTextBox
            // 
            this.pointBYCoordTextBox.Location = new System.Drawing.Point(155, 75);
            this.pointBYCoordTextBox.Name = "pointBYCoordTextBox";
            this.pointBYCoordTextBox.Size = new System.Drawing.Size(47, 22);
            this.pointBYCoordTextBox.TabIndex = 8;
            this.pointBYCoordTextBox.Text = "408";
            // 
            // pointCXCoordTextBox
            // 
            this.pointCXCoordTextBox.Location = new System.Drawing.Point(82, 110);
            this.pointCXCoordTextBox.Name = "pointCXCoordTextBox";
            this.pointCXCoordTextBox.Size = new System.Drawing.Size(47, 22);
            this.pointCXCoordTextBox.TabIndex = 7;
            this.pointCXCoordTextBox.Text = "494";
            // 
            // pointBXCoordTextBox
            // 
            this.pointBXCoordTextBox.Location = new System.Drawing.Point(82, 75);
            this.pointBXCoordTextBox.Name = "pointBXCoordTextBox";
            this.pointBXCoordTextBox.Size = new System.Drawing.Size(47, 22);
            this.pointBXCoordTextBox.TabIndex = 6;
            this.pointBXCoordTextBox.Text = "2";
            // 
            // pointAYCoordTextBox
            // 
            this.pointAYCoordTextBox.Location = new System.Drawing.Point(155, 40);
            this.pointAYCoordTextBox.Name = "pointAYCoordTextBox";
            this.pointAYCoordTextBox.Size = new System.Drawing.Size(47, 22);
            this.pointAYCoordTextBox.TabIndex = 5;
            this.pointAYCoordTextBox.Text = "6";
            // 
            // pointCLabel
            // 
            this.pointCLabel.AutoSize = true;
            this.pointCLabel.Location = new System.Drawing.Point(7, 110);
            this.pointCLabel.Name = "pointCLabel";
            this.pointCLabel.Size = new System.Drawing.Size(53, 17);
            this.pointCLabel.TabIndex = 4;
            this.pointCLabel.Text = "Point C";
            // 
            // depthOfRecursionTextBox
            // 
            this.depthOfRecursionTextBox.Location = new System.Drawing.Point(446, 37);
            this.depthOfRecursionTextBox.MaxLength = 1;
            this.depthOfRecursionTextBox.Name = "depthOfRecursionTextBox";
            this.depthOfRecursionTextBox.Size = new System.Drawing.Size(56, 22);
            this.depthOfRecursionTextBox.TabIndex = 6;
            this.depthOfRecursionTextBox.Text = "5";
            // 
            // depthOfRecursionLabel
            // 
            this.depthOfRecursionLabel.AutoSize = true;
            this.depthOfRecursionLabel.Location = new System.Drawing.Point(304, 37);
            this.depthOfRecursionLabel.Name = "depthOfRecursionLabel";
            this.depthOfRecursionLabel.Size = new System.Drawing.Size(137, 17);
            this.depthOfRecursionLabel.TabIndex = 7;
            this.depthOfRecursionLabel.Text = "Depth Of Recursion:";
            // 
            // sierpinskiTrianglePictureBox
            // 
            this.sierpinskiTrianglePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sierpinskiTrianglePictureBox.Location = new System.Drawing.Point(37, 226);
            this.sierpinskiTrianglePictureBox.Name = "sierpinskiTrianglePictureBox";
            this.sierpinskiTrianglePictureBox.Size = new System.Drawing.Size(671, 512);
            this.sierpinskiTrianglePictureBox.TabIndex = 8;
            this.sierpinskiTrianglePictureBox.TabStop = false;
            this.sierpinskiTrianglePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.sierpinskiTrianglePictureBox_Paint);
            this.sierpinskiTrianglePictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sierpinskiTrianglePictureBox_MouseClick);
            // 
            // mouseCoordinatesLabel
            // 
            this.mouseCoordinatesLabel.AutoSize = true;
            this.mouseCoordinatesLabel.Location = new System.Drawing.Point(557, 75);
            this.mouseCoordinatesLabel.Name = "mouseCoordinatesLabel";
            this.mouseCoordinatesLabel.Size = new System.Drawing.Size(39, 17);
            this.mouseCoordinatesLabel.TabIndex = 9;
            this.mouseCoordinatesLabel.Text = "(x, y)";
            // 
            // mouseCoordinateInfoLabel
            // 
            this.mouseCoordinateInfoLabel.AutoSize = true;
            this.mouseCoordinateInfoLabel.Location = new System.Drawing.Point(557, 37);
            this.mouseCoordinateInfoLabel.Name = "mouseCoordinateInfoLabel";
            this.mouseCoordinateInfoLabel.Size = new System.Drawing.Size(139, 17);
            this.mouseCoordinateInfoLabel.TabIndex = 10;
            this.mouseCoordinateInfoLabel.Text = "Mouse Co-ordinates:";
            // 
            // colourSelector
            // 
            this.colourSelector.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.colourSelector.Location = new System.Drawing.Point(560, 127);
            this.colourSelector.Name = "colourSelector";
            this.colourSelector.Size = new System.Drawing.Size(136, 35);
            this.colourSelector.TabIndex = 11;
            this.colourSelector.Text = "Select a Colour";
            this.colourSelector.UseVisualStyleBackColor = false;
            this.colourSelector.Click += new System.EventHandler(this.colourSelector_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Note: Get the co-ordinates of the mouse by clicking somewhere in the picture box." +
    "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 767);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colourSelector);
            this.Controls.Add(this.mouseCoordinateInfoLabel);
            this.Controls.Add(this.mouseCoordinatesLabel);
            this.Controls.Add(this.sierpinskiTrianglePictureBox);
            this.Controls.Add(this.depthOfRecursionLabel);
            this.Controls.Add(this.depthOfRecursionTextBox);
            this.Controls.Add(this.VerticesOfTriangleGroupBox);
            this.Controls.Add(this.displaySierpinskiFractalButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.VerticesOfTriangleGroupBox.ResumeLayout(false);
            this.VerticesOfTriangleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sierpinskiTrianglePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displaySierpinskiFractalButton;
        private System.Windows.Forms.TextBox pointAXCoordTextBox;
        private System.Windows.Forms.Label pointALabel;
        private System.Windows.Forms.Label pointBLabel;
        private System.Windows.Forms.GroupBox VerticesOfTriangleGroupBox;
        private System.Windows.Forms.Label pointCLabel;
        private System.Windows.Forms.TextBox pointAYCoordTextBox;
        private System.Windows.Forms.TextBox pointCYCoordTextBox;
        private System.Windows.Forms.TextBox pointBYCoordTextBox;
        private System.Windows.Forms.TextBox pointCXCoordTextBox;
        private System.Windows.Forms.TextBox pointBXCoordTextBox;
        private System.Windows.Forms.TextBox depthOfRecursionTextBox;
        private System.Windows.Forms.Label depthOfRecursionLabel;
        private System.Windows.Forms.PictureBox sierpinskiTrianglePictureBox;
        private System.Windows.Forms.Label mouseCoordinatesLabel;
        private System.Windows.Forms.Label mouseCoordinateInfoLabel;
        private System.Windows.Forms.Button colourSelector;
        private System.Windows.Forms.Label label1;
    }
}

