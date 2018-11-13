using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using Iscav1;
//using Iscav1;

namespace FacialRecognition
{
    public partial class modDeteccion : Form
    {
       //initialize
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        Image<Gray, byte> result = null;
      //  Image<Gray, byte> result, TrainedFace = null;

        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
      //now initialize a list to save recognized names
        List<string> NamePersons = new List<string>();
        string name = null;
        int t, ContTrain, NumLabels;

      //  Conexion c = new Conexion();
        public modDeteccion()
        {
            InitializeComponent();
               face = new HaarCascade("haarcascade_frontalface_default.xml");
               try
               {
                //Load of previus trainned faces and labels for each image
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                //MessageBox.Show(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");

                string[] Labels = Labelsinfo.Split('%');
                   NumLabels = Convert.ToInt16(Labels[0]);
                   ContTrain = NumLabels;
                   string LoadFaces;

                   for (int tf = 1; tf < NumLabels + 1; tf++)
                   {
                       LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    labels.Add(Labels[tf]);//make list string 
                   }
                   //initialize all variable same as previous

               }
               catch (Exception e)
               {
                   MessageBox.Show("no image trained" + e);
               }
        }

        private void Recognizer_Load(object sender, EventArgs e)
        {
            if (label2.Text.Equals('1') )
            {
                this.BackColor = System.Drawing.Color.Lime;
            }
            else
            {
                this.BackColor = System.Drawing.Color.Red;

            }

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnStartRec_Click(object sender, EventArgs e)
        {


            try
            {
                //link it to star form
                //Hi lets start face recognition 
                //import opencv libraries
                //now same start camera and capture face as describe in face detection then go to recognition so
                //Initialize the capture device
                grabber = new Capture();
                grabber.QueryFrame();
                //Initialize the FrameGraber event
                Application.Idle += new EventHandler(FrameGrabber);
                //add frame grabber same in detection lecture
                //copy code
                btnStartRec.Hide();
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message, "No se detecto ninguna Persona");
            }
          
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            modPersona p = new modPersona();
            menuConserje c = new menuConserje();
            if (FacialRecognition.validador.validarDetec == "Persona")
            {
                this.Hide();
            }
            else
            {

                c.Show();
            }

            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        void FrameGrabber(object sender, EventArgs e)
        {

            try
            {

                NamePersons.Add("");
                //now detect no. of faces in scene
                label2.Text = "0";

                //Get the current frame form capture device
                currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //Convert it to Grayscale
                gray = currentFrame.Convert<Gray, Byte>();

                //Face Detector
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
              face,
              1.3,
              10,
              Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
              new Size(20, 20));

                //Action for each element detected
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    DateTime horadetectada = DateTime.Now;
                    t = t + 1;
                    result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                    //draw the face detected in the 0th (gray) channel with blue color
                    currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);
                    //initialize result,t and gray if (trainingImages.ToArray().Length != 0)
                    {
                        //termcriteria against each image to find a match with it perform different iterations
                        MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);
                        //call class by creating object and pass parameters
#pragma warning disable CS0436 // Type conflicts with imported type
#pragma warning disable CS0436 // Type conflicts with imported type
                        EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
#pragma warning restore CS0436 // Type conflicts with imported type
#pragma warning restore CS0436 // Type conflicts with imported type
                         trainingImages.ToArray(),
                             labels.ToArray(),
                             1000,
                             ref termCrit);
                        //next step is to name find for recognize face
                        name = recognizer.Recognize(result);
                        //now show recognized person name so

                        currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));//initalize font for the name captured
                                                                                                                            //c.InsertarHoradetect(name, horadetectada);
                    }
                    NamePersons[t - 1] = name;
                    NamePersons.Add("");
                    //now we will check detected faces multiple or just one in next lecture uptill now we are done with recognition
                    label2.Text = facesDetected[0].Length.ToString();


                    if (label2.Text == "1")
                    {
                        label1.Text = name;
                        label1.Visible = true;
                        if (name != "")
                        {
                            char[] delimiterChars = { '-' };
                            string[] words = name.Split(delimiterChars);
                            for (int i = 0; i < 1; i++)
                            {
                                lblFaceID.Text = words[0];
                                lblNombre.Text = words[1];
                                lblDepto.Text = words[2];
                                label3.Visible = true;
                                label4.Visible = true;
                                label5.Visible = true;
                                lblDepto.Visible = true;
                                lblNombre.Visible = true;
                                lblFaceID.Visible = true;
                                lblHora.Text = horadetectada.ToString();
                                this.BackColor = System.Drawing.Color.Lime;




                            }
                        }
                        else
                        {
                            label1.Text = "Persona no reconocida";
                            this.BackColor = System.Drawing.Color.Red;

                        }
                    }

                    else
                    {
                        label1.Text = "Persona no reconocida";
                        label1.Visible = true;
                        this.BackColor = System.Drawing.Color.White;
                    }

                    //c.InsertarHoradetect(name, horadetectada);
                    // MessageBox.Show(" Te la inserto toda");

                }


                imageBox1.Image = currentFrame;
                //load haarclassifier and previous save image in directory to find match

                //hi now perform face recognitione
                //first of all add eigen class to project
                //i will upload in resource section so you can have it

                //Check that trained faces are present to recognize face
                //Done now run and test your program
                //Done with this now i will upload complete face recognition sdk
                //hope you learn program and enjoyed it

            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message, "No se detecto ninguna Persona");
            }

            

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Iscav1.modPersona p = new Iscav1.modPersona();
            menuConserje c = new menuConserje();
            if (FacialRecognition.validador.validarDetec == "Persona") {

                this.Hide();

            }
            else {

                c.Show();
            }
            
            this.Hide();
        }
       

    }
}
