using DTO.Models;
using RenHomeApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenHomeApp.Forms
{
    public partial class NewReviewForm : Form
    {
        public ReviewModel? review = null;

        private int homeId;
        private string userLogin;

        private GeneralService.Review reviewService;

        public NewReviewForm(int homeId, string userLogin, GeneralService.Review reviewService)
        {
            InitializeComponent();

            this.homeId = homeId;
            this.userLogin = userLogin;
            this.reviewService = reviewService;
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            review = new ReviewModel
            {
                IdHome = homeId,
                Login = userLogin,
                Grade = Convert.ToInt32(numericUpDownGrade.Value),
                Text = textBoxReview.Text
            };

            var response = Task.Run(async () => await reviewService.PostReviewAsync(review)).Result;

            if (!response)
            {
                MessageBox.Show("Случился какой-то сбой: отзыв не был оставлен");
                return;
            }

            Close();
        }

        private void bCancel_Click(object sender, EventArgs e) =>
            Close();
    }
}
