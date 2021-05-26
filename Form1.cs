using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тестилка
{
    public partial class Form1 : Form
    {
        public int n = 0;
        int[] answer;
        int[] answerR;
        int[] answer20;
        public int hhrr = 0;
        public int hhrr2 = 0;
        public int hhrr3 = 0;
        public int hhrr4 = 0;
        public Form1()
        {
            InitializeComponent();
            answer = new int[21];
            answerR = new int[31];
            answer20 = new int[21];
            radioButton1.BackColor = Color.Transparent;
            radioButton2.BackColor = Color.Transparent;
            radioButton3.BackColor = Color.Transparent;
            radioButton4.BackColor = Color.Transparent;
            radioButton5.BackColor = Color.Transparent;
            radioButton6.BackColor = Color.Transparent;
            radioButton7.BackColor = Color.Transparent;
            radioButton8.BackColor = Color.Transparent;
            checkBox1.BackColor = Color.Transparent;
            checkBox2.BackColor = Color.Transparent;
            checkBox3.BackColor = Color.Transparent;
            checkBox4.BackColor = Color.Transparent;
            Disc.BackColor = Color.Transparent;
            Razdel.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            NameTest1.BackColor = Color.Transparent;
            NameTest2.BackColor = Color.Transparent;
            NameTest3.BackColor = Color.Transparent;
        }

        public void show(int n)
        {
            label2.Text = "Вопрос " + n + "/20";
            switch (answer[n])
            {
                case 0:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    break;
                case 1:
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    break;
                case 2:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    break;
                case 3:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    radioButton4.Checked = false;
                    break;
                case 4:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = true;
                    break;

            }

            switch (answer20[n])
            {
                case 0:
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    break;
                case 1:
                    checkBox1.Checked = true;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    break;
                case 2:
                    checkBox1.Checked = false;
                    checkBox2.Checked = true;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    break;
                case 3:
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = true;
                    checkBox4.Checked = false;
                    break;
                case 4:
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = true;
                    break;

            }

            switch (n)
            {
                case 0:
                    break;
                case 1:
                    label1.Text = "База данных - это:";
                    radioButton1.Text = "1) совокупность данных, организованных по определенным правилам;";
                    radioButton2.Text = "2)совокупность программ для хранения и обработки больших массивов информации;";
                    radioButton3.Text = "3) интерфейс, поддерживающий наполнение и манипулирование данными;";
                    radioButton4.Text = "4) определенная совокупность информации.";
                    break;

                case 2:
                    label1.Text = "Наиболее распространенными в практике являются:";
                    radioButton1.Text = "1) распределенные базы данных";
                    radioButton2.Text = "2) иерархические базы данных";
                    radioButton3.Text = "3) сетевые базы данных";
                    radioButton4.Text = "4) реляционные базы данных";
                    break;

                case 3:
                    label1.Text = "Наиболее точным аналогом реляционной базы данных может служить:";
                    radioButton1.Text = "1) неупорядоченное множество данных";
                    radioButton2.Text = "2) вектор";
                    radioButton3.Text = "3) генеалогическое дерево";
                    radioButton4.Text = "4) двумерная таблица";
                    break;

                case 4:
                    label1.Text = "Что из перечисленного не является объектом Access:";
                    radioButton1.Text = "1) модули";
                    radioButton2.Text = "2) таблицы";
                    radioButton3.Text = "3) макросы";
                    radioButton4.Text = "4) ключи";
                    break;

                case 5:
                    label1.Text = "Таблицы в базах данных предназначены:";
                    radioButton1.Text = "1) для хранения данных базы";
                    radioButton2.Text = "2) для отбора и обработки данных базы";
                    radioButton3.Text = "3) для ввода данных базы и их просмотра";
                    radioButton4.Text = "4) для автоматического выполнения группы команд";
                    break;
                case 6:
                    label1.Text = "Выберите один из 6 вариантов ответа:";
                    radioButton1.Text = "1) для хранения данных базы";
                    radioButton2.Text = "2) для отбора и обработки данных базы";
                    radioButton3.Text = "3) для ввода данных базы и их просмотра";
                    radioButton4.Text = "4) для автоматического выполнения группы команд";
                    break;
                case 7:
                    label1.Text = "Для чего предназначены формы:";
                    radioButton1.Text = "1) для хранения данных базы";
                    radioButton2.Text = "2) для отбора и обработки данных базы";
                    radioButton3.Text = "3) для ввода данных базы и их просмотра";
                    radioButton4.Text = "4) для автоматического выполнения группы команд";
                    break;
                case 8:
                    label1.Text = "Для чего предназначены отчеты:";
                    radioButton1.Text = "1) для хранения данных базы";
                    radioButton2.Text = "2) для отбора и обработки данных базы";
                    radioButton3.Text = "3) для ввода данных базы и их просмотра";
                    radioButton4.Text = "4) для вывода обработанных данных базы на принтер";
                    break;
                case 9:
                    label1.Text = "Для чего предназначены макросы:";
                    radioButton1.Text = "1) для хранения данных базы";
                    radioButton2.Text = "2) для отбора и обработки данных базы";
                    radioButton3.Text = "3) для ввода данных базы и их просмотра";
                    radioButton4.Text = "4) для автоматического выполнения группы команд";
                    break;
                case 10:
                    label1.Text = "Для чего предназначены модули:";
                    radioButton1.Text = "1) для хранения данных базы";
                    radioButton2.Text = "2) для отбора и обработки данных базы";
                    radioButton3.Text = "3) для ввода данных базы и их просмотра";
                    radioButton4.Text = "4) для выполнения сложных программных действий";
                    break;
                case 11:
                    label1.Text = "В каком режиме работает с базой данных пользователь:";
                    radioButton1.Text = "1) в проектировочном";
                    radioButton2.Text = "2) в любительском";
                    radioButton3.Text = "3) в заданном";
                    radioButton4.Text = "4) в эксплуатационном";
                    break;
                case 12:
                    label1.Text = "В каком диалоговом окне создают связи между полями таблиц базы данных:";
                    radioButton1.Text = "1) таблица связей";
                    radioButton2.Text = "2) схема связей";
                    radioButton3.Text = "3) схема данных";
                    radioButton4.Text = "4) таблица данных";
                    break;
                case 13:
                    label1.Text = "Почему при закрытии таблицы программа Access не предлагает выполнить сохранение внесенных данных:";
                    radioButton1.Text = "1) недоработка программы";
                    radioButton2.Text = "2) потому что данные сохраняются сразу после ввода в таблицу";
                    radioButton3.Text = "3) потому что данные сохраняются только после закрытия всей базы данных";
                    radioButton4.Text = "";
                    break;
                case 14:
                    label1.Text = "Без каких объектов не может существовать база данных:";
                    radioButton1.Text = "1) без отчетов";
                    radioButton2.Text = "2) без таблиц";
                    radioButton3.Text = "3) без форм";
                    radioButton4.Text = "4) без макросов";
                    break;
                case 15:
                    label1.Text = "В каких элементах таблицы хранятся данные базы:";
                    radioButton1.Text = "1) в записях";
                    radioButton2.Text = "2) в столбцах";
                    radioButton3.Text = "3) в ячейках";
                    radioButton4.Text = "4) в строках";
                    break;
                case 16:
                    label1.Text = "Содержит ли какую-либо информацию таблица, в которой нет ни одной записи?";
                    radioButton1.Text = "1) таблица без записей существовать не может";
                    radioButton2.Text = "2) пустая таблица не содержит ни какой информации";
                    radioButton3.Text = "3) пустая таблица содержит информацию о структуре базы данных";
                    radioButton4.Text = "4) пустая таблица содержит информацию о будущих записях";
                    break;
                case 17:
                    label1.Text = "Содержит ли какую-либо информацию таблица, в которой нет полей?";
                    radioButton1.Text = "1) содержит информацию о структуре базы данных";
                    radioButton2.Text = "2) не содержит ни какой информации";
                    radioButton3.Text = "3) таблица без полей существовать не может";
                    radioButton4.Text = "4) содержит информацию о будущих записях";
                    break;
                case 18:
                    label1.Text = "В чем состоит особенность поля счетчик?";
                    radioButton1.Text = "1) служит для ввода числовых данных";
                    radioButton2.Text = "2) служит для ввода действительных чисел";
                    radioButton3.Text = "3) имеет ограниченный размер";
                    radioButton4.Text = "4) имеет свойство автоматического наращивания";
                    break;
                case 19:
                    label1.Text = "В чем состоит особенность поля мемо?";
                    radioButton1.Text = "1) служит для ввода числовых данных";
                    radioButton2.Text = "2) служит для ввода действительных чисел";
                    radioButton3.Text = "3) многострочный текст";
                    radioButton4.Text = "4) имеет ограниченный размер";
                    break;
                case 20:
                    label1.Text = "Ключами поиска в системах управления базами данных (СУБД) называются:";
                    checkBox1.Text = "1) логические выражения, определяющие условия поиска";
                    checkBox2.Text = "2) поля, по значению которых осуществляется поиск";
                    checkBox3.Text = "3) номера записей, удовлетворяющих условиям поиска";
                    checkBox4.Text = "4) номер первой по порядку записи, удовлетворяющей условиям поиска";
                    break;
            }
        }

        public void show2(int n)
        {
            label2.Text = "Вопрос " + n + "/20";
            switch (answer[n])
            {
                case 0:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    break;
                case 1:
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    break;
                case 2:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    break;
                case 3:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    radioButton4.Checked = false;
                    break;
                case 4:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = true;
                    break;
            }
           /* switch (answer20[n])
            {
                case 0:
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    break;
                case 1:
                    checkBox1.Checked = true;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    break;
                case 2:
                    checkBox1.Checked = false;
                    checkBox2.Checked = true;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    break;
                case 3:
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = true;
                    checkBox4.Checked = false;
                    break;
                case 4:
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = true;
                    break;
            }*/
            switch (n)
            {
                case 0:
                    break;
                case 1:
                    label1.Text = "Вопрос 2.1?";
                    radioButton1.Text = "gfhgfhg";
                    radioButton2.Text = "gfhfghfghfg";
                    radioButton3.Text = "gfhgfchfghhg";
                    radioButton4.Text = "cfbghgfchgh";
                    break;

                case 2:
                    label1.Text = "Провирка2.2";
                    radioButton1.Text = "fkljlkdjg";
                    radioButton2.Text = "fgssdfgdfs";
                    radioButton3.Text = "ddddddddddd";
                    radioButton4.Text = "fkljlkdjg";
                    break;

                case 3:
                    label1.Text = "2.3?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;

                case 4:
                    label1.Text = "2.4?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;

                case 5:
                    label1.Text = "2.5 ? ";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 6:
                    label1.Text = "2.6?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 7:
                    label1.Text = "2.7?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 8:
                    label1.Text = "2.8?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 9:
                    label1.Text = "2.9?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 10:
                    label1.Text = "2.10?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 11:
                    label1.Text = "2.11?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 12:
                    label1.Text = "2.12?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 13:
                    label1.Text = "2.13?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 14:
                    label1.Text = "2.14?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 15:
                    label1.Text = "2.15?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 16:
                    label1.Text = "2.16?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 17:
                    label1.Text = "2.17?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 18:
                    label1.Text = "2.18?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 19:
                    label1.Text = "2.19?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 20:
                    label1.Text = "2.20?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;

            }
        }

        public void show3(int n)
        {
            int n1 = n + 1;
            label2.Text = "Вопрос " + n + "/20";
            switch (answer[n])
            {
                case 0:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    break;
                case 1:
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    break;
                case 2:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    break;
                case 3:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    radioButton4.Checked = false;
                    break;
                case 4:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = true;
                    break;
            }

           /* switch (answer20[n])
            {
                case 0:
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    break;
                case 1:
                    checkBox1.Checked = true;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    break;
                case 2:
                    checkBox1.Checked = false;
                    checkBox2.Checked = true;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    break;
                case 3:
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = true;
                    checkBox4.Checked = false;
                    break;
                case 4:
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = true;
                    break;
            }*/
            switch (n)
            {
                case 0:
                    break;
                case 1:
                    label1.Text = "Вопрос 3.1?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;

                case 2:
                    label1.Text = "Провирка3.2";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;

                case 3:
                    label1.Text = "3.3?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;

                case 4:
                    label1.Text = "3.4?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;

                case 5:
                    label1.Text = "3.5 ? ";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 6:
                    label1.Text = "3.6?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 7:
                    label1.Text = "3.7?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 8:
                    label1.Text = "3.8?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 9:
                    label1.Text = "3.9?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 10:
                    label1.Text = "3.10?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 11:
                    label1.Text = "3.11?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 12:
                    label1.Text = "3.12?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 13:
                    label1.Text = "3.13?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 14:
                    label1.Text = "3.14?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 15:
                    label1.Text = "3.15?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 16:
                    label1.Text = "3.16?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 17:
                    label1.Text = "3.17?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 18:
                    label1.Text = "3.18?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 19:
                    label1.Text = "3.19?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;
                case 20:
                    label1.Text = "3.20?";
                    radioButton1.Text = "аорпаврагшаа";
                    radioButton2.Text = "аорпаврагшаа";
                    radioButton3.Text = "аорпаврагшаа";
                    radioButton4.Text = "аорпаврагшаа";
                    break;

            }
        }

        public void show4(int n)
        {
            label2.Text = "Вопрос " + n + "/30";
            switch (answerR[n])
            {
                case 0:
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    radioButton7.Checked = false;
                    radioButton8.Checked = false;
                    break;
                case 1:
                    radioButton5.Checked = true;
                    radioButton6.Checked = false;
                    radioButton7.Checked = false;
                    radioButton8.Checked = false;
                    break;
                case 2:
                    radioButton5.Checked = false;
                    radioButton6.Checked = true;
                    radioButton7.Checked = false;
                    radioButton8.Checked = false;
                    break;
                case 3:
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    radioButton7.Checked = true;
                    radioButton8.Checked = false;
                    break;
                case 4:
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    radioButton7.Checked = false;
                    radioButton8.Checked = true;
                    break;

            }

           /* switch (answer20[n])
            {
                case 0:
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    break;
                case 1:
                    checkBox1.Checked = true;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    break;
                case 2:
                    checkBox1.Checked = false;
                    checkBox2.Checked = true;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    break;
                case 3:
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = true;
                    checkBox4.Checked = false;
                    break;
                case 4:
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = true;
                    break;
            }*/
            switch (n)
            {
                case 0:
                    break;
                case 1:
                    label1.Text = "Вопрос 4.1?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;

                case 2:
                    label1.Text = "Провирка 4.2";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;

                case 3:
                    label1.Text = "4.3?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;

                case 4:
                    label1.Text = "4.4?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;

                case 5:
                    label1.Text = "4.5 ? ";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;
                case 6:
                    label1.Text = "4.6?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;
                case 7:
                    label1.Text = "4.7?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;
                case 8:
                    label1.Text = "4.8?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;
                case 9:
                    label1.Text = "4.9?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;
                case 10:
                    label1.Text = "4.10?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;
                case 11:
                    label1.Text = "4.11?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;
                case 12:
                    label1.Text = "4.12?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;
                case 13:
                    label1.Text = "4.13?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;
                case 14:
                    label1.Text = "3.14?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;
                case 15:
                    label1.Text = "4.15?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;
                case 16:
                    label1.Text = "4.16?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;
                case 17:
                    label1.Text = "4.17?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;
                case 18:
                    label1.Text = "4.18?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;
                case 19:
                    label1.Text = "4.19?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;
                case 20:
                    label1.Text = "4.20?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;
                case 21:
                    label1.Text = "4.21?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;
                case 22:
                    label1.Text = "4.22?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;
                case 23:
                    label1.Text = "4.24?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;
                case 24:
                    label1.Text = "4.25?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;
                case 25:
                    label1.Text = "4.26?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;
                case 26:
                    label1.Text = "4.27?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;
                case 27:
                    label1.Text = "4.28?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;
                case 28:
                    label1.Text = "3.20?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;
                case 29:
                    label1.Text = "4.29?";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;
                case 30:
                    label1.Text = "4.30";
                    radioButton5.Text = "hdshjfdhjdfhdjfsdhfs";
                    radioButton6.Text = "кирпич";
                    radioButton7.Text = "gdsfdgf";
                    radioButton8.Text = "fdghfdiugfd";
                    break;

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 4;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            answerR[n] = 1;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            answerR[n] = 2;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            answerR[n] = 3;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            answerR[n] = 4;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 1;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 2;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 3;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 4;
        }

        private void NTest1_Click(object sender, EventArgs e)
        {
            n++;
            if (n > 1) n = 1;
            show(n);
            NTest1.Visible = false;
            Next1.Visible = true;
            NTest2.Visible = false;
            NTest3.Visible = false;
            NTestR.Visible = false;
            Disc.Visible = false;
            Razdel.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            NameTest1.Visible = false;
            NameTest2.Visible = false;
            NameTest3.Visible = false;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
        }

        private void Next1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                n++;
                if (n > 20) n = 20;
                show(n);
            }
            else
            {
                MessageBox.Show("Выберите вариант ответа!");
            }

            if (n == 20)
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                checkBox4.Visible = true;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;

                
                    Result1.Visible = true;
                
            }

        }
    
        private void Result1_Click(object sender, EventArgs e)
        {
            hhrr = 1;
            int correct = 0;
            if (answer[1] == 1)
                correct++;
            if (answer[2] == 1)
                correct++;
            if (answer[3] == 1)
                correct++;
            if (answer[4] == 2)
                correct++;
            if (answer[5] == 2)
                correct++;
            if (answer[6] == 2)
                correct++;
            if (answer[7] == 3)
                correct++;
            if (answer[8] == 3)
                correct++;
            if (answer[9] == 3)
                correct++;
            if (answer[10] == 4)
                correct++;
            if (answer[11] == 4)
                correct++;
            if (answer[12] == 4)
                correct++;
            if (answer[13] == 1)
                correct++;
            if (answer[14] == 1)
                correct++;
            if (answer[15] == 1)
                correct++;
            if (answer[16] == 2)
                correct++;
            if (answer[17] == 2)
                correct++;
            if (answer[18] == 2)
                correct++;
            if (answer[19] == 3)
            {
                correct++;
            }
            if (checkBox3.Checked && checkBox4.Checked)
                correct++;
            pictureBox1.Visible = true;

            Result1.Visible = false;
            Next1.Visible = false;
            label1.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;

            if (correct >= 10)
            {
                pictureBox1.Image = Image.FromFile("F:/практика/гифки/гиф.gif");
            }

            if (correct < 10)
            {
                pictureBox1.Image = Image.FromFile("F:/практика/гифки/giff.gif");
            }

            int prcnt = correct;
            String msg = "Вы не прошли тест";
            if (prcnt >= 10) msg = "Вы прошли тест";
            MessageBox.Show("Вы ответили на " + prcnt + "  вопросов верно. " + msg);
            label2.Text = "Вы ответили на " + correct + "/20 баллов";

            NameTest1.Visible = true;
            NameTest2.Visible = true;
            NameTest3.Visible = true;
            pictureBox1.Visible = false;
            label2.Visible = false;
            // label3.Visible = false;
            Disc.Visible = true;
            Razdel.Visible = true;

            if (hhrr2 == 0)
            {
                NTest2.Visible = true;
            }

            if (hhrr3 == 0)
            {
                NTest3.Visible = true;
            }
           

            if (hhrr > 0)
            {
                if (hhrr2 > 0)
                {
                    if (hhrr3 > 0)
                    {
                        NTestR.Visible = true;
                    }
                }
            }
            n = 0;
        }

        private void NTest2_Click(object sender, EventArgs e)
        {
            n++;
            if (n > 1) n = 1;
            show2(n);
            NTest1.Visible = false;
            Next2.Visible = true;
            NTest2.Visible = false;
            NTest3.Visible = false;
            NTestR.Visible = false;
            Disc.Visible = false;
            Razdel.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            NameTest1.Visible = false;
            NameTest2.Visible = false;
            NameTest3.Visible = false;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
        }

        private void Next2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                n++;
                if (n > 20) n = 20;
                show2(n);


            }
            else
            {
                MessageBox.Show("Выберите вариант ответа!");
            }

            if (n == 20)
            {
              /*  checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                checkBox4.Visible = true;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
              */
                  if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
                  {
                    Result2.Visible = true;
                  }
            }
        }

        private void Result2_Click(object sender, EventArgs e)
        {
            hhrr2 = 1;
            int correct2 = 0;
            if (answer[1] == 1)
                correct2++;
            if (answer[2] == 1)
                correct2++;
            if (answer[3] == 1)
                correct2++;
            if (answer[4] == 2)
                correct2++;
            if (answer[5] == 2)
                correct2++;
            if (answer[6] == 2)
                correct2++;
            if (answer[7] == 3)
                correct2++;
            if (answer[8] == 3)
                correct2++;
            if (answer[9] == 3)
                correct2++;
            if (answer[10] == 4)
                correct2++;
            if (answer[11] == 4)
                correct2++;
            if (answer[12] == 4)
                correct2++;
            if (answer[13] == 1)
                correct2++;
            if (answer[14] == 1)
                correct2++;
            if (answer[15] == 1)
                correct2++;
            if (answer[16] == 2)
                correct2++;
            if (answer[17] == 2)
                correct2++;
            if (answer[18] == 2)
                correct2++;
            if (answer[19] == 3)
                correct2++;
            if (answer[20] == 3)
                correct2++;

            pictureBox1.Visible = true;
            NTest2.Visible = false;
            Result2.Visible = false;
            Next2.Visible = false;
            label1.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            if (correct2 >= 10)
            {
                pictureBox1.Image = Image.FromFile("F:/практика/гифки/гиф.gif");
            }

            if (correct2 < 10)
            {
                pictureBox1.Image = Image.FromFile("F:/практика/гифки/giff.gif");
            }

            int prcnt = correct2;
            String msg = "Вы не прошли тест";
            if (prcnt >= 10) msg = "Вы прошли тест";
            MessageBox.Show("Вы ответили на " + prcnt + "  вопросов верно. " + msg);


            NameTest1.Visible = true;
            NameTest2.Visible = true;
            NameTest3.Visible = true;
            pictureBox1.Visible = false;
            label2.Visible = false;
            // label3.Visible = false;
            Disc.Visible = true;
            Razdel.Visible = true;

            if (hhrr == 0)
            {
                NTest1.Visible = true;
            }

            if (hhrr3 == 0)
            {
                NTest3.Visible = true;
            }

            if (hhrr > 0)
            {
                if (hhrr2 > 0)
                {
                    if (hhrr3 > 0)
                    {
                        NTestR.Visible = true;
                    }
                }
            }
            n = 0;
        }

        private void NTest3_Click(object sender, EventArgs e)
        {
            n++;
            if (n > 1) n = 1;
            show3(n);
            NTest1.Visible = false;
            Next3.Visible = true;
            NTest2.Visible = false;
            NTest3.Visible = false;
            NTestR.Visible = false;
            Disc.Visible = false;
            Razdel.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            NameTest1.Visible = false;
            NameTest2.Visible = false;
            NameTest3.Visible = false;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
        }

        private void Next3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                n++;
                if (n > 20) n = 20;
                show3(n);


            }
            else
            {
                MessageBox.Show("Выберите вариант ответа!");
            }

            if (n == 20)
            {

                if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
                {
                    Result3.Visible = true;
                }
            }
        }

        private void Result3_Click(object sender, EventArgs e)
        {
            hhrr3 = 1;
            int correct3 = 0;
            if (answer[1] == 1)
                correct3++;
            if (answer[2] == 1)
                correct3++;
            if (answer[3] == 1)
                correct3++;
            if (answer[4] == 2)
                correct3++;
            if (answer[5] == 2)
                correct3++;
            if (answer[6] == 2)
                correct3++;
            if (answer[7] == 3)
                correct3++;
            if (answer[8] == 3)
                correct3++;
            if (answer[9] == 3)
                correct3++;
            if (answer[10] == 4)
                correct3++;
            if (answer[11] == 4)
                correct3++;
            if (answer[12] == 4)
                correct3++;
            if (answer[13] == 1)
                correct3++;
            if (answer[14] == 1)
                correct3++;
            if (answer[15] == 1)
                correct3++;
            if (answer[16] == 2)
                correct3++;
            if (answer[17] == 2)
                correct3++;
            if (answer[18] == 2)
                correct3++;
            if (answer[19] == 3)
                correct3++;
            if (answer[20] == 3)
                correct3++;

            pictureBox1.Visible = true;
            NTest3.Visible = false;
            Result3.Visible = false;
            Next3.Visible = false;
            label1.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;

            if (correct3 >= 10)
            {
                pictureBox1.Image = Image.FromFile("F:/практика/гифки/гиф.gif");
            }

            if (correct3 < 10)
            {
                pictureBox1.Image = Image.FromFile("F:/практика/гифки/giff.gif");
            }

            int prcnt = correct3;
            String msg = "Вы не прошли тест";
            if (prcnt >= 10) msg = "Вы прошли тест";
            MessageBox.Show("Вы ответили на " + prcnt + "  вопросов верно. " + msg);

            NameTest1.Visible = true;
            NameTest2.Visible = true;
            NameTest3.Visible = true;
            pictureBox1.Visible = false;
            label2.Visible = false;
            // label3.Visible = false;
            Disc.Visible = true;
            Razdel.Visible = true;

            if (hhrr == 0)
            {
                NTest1.Visible = true;
            }

            if (hhrr2 == 0)
            {
                NTest2.Visible = true;
            }

            if (hhrr > 0)
            {
                if (hhrr2 > 0)
                {
                    if (hhrr3 > 0)
                    {
                        NTestR.Visible = true;
                    }
                }
            }
            n = 0;
        }

        private void NTestR_Click(object sender, EventArgs e)
        {
            n++;
            if (n > 1) n = 1;
            show4(n);
            NTest1.Visible = false;
            NTest2.Visible = false;
            NTest3.Visible = false;
            NTestR.Visible = false;
            NextR.Visible = true;
            Disc.Visible = false;
            Razdel.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            NameTest1.Visible = false;
            NameTest2.Visible = false;
            NameTest3.Visible = false;
            radioButton5.Visible = true;
            radioButton6.Visible = true;
            radioButton7.Visible = true;
            radioButton8.Visible = true;
        }

        private void NextR_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked || radioButton6.Checked || radioButton7.Checked || radioButton8.Checked)
            {
                n++;
                if (n > 30) n = 30;
                show4(n);
            }
            else
            {
                MessageBox.Show("Выберите вариант ответа!");
            }
            if (n == 30)
            {
                if (radioButton5.Checked || radioButton6.Checked || radioButton7.Checked || radioButton8.Checked)
                {
                    ResultR.Visible = true;
                }
            }
        }

        private void ResultR_Click(object sender, EventArgs e)
        {
            hhrr4++;
            int correct4 = 0;
            if (answerR[1] == 3)
                correct4++;
            if (answerR[2] == 3)
                correct4++;
            if (answerR[3] == 3)
                correct4++;
            if (answerR[4] == 3)
                correct4++;
            if (answerR[5] == 3)
                correct4++;
            if (answerR[6] == 3)
                correct4++;
            if (answerR[7] == 3)
                correct4++;
            if (answerR[8] == 3)
                correct4++;
            if (answerR[9] == 3)
                correct4++;
            if (answerR[10] == 3)
                correct4++;
            if (answerR[11] == 3)
                correct4++;
            if (answerR[12] == 3)
                correct4++;
            if (answerR[13] == 3)
                correct4++;
            if (answerR[14] == 3)
                correct4++;
            if (answerR[15] == 3)
                correct4++;
            if (answerR[16] == 3)
                correct4++;
            if (answerR[17] == 3)
                correct4++;
            if (answerR[18] == 3)
                correct4++;
            if (answerR[19] == 3)
                correct4++;
            if (answerR[20] == 3)
                correct4++;
            if (answerR[21] == 3)
                correct4++;
            if (answerR[22] == 3)
                correct4++;
            if (answerR[23] == 3)
                correct4++;
            if (answerR[24] == 3)
                correct4++;
            if (answerR[25] == 3)
                correct4++;
            if (answerR[26] == 3)
                correct4++;
            if (answerR[27] == 3)
                correct4++;
            if (answerR[28] == 3)
                correct4++;
            if (answerR[29] == 3)
                correct4++;
            if (answerR[30] == 3)
                correct4++;



            pictureBox1.Visible = true;
            if (correct4 >= 5)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/qwerty6000/Downloads/гиф.gif");
                label2.Text = "Количество баллов за тест = " + correct4 + "Вы отлично справились!";
            }

            if (correct4 < 5)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/qwerty6000/Downloads/giff.gif");
                label2.Text = "Количество баллов за тест = " + correct4 + " Вы не прошли тест на хороший результат";
            }

            int prcnt = correct4;
            String msg = "Вы не прошли тест";
            if (prcnt >= 10) msg = "Вы прошли тест";
            MessageBox.Show("Вы ответили на " + prcnt + "  вопросов верно. " + msg);

            NTestR.Visible = false;
            ResultR.Visible = false;
            NextR.Visible = false;
            label1.Visible = false;
            NameTest1.Visible = true;
            NameTest2.Visible = true;
            NameTest3.Visible = true;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;


            pictureBox1.Visible = false;
            label2.Visible = false;
            // label3.Visible = false;
            Disc.Visible = true;
            Razdel.Visible = true;
            n = 0;
        }
    }
}

