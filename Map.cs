using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Map
{
    public partial class Map : Form
    {

        private List<PointLatLng> points;
        private Dictionary<PointLatLng, string> data;
        private List<PointLatLng> dataP;
        private List<Bitmap> TransportList;
        private bool restore = false;
        double latInitial;
        double lonInitial;


        public Map()
        {
            InitializeComponent();
            points = new List<PointLatLng>();
            data = new Dictionary<PointLatLng, string>();
            dataP = new List<PointLatLng>();
            TransportList = new List<Bitmap>();

            TransportList.Add((Bitmap)Image.FromFile(@"D:\images\train.png"));
            TransportList.Add((Bitmap)Image.FromFile(@"D:\images\car.png"));
            TransportList.Add((Bitmap)Image.FromFile(@"D:\bus.png"));
            TransportList.Add((Bitmap)Image.FromFile(@"D:\moto.png"));


            dataP.Add(new PointLatLng(47.79, 22.86));
            dataP.Add(new PointLatLng(47.12, 24.48));
            dataP.Add(new PointLatLng(46.92, 26.38));
            dataP.Add(new PointLatLng(46.53, 24.56));
            dataP.Add(new PointLatLng(45.69, 27.18));
            dataP.Add(new PointLatLng(45.44, 28.03));
            dataP.Add(new PointLatLng(45.85, 22.91));
            dataP.Add(new PointLatLng(45.75, 21.20));

            dataP.Add(new PointLatLng(47.67, 26.28));
            dataP.Add(new PointLatLng(46.63, 27.72));
            dataP.Add(new PointLatLng(47.16, 27.57));
            dataP.Add(new PointLatLng(45.86, 25.79));
            dataP.Add(new PointLatLng(46.36, 25.79));
            dataP.Add(new PointLatLng(46.06, 23.57));
            dataP.Add(new PointLatLng(45.79, 24.14));


            dataP.Add(new PointLatLng(45.64, 25.59));
            dataP.Add(new PointLatLng(45.10, 24.37));
            dataP.Add(new PointLatLng(44.31, 23.79));
            dataP.Add(new PointLatLng(44.43, 26.11));
            dataP.Add(new PointLatLng(44.86, 24.87));
            dataP.Add(new PointLatLng(44.94, 26.02));
            dataP.Add(new PointLatLng(44.17, 28.63));
            dataP.Add(new PointLatLng(45.17, 28.79));

            dataP.Add(new PointLatLng(45.15, 26.82));
            dataP.Add(new PointLatLng(44.56, 27.36));
            dataP.Add(new PointLatLng(46.57, 26.90));

            dataP.Add(new PointLatLng(47.06, 21.93));
            dataP.Add(new PointLatLng(46.78, 23.62));
            dataP.Add(new PointLatLng(46.18, 21.31));
            dataP.Add(new PointLatLng(45.03, 23.27));
            dataP.Add(new PointLatLng(45.42, 22.22));

            dataP.Add(new PointLatLng(47.34, 25.36)); 
            dataP.Add(new PointLatLng(47.65, 23.57)); 
            dataP.Add(new PointLatLng(47.20, 23.05)); 
            dataP.Add(new PointLatLng(44.63, 22.65)); 
            dataP.Add(new PointLatLng(44.42, 24.37)); 

            dataP.Add(new PointLatLng(44.92, 25.46)); 
            dataP.Add(new PointLatLng(45.32, 25.56)); 
            dataP.Add(new PointLatLng(43.81, 28.58)); 
            dataP.Add(new PointLatLng(45.27, 27.97)); 
            dataP.Add(new PointLatLng(46.25, 26.77)); 

            dataP.Add(new PointLatLng(47.74, 26.66)); 
            dataP.Add(new PointLatLng(47.84, 25.92)); 
            dataP.Add(new PointLatLng(47.92, 23.90)); 

            dataP.Add(new PointLatLng(44.19, 27.33)); 

            dataP.Add(new PointLatLng(45.76, 22.90)); 
            dataP.Add(new PointLatLng(46.22, 24.79)); 
            dataP.Add(new PointLatLng(46.22, 27.66)); 

        }

        private void Map_Load(object sender, EventArgs e)
        {
            
            WindowState = FormWindowState.Maximized;
            
            GMapProviders.GoogleMap.ApiKey = API.Key;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMap.CacheLocation = @"cache";
            gMap.DragButton = MouseButtons.Left;
            gMap.MapProvider = GMapProviders.GoogleMap;
            gMap.ShowCenter = false;
            gMap.CanDragMap = true;
            gMap.MinZoom = 2;
            gMap.MaxZoom = 24;
            gMap.Zoom = 7;
            gMap.AutoScroll = true;


            if (this.DialogResult == DialogResult.Cancel)
            {
                this.Close();
            }

        }

        private void gMap_Load(object sender, EventArgs e)
        {

            ///gMap.Position = new PointLatLng(45.9432, 24.9668);
            gMap.SetPositionByKeywords("Romania");
            generate_data();
            restore = true;

        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            try
            {
                latInitial = Convert.ToDouble(txtLatitudine.Text);
                lonInitial = Convert.ToDouble(txtLongitudine.Text);
                PointLatLng point = new PointLatLng(latInitial, lonInitial);

                LoadMap(point);
                LoadAndMark(point);
                AddMarker(point);
                
                FixElement();
            }catch(Exception)
            {
                MessageBox.Show("Date insuficiente pentru crearea unui marker!");
            }
        }

        private void LoadAndMark(PointLatLng point)
        {
            LoadMap(point);
            AddMarker(point);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        
                if (points.Count()==2)
                {
                    points.Clear();
                    MessageBox.Show("Ati introdus prea multe puncte! Incercati din nou", "Info");
                    txtLatitudine.Text = "";
                    txtLongitudine.Text = "";
                    return;
                }

            try
            {
 
                double lat = Convert.ToDouble(txtLatitudine.Text);
                double lon = Convert.ToDouble(txtLongitudine.Text);

                foreach (var item in data)
                {
                    if ((new PointLatLng(lat, lon) == item.Key))
                    {

                        points.Add(new PointLatLng(Convert.ToDouble(txtLatitudine.Text),
                            Convert.ToDouble(txtLongitudine.Text)));

                        txtLatitudine.Text = "";
                        txtLongitudine.Text = "";
                        
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nu a fost selectat niciun punct!", "Info");
            }          
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            data.Clear();
            points.Clear();
            txtDistance.Text = "";
            
            while (gMap.Overlays.Count > 0)
            {
                gMap.Overlays.RemoveAt(0);
                gMap.Refresh();
               
            }
            restore = false;           
        }

        private void btnGetRoute_Click(object sender, EventArgs e)
        {

            bool err = false;
            gMap.Zoom = 7;
            try
            {

                if (!points[1].Equals(null) && !points[0].Equals(null))
                {
                    var route = GoogleMapProvider.Instance.GetRoute(points[0], points[1], false, false, 9);

                    var r = new GMapRoute(route.Points, "Ruta aleasa")
                    {
                        Stroke = new Pen(Color.DarkBlue, 5)
                    };

                    var routes = new GMapOverlay("rute");

                    routes.Routes.Add(r);
                    gMap.Overlays.Add(routes);


                    double distance = Math.Round(route.Distance,1);
                    txtDistance.Text = distance + " Km";


                    FixElement();

                    

                    foreach (var item in data)
                    {

                        if ((item.Value) == "car" && item.Key == points[0])
                        {
                            double h = (int)(distance / 80);
                            double min = (Math.Round(distance / 80, 2) - (int)Math.Round(distance / 80, 2));

                            min = (int)(min * 60);
                            

                            if (route.Distance < 80)
                            {
                                txtSpeed.Text = Math.Round((distance / 80),0) * 60 + " min";
                            }
                            else
                            {                   
                               
                                txtSpeed.Text = h + " : " + min + " h";
                            }

                        }

                        if ((item.Value) == "bus" && item.Key == points[0])
                        {
                            double h = (int)(distance / 60);
                            double min = (Math.Round(distance / 60, 2) - (int)Math.Round(distance / 60, 2));

                            min = (int)(min * 60);

                            if (route.Distance < 60)
                            {
                                txtSpeed.Text = Math.Round((distance / 60),0) * 60 + " min";
                            }
                            else
                            {                   

                                txtSpeed.Text = h + " : " + min + " h";
                            }

                        }

                        if ((item.Value) == "train" && item.Key == points[0])
                        {
                            double h = (int)(distance / 50);
                            double min = (Math.Round(distance / 50, 2) - (int)Math.Round(distance / 50, 2));



                            min = (int)(min * 60);

                            if (route.Distance < 50)
                            {
                                txtSpeed.Text = Math.Round((distance / 50),0) * 60 + " min";
                            }
                            else
                            {                   

                                txtSpeed.Text = h + " : " + min + " h";
                            }

                        }
                        if ((item.Value) == "moto" && item.Key == points[0])
                        {
                            double h = (int)(distance / 90);
                            double min = (Math.Round(distance / 90, 2) - (int)Math.Round(distance / 90, 2));


                            min = (int)(min * 60);

                            if (route.Distance < 90)
                            {
                                txtSpeed.Text = Math.Round((distance / 90),0) * 60 + " min";
                            }
                            else
                            {                   

                                txtSpeed.Text = h + " : " + min + " h";
                            }

                        }
                    }

                  

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Adresele nu au fost selectate corect!");
                err = true;
            }

            try
            {

                PointLatLng lastPoint = points[1];
                points.Clear();
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Doriti sa continuati traseul?", "Info", buttons);

                if (result == DialogResult.Yes)
                {
                    points.Add(lastPoint);

                    txtLatitudine.Text = "";
                    txtLongitudine.Text = "";
                    //insertFinalPoint();
                }
                else
                {
                    points.Clear();
                }
            }
            catch(Exception)
            {
                if(err==false)
                MessageBox.Show("Data introduse gresit!", "Info");
            }

         
        }

        private void Map_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }
        }


        private void gMap_MouseClick(object sender, MouseEventArgs e)
        {
    
            if (e.Button==MouseButtons.Left)
            {
                var pointMap = gMap.FromLocalToLatLng(e.X,e.Y);
                double lat = pointMap.Lat;
                double lng = pointMap.Lng;

                txtLatitudine.Text = Convert.ToString(lat);
                txtLongitudine.Text = Convert.ToString(lng);

                

            }
        }

        private void FixElement()
        {
            double zoom = gMap.Zoom;
            zoom++;
            gMap.Zoom = zoom;
            zoom--;
            gMap.Zoom = zoom;
        }

        private void LoadMap(PointLatLng point)
        {

            gMap.Position = point;
           

        }

        private void AddMarker(PointLatLng pointToAdd, GMarkerGoogleType markerType = GMarkerGoogleType.arrow)
        {

            GMapOverlay markers = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(pointToAdd, markerType);
            

            markers.Markers.Add(marker);
            gMap.Overlays.Add(markers);
  

        }

        private void AddPictureMarker(PointLatLng pointToAdd, Bitmap bitmap)
        {
            GMapOverlay markers = new GMapOverlay("markers");

            var marker = new GMarkerGoogle(pointToAdd, bitmap);

            marker.ToolTipText = $"\nLat: {pointToAdd.Lat} \nLong: {pointToAdd.Lng}";

            markers.Markers.Add(marker);
            gMap.Overlays.Add(markers); 
        }

        private void btn_cautareP_Click(object sender, EventArgs e)
        {
            gMap.SetPositionByKeywords(txtPlecare.Text);
            gMap.Zoom = 12;
        }

        private void btn_cautareS_Click(object sender, EventArgs e)
        {
            gMap.SetPositionByKeywords(txtSosire.Text);
            gMap.Zoom = 12;
        }

        private void generate_data()
        {

            String[] strings = { "bus", "train", "car", "moto" };
            Random random = new Random();
            String theRanStr = strings[random.Next(strings.Length)]; 

            for (int i=0;i<dataP.Count;i++)
            {
                theRanStr = strings[random.Next(strings.Length)];
                data.Add(dataP[i], theRanStr);
            }

            foreach (var item in data)
            {
        
                if(item.Value=="train")
                {
                   
                    AddPictureMarker(item.Key, TransportList[0]);
                }
                if (item.Value == "car")
                {

                    AddPictureMarker(item.Key, TransportList[1]);
                }
                if (item.Value == "bus")
                {

                    AddPictureMarker(item.Key, TransportList[2]);
                }
                if (item.Value == "moto")
                {

                    AddPictureMarker(item.Key, TransportList[3]);
                }

                //MessageBox.Show(data[item.Key]);

            }


        }

        private void Restore_Click(object sender, EventArgs e)
        {
            if (restore == false)
            {
                data.Clear();
                generate_data();
                FixElement();
                txtSpeed.Text = "";
            }
            restore = true;
        }

    }
}
