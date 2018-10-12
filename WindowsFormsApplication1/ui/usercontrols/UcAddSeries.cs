using Seriendatenbank.data;
using Seriendatenbank.ui.userControls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ui.usercontrols
{
    public partial class UcAddSeries : Template
    {
        private static UcAddSeries instance = null;
        private byte[] picture;

        public static UcAddSeries Instance
        {
            get
            {
                if (instance == null)
                    instance = new UcAddSeries();
                return instance;
            }
        }

        public UcAddSeries()
        {
            InitializeComponent();
        }

        public static void Reset()
        {
            instance = null;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            txt_filename.Text = "";
            picture = null;
            if (opd_file_picker.ShowDialog() == DialogResult.OK)
            {
                txt_filename.Text = opd_file_picker.FileName;
                try
                {
                    picture = File.ReadAllBytes(opd_file_picker.FileName);
                }catch(Exception exception)
                {
                    MessageBox.Show("Fehler: " + exception);
                }  
            }
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_series_name.Text))
                MessageBox.Show("Keinen Seriennamen eingegeben");
            else if (String.IsNullOrWhiteSpace(txt_description.Text))
                MessageBox.Show("Keine Beschreibung eingegeben");
            //else if (String.IsNullOrWhiteSpace(cmb_genre.SelectedText))
            //   MessageBox.Show("Kein Genre ausgewählt");
            else if (String.IsNullOrWhiteSpace(txt_count_seasons.Text))
                MessageBox.Show("Keine Staffelanzahl angegeben");
            else if (picture == null)
                MessageBox.Show("Kein Bild ausgewählt");
            else
            {
                if (dataAccess.AddSeries(txt_series_name.Text, picture, txt_description.Text, null, Int32.Parse(txt_count_seasons.Text)))
                {
                    MessageBox.Show("Erfolg");
                    Notify(this, UcSeries.Instance);
                }
                else
                    MessageBox.Show("Fehler");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Notify(this, UcSeries.Instance);
        }
    }
}