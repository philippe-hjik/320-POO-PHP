using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        Label monLabel = new Label();
        Random random = new Random();

        public void button1_Click(object sender, EventArgs e)
        {
            string texteAAfficher = "Le texte que vous voulez afficher.";
            // Personnalisez le label
            monLabel.Location = new Point(random.Next(0,600), random.Next(0, 500)); // Position du label
            monLabel.Size = new Size(200, 30); // Taille du label
            monLabel.Text = texteAAfficher;

            // Ajoutez le label au formulaire
            this.Controls.Add(monLabel);
        }
    }
}
