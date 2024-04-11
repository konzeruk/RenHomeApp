using DTO.Entities;
using DTO.Models;

namespace DTO.Extensions
{
    public static class ConvertExtensions
    {
        public static UserModelResponse ToUserModelResponse(this UserEntity user) =>
            new UserModelResponse()
            {
                Id = user.Id,
                Login = user.Login
            };

        public static List<HomeModel> ToHomesModel(this List<HomeEntity> homes)
        {
            var result = new List<HomeModel>();

            foreach (var home in homes)
                result.Add(home.ToHomeModel());

            return result;
        }

        public static HomeModel ToHomeModel(this HomeEntity home) =>
            new HomeModel()
            {
                Id = home.Id,
                City = home.City,
                District = home.District,
                Price = home.Price,
                Description = home.Description,
                Reservations = home.Reservations.ToReservationsModel(),
            };

        public static List<ReservationModel> ToReservationsModel(this List<ReservationEntity> reserservations)
        {
            var result = new List<ReservationModel>();

            foreach (var reserservation in reserservations)
                result.Add(reserservation.ToReservationModel());

            return result;
        }

        public static ReservationModel ToReservationModel(this ReservationEntity reservation) =>
            new ReservationModel()
            {
                StartDate = reservation.StartDate.ToString(),
                EndDate = reservation.EndDate.ToString()
            };

        public static HomeEntity ToHomeEntity(this HomeModel home) =>
            new HomeEntity()
            {
                Id = home.Id,
                City = home.City,
                District = home.District,
                Price = home.Price,
                Description = home.Description,
                Reservations = home.Reservations.ToReservationsEntities(),
            };

        public static List<ReservationEntity> ToReservationsEntities(this List<ReservationModel> reservations)
        {
            var result = new List<ReservationEntity>();

            foreach (var reserservation in reservations)
                result.Add(reserservation.ToReservationEntity());

            return result;
        }

        public static ReservationEntity ToReservationEntity(this ReservationModel reservation) =>
            new ReservationEntity()
            {
                StartDate = DateTime.Parse(reservation.StartDate),
                EndDate = DateTime.Parse(reservation.EndDate)
            };

        public static List<ReviewModel> ToReviewsModels(this List<ReviewEntity> reviews)
        {
            var result = new List<ReviewModel>();

            foreach (var review in reviews)
                result.Add(review.ToReviewModel());

            return result;
        }

        public static ReviewModel ToReviewModel(this ReviewEntity review) =>
            new ReviewModel()
            {
                Login = review.Login,
                IdHome = review.IdHome,
                Text = review.Text,
                Grade = review.Grade,
            };

        public static ReviewEntity ToReviewEntity(this ReviewModel review) =>
            new ReviewEntity()
            {
                Login = review.Login,
                IdHome = review.IdHome,
                Text = review.Text,
                Grade = review.Grade,
            };
    }
}
