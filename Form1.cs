namespace FormsApp02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ยินดีตอนรับผู้ใช้งาน", "Welcome");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ต้องการปิดโปรแกรม?", "Close Windows",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;  //ยกเลิกคำสั่งปิดฟอร์ม
            }


        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            // input รับค่าจาก Textbox ชื่อ txtRedius(แปลงชนิดข้อมูลเป็น Double)
            double Radius = 0;
            //Redius = Convert.ToDouble(txtRedius.Text);
            if (double.TryParse(txtRadius.Text, out Radius) == false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "ฮ่วย Error!!");
                txtRadius.Focus();      //ให้มี Cursar ที่ Textbox
                txtRadius.SelectAll();  //ให้ Selected ข้อความใน textbox
                return;

            }
            //process คำนวณพื้นที่ สูตร pi*r*r
            double CircleArea = Math.PI * Math.Pow(Radius, 2);
            //Math.PI ให้ค่า: Pi
            //Math.Pow(x,y) x ยกกำลัง y
            //output นำไปแสดงผลที่

            lblResult.Text = CircleArea.ToString("0.00");

            txtRadius.Focus();
            txtRadius.SelectAll();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Height = 0;
            double Widht = 0;
            if (double.TryParse(txtHeight.Text, out Height) == false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เฮ้ย Error!!");
                return;
            }

            if (double.TryParse(txtWidht.Text, out Widht) == false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เฮ้ย Error!!");
                return;
            }
            // คำนวณพื้นที่สามเหลี่ยม
            double triangleArea = 0.5 * Width * Height;
            lblResult.Text = triangleArea.ToString("0.00");
            txtHeight.Focus();
            txtHeight.SelectAll();
        }

        private void txtWidht_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double HexagonWidth = 0;
            if (double.TryParse(txtHexagonWidth.Text, out HexagonWidth) == false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เฮ้ย Error!!");
                return;

            }
            double hexagonArea = (3 * Math.Sqrt(3) / 2) * Math.Pow(HexagonWidth, 2);
            lblResult.Text = hexagonArea.ToString("0.00");

        }
    }

}