using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using System.Runtime.InteropServices;
namespace FacialRecognition
{



    public partial class Form1 : Form
    {

         new x Capture();
        Capture grabber;
        Image<Bgr, byte> currentFrame;
        Image<Gray, byte> gray,result,TrainedFace = null;
        // initialize haarcascade
        HaarCascade face;
        //initialize faces and name storage array
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> Lista_nombres = new List<string>();
       int NumLabels,ContTrain=0;
        int t = 0;

        Conexion c = new Conexion();
        public Form1()
        {
            //load cascade file by giving file name
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            
            InitializeComponent();
            try
            {
                //Load of previus trainned faces and labels for each image
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string[] separador = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(separador[0]);//total no. of faces present
                ContTrain = NumLabels;//cont train will add new image to previous 1 i.e if 3 are present new added give it as4
                string LoadFaces;

                for (int tf = 1; tf < NumLabels + 1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    Lista_nombres.Add(separador[tf]);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Train item if its first time");
            }
            //now see go to created folder and test the result
            //done
            //lets arrange this
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
        }

        //btnIniciaCamara
        private void button1_Click(object sender, EventArgs e)
        {
            grabber = new Capture();
            // initialize grabber event
            grabber.QueryFrame();
           // capture video 
            Application.Idle += new EventHandler(FrameGrabber);
            //initalize Frame grabber event
            btnCapturaCara.Visible = true;

        }
        void FrameGrabber(object sender, EventArgs e)
        {

            currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            //convert frame to gray scale
            gray = currentFrame.Convert<Gray, Byte>();
            //now detect face by using classifier
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
face,//name of cascade
1.2,
10,
Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
new Size(20, 20));
            //now check each frame of imagebox containing video and detect face
            foreach (MCvAvgComp f in facesDetected[0])
            {
                //if face found increment t
                t = t + 1;
                //now see result by copying detected face in a frame name as result
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //we convert current frame to gray scale and resize to 100x100
                //now draw rectangle on detected image
                currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);
                
                //now run
            }

            //view currentframe in imported imagebox
            imageBox1.Image = currentFrame;
            //now run application
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

        }


        //btn Capturacara
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            btnIngresaCara.Visible = true;
            //done
            //use image box to show the detected face
            //go to design view and create
            //as we already detect face in previous lecturee and store in result
            //we use that and resize in new gray image
            TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            //now show in imagebox
            imageBox2.Image = TrainedFace;
            //run
            //as you see image detected and resized
            //now we will save image along with its name so

        }



        // btn guardaFace
        private void button3_Click(object sender, EventArgs e)
        {
                 
            ContTrain=ContTrain+1;

            trainingImages.Add(TrainedFace);
            Lista_nombres.Add(textBox1.Text);

           // c.Insertar(textBox1.Text,trainingImages.ToArray.ToString());
            
            //write no. of trained faces to list
            File.WriteAllText("C:\\Face/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");//add library to read/write to input file
            //write labels or data name to file
            string ruta = "";
            for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
            {
               ruta= ("C:\\Face" + i + ".bmp");//sav faces to folder with name face(i)i is no. of face and .bmp extension of detected face image
               File.AppendAllText("C:\\Face/TrainedLabels.txt", Lista_nombres.ToArray()[i - 1] + "%");//save names to text file

                
            }

           // MessageBox.Show("la url es " + "--" + ruta);
            c.Insertar(textBox1.Text, ruta);
            // MessageBox.Show("Image trained and save to database" + trainingImages+ TrainedFace);
            //now load previous images and append new trainining image to it
            //now run
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StartScreen s = new StartScreen();
            s.Show();
            this.Hide();
        }

       
       

       

       
       

       
       

       

        

        
        
       
    }
}
