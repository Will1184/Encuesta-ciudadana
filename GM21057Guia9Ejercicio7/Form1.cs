// Guía:#9
// Ejercicio:#7
// Fecha: 06/11/2022
// Autor: BRANDON WILLIAM GOMEZ MONGE
// Carnet: GM21057
// GD: #1
// Instructora: ING. NELLY LISSETTE HENRIQUEZ SANCHEZ

namespace GM21057Guia9Ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        //DECLARACION DE VARIABLES
        private List<int> duis = new List<int>();
        private List<int> alturas = new List<int>();
        private List<int> edades = new List<int>();
        private List<string> nombres = new List<string>();
        private double promAltura = 0, promEdad = 0;
        private string nombreMasComun = null;
        private int cantidadVeces=1;
        private string nombreCom = null;

        //VALIDACIONES Y METODOS
     

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            //DECLARACION DE OBJETO
            Persona p = new Persona();

            //EXCEPCIONES
            try {
                if (RestriccionDui()&&RestriccionDep())
                {
                    QuitarErrorProvider();
                    //ENTRADA DE DATOS
                    Persona persona = new Persona(int.Parse(textBoxDui.Text), int.Parse(textBoxAltura.Text)
                         , int.Parse(textBoxEdad.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxDepartamento.Text);
                    //PROCESO DE DATOS
                    p.AgregarPersona(duis, edades, alturas, persona);
                    nombres.Add(persona.Nombre);
                    NombreMasComun(persona.Nombre);
                    promAltura = p.PromedioAltura(promAltura, alturas, persona);
                    promEdad = p.PromedioEdades(promEdad, edades, persona);
                    borrar();
                    
                }
               
            }
            catch (FormatException)
            {
                MessageBox.Show("Ha ocurrido un Error en la introduccion de datos", "Error");
                errorProvider1.SetError(textBoxDui, "INGRESE VALORES NUMERICOS");
                errorProvider1.SetError(textBoxEdad, "INGRESE VALORES NUMERICOS");
                errorProvider1.SetError(textBoxAltura, "INGRESE VALORES NUMERICOS");
                Validaciones();
            }

        }
        private void Validaciones()
        {

            if (textBoxNombre.Text == string.Empty)
            {
                errorProvider1.SetError(textBoxNombre, "INGRESE DATOS");

            }
            if (textBoxApellido.Text == string.Empty)
            {
                errorProvider1.SetError(textBoxApellido, "INGRESE DATOS");

            }
            if (textBoxDepartamento.Text == string.Empty)
            {
                errorProvider1.SetError(textBoxDepartamento, "INGRESE DATOS");

            }
            if (textBoxDui.Text == string.Empty)
            {
                errorProvider2.SetError(textBoxDui, "INGRESE DATOS");

            }
            if (textBoxAltura.Text == string.Empty)
            {
                errorProvider2.SetError(textBoxAltura, "INGRESE DATOS");

            }
            if (textBoxEdad.Text == string.Empty)
            {
                errorProvider2.SetError(textBoxEdad, "INGRESE DATOS");

            }

        }
        private void borrar()
        {
            textBoxDui.Clear();
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxAltura.Clear();
            textBoxDepartamento.Clear();
            textBoxEdad.Clear();
        }
        public Boolean RestriccionDui()
        {
            Boolean restDui = true;
            for (int i = 0; i < duis.Count; i++)
            {

                if (duis[i] == int.Parse(textBoxDui.Text))
                {
                    restDui = false;
                    MessageBox.Show("El DUI YA HA SIDO INGRESADO, POR FAVOR INTENTE DE NUEVO", "PROCESO INVALIDO");
                }

            }
            return restDui;
        }
        public Boolean RestriccionDep()
        {
            Boolean restDep;
            if (textBoxDepartamento.Text.ToLower() == "santa ana" || textBoxDepartamento.Text.ToLower() == "ahuachapan"
                  || textBoxDepartamento.Text.ToLower() == "sonsonate" || textBoxDepartamento.Text.ToLower() == "chalatenango"
                  || textBoxDepartamento.Text.ToLower() == "la libertad" || textBoxDepartamento.Text.ToLower() == "san salvador"
                  || textBoxDepartamento.Text.ToLower() == "cuscatlan" || textBoxDepartamento.Text.ToLower() == "la paz"
                  || textBoxDepartamento.Text.ToLower() == "cabañas" || textBoxDepartamento.Text.ToLower() == "san vicente"
                  || textBoxDepartamento.Text.ToLower() == "san miguel" || textBoxDepartamento.Text.ToLower() == "usulutan"
                  || textBoxDepartamento.Text.ToLower() == "morazan" || textBoxDepartamento.Text.ToLower() == "la union")
            {

                restDep = true;
            }
            else
            {
                errorProvider2.SetError(textBoxDepartamento, "INGRESE UN DEPARTAMENTO EXISTENTE");
                restDep = false;
            }
            return restDep;
        }
        private void NombreMasComun(string nombre)
        {
            for (int i = 0; i < nombres.Count; i++)
            {
                int cantVeces = 0;
                if (nombre.ToLower() == nombres[i].ToLower())
                {
                    nombreCom = nombres[i];
                    cantVeces++;
                    if (cantVeces >= cantidadVeces)
                    {
                        cantidadVeces = cantVeces;
                        nombreMasComun = nombreCom;
                    }
                }

            }

        }
        private void QuitarErrorProvider()
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
        }
        //SALIR DEL PROGRAMA
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        //SALIDA DE DATOS
        private void buttonResumen_Click(object sender, EventArgs e)
        {
            if (nombreMasComun == null)
            {
                nombreMasComun = "None";
            }
            Form2 form2 = new Form2(promAltura,promEdad,nombreMasComun);
            form2.ShowDialog                                ();
        }

    }
}