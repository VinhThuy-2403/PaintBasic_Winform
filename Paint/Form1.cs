using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Graphics gp;

        Color myColor;


        bool bLine = false;
        bool bRec = false;
        bool bEllipse = false;
        bool bSquare = false, bCircle = false, bDuongCong = false, bDaGiac = false;

        bool isPress = false;
        int penWidth;

        private clsDrawObject currentDrawingObject = null;

        DashStyle currentPenType = DashStyle.Solid;

        List<clsDrawObject> lstObjects = new List<clsDrawObject>();
        public Form1()
        {
            InitializeComponent();
            gp = this.plMain.CreateGraphics();
            myColor = Color.Blue;
            this.btnColor.BackColor = Color.Blue;
            this.penWidth = 2; //Độ dày mặc định
            numDoday.Value = penWidth;

        }

        private void plMain_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < this.lstObjects.Count; i++)
            {
                this.lstObjects[i].Draw(gp);
            }  
        }

        private void ResetShapeSelection()
        {
            this.bLine = false;
            this.bRec = false;
            this.bEllipse = false;
            this.bSquare = false;
            this.bCircle = false;
            this.bDuongCong = false;
            this.bDaGiac = false;
        }


        private void btnLine_Click_1(object sender, EventArgs e)
        {
            ResetShapeSelection();
            this.bLine = true;
        }

        private void btnRec_Click_1(object sender, EventArgs e)
        {
            ResetShapeSelection();
            this.bRec = true;
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            ResetShapeSelection();
            this.bEllipse = true;
        }

        private void btnSquare_Click_1(object sender, EventArgs e)
        {
            ResetShapeSelection();
            this.bSquare = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetShapeSelection();
            this.bCircle = true;
        }

        private void btnDuongCong_Click(object sender, EventArgs e)
        {
            ResetShapeSelection();
            this.bDuongCong = true;
        }

        private void btnDaGiac_Click(object sender, EventArgs e)
        {
            ResetShapeSelection();
            this.bDaGiac = true;

            //clsDaGiac newPolygon = new clsDaGiac();
            //newPolygon.myPen.Color = myColor;
            //this.lstObjects.Add(newPolygon);
        }

        private void plMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.isPress) return;
            this.isPress = true;



            if (this.bLine == true)
            {
                currentDrawingObject = new clsLine();
                currentDrawingObject.p1 = e.Location;
                currentDrawingObject.myPen.Color = myColor;
                currentDrawingObject.myPen.Width = penWidth;
                currentDrawingObject.myPen.DashStyle = currentPenType;
                this.lstObjects.Add(currentDrawingObject);
            }    

            if (this.bRec == true)
            {
                currentDrawingObject = new clsRec();
                currentDrawingObject.p1 = e.Location;
                currentDrawingObject.myPen.Color = myColor;
                currentDrawingObject.myPen.Width = penWidth;
                currentDrawingObject.myPen.DashStyle = currentPenType;
                this.lstObjects.Add(currentDrawingObject);
            } 

            if (this.bEllipse == true)
            {
                currentDrawingObject = new clsEllipse();
                currentDrawingObject.p1 = e.Location;
                currentDrawingObject.myPen.Color = myColor;
                currentDrawingObject.myPen.Width = penWidth;
                currentDrawingObject.myPen.DashStyle = currentPenType;
                this.lstObjects.Add (currentDrawingObject);
            } 
              
            if (this.bSquare == true)
            {
                currentDrawingObject = new clsSquare();
                currentDrawingObject.p1 = e.Location;
                currentDrawingObject.myPen.Color = myColor;
                currentDrawingObject.myPen.Width = penWidth;
                currentDrawingObject.myPen.DashStyle = currentPenType;
                this.lstObjects.Add(currentDrawingObject);
            }    

            if (this.bCircle == true)
            {
                currentDrawingObject = new clsCircle();
                currentDrawingObject.p1 = e.Location;
                currentDrawingObject.myPen.Color = myColor;
                currentDrawingObject.myPen.Width = penWidth;
                currentDrawingObject.myPen.DashStyle = currentPenType;
                this.lstObjects.Add(currentDrawingObject);
            }   
            
            if (this.bDuongCong)
            {
                currentDrawingObject = new clsDuongCong();
                currentDrawingObject.myPen.Color = myColor;
                ((clsDuongCong)currentDrawingObject).AddPoint(e.Location);
                currentDrawingObject.myPen.Width = penWidth;
                currentDrawingObject.myPen.DashStyle = currentPenType;
                this.lstObjects.Add(currentDrawingObject);
            }

            if (this.bDaGiac)
            {
                if (this.lstObjects.Count == 0 || !(this.lstObjects[this.lstObjects.Count - 1] is clsDaGiac))
                {
                    // Tạo đa giác mới
                    currentDrawingObject = new clsDaGiac();
                    currentDrawingObject.myPen.Color = myColor;
                    currentDrawingObject.myPen.Width = penWidth;
                    currentDrawingObject.myPen.DashStyle = currentPenType;
                    ((clsDaGiac)currentDrawingObject).AddPoint(e.Location);
                    this.lstObjects.Add(currentDrawingObject);
                }
                else
                {
                    // Thêm điểm vào đa giác hiện tại
                    currentDrawingObject = (clsDaGiac)this.lstObjects[this.lstObjects.Count - 1];
                    ((clsDaGiac)currentDrawingObject).AddPoint(e.Location);
                }
            }

        }

        private void numDoday_ValueChanged(object sender, EventArgs e)
        {
            penWidth = (int)numDoday.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbPenType.SelectedItem.ToString())
            {
                case "Dash":
                    currentPenType = DashStyle.Dash;
                    break;
                case "Dot":
                    currentPenType = DashStyle.Dot;
                    break;
                case "DashDot":
                    currentPenType = DashStyle.DashDot;
                    break;
                case "DashDotDot":
                    currentPenType = DashStyle.DashDotDot;
                    break;
                default:
                    currentPenType = DashStyle.Solid;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPenType.SelectedIndex = 0;
        }

        private void btnFillColor_Click(object sender, EventArgs e)
        {

        }

        private void plMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isPress && currentDrawingObject != null)
            {
                clsDrawObject lastObject = this.lstObjects[this.lstObjects.Count - 1];

                if (this.bDuongCong)
                {
                    ((clsDuongCong)currentDrawingObject).AddPoint(e.Location);
                }
                else
                {
                    currentDrawingObject.p2 = e.Location;
                }

                this.plMain.Invalidate(); // Vẽ lại
            }
        }

        private void plMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (!this.isPress) return;

            this.isPress = false;

            if (currentDrawingObject != null && !this.bDuongCong && !this.bDaGiac)
            {
                currentDrawingObject.p2 = e.Location;
            }

            if (this.bDaGiac && e.Button == MouseButtons.Right)
            {
                clsDaGiac daGiac = currentDrawingObject as clsDaGiac;
                if (daGiac != null)
                {
                    daGiac.ClosePolygon();
                    this.bDaGiac = false;
                }
            }

            currentDrawingObject = null; // Reset đối tượng hiện tại sau khi hoàn thành vẽ
            this.plMain.Invalidate();

            //this.bLine = false;
            //this.bEllipse = false;
            //this.bRec = false;
            //this.bSquare = false;

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                myColor = colorDialog.Color;
                btnColor.BackColor = myColor;
            }

            colorDialog.Dispose();
        }
    }

    public abstract class clsDrawObject
    {
        public Point p1;
        public Point p2;
        public Pen myPen = new Pen(Color.Blue, 2);

        public DashStyle PenType
        {
            get { return myPen.DashStyle; }
            set { myPen.DashStyle = value; }
        }

        public abstract void Draw(Graphics myGp);

    };

    public class clsComplexObject : clsDrawObject
    {
        protected List<clsDrawObject> lstObject;
        public override void Draw(Graphics myGp)
        {
               for (int i = 0; i < this.lstObject.Count; i++)
               {
                    lstObject[i].Draw(myGp);
               }      
        }
    };

    public class clsLine : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
            myGp.DrawLine(myPen, this.p1, this.p2);
        }
    };

    public class clsRec : clsDrawObject
    {
        
        public override void Draw( Graphics myGp)
        {
            myGp.DrawRectangle(
                myPen, Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y),
                Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y));
        }
    };

    public class clsEllipse : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
            myGp.DrawEllipse(myPen, Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y),
                Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y));
        }
    }

    //Hinh vuong
    public class clsSquare : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
            int size = Math.Min(Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y));

            // Đảm bảo p1 là góc trên trái
            int startX = p1.X < p2.X ? p1.X : p1.X - size;
            int startY = p1.Y < p2.Y ? p1.Y : p1.Y - size;

            myGp.DrawRectangle(myPen, startX, startY, size, size);
        }
    }

    //Hinhtron
    public class clsCircle : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
            int diameter = Math.Min(Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y)); // Đảm bảo hình tròn (đường kính = cạnh nhỏ nhất)

            // Xác định góc trên trái của hình tròn dựa trên hướng kéo chuột
            int startX = p1.X < p2.X ? p1.X : p1.X - diameter;
            int startY = p1.Y < p2.Y ? p1.Y : p1.Y - diameter;

            myGp.DrawEllipse(myPen, startX, startY, diameter, diameter);
        }
    }

    //Duong cong
    public class clsDuongCong : clsDrawObject
    {
        private List<Point> points = new List<Point>(); // Danh sách điểm của đường cong

        public void AddPoint(Point p)
        {
            points.Add(p);
        }

        public override void Draw(Graphics myGp)
        {
            if (points.Count > 1) // Cần ít nhất 2 điểm để vẽ đường cong
            {
                myGp.DrawCurve(myPen, points.ToArray());
            }
        }
    }

    //Da giac
    public class clsDaGiac : clsDrawObject
    {
        private List<Point> points = new List<Point>(); // Danh sách điểm của đa giác

        public void AddPoint(Point p)
        {
            points.Add(p);
        }

        public override void Draw(Graphics myGp)
        {
            if (points.Count > 2)
            {
                if (isClosed)
                {
                    myGp.DrawPolygon(myPen, points.ToArray());
                }
                else
                {
                    myGp.DrawLines(myPen, points.ToArray());
                }
            }
        }

        bool isClosed = false;

        public void ClosePolygon()
        {
            if (points.Count > 2) // Khi hoàn thành, vẽ đường khép kín
            {
                isClosed = true;
                points.Add(points[0]); // Nối điểm đầu và điểm cuối
            }
        }
    }

}
