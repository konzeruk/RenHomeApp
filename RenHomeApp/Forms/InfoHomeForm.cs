using DTO.Models;
using RenHomeApp.Services;
using System.Windows.Forms;

namespace RenHomeApp.Forms
{
    public partial class InfoHomeForm : Form
    {
        private HomeModel home;
        private List<ReviewModel>? reviews;
        private string userLogin;

        private GeneralService.Review reviewService;

        public InfoHomeForm(HomeModel home, string userLogin)
        {
            InitializeComponent();

            this.home = home;
            this.userLogin = userLogin;
            this.reviewService = new GeneralService.Review();

            InitInfoOfHome();
            InitReviews();
        }

        private void InitInfoOfHome()
        {
            textBoxAddress.Text = $"г. {home.City}, {home.District}";
            textBoxPrice.Text = $"{home.Price} р.";
            textBoxDescription.Text = home.Description;
        }

        private void InitReviews()
        {
            reviews = Task.Run(async () => await reviewService.GetReviewsByIdAsync(home.Id)).Result;

            if (reviewService != null)
            {
                CreateReviews();
                return;
            }

            reviews = new List<ReviewModel>();
        }

        private void CreateReviews()
        {
            if (home.Reservations != null)
            {
                foreach (var review in reviews!)
                {
                    var textBoxReview = new TextBox();

                    textBoxReview.Multiline = true;
                    textBoxReview.ScrollBars = ScrollBars.Vertical;
                    textBoxReview.ReadOnly = true;

                    textBoxReview.Width = 436;
                    textBoxReview.Height = 100;

                    var text = new string[]
                    {
                        $"Пользователь: {review.Login}",
                        $"Оценка: {review.Grade} из 5",
                        "",
                        "Отзыв:",
                        $"{review.Text}"
                    };

                    textBoxReview.Lines = text;

                    reviewLayoutPanel.Controls.Add(textBoxReview);
                }
                this.Refresh();
            }
        }

        private void bAddReview_Click(object sender, EventArgs e)
        {
            var form = new NewReviewForm(home.Id, userLogin, reviewService);

            form.ShowDialog();

            var newReview = form.review;

            if (newReview == null)
                return;

            reviews.Add(newReview);

            reviewLayoutPanel.Controls.Clear();

            CreateReviews();
        }

        private void bReservation_Click(object sender, EventArgs e)
        {
            var form = new ReservationForm(home.Reservations);

            form.ShowDialog();

            var newReservation = form.newReservation;

            if (newReservation == null) 
                return;

            if(home.Reservations == null)
                home.Reservations = new List<ReservationModel>();

            home.Reservations.Add(newReservation);
        }
    }
}
