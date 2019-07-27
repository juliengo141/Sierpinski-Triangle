using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sierpinski_Triangle
{
    public partial class Form1 : Form
    {

        #region Global Variables
        private Bitmap sierpinskiTriangleBitmap = new Bitmap(500, 500);
        Graphics sierpinskiTriangleImage;
        Color triangleColour = Color.Black;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region Event Handler
        private void displaySierpinskiFractalButton_Click(object sender, EventArgs e)
        {
            SolidBrush brush = new SolidBrush(triangleColour);

            sierpinskiTriangleImage = Graphics.FromImage(sierpinskiTriangleBitmap);
            sierpinskiTriangleImage.Clear(sierpinskiTrianglePictureBox.BackColor);

            bool isNumeric = Int32.TryParse(depthOfRecursionTextBox.Text, out int depthOfRecursion);

            bool isNumeric1 = float.TryParse(pointAXCoordTextBox.Text, out float pointAXCoord);
            bool isNumeric2 = float.TryParse(pointAYCoordTextBox.Text, out float pointAYCoord);

            bool isNumeric3 = float.TryParse(pointBXCoordTextBox.Text, out float pointBXCoord);
            bool isNumeric4 = float.TryParse(pointBYCoordTextBox.Text, out float pointBYCoord);

            bool isNumeric5 = float.TryParse(pointCXCoordTextBox.Text, out float pointCXCoord);
            bool isNumeric6 = float.TryParse(pointCYCoordTextBox.Text, out float pointCYCoord);

            if (!isNumeric || !isNumeric1 || !isNumeric2 || !isNumeric3 || !isNumeric4 || !isNumeric5 || !isNumeric6)
            {
                MessageBox.Show("Please fill all the requirements", "Only numbers allowed");
            }

            else
            {
                PointF pointA = new PointF(pointAXCoord, pointAYCoord);
                PointF pointB = new PointF(pointBXCoord, pointBYCoord);
                PointF pointC = new PointF(pointCXCoord, pointCYCoord);

                drawTriangle(sierpinskiTriangleImage, depthOfRecursion, brush, pointA, pointB, pointC);

                sierpinskiTrianglePictureBox.Refresh();
            }

        }
        private void sierpinskiTrianglePictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            mouseCoordinatesLabel.Text = "(" + e.X + ", " + e.Y + ")";
        }

        private void sierpinskiTrianglePictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(sierpinskiTriangleBitmap, 0, 0);
        }

        private void colourSelector_Click(object sender, EventArgs e)
        {
            ColorDialog dialogForColours = new ColorDialog();

            if (dialogForColours.ShowDialog() == DialogResult.OK)
            {
                triangleColour = dialogForColours.Color;
            }
        }
        #endregion

        #region Methods
        private void drawTriangle(Graphics fractalImage, int recursionDepth, SolidBrush brush, PointF pointA, PointF pointB, PointF pointC)
        {
            if (recursionDepth == 0)
            {
                PointF[] points = { pointA, pointB, pointC };
                fractalImage.FillPolygon(brush, points);
            }

            else
            {
                PointF midpointOfAB = new PointF((pointA.X + pointB.X) / 2f, (pointA.Y + pointB.Y) / 2f);
                PointF midpointOfAC = new PointF((pointA.X + pointC.X) / 2f, (pointA.Y + pointC.Y) / 2f);
                PointF midpointOfBC = new PointF((pointB.X + pointC.X) / 2f, (pointB.Y + pointC.Y) / 2f);

                drawTriangle(sierpinskiTriangleImage, recursionDepth - 1, brush, pointA, midpointOfAB, midpointOfAC);
                drawTriangle(sierpinskiTriangleImage, recursionDepth - 1, brush, midpointOfAB, pointB, midpointOfBC);
                drawTriangle(sierpinskiTriangleImage, recursionDepth - 1, brush, midpointOfAC, midpointOfBC, pointC);

            }
        }
        #endregion
    }
}
