using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Controle;
using Modelos;

namespace GuizzoLtda
{
    public partial class MapaTeste : Form
    {
        int idcliente;
        EmpresaControle usu = new EmpresaControle();
        EmpresaModelo us = new EmpresaModelo();

        private List<PointLatLng> _points;

        public MapaTeste()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }
        GMapOverlay markers = new GMapOverlay("markers");

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(txtLat.Text.Trim().Equals("") && txtLong.Text.Trim().Equals("")))
            {

                double lat = Convert.ToDouble(txtLat.Text);
                double lng = Convert.ToDouble(txtLong.Text);
                MapaBr.Position = new PointLatLng(lat, lng);
                PointLatLng point = new PointLatLng(lat, lng);
                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_pushpin);
                markers.Markers.Add(marker);
                MapaBr.Overlays.Add(markers);
            }
            else
            {
                if (!txtEndereco.Text.Trim().Equals(""))
                {
                    GeoCoderStatusCode statusCode;
                    var pointLatLng = GoogleMapProvider.Instance.GetPoint(txtEndereco.Text.Trim(), out statusCode);

                    if (statusCode == GeoCoderStatusCode.OK)
                    {
                        txtLat.Text = pointLatLng?.Lat.ToString();
                        txtLong.Text = pointLatLng?.Lng.ToString();
                        button1.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong. Returned Status Code:" + statusCode);
                    }
                }

                else
                {
                    MessageBox.Show("Invalid data to load");
                }
            }

        }

        private void MapaTeste_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyAoYjaVsfQLcNYmjyBdRjyqKGjc9YIABLo";
            MapaBr.ShowCenter = false;
            MapaBr.DragButton = MouseButtons.Left;
            MapaBr.MapProvider = GMapProviders.GoogleMap;
            MapaBr.SetPositionByKeywords("Curitiba, Brazil");
            MapaBr.MinZoom = 5;
            MapaBr.MaxZoom = 18;
            MapaBr.Zoom = 10;

        }

        private void btnPara_Click(object sender, EventArgs e)
        {
            _points.Add(new PointLatLng(Convert.ToDouble(txtLat.Text),
                Convert.ToDouble(txtLong.Text)));
            MapaBr.Zoom = 14;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _points.Clear();
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            var route = GoogleMapProvider.Instance
                .GetRoute(_points[0], _points[1], false, false, 10);
            var r = new GMapRoute(route.Points, "My Route");
            var routes = new GMapOverlay("Routes");
            routes.Routes.Add(r);
            MapaBr.Overlays.Add(routes);

            labeldistancia.Text = route.Distance + "Km";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FuncionarioMenu fmenureturn = new FuncionarioMenu(us, idcliente);
            this.Hide();
            fmenureturn.Show();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (MapaBr.Overlays.Count > 0)
            {
                MapaBr.Overlays.RemoveAt(0);
                MapaBr.Refresh();
            }
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            _points.Clear();
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            var route = GoogleMapProvider.Instance.GetRoute(_points[0], _points[1], false, false, 10);
            var r = new GMapRoute(route.Points, "My Route");
            var routes = new GMapOverlay("Routes");
            routes.Routes.Add(r);
            MapaBr.Overlays.Add(routes);
            labeldistancia.Text = route.Distance + "Km";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
          

            _points.Add(new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text)));
            MapaBr.Zoom = 14;
        }
    }
}
