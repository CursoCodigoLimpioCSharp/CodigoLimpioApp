using System.Collections.Generic;
using System.Windows.Forms;

namespace Cap1.TipeoApp
{
    public partial class Form1 : Form
    {
        // UPPER_CASE_SNAKE_CASE nombre de la constante
        private const string MENSAJE_SALIDA_PROGRAMA = "El programa se cerrará";

        // PascalCase nombre de la propiedad
        public int ElementosEnGrid { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, System.EventArgs e)
        {
            // camelCase en variable
            var dataSource = ObtenerElementosParaGridPrincipal();

            ElementosEnGrid = dataSource.Count;

            // Hungarian notation nombre del elemento DataGridView (grd)
            grdPrincipal.AutoGenerateColumns = true;
            grdPrincipal.DataSource = dataSource;
        }

        // PascalCase nombre del método
        private List<DataGridElement> ObtenerElementosParaGridPrincipal()
        {
            return new List<DataGridElement>
            {
                new DataGridElement("Elemento 1"),
                new DataGridElement("Elemento 2"),
                new DataGridElement("Elemento 3")
            };
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(MENSAJE_SALIDA_PROGRAMA);
            Close();
        }
    }

    // PascalCase nombre de la clase
    public class DataGridElement
    {
        public string Element { get; set; }

        // camelCase en el parametro
        public DataGridElement(string element)
        {
            Element = element;
        }
    }
}