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
using static Paint.Form1;

namespace Paint
{
   


    public partial class Form1 : Form
    {

        private bool isScaling = false;
        private SelectionManager.ResizeHandle activeResizeHandle;

        SelectionManager selectionManager;
        bool isMovingObject = false; //Dang di chuyen doi tuong

        bool isFilled = false; // Kiểm tra xem có tô màu hay không
        
        Graphics gp;

        Color myColor;


        bool bLine = false;
        bool bRec = false;
        bool bEllipse = false;
        bool bSquare = false, bCircle = false, bDuongCong = false, bDaGiac = false;

        bool isPress = false;
        int penWidth;

        private clsDrawObject currentDrawingObject = null;

        //Brush
        public enum BrushType { Solid, Hatch, Gradient }

        // Các biến quản lý brush hiện tại
        private BrushType CurrentBrushType = BrushType.Solid;
        private Color secondaryColor = Color.White;
        private HatchStyle currentHatchStyle = HatchStyle.Cross;
        private float gradientAngle = 45f;


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
            cbBrushType.SelectedIndex = 0;
            selectionManager = new SelectionManager();
        }

        private void plMain_Paint(object sender, PaintEventArgs e)
        {
            foreach (var obj in lstObjects)
            {
                obj.Draw(e.Graphics);
            }

            // Vẽ selection (nếu có)
            selectionManager.DrawSelection(e.Graphics);
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

            bool isDrawingMode = bLine || bRec || bEllipse || bSquare || bCircle || bDuongCong || bDaGiac;
            bool isCtrlPressed = (Control.ModifierKeys & Keys.Control) == Keys.Control;

            if (!isDrawingMode)
            {
                activeResizeHandle = selectionManager.GetHandleAtPoint(e.Location);
                
                if (activeResizeHandle != SelectionManager.ResizeHandle.None)
                {
                    isScaling = true;
                }    
                
                // Chế độ select hình
                selectionManager.SelectObject(lstObjects, e.Location, isCtrlPressed);
                isMovingObject = selectionManager.HasSelection;

                if (isMovingObject)
                {
                    return;
                }
            }

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

                //Cau hinh brush
                currentDrawingObject.BrushType = this.CurrentBrushType;
                currentDrawingObject.SecondaryColor = this.secondaryColor;
                currentDrawingObject.HatchStyle = this.currentHatchStyle;
                currentDrawingObject.GradientAngle = this.gradientAngle;

                currentDrawingObject.p1 = e.Location;
                currentDrawingObject.myPen.Color = myColor;
                currentDrawingObject.myPen.Width = penWidth;
                currentDrawingObject.myPen.DashStyle = currentPenType;
                currentDrawingObject.isFilled = this.isFilled;
                this.lstObjects.Add(currentDrawingObject);
            } 

            if (this.bEllipse == true)
            {
                currentDrawingObject = new clsEllipse();

                currentDrawingObject.BrushType = this.CurrentBrushType;
                currentDrawingObject.SecondaryColor = this.secondaryColor;
                currentDrawingObject.HatchStyle = this.currentHatchStyle;
                currentDrawingObject.GradientAngle = this.gradientAngle;

                currentDrawingObject.p1 = e.Location;
                currentDrawingObject.myPen.Color = myColor;
                currentDrawingObject.myPen.Width = penWidth;
                currentDrawingObject.myPen.DashStyle = currentPenType;
                currentDrawingObject.isFilled = this.isFilled;
                this.lstObjects.Add (currentDrawingObject);
            } 
              
            if (this.bSquare == true)
            {
                currentDrawingObject = new clsSquare();

                currentDrawingObject.BrushType = this.CurrentBrushType;
                currentDrawingObject.SecondaryColor = this.secondaryColor;
                currentDrawingObject.HatchStyle = this.currentHatchStyle;
                currentDrawingObject.GradientAngle = this.gradientAngle;

                currentDrawingObject.p1 = e.Location;
                currentDrawingObject.myPen.Color = myColor;
                currentDrawingObject.myPen.Width = penWidth;
                currentDrawingObject.myPen.DashStyle = currentPenType;
                currentDrawingObject.isFilled = this.isFilled;
                this.lstObjects.Add(currentDrawingObject);
            }    

            if (this.bCircle == true)
            {
                currentDrawingObject = new clsCircle();

                currentDrawingObject.BrushType = this.CurrentBrushType;
                currentDrawingObject.SecondaryColor = this.secondaryColor;
                currentDrawingObject.HatchStyle = this.currentHatchStyle;
                currentDrawingObject.GradientAngle = this.gradientAngle;

                currentDrawingObject.p1 = e.Location;
                currentDrawingObject.myPen.Color = myColor;
                currentDrawingObject.myPen.Width = penWidth;
                currentDrawingObject.myPen.DashStyle = currentPenType;
                currentDrawingObject.isFilled = this.isFilled;
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

                    currentDrawingObject.BrushType = this.CurrentBrushType;
                    currentDrawingObject.SecondaryColor = this.secondaryColor;
                    currentDrawingObject.HatchStyle = this.currentHatchStyle;
                    currentDrawingObject.GradientAngle = this.gradientAngle;

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
            this.isFilled = true;
        }

        private void cbBrushType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentBrushType = (BrushType)cbBrushType.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.isFilled = false;
        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectionManager.HasSelection)
            {
                foreach(var obj in selectionManager.SelectedObjects.ToList())
                {
                    lstObjects.Remove(obj);
                }    
                selectionManager.SelectedObjects.Clear();
                plMain.Invalidate();
            }    
        }

        private void plMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isPress)
            {
                if (isScaling)
                {
                    selectionManager.ScaleSelectedObject(e.Location, activeResizeHandle);
                    plMain.Invalidate();
                }    
                else if (isMovingObject && selectionManager.HasSelection)
                {
                    //Chế độ di chuyển hình đã chọn
                    selectionManager.MoveSelectedObjects(e.Location);
                    plMain.Invalidate();
                }
                else if (currentDrawingObject != null)
                {
                    // Chế độ vẽ hình mới
                    if (this.bDuongCong)
                    {
                        ((clsDuongCong)currentDrawingObject).AddPoint(e.Location);
                    }
                    else
                    {
                        currentDrawingObject.p2 = e.Location;
                    }
                    plMain.Invalidate();
                }
            }

        }

        private void plMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (!this.isPress) return;

            this.isPress = false;

            if (isMovingObject)
            {
                isMovingObject = false;
            }
            else if (currentDrawingObject != null  && !this.bDaGiac)
            {
                currentDrawingObject.p2 = e.Location;
                ResetShapeSelection();
                currentDrawingObject = null;
            }

            if (this.bDaGiac && e.Button == MouseButtons.Right)
            {
                clsDaGiac daGiac = currentDrawingObject as clsDaGiac;
                if (daGiac != null)
                {
                    daGiac.ClosePolygon();
                    daGiac.isFilled = this.isFilled;
                    this.bDaGiac = false;
                }
            }   

            
            /*currentDrawingObject = null; */// Reset đối tượng hiện tại sau khi hoàn thành vẽ
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
        public bool isFilled = false; // Kiểm tra xem có tô màu hay không

        public DashStyle PenType
        {
            get { return myPen.DashStyle; }
            set { myPen.DashStyle = value; }
        }

        public abstract void Draw(Graphics myGp);

        public virtual bool CanBeFilled()
        {
            return true; // Mặc định có thể tô
        }

        //brush
        public BrushType BrushType { get; set; } = BrushType.Solid;
        public Color SecondaryColor { get; set; } = Color.White;
        public HatchStyle HatchStyle { get; set; } = HatchStyle.Cross;
        public float GradientAngle { get; set; } = 45f;

        protected Brush CreateLocalBrush(Rectangle bounds)
        {
            switch (this.BrushType)
            {
                case BrushType.Hatch:
                    return new HatchBrush(this.HatchStyle, myPen.Color, this.SecondaryColor);

                case BrushType.Gradient:
                    return new LinearGradientBrush(bounds,
                           myPen.Color,
                           this.SecondaryColor,
                           this.GradientAngle);

                default: // Solid
                    return new SolidBrush(myPen.Color);
            }
        }


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
        public override bool CanBeFilled() => false;
        public override void Draw(Graphics myGp)
        {
            myGp.DrawLine(myPen, this.p1, this.p2);
        }
        
    };

    public class clsRec : clsDrawObject
    {

        public override void Draw(Graphics g)
        {
            Rectangle rect = new Rectangle(
                Math.Min(p1.X, p2.X),
                Math.Min(p1.Y, p2.Y),
                Math.Max(1, Math.Abs(p2.X - p1.X)),  // Đảm bảo Width >= 1
                Math.Max(1, Math.Abs(p2.Y - p1.Y))); // Đảm bảo Height >= 1

            if (isFilled)
            {
                using (Brush brush = this.CreateLocalBrush(rect))
                {
                    g.FillRectangle(brush, rect);
                }
            }
            g.DrawRectangle(myPen, rect);
        }


    };

    public class clsEllipse : clsDrawObject
    {
        public override void Draw(Graphics g)
        {
            Rectangle ellipse = new Rectangle(
                Math.Min(p1.X, p2.X),
                Math.Min(p1.Y, p2.Y),
                Math.Max(1, Math.Abs(p2.X - p1.X)),  // Đảm bảo Width >= 1
                Math.Max(1, Math.Abs(p2.Y - p1.Y))); // Đảm bảo Height >= 1

            if (isFilled)
            {
                using (Brush brush = this.CreateLocalBrush(ellipse))
                {
                    g.FillEllipse(brush, ellipse);
                }
            }
            g.DrawEllipse(myPen, ellipse);
        }
    }

    //Hinh vuong
    public class clsSquare : clsDrawObject
    {
        public override void Draw(Graphics g)
        {
            int size = Math.Max(1, Math.Min(Math.Abs(p2.X - p1.X),Math.Abs(p2.Y - p1.Y)));
            int startX = p1.X < p2.X ? p1.X : p1.X - size;
            int startY = p1.Y < p2.Y ? p1.Y : p1.Y - size;
            Rectangle square = new Rectangle(startX, startY, size, size);


            if (isFilled)
            {
                using (Brush brush = this.CreateLocalBrush(square))
                {
                    g.FillRectangle(brush, square);
                }
            }
            g.DrawRectangle(myPen, square);
        }
    }
    //Hinhtron
    public class clsCircle : clsDrawObject
    {
        public override void Draw(Graphics g)
        {
            int diameter = Math.Max(1, Math.Min(Math.Abs(p2.X - p1.X),Math.Abs(p2.Y - p1.Y)));
            int startX = p1.X < p2.X ? p1.X : p1.X - diameter;
            int startY = p1.Y < p2.Y ? p1.Y : p1.Y - diameter;

            // Tạo rectangle bao quanh hình tròn
            Rectangle circle = new Rectangle(startX, startY, diameter, diameter);

            // Tô màu nếu được bật
            if (isFilled)
            {
                using (Brush brush = this.CreateLocalBrush(circle))
                {
                    g.FillEllipse(brush, circle);
                }
            }

            // Vẽ viền
            g.DrawEllipse(myPen, circle);
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

        public void SetPoints(List<Point> newPoints)
        {
            points = new List<Point>(newPoints);

            // Cập nhật p1 và p2 để phù hợp với bounding box
            if (points.Count > 0)
            {
                p1 = new Point(points.Min(p => p.X), points.Min(p => p.Y));
                p2 = new Point(points.Max(p => p.X), points.Max(p => p.Y));
            }
        }

        public List<Point> GetPoints()
        {
            return new List<Point>(points);
        }
    }

    //Da giac
    public class clsDaGiac : clsDrawObject
    {
        private List<Point> points = new List<Point>();
        bool isClosed = false;

        public void AddPoint(Point p)
        {
            points.Add(p);
        }

        public override void Draw(Graphics g)
        {
            if (points.Count > 2)
            {
                if (isClosed)
                {
                    // Vẽ và tô màu nếu đa giác đã khép kín
                    if (isFilled)
                    {
                        using (Brush brush = this.CreateLocalBrush(GetBoundingBox()))
                        {
                            g.FillPolygon(brush, points.ToArray());
                        }
                    }
                    g.DrawPolygon(myPen, points.ToArray());
                }
                else
                {
                    g.DrawLines(myPen, points.ToArray());
                }
            }
        }

        public void ClosePolygon()
        {
            if (points.Count > 2)
            {
                isClosed = true;
                points.Add(points[0]); // Nối điểm đầu và cuối
            }
        }

        private Rectangle GetBoundingBox()
        {
            if (points.Count == 0) return new Rectangle(0, 0, 1, 1);

            int minX = points.Min(p => p.X);
            int minY = points.Min(p => p.Y);
            int maxX = points.Max(p => p.X);
            int maxY = points.Max(p => p.Y);

            return new Rectangle(minX, minY,
                Math.Max(1, maxX - minX),
                Math.Max(1, maxY - minY));
        }

        public List<Point> GetPoints()
        {
            return new List<Point>(points);
        }

        public void SetPoints(List<Point> newPoints)
        {
            points = new List<Point>(newPoints);

            // Cập nhật p1 và p2 để phù hợp với bounding box
            if (points.Count > 0)
            {
                p1 = new Point(points.Min(p => p.X), points.Min(p => p.Y));
                p2 = new Point(points.Max(p => p.X), points.Max(p => p.Y));
            }
        }
    }



    //SelectionManager để quản lý chọn và di chuyển
    public class SelectionManager
    {
        public enum ResizeHandle
        {
            None,
            TopLeft, Top, TopRight,
            Left, Right,
            BottomLeft, Bottom, BottomRight
        }

        private const int HandleSize = 8;
        private ResizeHandle activeHandle = ResizeHandle.None;

        private List<clsDrawObject> selectedObjects = new List<clsDrawObject>();
        private Point selectionStartPoint;
        private Point offset;
        private Dictionary<clsDrawObject, Rectangle> originalBounds = new Dictionary<clsDrawObject, Rectangle>();
        private bool isMultiSelectMode = false;

        public bool HasSelection => selectedObjects.Count > 0;
        public List<clsDrawObject> SelectedObjects => selectedObjects;

        public void SelectObject(List<clsDrawObject> objects, Point location, bool isCtrlPressed)
        {
            if (!isCtrlPressed)
            {
                // Nếu không giữ Ctrl, xóa tất cả lựa chọn hiện tại
                selectedObjects.Clear();
                originalBounds.Clear();
            }

            // Tìm đối tượng được click
            var clickedObject = FindObjectAtLocation(objects, location);

            if (clickedObject != null)
            {
                if (isCtrlPressed && selectedObjects.Contains(clickedObject))
                {
                    // Nếu đang giữ Ctrl và click vào đối tượng đã chọn, bỏ chọn nó
                    selectedObjects.Remove(clickedObject);
                    originalBounds.Remove(clickedObject);
                }
                else
                {
                    // Thêm vào danh sách chọn
                    if (!selectedObjects.Contains(clickedObject))
                    {
                        selectedObjects.Add(clickedObject);
                        originalBounds[clickedObject] = GetObjectBounds(clickedObject);
                    }
                }
            }

            selectionStartPoint = location;
            isMultiSelectMode = isCtrlPressed && selectedObjects.Count > 0;
        }

        private clsDrawObject FindObjectAtLocation(List<clsDrawObject> objects, Point location)
        {
            // Kiểm tra từng object từ trên xuống (để chọn object trên cùng)
            foreach (var obj in objects.Reverse<clsDrawObject>())
            {
                if (obj is clsDuongCong duongCong)
                {
                    if (IsPointNearCurve(duongCong.GetPoints(), location, 5))
                    {
                        return obj;
                    }
                }
                else if (IsPointInObject(obj, location))
                {
                    return obj;
                }
            }
            return null;
        }

        public ResizeHandle GetHandleAtPoint(Point point)
        {
            if (!HasSelection) return ResizeHandle.None;

            // Chỉ scale khi chọn 1 đối tượng
            if (selectedObjects.Count != 1) return ResizeHandle.None;

            var bounds = GetObjectBounds(selectedObjects[0]);

            // Tạo các handle (ô vuông nhỏ) ở các vị trí
            Rectangle[] handles = {
        new Rectangle(bounds.Left - HandleSize/2, bounds.Top - HandleSize/2, HandleSize, HandleSize), // TopLeft
        new Rectangle(bounds.Left + bounds.Width/2 - HandleSize/2, bounds.Top - HandleSize/2, HandleSize, HandleSize), // Top
        new Rectangle(bounds.Right - HandleSize/2, bounds.Top - HandleSize/2, HandleSize, HandleSize), // TopRight
        new Rectangle(bounds.Left - HandleSize/2, bounds.Top + bounds.Height/2 - HandleSize/2, HandleSize, HandleSize), // Left
        new Rectangle(bounds.Right - HandleSize/2, bounds.Top + bounds.Height/2 - HandleSize/2, HandleSize, HandleSize), // Right
        new Rectangle(bounds.Left - HandleSize/2, bounds.Bottom - HandleSize/2, HandleSize, HandleSize), // BottomLeft
        new Rectangle(bounds.Left + bounds.Width/2 - HandleSize/2, bounds.Bottom - HandleSize/2, HandleSize, HandleSize), // Bottom
        new Rectangle(bounds.Right - HandleSize/2, bounds.Bottom - HandleSize/2, HandleSize, HandleSize)  // BottomRight
    };

            // Kiểm tra điểm click có nằm trong handle nào không
            for (int i = 0; i < handles.Length; i++)
            {
                if (handles[i].Contains(point))
                    return (ResizeHandle)(i + 1); // +1 vì enum bắt đầu từ 1
            }

            return ResizeHandle.None;
        }

        private bool IsPointNearCurve(List<Point> points, Point pt, int tolerance)
        {
            if (points.Count < 2) return false;

            for (int i = 0; i < points.Count - 1; i++)
            {
                if (IsPointNearLine(points[i], points[i + 1], pt, tolerance))
                    return true;
            }
            return false;
        }

        private bool IsPointInObject(clsDrawObject obj, Point point)
        {
            if (obj is clsLine line)
            {
                return IsPointNearLine(line.p1, line.p2, point, 5);
            }
            else if (obj is clsRec || obj is clsSquare || obj is clsEllipse || obj is clsCircle)
            {
                var bounds = GetObjectBounds(obj);
                return bounds.Contains(point);
            }
            else if (obj is clsDaGiac daGiac)
            {
                return IsPointInPolygon(daGiac.GetPoints(), point);
            }
            return false;
        }

        private bool IsPointNearLine(Point p1, Point p2, Point pt, int tolerance)
        {
            float dx = p2.X - p1.X;
            float dy = p2.Y - p1.Y;
            float length = (float)Math.Sqrt(dx * dx + dy * dy);

            if (length == 0) return false;

            float u = ((pt.X - p1.X) * dx + (pt.Y - p1.Y) * dy) / (length * length);

            if (u < 0 || u > 1) return false;

            float ix = p1.X + u * dx;
            float iy = p1.Y + u * dy;
            float distance = (float)Math.Sqrt(Math.Pow(pt.X - ix, 2) + Math.Pow(pt.Y - iy, 2));

            return distance <= tolerance;
        }

        private bool IsPointInPolygon(List<Point> polygon, Point point)
        {
            bool inside = false;
            for (int i = 0, j = polygon.Count - 1; i < polygon.Count; j = i++)
            {
                if (((polygon[i].Y > point.Y) != (polygon[j].Y > point.Y)) &&
                    (point.X < (polygon[j].X - polygon[i].X) * (point.Y - polygon[i].Y) /
                    (polygon[j].Y - polygon[i].Y) + polygon[i].X))
                {
                    inside = !inside;
                }
            }
            return inside;
        }

        public void MoveSelectedObjects(Point newLocation)
        {
            if (!HasSelection) return;

            int deltaX = newLocation.X - selectionStartPoint.X;
            int deltaY = newLocation.Y - selectionStartPoint.Y;

            foreach (var obj in selectedObjects)
            {
                if (obj is clsDaGiac daGiac)
                {
                    List<Point> newPoints = new List<Point>();
                    foreach (Point p in daGiac.GetPoints())
                    {
                        newPoints.Add(new Point(p.X + deltaX, p.Y + deltaY));
                    }
                    daGiac.SetPoints(newPoints);
                }
                else if (obj is clsDuongCong duongCong)
                {
                    List<Point> newPoints = new List<Point>();
                    foreach (Point p in duongCong.GetPoints())
                    {
                        newPoints.Add(new Point(p.X + deltaX, p.Y + deltaY));
                    }
                    duongCong.SetPoints(newPoints);
                }
                else
                {
                    obj.p1.X += deltaX;
                    obj.p1.Y += deltaY;
                    obj.p2.X += deltaX;
                    obj.p2.Y += deltaY;
                }
            }

            selectionStartPoint = newLocation;
        }

        public void DrawSelection(Graphics g)
        {
            foreach (var obj in selectedObjects)
            {
                var bounds = GetObjectBounds(obj);
                using (Pen selectionPen = new Pen(Color.Red, 2))
                {
                    selectionPen.DashStyle = DashStyle.Dash;
                    g.DrawRectangle(selectionPen, bounds);
                }
            }

            if (selectedObjects.Count == 1)
            {
                var bounds = GetObjectBounds(selectedObjects[0]);

                // Vẽ các handle
                Brush handleBrush = Brushes.White;
                foreach (ResizeHandle handle in Enum.GetValues(typeof(ResizeHandle)))
                {
                    if (handle == ResizeHandle.None) continue;

                    Rectangle handleRect = GetHandleRect(bounds, handle);
                    g.FillRectangle(handleBrush, handleRect);
                    g.DrawRectangle(Pens.Black, handleRect);
                }
            }    
        }

        private Rectangle GetHandleRect(Rectangle bounds, ResizeHandle handle)
        {
            int x = 0, y = 0;

            switch (handle)
            {
                case ResizeHandle.TopLeft:
                    x = bounds.Left - HandleSize / 2;
                    y = bounds.Top - HandleSize / 2;
                    break;
                case ResizeHandle.Top:
                    x = bounds.Left + bounds.Width / 2 - HandleSize / 2;
                    y = bounds.Top - HandleSize / 2;
                    break;
                case ResizeHandle.TopRight:
                    x = bounds.Right - HandleSize / 2;
                    y = bounds.Top - HandleSize / 2;
                    break;
                case ResizeHandle.Left:
                    x = bounds.Left - HandleSize / 2;
                    y = bounds.Top + bounds.Height / 2 - HandleSize / 2;
                    break;
                case ResizeHandle.Right:
                    x = bounds.Right - HandleSize / 2;
                    y = bounds.Top + bounds.Height / 2 - HandleSize / 2;
                    break;
                case ResizeHandle.BottomLeft:
                    x = bounds.Left - HandleSize / 2;
                    y = bounds.Bottom - HandleSize / 2;
                    break;
                case ResizeHandle.Bottom:
                    x = bounds.Left + bounds.Width / 2 - HandleSize / 2;
                    y = bounds.Bottom - HandleSize / 2;
                    break;
                case ResizeHandle.BottomRight:
                    x = bounds.Right - HandleSize / 2;
                    y = bounds.Bottom - HandleSize / 2;
                    break;
            }

            return new Rectangle(x, y, HandleSize, HandleSize);
        }


        private Rectangle GetObjectBounds(clsDrawObject obj)
        {
            if (obj is clsCircle circle)
            {
                int diameter = Math.Min(Math.Abs(circle.p2.X - circle.p1.X), Math.Abs(circle.p2.Y - circle.p1.Y));
                int x = circle.p1.X < circle.p2.X ? circle.p1.X : circle.p1.X - diameter;
                int y = circle.p1.Y < circle.p2.Y ? circle.p1.Y : circle.p1.Y - diameter;
                return new Rectangle(x, y, diameter, diameter);
            }
            else if (obj is clsSquare square)
            {
                int size = Math.Min(Math.Abs(square.p2.X - square.p1.X), Math.Abs(square.p2.Y - square.p1.Y));
                int x = square.p1.X < square.p2.X ? square.p1.X : square.p1.X - size;
                int y = square.p1.Y < square.p2.Y ? square.p1.Y : square.p1.Y - size;
                return new Rectangle(x, y, size, size);
            }
            else if (obj is clsLine line)
            {
                return new Rectangle(
                    Math.Min(line.p1.X, line.p2.X),
                    Math.Min(line.p1.Y, line.p2.Y),
                    Math.Abs(line.p2.X - line.p1.X),
                    Math.Abs(line.p2.Y - line.p1.Y));
            }
            else if (obj is clsDaGiac daGiac)
            {
                var points = daGiac.GetPoints();
                if (points.Count == 0) return Rectangle.Empty;

                int minX = points.Min(p => p.X);
                int minY = points.Min(p => p.Y);
                int maxX = points.Max(p => p.X);
                int maxY = points.Max(p => p.Y);

                return new Rectangle(minX, minY, maxX - minX, maxY - minY);
            }
            else if (obj is clsDuongCong duongCong)
            {
                var points = duongCong.GetPoints();
                if (points.Count == 0) return Rectangle.Empty;

                int minX = points.Min(p => p.X);
                int minY = points.Min(p => p.Y);
                int maxX = points.Max(p => p.X);
                int maxY = points.Max(p => p.Y);

                return new Rectangle(minX, minY, maxX - minX, maxY - minY);
            }
            else // Các hình khác
            {
                return new Rectangle(
                    Math.Min(obj.p1.X, obj.p2.X),
                    Math.Min(obj.p1.Y, obj.p2.Y),
                    Math.Abs(obj.p2.X - obj.p1.X),
                    Math.Abs(obj.p2.Y - obj.p1.Y));
            }
        }

        public void ScaleSelectedObject(Point mousePos, ResizeHandle handle)
        {
            if (selectedObjects.Count != 1) return;

            var obj = selectedObjects[0];
            var bounds = GetObjectBounds(obj);

            // Đảm bảo kích thước tối thiểu
            if (bounds.Width < 5 || bounds.Height < 5) return;

            float scaleX = 1f, scaleY = 1f;
            PointF origin = PointF.Empty;
            bool maintainAspectRatio = (Control.ModifierKeys & Keys.Shift) == Keys.Shift;

            // Tính toán tỷ lệ scale dựa trên handle được kéo
            switch (handle)
            {
                case ResizeHandle.TopLeft:
                    scaleX = (bounds.Right - mousePos.X) / (float)bounds.Width;
                    scaleY = (bounds.Bottom - mousePos.Y) / (float)bounds.Height;
                    origin = new PointF(bounds.Right, bounds.Bottom);
                    break;
                case ResizeHandle.Top:
                    scaleY = (bounds.Bottom - mousePos.Y) / (float)bounds.Height;
                    origin = new PointF(bounds.Left + bounds.Width / 2f, bounds.Bottom);
                    break;
                case ResizeHandle.TopRight:
                    origin = new PointF(bounds.Left, bounds.Bottom);
                    scaleX = Math.Max(0.1f, (mousePos.X - bounds.Left) / (float)Math.Max(1, bounds.Width));
                    scaleY = Math.Max(0.1f, (bounds.Bottom - mousePos.Y) / (float)Math.Max(1, bounds.Height));
                    if (maintainAspectRatio) scaleY = scaleX;
                    break;
                case ResizeHandle.Left:
                    scaleX = (bounds.Right - mousePos.X) / (float)bounds.Width;
                    origin = new PointF(bounds.Right, bounds.Top + bounds.Height / 2f);
                    break;
                case ResizeHandle.Right:
                    origin = new PointF(bounds.Left, bounds.Top + bounds.Height / 2f);
                    scaleX = Math.Max(0.1f, (mousePos.X - bounds.Left) / (float)Math.Max(1, bounds.Width));
                    break;
                case ResizeHandle.BottomLeft:
                    origin = new PointF(bounds.Right, bounds.Top);
                    scaleX = Math.Max(0.1f, (bounds.Right - mousePos.X) / (float)Math.Max(1, bounds.Width));
                    scaleY = Math.Max(0.1f, (mousePos.Y - bounds.Top) / (float)Math.Max(1, bounds.Height));
                    if (maintainAspectRatio) scaleX = scaleY;
                    break;
                case ResizeHandle.Bottom:
                    origin = new PointF(bounds.Left + bounds.Width / 2f, bounds.Top);
                    scaleY = Math.Max(0.1f, (mousePos.Y - bounds.Top) / (float)Math.Max(1, bounds.Height));
                    break;
                case ResizeHandle.BottomRight:
                    origin = new PointF(bounds.Left, bounds.Top);
                    scaleX = Math.Max(0.1f, (mousePos.X - bounds.Left) / (float)Math.Max(1, bounds.Width));
                    scaleY = Math.Max(0.1f, (mousePos.Y - bounds.Top) / (float)Math.Max(1, bounds.Height));
                    if (maintainAspectRatio) scaleY = scaleX;
                    break;
            }



            // Áp dụng phép scale
            if (obj is clsDaGiac daGiac)
            {
                ScalePolygon(daGiac, scaleX, scaleY, origin);
            }
            else if (obj is clsDuongCong duongCong)
            {
                ScalePolygon(duongCong, scaleX, scaleY, origin);
            }
            else
            {
                ScaleBasicShape(obj, scaleX, scaleY, origin);
            }
        }

        private void ScaleBasicShape(clsDrawObject obj, float scaleX, float scaleY, PointF origin)
        {
            PointF p1 = new PointF(obj.p1.X, obj.p1.Y);
            PointF p2 = new PointF(obj.p2.X, obj.p2.Y);

            p1 = ScalePoint(p1, scaleX, scaleY, origin);
            p2 = ScalePoint(p2, scaleX, scaleY, origin);

            obj.p1 = Point.Round(p1);
            obj.p2 = Point.Round(p2);
        }

        private void ScalePolygon(clsDaGiac polygon, float scaleX, float scaleY, PointF origin)
        {
            var points = polygon.GetPoints();
            var scaledPoints = new List<Point>();

            foreach (var point in points)
            {
                PointF scaledPoint = ScalePoint(new PointF(point.X, point.Y), scaleX, scaleY, origin);
                scaledPoints.Add(Point.Round(scaledPoint));
            }

            polygon.SetPoints(scaledPoints);
        }

        private void ScalePolygon(clsDuongCong curve, float scaleX, float scaleY, PointF origin)
        {
            var points = curve.GetPoints();
            var scaledPoints = new List<Point>();

            foreach (var point in points)
            {
                PointF scaledPoint = ScalePoint(new PointF(point.X, point.Y), scaleX, scaleY, origin);
                scaledPoints.Add(Point.Round(scaledPoint));
            }

            curve.SetPoints(scaledPoints);
        }

        private PointF ScalePoint(PointF point, float scaleX, float scaleY, PointF origin)
        {
            // Dịch chuyển về gốc tọa độ
            float x = point.X - origin.X;
            float y = point.Y - origin.Y;

            // Áp dụng scale
            x *= scaleX;
            y *= scaleY;

            // Dịch chuyển trở lại vị trí ban đầu
            return new PointF(x + origin.X, y + origin.Y);
        }
    }

}
