namespace Tarea3
{
    public partial class Form1 : Form
    {
        private Label? lblFigura;
        private ComboBox? cmbFiguras;
        private Label? lblCalculo;
        private ComboBox? cmbCalculos;
        private Label? lblAltura;
        private TextBox? txtAltura;
        private Label? lblResultado;
        private TextBox? txtResultado;
        private Button? btnCalcular;

        //
        private Label? lblAnchura;
        private TextBox? txtAnchura;
        private Label? lblLado1;
        private TextBox? txtLado1;

        public Form1()
        {
            InitializeComponent();
            InicializarComponentes();

        }
        private void InicializarComponentes()
        {
            // Tamaño de la ventana
            this.Size = new Size(300, 350);

            //Etiqueta Figura
            lblFigura = new Label();
            lblFigura.Text = "Figura";
            lblFigura.AutoSize = true;
            lblFigura.Location = new Point(10, 10);

            //ComboBox Figuras
            cmbFiguras = new ComboBox();
            cmbFiguras.Items.Add("Selecciona figura");
            cmbFiguras.Items.Add("Cuadrado");

            //Implementando lo pedido
            cmbFiguras.Items.Add("Triangulo");
            cmbFiguras.Items.Add("Rectangulo");
            //Aqui termina lo implementado

            cmbFiguras.SelectedIndex = 0;
            cmbFiguras.Location = new Point(10, 40);
            cmbFiguras.SelectedValueChanged += new EventHandler(cmb_ValueChanged);

            //Etiqueta Calculo
            lblCalculo = new Label();
            lblCalculo.Text = "Cálculo";
            lblCalculo.AutoSize = true;
            lblCalculo.Location = new Point(150, 10);

            //ComboBox Calculos
            cmbCalculos = new ComboBox();
            cmbCalculos.Items.Add("Selecciona calculo");
            cmbCalculos.Items.Add("Périmetro");
            cmbCalculos.Items.Add("Área");
            cmbCalculos.SelectedIndex = 0;
            cmbCalculos.Location = new Point(150, 40);
            cmbCalculos.SelectedValueChanged += new EventHandler(cmb_ValueChanged);

            //Aqui

            //Etiqueta Anchura
            lblAnchura = new Label();
            lblAnchura.Text = "Anchura";
            lblAnchura.AutoSize = true;
            lblAnchura.Location = new Point(10, 100);
            lblAnchura.Visible = false;

            //TextBox Anchura
            txtAnchura = new TextBox();
            txtAnchura.Size = new Size(100, 20);
            txtAnchura.Location = new Point(65, 100);
            txtAnchura.Visible = false;

            //Etiqueta Lado 3
            lblLado1 = new Label();
            lblLado1.Text = "Lado 3";
            lblLado1.AutoSize = true;
            lblLado1.Location = new Point(10, 120);
            lblLado1.Visible = false;
            //TextBox Lado 3
            txtLado1 = new TextBox();
            txtLado1.Size = new Size(100, 20);
            txtLado1.Location = new Point(65, 120);
            txtLado1.Visible = false;

            //

            //Etiqueta Altura
            lblAltura = new Label();
            lblAltura.Text = "Altura";
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(10, 80);
            lblAltura.Visible = false;

            //TextBox Altura
            txtAltura = new TextBox();
            txtAltura.Size = new Size(100, 20);
            txtAltura.Location = new Point(65, 75);
            txtAltura.Visible = false;

            //Etiqueta Altura
            lblResultado = new Label();
            lblResultado.Text = "Resultado";
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(10, 280);

            //TextBox Prueba
            txtResultado = new TextBox();
            txtResultado.Size = new Size(100, 20);
            txtResultado.Location = new Point(70, 275);

            //Boton Calcular
            btnCalcular = new Button();
            btnCalcular.Text = "Calcular";
            btnCalcular.AutoSize = true;
            btnCalcular.Location = new Point(200, 200);
            btnCalcular.Click += new EventHandler(btnCalcular_Click);

            //Agregar controles a la ventana
            this.Controls.Add(lblFigura);
            this.Controls.Add(cmbFiguras);
            this.Controls.Add(lblCalculo);
            this.Controls.Add(cmbCalculos);
            this.Controls.Add(lblAltura);
            this.Controls.Add(txtAltura);
            this.Controls.Add(lblResultado);
            this.Controls.Add(txtResultado);
            this.Controls.Add(btnCalcular);

            //
            this.Controls.Add(lblAnchura);
            this.Controls.Add(txtAnchura);
            this.Controls.Add(lblLado1);
            this.Controls.Add(txtLado1);

        }
        private void cmb_ValueChanged(object sender, EventArgs e)
        {
            if (cmbCalculos.SelectedIndex != 0 && cmbFiguras.SelectedIndex != 0)
            {
                if (cmbFiguras.SelectedItem.ToString() == "Cuadrado")
                {
                    //cmbFigura.SelectedIndex==1
                    if (cmbCalculos.SelectedItem.ToString() == "Périmetro")
                    {
                        txtAltura.Visible = true;
                        lblAltura.Visible = true;
                    }
                    if (cmbCalculos.SelectedItem.ToString() == "Área")
                    {
                        txtAltura.Visible = true;
                        lblAltura.Visible = true;
                    }
                }
                if (cmbFiguras.SelectedItem.ToString() == "Triangulo")
                {
                    if (cmbCalculos.SelectedItem.ToString() == "Périmetro")
                    {
                        txtAltura.Visible = true; //Altura (Lado 1)
                        lblAltura.Visible = true;
                        txtAnchura.Visible = true; //Base (Lado 2)
                        lblAnchura.Visible = true;
                        txtLado1.Visible = true; //Lado 3
                        lblLado1.Visible = true;
                    }
                    if (cmbCalculos.SelectedItem.ToString() == "Área")
                    {
                        txtAltura.Visible = true; //Altura
                        lblAltura.Visible = true;
                        txtAnchura.Visible = true; //Base
                        lblAnchura.Visible = true;
                    }
                }
                if (cmbFiguras.SelectedItem.ToString() == "Rectangulo")
                {
                    if (cmbCalculos.SelectedItem.ToString() == "Périmetro")
                    {
                        txtAltura.Visible = true; //Lado 1
                        lblAltura.Visible = true;
                        txtAnchura.Visible = true; //Lado 2 
                        lblAnchura.Visible = true;
                    }
                    if (cmbCalculos.SelectedItem.ToString() == "Área")
                    {
                        txtAltura.Visible = true; //Altura
                        lblAltura.Visible = true;
                        txtAnchura.Visible = true; //Base
                        lblAnchura.Visible = true;
                    }
                }
            }
            else
            {
                txtAltura.Visible = false;
                lblAltura.Visible = false;
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string calculo = cmbCalculos.SelectedItem.ToString();
            string figura = cmbFiguras.SelectedItem.ToString();
            if (txtAltura.Text != "")
            {
                if (figura == "Cuadrado")
                {
                    if (calculo == "Périmetro")
                    {
                        int altura = Convert.ToInt32(txtAltura.Text);
                        txtResultado.Text = (altura * 4).ToString();
                    }
                    if (calculo == "Área")
                    {
                        int altura = Convert.ToInt32(txtAltura.Text);
                        txtResultado.Text = (altura * altura).ToString();
                    }
                }
                if (figura == "Triangulo")
                {
                    if (calculo == "Périmetro")
                    {
                        int lado1 = Convert.ToInt32(txtAnchura.Text);
                        int lado2 = Convert.ToInt32(txtAltura.Text);
                        int lado3 = Convert.ToInt32(txtLado1.Text);
                        int total = lado1 + lado2 + lado3;
                        txtResultado.Text = total.ToString();
                    }
                    if (calculo == "Área")
                    {
                        int base1 = Convert.ToInt32(txtAnchura.Text);
                        int altura = Convert.ToInt32(txtAltura.Text);
                        float total = base1 * altura;
                        txtResultado.Text = (total/2).ToString();
                    }
                }
                if (figura == "Rectangulo")
                {
                    if (calculo == "Périmetro")
                    {
                        int base1 = Convert.ToInt32(txtAnchura.Text);
                        int altura = Convert.ToInt32(txtAltura.Text);
                        int total = ((base1 + altura) * 2);
                        txtResultado.Text = total.ToString();
                    }
                    if (calculo == "Área")
                    {
                        int base1 = Convert.ToInt32(txtAnchura.Text);
                        int altura = Convert.ToInt32(txtAltura.Text);
                        float total = base1 * altura;
                        txtResultado.Text = total.ToString();
                    }
                }
            }
        }
    }
}