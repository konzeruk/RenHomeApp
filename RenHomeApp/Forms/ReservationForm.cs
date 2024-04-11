using DTO.Models;

namespace RenHomeApp.Forms
{
    public partial class ReservationForm : Form
    {
        public ReservationModel? newReservation = null;

        private List<ReservationModel>? reservations;

        public ReservationForm(List<ReservationModel>? reservations)
        {
            InitializeComponent();

            this.reservations = reservations;

            InitCalendars();
        }

        private void InitCalendars()
        {
            var nowDate = DateTime.Now;

            dateTimePickerStart.MinDate = dateTimePickerEnd.MinDate = new DateTime(nowDate.Year, nowDate.Month, (nowDate.Day == 1) ? GetMinDate(nowDate.Month) : nowDate.Day - 1);
            dateTimePickerStart.MaxDate = dateTimePickerEnd.MaxDate = new DateTime(nowDate.Year, (nowDate.Month == 12) ? 2 : nowDate.Month + 2, nowDate.Day);
        }

        private int GetMinDate(int month) => month
            switch
        {
            1 => 31,
            2 => 31,
            3 => 29,
            4 => 31,
            5 => 30,
            6 => 31,
            7 => 30,
            8 => 31,
            9 => 30,
            10 => 31,
            11 => 31,
            12 => 30,
            _ => throw new NotImplementedException("Не верно указан месяц"),
        };

        private void bOk_Click(object sender, EventArgs e)
        {
            var startDate = dateTimePickerStart.Value;
            var endDate = dateTimePickerEnd.Value;

            if (endDate < startDate)
            {
                MessageBox.Show("Дата выселения не должна быть раньше даты заселения");
                return;
            }

            if(!CheckReservDate(startDate, endDate))
            {
                MessageBox.Show("Выбранные даты заняты");
                return;
            }

            newReservation = new ReservationModel
            {
                StartDate = startDate.ToString(),
                EndDate = endDate.ToString(),
            };

            Close();
        }

        private bool CheckReservDate(DateTime startDate, DateTime endDate)
        {
            if (reservations != null)
                foreach (var reservation in reservations)
                {
                    var _startDate = Convert.ToDateTime(reservation.StartDate);
                    var _endDate = Convert.ToDateTime(reservation.EndDate);

                    if (startDate > _startDate && startDate < _endDate)
                        return false;

                    if (endDate > _startDate && endDate < _endDate)
                        return false;

                    if (startDate < _startDate && endDate > _endDate)
                        return false;
                }
            return true;
        }

        private void bCancel_Click(object sender, EventArgs e) =>
            Close();
    }
}
