using DTO.Models;
using Microsoft.VisualBasic.Logging;
using RenHomeApp.Forms;
using RenHomeApp.Services;

namespace RenHomeApp
{
    public partial class RentalHomeForm : Form
    {
        private List<HomeModel>? homes;
        private UserModelResponse? user;
        private GeneralService.Home homeService;

        public RentalHomeForm()
        {
            InitializeComponent();

            Auth();

            homeService = new GeneralService.Home();

            InitListHomes();

            CreatePanelsWithInfo();
        }

        private void Auth()
        {
            var form = new AuthorizationForm();

            Visible = false;

            form.ShowDialog();

            user = form.user;

            if (user == null)
                Environment.Exit(0);

            Visible = true;
        }

        private void InitListHomes()
        {
            UpdateHomes();

            if (homes == null)
            {
                MessageBox.Show("Варианты жилья отсутствуют");

                Close();
            }
        }

        private void UpdateHomes() =>
            homes = Task.Run(async () => await homeService.GetAllHomesAsync()).Result;

        private void CreatePanelsWithInfo()
        {
            for (var it = 0; it < homes.Count; ++it)
            {
                var panel = new Panel();

                panel.Width = 790;
                panel.Height = 100;

                panel.Paint += Panel_Paint; ;
                panel.DoubleClick += Panel_DoubleClick;

                panel.Name = $"{it}";

                mainLayoutPanel.Controls.Add(panel);
            }
        }

        private void Panel_Paint(object? sender, PaintEventArgs e)
        {
            var rectangle = new Rectangle(0, 0, 780, 90);
            e.Graphics.DrawRectangle(new Pen(Color.Black, 1), rectangle);

            var currentHome = Convert.ToInt32((sender as Panel)!.Name);

            var home = homes[currentHome];

            var text = $"Город: {home.City}\n\n" +
                $"Адрес: {home.District}\n\n" +
                $"Цена за ночь: {home.Price}";

            e.Graphics.DrawString(text, Font, Brushes.Black, rectangle);
        }

        private void Panel_DoubleClick(object? sender, EventArgs e)
        {
            UpdateHomes();

            var currentHome = Convert.ToInt32((sender as Panel)!.Name);

            var form = new InfoHomeForm(homes[currentHome], user!.Login);

            Visible = false;
            
            form.ShowDialog();

            Visible = true;
        }
    }
}
