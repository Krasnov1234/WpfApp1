using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.Доб_Админ.Сотрудники
{
    
    public class Sotr
    {
        gr691_koyEntities1 db = new gr691_koyEntities1();
        Поварята ISotr = new Поварята();

        public bool InsSotr(string id, string Фамилия, string Имя, string Отчество, string пароль)
        {
            gr691_koyEntities1 db = new gr691_koyEntities1();

            Regex SpecialSimbols = new Regex("([#]|[=]|[/]|[*]|[@]|[&]|[>]|[<]|[;]|[']|[$]|[№]|[!]|[№]|[;]|[{]|[}]|[[]|[]]|[~])");
            Regex searchFullNumber = new Regex(@"(\d)");
            Regex Words = new Regex("^[A-za-z]");
            MatchCollection matchSpecialSymbol;
            MatchCollection matchSearchFullNumber;
            MatchCollection matchWords;
            matchSpecialSymbol = SpecialSimbols.Matches(Фамилия);
            matchSearchFullNumber = searchFullNumber.Matches(Фамилия);
            matchWords = Words.Matches(Фамилия);


            try
            {
                if (string.IsNullOrWhiteSpace(id) == false)
                {
                    MessageBox.Show("Ошибка в таблице <Predmet>!\nВы хотели добавить id сами. Он проставляется автоматически.", "Ошибкаp", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(Фамилия) == true)
                {
                    MessageBox.Show("Вы забыли внести данные в поле <Сотрудник>.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(пароль) == true)
                {
                    MessageBox.Show("Вы забыли внести данные в поле <пароль>.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                else if (matchSpecialSymbol.Count > 0)
                {
                    MessageBox.Show("Не допускаются спецсимволы.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                else if (matchSearchFullNumber.Count > 0)
                {
                    MessageBox.Show("Не допускаются цифры или числа.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                else if (matchWords.Count > 0)
                {
                    MessageBox.Show("Вводятся только кирилица.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                else
                {
                    MessageBox.Show("Сотрудник добавлен.", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);

                    ISotr.Фамилия = Фамилия;
                    ISotr.Имя = Имя;
                    ISotr.Отчество = Отчество;

                    ISotr.Пароль = пароль;
                    db.Поварята.Add(ISotr);
                    db.SaveChanges();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Нельзя добавить", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;

            }

            return true;


        }
        public bool Delete_Sotr(string Id)
        {
            gr691_koyEntities1 db = new gr691_koyEntities1();



            try
            {
                if (string.IsNullOrWhiteSpace(Id) == true)
                {
                    MessageBox.Show("Вы забыли внести данные в поле <Id>.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }

                else
                {
                    MessageBox.Show("Сотрудник удалён.", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);

                    int num = Convert.ToInt32(Id);
                    var dRow = db.Поварята.Where(w => w.ID == num).FirstOrDefault();
                    db.Поварята.Remove(dRow);


                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нельзя удалить", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            return true;
        }
        public bool Update_Sotr(string id, string Фамилия, string Имя, string Отчество, string пароль)
        {
            gr691_koyEntities1 db = new gr691_koyEntities1();
            try
            {
                Regex SpecialSimbols = new Regex("([#]|[=]|[/]|[*]|[@]|[&]|[>]|[<]|[;]|[']|[$]|[№]|[!]|[№]|[;]|[{]|[}]|[[]|[]]|[~])");
                Regex searchFullNumber = new Regex(@"(\d)");
                Regex Words = new Regex("^[A-za-z]");
                MatchCollection matchSpecialSymbol;
                MatchCollection matchSearchFullNumber;
                MatchCollection matchWords;
                matchSpecialSymbol = SpecialSimbols.Matches(Фамилия);
                matchSearchFullNumber = searchFullNumber.Matches(Фамилия);
                matchWords = Words.Matches(Фамилия);


                if (string.IsNullOrWhiteSpace(Фамилия) == true)
                {
                    MessageBox.Show("Вы забыли внести данные в поле <Сотрудник>.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(пароль) == true)
                {
                    MessageBox.Show("Вы забыли внести данные в поле <пароль>.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                else if (matchSpecialSymbol.Count > 0)
                {
                    MessageBox.Show("Не допускаются спецсимволы.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                else if (matchSearchFullNumber.Count > 0)
                {
                    MessageBox.Show("Не допускаются цифры или числа.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                else if (matchWords.Count > 0)
                {
                    MessageBox.Show("Вводятся только кирилица.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                else
                {
                    MessageBox.Show("Сотрудник обновлён.", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);

                    // Cardio.Id = Convert.ToInt32(Id);
                    //Cardio.Cardio_training1 = Convert.ToString(Cardio);
                    int num = Convert.ToInt32(id);
                    var uRow = db.Поварята.Where(w => w.ID == num).FirstOrDefault();


                    uRow.Фамилия = Фамилия.ToString();
                    uRow.Имя = Имя.ToString();
                    uRow.Отчество = Отчество.ToString();


                    uRow.Пароль = пароль.ToString();
                    db.Поварята.Add(ISotr);
                    

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нельзя обновить", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }
    }
}
