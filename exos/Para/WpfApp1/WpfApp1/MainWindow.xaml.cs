using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.KeyDown += MainWindow_KeyDown; // Abonnez-vous à l'événement KeyDown de la fenêtre.

            MainWindow_KeyDown();
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            double step = 30;

            switch (e.Key)
            {
                case Key.A:
                    Player.Margin = new Thickness(Player.Margin.Left - step, Player.Margin.Top, Player.Margin.Right, Player.Margin.Bottom);
                    break;
                case Key.D:
                    Player.Margin = new Thickness(Player.Margin.Left + step, Player.Margin.Top, Player.Margin.Right, Player.Margin.Bottom);
                    break;
                case Key.W:
                    Player.Margin = new Thickness(Player.Margin.Left, Player.Margin.Top - step, Player.Margin.Right, Player.Margin.Bottom);
                    break;
                case Key.S:
                    Player.Margin = new Thickness(Player.Margin.Left, Player.Margin.Top + step, Player.Margin.Right, Player.Margin.Bottom);
                    break;
            }
        }
    }
}
