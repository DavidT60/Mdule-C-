using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClassCombox
{
    public partial class Form1 : Form
    {
       
        ClassPasser dataProv = new ClassPasser();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){


            GridViewProv.ReadOnly = true;


            //Toma todos los nombre Provincias//
            GridViewProv.DataSource = dataProv.Fill("SELECT Nombreprovincia as Provincias FROM Provincias");


            //Rellenar combobox//
            for (int i = 0; i < GridViewProv.Rows.Count; i++){
                String data = (string)GridViewProv.Rows[i].Cells["Provincias"].Value;
                 if(data != null) comboBoxProvin.Items.Add(data);
            }



            GridViewProv.CurrentCell = null;

        }

        private void comboBoxProvin_SelectedValueChanged(object sender, EventArgs e){


            String d = dataProv.DataId("SELECT codigoprovincia FROM Provincias WHERE Nombreprovincia like"+"'"+comboBoxProvin.SelectedItem+"'"+"; ");
            int id = int.Parse(d.ToString().ToUpper());

            municipios.DataSource = dataProv.Fill("SELECT Nombremunicipio as Municipios FROM Municipios WHERE codigoprovincia= "+ id );

            distritos.DataSource = dataProv.Fill("SELECT Nombredistrito as Distrito FROM Distritos WHERE codigomunicipio= " + id);



            //style DataGridview//
            this.municipios.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.distritos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GridViewProv.CurrentCell = null;



        }
    }
}
