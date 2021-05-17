using SimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TCPServer
{
    public partial class InteractiveDungeonWindow : Form
    {
        public InteractiveDungeonWindow(System.Xml.XmlNode dungeon)
        {
            InitializeComponent();
            Dungeon = dungeon;
        }
        public XmlNode Dungeon;
        public int HexHeight = 25;
        public List<PointF> Hexagons = new List<PointF>();
        public bool createDoor = false;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }


        //******Below is the Drawing of the Board and All of it's methods *********

        // Return the points that define the indicated hexagon.
        private PointF[] HexToPoints(float height, float row, float col)
        {
            // Start with the leftmost corner of the upper left hexagon.
            float width = HexWidth(height);
            float y = height / 2;
            float x = 0;

            // Move down the required number of rows.
            y += row * height;

            // If the column is odd, move down half a hex more.
            if (col % 2 == 1) y += height / 2;

            // Move over for the column number.
            x += col * (width * 0.75f);

            // Generate the points.
            return new PointF[]
                {
            new PointF(x, y),
            new PointF(x + width * 0.25f, y - height / 2),
            new PointF(x + width * 0.75f, y - height / 2),
            new PointF(x + width, y),
            new PointF(x + width * 0.75f, y + height / 2),
            new PointF(x + width * 0.25f, y + height / 2),
                };
        }

        // Return the width of a hexagon.
        private float HexWidth(float height)
        {
            return (float)(4 * (height / 2 / Math.Sqrt(3)));
        }

        // Draw a hexagonal grid for the indicated area.
        // (You might be able to draw the hexagons without
        // drawing any duplicate edges, but this is a lot easier.)
        private void DrawHexGrid(Graphics gr, Pen pen,
            float xmin, float xmax, float ymin, float ymax,
            float height)
        {
            // Loop until a hexagon won't fit.
            for (int row = 0; ; row++)
            {
                // Get the points for the row's first hexagon.
                PointF[] points = HexToPoints(height, row, 0);

                // If it doesn't fit, we're done.
                if (points[4].Y > ymax) break;

                // Draw the row.
                for (int col = 0; ; col++)
                {
                    // Get the points for the row's next hexagon.
                    points = HexToPoints(height, row, col);

                    // If it doesn't fit horizontally,
                    // we're done with this row.
                    if (points[3].X > xmax) break;

                    // If it fits vertically, draw it.
                    if (points[4].Y <= ymax)
                    {
                        gr.DrawPolygon(pen, points);
                    }
                }
            }
        }

        // Redraw the grid.
        private void picGrid_Paint(object sender, PaintEventArgs e)
        {
            if (createDoor)
            {
                Graphics g = e.Graphics;
                g.DrawLine(Pens.Blue, ptFrom, ptTo);
            }

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // Draw the selected hexagons.
                foreach (PointF point in Hexagons)
                {
                    e.Graphics.FillPolygon(Brushes.LightBlue,
                        HexToPoints(HexHeight, point.X, point.Y));
                }

                // Draw the grid.
                DrawHexGrid(e.Graphics, Pens.Black,
                    0, pnlDungeonBoard.ClientSize.Width,
                    0, pnlDungeonBoard.ClientSize.Height,
                    HexHeight);

                foreach (var rectangle in this._rectangles)
                {
                    e.Graphics.DrawRectangle(Pens.Black, rectangle);
                }
            
        }

        // Return the row and column of the hexagon at this point.
        private void PointToHex(float x, float y, float height,
            out int row, out int col)
        {
            // Find the test rectangle containing the point.
            float width = HexWidth(height);
            col = (int)(x / (width * 0.75f));

            if (col % 2 != 1)
                row = (int)Math.Floor(y / height);
            else
                row = (int)Math.Floor((y - height / 2) / height);

            // Find the test area.
            float testx = col * width * 0.75f;
            float testy = row * height;
            if (col % 2 == 1) testy += height / 2;

            // See if the point is above or
            // below the test hexagon on the left.
            bool is_above = false, is_below = false;
            float dx = x - testx;
            if (dx < width / 4)
            {
                float dy = y - (testy + height / 2);
                if (dx < 0.001)
                {
                    // The point is on the left edge of the test rectangle.
                    if (dy < 0) is_above = true;
                    if (dy > 0) is_below = true;
                }
                else if (dy < 0)
                {
                    // See if the point is above the test hexagon.
                    if (-dy / dx > Math.Sqrt(3)) is_above = true;
                }
                else
                {
                    // See if the point is below the test hexagon.
                    if (dy / dx > Math.Sqrt(3)) is_below = true;
                }
            }

            // Adjust the row and column if necessary.
            if (is_above)
            {
                if (col % 2 != 1) row--;
                col--;
            }
            else if (is_below)
            {
                if (col % 2 == 1) row++;
                col--;
            }
        }

        // Display the row and column under the mouse.
        private void picGrid_MouseMove(object sender, MouseEventArgs e)
        {
            int row, col;
            PointToHex(e.X, e.Y, HexHeight, out row, out col);
            lblMouseLocation.Text = "(" + row + ", " + col + ")";
        }

        // Add the clicked hexagon to the Hexagons list.
        private void picGrid_MouseClick(object sender, MouseEventArgs e)
        {

            if (createDoor)
            {

            }
            else
            {
                int row, col;
                PointToHex(e.X, e.Y, HexHeight, out row, out col);
                PointF check = new PointF(row, col);

                if (Hexagons.Contains(check))
                {
                    Hexagons.Remove(check);
                }
                else
                {
                    Hexagons.Add(new PointF(row, col));
                }
            }
            

            pnlDungeonBoard.Refresh();

        }

        private void InteractiveDungeonWindow_Load(object sender, EventArgs e)
        {
            this.Text = "Dungeon: " + Dungeon.Name + " - (Edit Mode)";
            this.SetStyle(
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.UserPaint |
            ControlStyles.DoubleBuffer,
            true);
        }

        List<Rectangle> _rectangles = new List<Rectangle>();
        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            int i = 0;
            int positionX = 0;
            foreach (XmlNode room in Dungeon)
            {
                if(i == 0)
                {
                    var rectangle = new Rectangle(0, 0, int.Parse(room.Attributes["width"].Value) * HexHeight, int.Parse(room.Attributes["length"].Value) * HexHeight);
                    this._rectangles.Add(rectangle);
                    positionX += int.Parse(room.Attributes["width"].Value) * HexHeight;
                }
                else
                {
                    int reqIndex = i - 1;
                    
                    var rectangle = new Rectangle(positionX, 0, int.Parse(room.Attributes["width"].Value) * HexHeight, int.Parse(room.Attributes["length"].Value) * HexHeight);
                    this._rectangles.Add(rectangle);
                    positionX += int.Parse(room.Attributes["width"].Value) * HexHeight;
                }
                i++;
            }
            this.Invalidate();

        }

        //below is part of painting a line from one location to another....(for making doors and such)

        Point ptFrom, ptTo;

        private void pnlDungeonBoard_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ptFrom = e.Location;
            }
        }


        private void btnCreateDoors_Click(object sender, EventArgs e)
        {
            if (createDoor)
            {
                createDoor = false;
            }
            else
            {
                createDoor = true;
            }

        }

        private void pnlDungeonBoard_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ptTo = e.Location;
                Invalidate();
            }
        }
    }
}
