using EntidadesParcial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRMVIAJES
{
    public partial class FrmEstadisticas : Form
    {
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            BindingSource bs3 = new BindingSource();
            InformarDestinosPorFacturacion(bs);
            InformarAeronavesCantidadDeHorasVoladas(bs3);
            this.lbl_DestinoFavorito.Text = $"Destino Favorito: {Compañia.BuscarDestinoFavorito()}";
            this.lbl_GananciasTotales.Text = $"Totales: {Compañia.InformarGananciaTotalDeLosVuelos()}";
            this.lbl_Cabotaje.Text = $"Cabotajes: {Compañia.InformarGananciaNacionalDeLosVuelos()}";
            this.lbl_Internacional.Text = $"Internacional: {Compañia.InformarGananciaInternacionalDeLosVuelos()}";


        }
        private void InformarDestinosPorFacturacion(BindingSource bs)
        {
            if (Compañia.CargarDiccionarioHistorialDeVuelosPorFacturacion().Count > 0)
            {
                bs.DataSource = Compañia.CargarDiccionarioHistorialDeVuelosPorFacturacion();
                this.dtg_DestinosFacturados.DataSource = bs;
                this.dtg_DestinosFacturados.Visible = true;
            }
            else
            {
                this.dtg_DestinosFacturados.Visible = false;
                this.lbl_EncabezaDestinosFacturados.Text = "No hay vuelos en el historial";
            }
        }
        private void InformarAeronavesCantidadDeHorasVoladas(BindingSource bs3)
        {
            if (Compañia.CargarDiccionarioDeAeronavesPorCantidadDeHorasVoladas().Count > 0)
            {
                bs3.DataSource = Compañia.CargarDiccionarioDeAeronavesPorCantidadDeHorasVoladas();
                this.dtg_Aeronaves.DataSource = bs3;
                this.dtg_Aeronaves.Visible = true;
            }
            else
            {
                this.dtg_Aeronaves.Visible = false;
                this.lbl_EncabezaAeronaves.Text = "No hay aeronaves";
            }
        }
    }
}
