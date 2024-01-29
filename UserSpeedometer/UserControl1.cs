using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//picturebox 투명도
//https://ssabi.tistory.com/40
//https://stackoverflow.com/questions/11412169/is-it-possible-to-have-two-overlapping-picturebox-controls-with-transparent-imag
//userproperty 
//https://www.youtube.com/watch?v=o2PQDs90iHA&list=PLoFFz2j8yxxxH_3ustbHATXtMsHZ-Saei
//https://bravochoi.tistory.com/115
//Picture Rotation
//https://www.codeproject.com/Articles/58815/C-Image-PictureBox-Rotations


namespace UserSpeedometer
{
    public partial class UserControl1: UserControl
    {
        //Load an image in from a file
        public Image pin_image = Properties.Resources.pin7;

        public string angleVal="0";


        //User Property
        [Category("UserProperty"),Description("Number1")]
        public string Number1
        {
            get {
                return this.label1.Text;
            }
            set {
                this.label1.Text = value;
            
            }
        }
        [Category("UserProperty"), Description("Number2")]
        public string Number2
        {
            get
            {
                return this.label2.Text;
            }
            set
            {
                this.label2.Text = value;

            }
        }
        [Category("UserProperty"), Description("Number3")]
        public string Number3
        {
            get
            {
                return this.label3.Text;
            }
            set
            {
                this.label3.Text = value;

            }
        }
        [Category("UserProperty"), Description("Number4")]
        public string Number4
        {
            get
            {
                return this.label4.Text;
            }
            set
            {
                this.label4.Text = value;

            }
        }
        [Category("UserProperty"), Description("Number5")]
        public string Number5
        {
            get
            {
                return this.label5.Text;
            }
            set
            {
                this.label5.Text = value;

            }
        }
        [Category("UserProperty"), Description("Number6")]
        public string Number6
        {
            get
            {
                return this.label6.Text;
            }
            set
            {
                this.label6.Text = value;

            }
        }
        [Category("UserProperty"), Description("Number7")]
        public string Number7
        {
            get
            {
                return this.label7.Text;
            }
            set
            {
                this.label7.Text = value;

            }
        }
        [Category("UserProperty"), Description("MeterName")]
        public string MeterName
        {
            get
            {
                return this.label8.Text;
            }
            set
            {
                this.label8.Text = value;

            }
        }
        [Category("UserProperty"), Description("Angle")]
        public string Angle
        {   
            get
            {
                return angleVal;
            }
            set
            {   //1눈금당 10도이다.
                angleVal = value;
                pictureBox2.Image = RotateImage(pin_image, new PointF(pin_image.Width / 2, pin_image.Height / 2), Convert.ToInt32(angleVal));
            }
        }
      

        public UserControl1()
        {
            InitializeComponent();
            pictureBox1.BackColor=Color.Transparent;
            pictureBox2.BackColor=Color.Transparent;
            pictureBox2.Parent = pictureBox1;

            label1.BackColor=Color.Transparent;
            label1.Parent = pictureBox1;

            label2.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;

            label3.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;

            label4.BackColor = Color.Transparent;
            label4.Parent = pictureBox1;

            label5.BackColor = Color.Transparent;
            label5.Parent = pictureBox1;
            label6.BackColor = Color.Transparent;
            label6.Parent = pictureBox1;
            label7.BackColor = Color.Transparent;
            label7.Parent = pictureBox1;
            label8.BackColor = Color.Transparent;
            label8.Parent = pictureBox1;

            //Load an image in from a file
            //pin_image = Properties.Resources.pin7;
            //Set our picture box to that image
            //pictureBox2.Image = RotateImage(pin_image, new PointF(pin_image.Width / 2, pin_image.Height / 2), -150);
            //pictureBox2.Image = RotateImage(pin_image, new PointF(pin_image.Width / 2, pin_image.Height / 2), Convert.ToInt32(angleVal));
        }
        // 이미지 회전
        public static Bitmap RotateImage(Image image, PointF offset, float angle)
        {
            if (image == null)
                throw new ArgumentNullException("image");
            //create a new empty bitmap to hold rotated image

            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            //make a graphics object from the empty bitmap
            Graphics g = Graphics.FromImage(rotatedBmp);



            //Put the rotation point in the center of the image
            g.TranslateTransform(offset.X, offset.Y);

            //rotate the image
            g.RotateTransform(angle);
            //move the image back
            g.TranslateTransform(-offset.X, -offset.Y);



            //draw passed in image onto graphics object
            g.DrawImage(image, new PointF(0, 0));

            return rotatedBmp;

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
