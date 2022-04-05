using System;
using System.Drawing;
using System.Windows.Forms;
using System.Speech.Synthesis;





namespace EjecucionClase_LeonardoLoza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCantidad.Text = tbCantidad.Value.ToString();


        }

  




        private void tbCantidad_Scroll(object sender, EventArgs e)
        {
            lblCantidad.Text = tbCantidad.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //crear las cajas

            byte cantidadDeCajas = Convert.ToByte(tbCantidad.Value);
            //convierte bit por bit a un byte

            byte cantidadDeCajas2 = (byte)tbCantidad.Value;
            //agarra el valor y lo maquilla para que sea un byte pero no hay una conversión como tal
            //sigue funcionando como byte

            for (int i = 1; i <= tbCantidad.Value; i++)
            {
                //Crear cajas de texto

                //el txtcontrol es un objeto, y si vuelve a entrar al for vuelve a crear uno,
                //cada uno es totalmente independiente
                TextBox txtControl = new TextBox();
                //los contoles del cuadro de herramienta vienen de una clase

                txtControl.Name = "txt" + " "+ i.ToString();
                //le cambio el nombre a la caja de texto para que no se llamen igual
                txtControl.Tag = i;
                txtControl.Size = new Size(60, 15);
                txtControl.Location = new Point(ClientSize.Width/2, 30 *( i+1));
                //pone una caja que baja cada 30 pixeles 
                txtControl.Text = txtControl.Name + " "+ i.ToString(); //le asigno adentro un nombre a cada objeto creado
                //concateno valores (es decir, me dice que caja es

                this.Controls.Add(txtControl);

                //Asociarlo a un evento al método txtClic (se activa el método txtClic cuando
                //de un clic a uno de los controles, es decir,una caja de texto)
                txtControl.Click += new EventHandler(txtClic);
                //cuando de click a un control se va a traer 
            }

        }


        //metodo para usar las cajas, 
        public void txtClic(object sender, EventArgs e)
        //en el método checa si es un textbox,
        {

            string speech = string.Format("El nombre del control es:" + ((TextBox)sender).Name.ToString());
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
          

            while (true)
            {
                speechSynthesizer.Speak(speech);
            }
            //busca con el sender el tipo de elemento para que se traiga el tag
            //MessageBox.Show("Control:" + ((TextBox)sender).Tag.ToString());
            //object sender me permite traer la información en específico del control que tiene el foco
            //es decir, que solo va a buscar los objetos tipo textbox y me va a enviar la propiedad tag,
            //pero no guarda nada
            //el sender solo se trae la info del objeto que trae el foco
            //y que sea de tipo textbox

            //va a buscar objetos de tipo textbox y se va a traer el tag de ellos


        }
    }
}
