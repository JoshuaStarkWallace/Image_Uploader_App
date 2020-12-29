using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Uploader_App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void image_DetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.image_DetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Image_Details' table. You can move, or remove it, as needed.
            this.image_DetailsTableAdapter.Fill(this.dataSet1.Image_Details);

        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images only. | *.jpg; *.jpeg; *.png; *.gif;";

            DialogResult dr = ofd.ShowDialog();

            imagePictureBox.Image = Image.FromFile(ofd.FileName);

            imagePathLabel1.Text = ofd.FileName;
        }
    }
}
