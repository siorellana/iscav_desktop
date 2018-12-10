using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.IO;
using Iscav1;

namespace FacialRecognition
{
    public partial class modEnroll : Form
    {
        Capture grabber;
        Image<Bgr, byte> currentFrame;
        Image<Gray, byte> gray,result,TrainedFace = null;
        // initialize haarcascade
        HaarCascade face;
        //initialize faces and name storage array
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        Random rnd = new Random();
        int NumLabels,ContTrain=0;
        int t = 0;
        String faceid = null;
        String depto = null;
        String tipoPersona = null;
        String nombre = null;
        public modEnroll()

        {
            //load cascade file by giving file name
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            
            InitializeComponent();
            try
            {
                //Load of previus trainned faces and labels for each image
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(Labels[0]);//total no. of faces present
                ContTrain = NumLabels;//cont train will add new image to previous 1 i.e if 3 are present new added give it as4
                string LoadFaces;

                for (int tf = 1; tf < NumLabels + 1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    labels.Add(Labels[tf]);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("No hay personas registradas, ingrese algunas antes de activar la detección." + e);
            }
            //now see go to created folder and test the result
            //done
            //lets arrange this
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbprodDataSet1.tbdepto' Puede moverla o quitarla según sea necesario.
            this.tbdeptoTableAdapter.Fill(this.dbprodDataSet1.tbdepto);

        }

        private void btnStartCam_Click(object sender, EventArgs e)
        {
            grabber = new Capture();
            // initialize grabber event
            grabber.QueryFrame();
           // capture video 
            Application.Idle += new EventHandler(FrameGrabber);
            //initalize Frame grabber event
            btnDetectCam.Visible = true;

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
                currentFrame.Draw(f.rect, new Bgr(Color.Green), 2);
                
                //now run
            }

            //view currentframe in imported imagebox
            imageBox1.Image = currentFrame;
            //now run application
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblFaceID_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            modPersona p = new modPersona();
            SelectMenuCon c = new SelectMenuCon();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDetectCam_Click(object sender, EventArgs e)
        {

            try
            {
                lblNombre.Visible = true;
                boxNombre.Visible = true;
                lblDepto.Visible = true;
                boxDepto.Visible = true;
                btnIngresar.Visible = true;
                lblFaceID.Visible = true;

                //done
                //use image box to show the detected face
                //go to design view and create
                //as we already detect face in previous lecturee and store in result
                //we use that and resize in new gray image
                /*for (int val = 0; val < 1; val++) ;
                { 

                    MessageBox.Show("Espere que se encienda la camara");

                }*/

                TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                //now show in imagebox
                imageBox2.Image = TrainedFace;

                int FaceId = rnd.Next(1000);
                lblFaceID.Text = FaceId.ToString();
                //run
                //as you see image detected and resized
                //now we will save image along with its name so

            }
            catch (System.Exception ex)
            {
            
               lblMensaje.Text = "No se detecto ninguna Persona";
                MessageBox.Show("No se detecto ninguna Persona");

                MessageBox.Show(ex.Message, "No se detecto ninguna Persona");
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ContTrain=ContTrain+1;
            //now save the trained images
            //so we create a folder to save image database
            //Go to yours project debug folder and create folder
            //name it with TrainedFaces or any thing you want
            //in this folder detected faces will be save
            //now we need to save name of specific image as well
            //we will create a text file inside same folder
            //name it as TrainedLabels.txt or any thing you want
            //Done now we will do coding work
            //So save face detected in folder Trainedface created in previous tutorial
            //save name to face from textbox to text file
            //so create list array to save database
            //now load 
            //add images and names to list array
            trainingImages.Add(TrainedFace);
            faceid = lblFaceID.Text;
            depto = boxDepto.Text;
            tipoPersona = cbTipoPerson.Text;
            nombre = boxNombre.Text;
            byte[] arr = null;

            labels.Add(faceid + "-" + boxNombre.Text + "-" + depto + "-" + tipoPersona );
         
            //write no. of trained faces to list
            File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");//add library to read/write to input file
            //write labels or data name to file
            for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
            {
                
                trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");//sav faces to folder with name face(i)i is no. of face and .bmp extension of detected face image
                File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");//save names to text file
                Image fotoGuardada = Image.FromFile(@Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");

                
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(fotoGuardada, typeof(byte[]));

               }
            try
            {
                // Objetos de conexión y comando
                System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True"));
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                // Estableciento propiedades
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO tbpersona VALUES (@faceid, @nombre, @depto, @tipopersona, @fotopersona, @activo)";

                // Creando los parámetros necesarios
                cmd.Parameters.Add("@faceid", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@nombre", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@depto", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@activo", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@tipopersona", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@fotopersona", System.Data.SqlDbType.Image);
                MemoryStream ms = new MemoryStream();
               // imageBox2.Image.Save(ms,"@fotopersona" , System.Drawing.Imaging.ImageFormat.Bmp);
                cmd.Parameters["@fotopersona"].Value = ms.GetBuffer();
                // Asignando los valores a los atributos
                cmd.Parameters["@faceid"].Value = int.Parse(faceid);
                cmd.Parameters["@nombre"].Value = nombre;
                cmd.Parameters["@depto"].Value = int.Parse(depto);
                cmd.Parameters["@tipopersona"].Value = tipoPersona;
                //cmd.Parameters["@fotopersona"].Value = imageBox2;
                cmd.Parameters["@fotopersona"].Value = arr;
                cmd.Parameters["@activo"].Value = "true";

                // Asignando el valor de la imagen
                //// Stream usado como buffer
                //System.IO.MemoryStream ms = new System.IO.MemoryStream();
                //// Se guarda la imagen en el buffer
                //imageBox2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //// Se extraen los bytes del buffer para asignarlos como valor para el 
                //// parámetro.
                //cmd.Parameters["@image"].Value = ms.GetBuffer();

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





            MessageBox.Show("Imagen guardada y persona registrada.");

            lblFaceID.Text = null;
            boxDepto.Text = null;
            boxNombre.Text = null;
            //now load previous images and append new trainining image to it
            //now run
        }

        private void button4_Click(object sender, EventArgs e)
        {
            modPersona p = new modPersona();
            SelectMenuCon c = new SelectMenuCon();
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

       
       

       

       
       

       
       

       

        

        
        
       
    }
}
