using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace camping
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] firstDateArray;
        string[] lastDateArray;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void firstDateText_CalendarClosed(object sender, RoutedEventArgs e)
        {
            if (firstDateText.SelectedDate.HasValue)
            {
                string firstDate = firstDateText.SelectedDate.Value.ToString("dd/MM/yyyy");
                firstDateArray = firstDate.Split('-');
            }
        }

        private void lastDateText_CalendarClosed(object sender, RoutedEventArgs e)
        {
            if (lastDateText.SelectedDate.HasValue)
            {
                string lastDate = lastDateText.SelectedDate.Value.ToString("dd/MM/yyyy");
                lastDateArray = lastDate.Split('-');
            }
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (firstDateArray != null && lastDateArray != null)
            {
                int firstDateDay = Convert.ToInt32(firstDateArray[0]);
                int firstDateMonth = Convert.ToInt32(firstDateArray[1]);
                int firstDateYear = Convert.ToInt32(firstDateArray[2]);

                int lastDateDay = Convert.ToInt32(lastDateArray[0]);
                int lastDateMonth = Convert.ToInt32(lastDateArray[1]);
                int lastDateYear = Convert.ToInt32(lastDateArray[2]);

                int costOfLand = 0;
                int cost = 0;
                int totalDays = 0;


                if (firstDateDay > lastDateDay || firstDateMonth > lastDateMonth || firstDateYear > lastDateYear)
                {
                    outputText.Text = "Please make the first date lower then te last date";
                }
                else
                {
                    if (firstDateArray[0] == lastDateArray[0] && firstDateArray[1] == lastDateArray[1] && firstDateArray[2] == lastDateArray[2])
                    {
                        outputText.Text = "Please don't enter the same date";
                    }
                    else
                    {
                        int day = lastDateDay - firstDateDay;
                        int month = (lastDateMonth - firstDateMonth) * 30;
                        int year = (lastDateYear - firstDateYear) * 365;
                        totalDays = day + month + year;


                        if (firstDateMonth >= 7 && lastDateMonth <= 8)
                        {
                            if (firstDateDay < 11 && lastDateDay < 11 && firstDateMonth == 7 && lastDateMonth == 7)
                            {
                                costOfLand = 25 * totalDays;
                            }
                            if (firstDateDay > 15 && lastDateDay > 15 && firstDateMonth == 8 && lastDateMonth == 8)
                            {
                                costOfLand = 25 * totalDays;
                            }
                            if (firstDateDay >= 11 && firstDateMonth == 7 && lastDateDay <= 15 && lastDateMonth == 8)
                            {
                                costOfLand = 30 * totalDays;
                            }
                            if (firstDateDay >= 11 && firstDateMonth == 7 && lastDateMonth == 7)
                            {
                                costOfLand = 30 * totalDays;
                            }
                            if (lastDateDay <= 15 && firstDateMonth == 8 && lastDateMonth == 8)
                            {
                                costOfLand = 30 * totalDays;
                            }
                            if (firstDateDay < 11 && firstDateMonth == 7 && ((lastDateDay > 11 && lastDateMonth == 7) || lastDateMonth == 8))
                            {
                                int totalDaysBeforeSeason = 11 - firstDateDay;
                                int totalDaysDuringSeason = totalDays - totalDaysBeforeSeason;
                                costOfLand = 25 * totalDaysBeforeSeason + totalDaysDuringSeason * 30;
                            }
                            if (lastDateDay > 15 && lastDateMonth == 8 && ((firstDateDay > 11 && firstDateMonth == 7) || firstDateMonth == 8))
                            {
                                int totalDaysAfterSeason = lastDateDay - 15;
                                int totalDaysDuringSeason = totalDays - totalDaysAfterSeason;
                                costOfLand = 25 * totalDaysAfterSeason + totalDaysDuringSeason * 30;

                            }
                            if (firstDateDay < 11 && firstDateMonth == 7 && lastDateDay > 15 && lastDateMonth == 8)
                            {
                                int totalDaysBeforeSeason = 11 - firstDateDay;
                                int totalDaysAfterSeason = lastDateDay - 15;
                                int totalDaysDuringSeason = totalDays - totalDaysAfterSeason - totalDaysBeforeSeason;
                                costOfLand = 25 * totalDaysBeforeSeason + 25 * totalDaysAfterSeason + totalDaysDuringSeason * 30;
                            }
                        }
                        else
                        {
                            costOfLand = 25 * totalDays;
                        }
                    }
                }
                int amountOfPersonsValue = Convert.ToInt32(amountOfPersons.Text);
                int amountOfMetersValue = Convert.ToInt32(amountOfMeters.Text);
                int amountOfCarsValue = Convert.ToInt32(amountOfCars.Text);
                int amountOfDogsValue = Convert.ToInt32(amountOfDogs.Text);

                cost += (amountOfPersonsValue * 5);
                cost += (amountOfCarsValue * 5);
                cost += (amountOfDogsValue * 5);

                if (amountOfMetersValue > 10)
                {
                    int costOfMeters = amountOfMetersValue - 10;
                    cost += costOfMeters * 3;
                }
                if (amountOfMetersValue < 10)
                {
                    int costOfMeters = 10 - amountOfMetersValue;
                    cost -= costOfMeters * 2;
                }
                cost = cost * totalDays;

                outputText.Text = (costOfLand + cost).ToString() + " Euro";
            }

            else
            {
                if (firstDateArray == null)
                    outputText.Text = "Please enter the first date first before calcualting";
                else if (lastDateArray == null)
                    outputText.Text = "Please enter the last date first before calcualting";
            }

        }
    }
}
