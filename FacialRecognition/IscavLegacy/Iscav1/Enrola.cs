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
using FacialRecognition;




namespace Iscav1
{
    public partial class Enrola : Form
    {

        Capture grabber;
        Image<Bgr, byte> corriendoFrames;
        Image<Gray, byte> gray, result, CaraCapturada = null;
        // initialize haarcascade
        HaarCascade face;
        //initialize faces and name storage array
        List<Image<Gray, byte>> listaImagenes = new List<Image<Gray, byte>>();
        List<string> lista = new List<string>();
        int Cantnombres, Contador = 0;
        int t = 0;

        public Enrola()
        {
            face = new HaarCascade("haarcascade_frontalface_default.xml");

            InitializeComponent();


            try
            {
                //Load of previus trainned faces and labels for each image
                string Labelsinfo = File.ReadAllText("C:\\Face/Caras.txt");
                string[] Lista = Labelsinfo.Split('%');
                Cantnombres = Convert.ToInt16(Lista[0]);//total no. of faces present
                Contador = Cantnombres;//cont train will add new image to previous 1 i.e if 3 are present new added give it as4
                string LoadFaces;

                for (int tf = 1; tf < Cantnombres + 1; tf++)
                {
                    MessageBox.Show(txtNombre.Text);
                    LoadFaces = txtNombre.Text + tf + ".bmp";
                    listaImagenes.Add(new Image<Gray, byte>("C:\\Face" + LoadFaces));
                    lista.Add(Lista[tf]);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Esta es la primera imagen " + "" + e);
            }
            //now see go to created folder and test the result
            //done
            //lets arrange this
        }

        private void Enrola_Load(object sender, EventArgs e)
        {

        }
        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            grabber = new Capture();
            // initialize grabber event
            grabber.QueryFrame();
            // capture video 
            Application.Idle += new EventHandler(FrameGrabber);
            //initalize Frame grabber event
            btn_capturar.Visible = true;
        }

        void FrameGrabber(object sender, EventArgs e)
        {

            corriendoFrames = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            //convert frame to gray scale
            gray = corriendoFrames.Convert<Gray, Byte>();
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
                result = corriendoFrames.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //we convert current frame to gray scale and resize to 100x100
                //now draw rectangle on detected image
                corriendoFrames.Draw(f.rect, new Bgr(Color.Red), 2);

                //now run
            }

            //view currentframe in imported imagebox
            imageBox1.Image = corriendoFrames;
            //now run application
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Enrola.ActiveForm.Close();
        }

        private void btn_capturar_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            txtNombre.Visible = true;
            btn_ingresar.Visible = true;
            //done
            //use image box to show the detected face
            //go to design view and create
            //as we already detect face in previous lecturee and store in result
            //we use that and resize in new gray image
            CaraCapturada = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            //now show in imagebox
            imageBox2.Image = CaraCapturada;
            //run
            //as you see image detected and resized
            //now we will save image along with its name so
        }

        public void limpiar()
        {
            txtNombre.Text = "";
        }

        private void btnDetectar_Click(object sender, EventArgs e)
        {
            //grabber = new Capture();
            //grabber.QueryFrame();
            ////Initialize the FrameGraber event
            //Application.Idle += new EventHandler(FrameGrabber2);
        }

        private bool IsNumeric(String num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;

            }
            catch (Exception)
            {
                return false;

            }
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {


            if (txtNombre.Text == "")
            {
                MessageBox.Show(" ingresar un nombre ");
            }
            else
            {


                // c.Insertar(textBox1.Text,trainingImages.ToArray.ToString());

                //write no. of trained faces to list
                //write labels or data name to file
                string ruta = "";
                for (int i = 1; i < listaImagenes.ToArray().Length + 1; i++)
                {

                    Contador = Contador + 1;

                    listaImagenes.Add(CaraCapturada);
                    lista.Add(txtNombre.Text);


                    File.WriteAllText("C:\\Face/Caras.txt", listaImagenes.ToArray().Length.ToString() + "%");//add library to read/write to input file

                    listaImagenes.ToArray()[i - 1].Save("C:\\Face/" + i + ".bmp"); //Guarda la imagen //buscar por rut
                    File.AppendAllText("C:\\Face/Caras.txt", lista.ToArray()[i - 1] + "%");//save names to text file
                    ruta = ("C:\\Face/" + i + ".bmp");//guardo la ruta




                }


                AccesoLogica negocio = new AccesoLogica();
                string nombre = txtNombre.Text;
                int resultado = negocio.InsertEnrola(nombre, ruta);

                MessageBox.Show(" Insertado con exito la url es " + "--" + ruta);
                //c.Insertar(txtNombre.Text, ruta);
                // MessageBox.Show("Image trained and save to database" + trainingImages+ TrainedFace);
                //now load previous images and append new trainining image to it
                //now run
            }



        }

        public void consigueNombre()
        {
            string nom = "";

            nom = txtNombre.Text;
        }


        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);

        private void btnStop_Click(object sender, EventArgs e)
        {
            grabber.Dispose();
            //Application.Idle += new EventHandler(FrameGrabber);

        }

        //now initialize a list to save recognized names
        //List<string> NamePersons = new List<string>();
        //string name = null;



        //void FrameGrabber2(object sender, EventArgs e)
        //{

        //    AccesoLogica negocio = new AccesoLogica();
        //    Contador = negocio.ValidaEnrola(); // valida la cantidad de usuarios que existe

        //    string faceurl = "";
        //    string url = Negocio.AccesoLogica.ObtenerUrl(faceurl).ToString(); // valida faceurl de la BD

        //    NamePersons.Add("");
        //    //now detect no. of faces in scene
        //    label2.Text = "0";

        //    //Get the current frame form capture device
        //    corriendoFrames = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

        //    //Convert it to Grayscale
        //    gray = corriendoFrames.Convert<Gray, Byte>();

        //    //Face Detector
        //    MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
        //  face,
        //  1.3,
        //  10,
        //  Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
        //  new Size(20, 20));

        //    //Action for each element detected
        //    foreach (MCvAvgComp f in facesDetected[0])
        //    {
        //        t = t + 1;
        //        result = corriendoFrames.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
        //        //draw the face detected in the 0th (gray) channel with blue color
        //        corriendoFrames.Draw(f.rect, new Bgr(Color.Red), 2);
        //        //initialize result,t and gray if (trainingImages.ToArray().Length != 0)
        //        {
        //            //termcriteria against each image to find a match with it perform different iterations
        //            MCvTermCriteria termCrit = new MCvTermCriteria(Contador, 0.001);
        //            //call class by creating object and pass parameters
        //            ReconocimientoObjetos reconocimiento = new ReconocimientoObjetos(
        //                 listaImagenes.ToArray(),
        //                 lista.ToArray(),
        //                 1000,
        //                 ref termCrit);
        //            //next step is to name find for recognize face
        //            name = reconocimiento.Reconocerte(result);
        //            //now show recognized person name so
        //            corriendoFrames.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));//initalize font for the name captured

        //        }
        //        NamePersons[t - 1] = name;
        //        NamePersons.Add("");
        //        //now we will check detected faces multiple or just one in next lecture uptill now we are done with recognition
        //        label2.Text = facesDetected[0].Length.ToString();
        //    }
        //    imageBox3.Image = corriendoFrames;
        //    //load haarclassifier and previous save image in directory to find match

        //    //hi now perform face recognitione
        //    //first of all add eigen class to project
        //    //i will upload in resource section so you can have it

        //    //Check that trained faces are present to recognize face
        //    //Done now run and test your program
        //    //Done with this now i will upload complete face recognition sdk
        //    //hope you learn program and enjoyed it
        //    MessageBox.Show("existen esta cantidad de personas"+Contador);
        //    MessageBox.Show("esta es la url" + url);
        //}





    }
}
