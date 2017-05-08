using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components; //для работы метро
using MetroFramework.Forms; //для работы метро

//1) Нужно посмотреть момент с блокировкой переходов по TabPage при нажании кнопки "подтвердить" и разблокировкой этого же, при "отменить"
//2) Посмотреть момент со считыванием клавиш при вводе в "назначить свою". чтобы не дублировался shiftKey\altkey\controlkey (с If поиграть)

namespace WindowsFormsApp1
{
    public partial class Form1 : MetroForm //"Form" было изначально, а не "MetroForm"
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        //
        //
        // Код для кнопки F.A.Q. 
        private void FAQ_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "1) Выбери один из стандартных вариантов сочетаний клавиш или введи свою.\n2) Назначь стандартную операцию или выбери свою.\n3) Нажми ''Сохранить'' и будь счатлив(а)!\nУдачи! :)",
                "А собственно как это?",
                MessageBoxButtons.OK,
                MessageBoxIcon.Question);
        }



        //
        //
        //!!!***   ВЕРХЯЯ ГРУППА   ***!!!\\\ 
        //
        //

        //
        //
        // GroupButtonsIn_Enter - Группа кнопок назначаемых клавиш.
        private void GroupButtonsIn_Enter(object sender, EventArgs e)
        {

        }

        //
        //
        // Кнопка "Подтвердить выбор назначаемой кнопки: LazyButton"
        private void LazyButtonButtonОК_Click(object sender, EventArgs e)
        {
            LazyButtonButtonCancel.Enabled = true;
            GroupButtonsOut.Enabled = true;
            NumEnter.Enabled = false;
            NumPlus.Enabled = false;
            NumMinus.Enabled = false;
            UserButton.Enabled = false;
            
            //SelectedIndexChanded = 
            //if (LazyButtonButtonCancel.Enabled == true)  КАК СДЕЛАТЬ ТАК, ЧТОБЫ TABPAGES ЗАБЛОКИРОВАЛИСЬ ПРИ НАЖАТИИ "ПОДТВЕРДИТЬ"
        }

        //
        //
        // Кнопка "Отменить выбор назначаемой кнопки: LazyButton"
        private void LazyButtonButtonCancel_Click(object sender, EventArgs e)
        {
            LazyButtonButtonCancel.Enabled = false;
            GroupButtonsOut.Enabled = false;
            NumEnter.Enabled = true;
            NumPlus.Enabled = true;
            NumMinus.Enabled = true;
            UserButton.Enabled = true;
            //ListGroupButtonsIn.Enabled = true;
        }

        //
        //
        // Кнопка "Подтвердить выбор назначаемой кнопки: NumEnter+NumPlus"
        private void NumEnterButtonOK_Click(object sender, EventArgs e)
        {
            NumEnterButtonCancel.Enabled = true;
            GroupButtonsOut.Enabled = true;
            LazyButton.Enabled = false;
            NumPlus.Enabled = false;
            NumMinus.Enabled = false;
            UserButton.Enabled = false;
        }

        //
        //
        // Кнопка "Отменить выбор назначаемой кнопки: NumEnter+NumPlus"
        private void NumEnterButtonCancel_Click(object sender, EventArgs e)
        {
            NumEnterButtonCancel.Enabled = false;
            GroupButtonsOut.Enabled = false;
            LazyButton.Enabled = true;
            NumPlus.Enabled = true;
            NumMinus.Enabled = true;
            UserButton.Enabled = true;
        }

        // 
        //
        //Кнопка "Подтвердить выбор назначаемой кнопки: NumEnter+NumDel"
        private void NumPlusButtonOK_Click(object sender, EventArgs e)
        {
            NumPlusButtonCancel.Enabled = true;
            GroupButtonsOut.Enabled = true;
            LazyButton.Enabled = false;
            NumEnter.Enabled = false;
            NumMinus.Enabled = false;
            UserButton.Enabled = false;
        }

        //
        //
        // Кнопка "Отменить выбор назначаемой кнопки: NumEnter+NumDel"
        private void NumPlusButtonCancel_Click(object sender, EventArgs e)
        {
            NumPlusButtonCancel.Enabled = false;
            GroupButtonsOut.Enabled = false;
            LazyButton.Enabled = true;
            NumEnter.Enabled = true;
            NumMinus.Enabled = true;
            UserButton.Enabled = true;
        }

        //
        //
        // Кнопка "Подтвердить выбор назначаемой кнопки: NumDel+Num0"
        private void NumMinusButtonOK_Click(object sender, EventArgs e)
        {
            NumMinusButtonCancel.Enabled = true;
            GroupButtonsOut.Enabled = true;
            LazyButton.Enabled = false;
            NumEnter.Enabled = false;
            NumPlus.Enabled = false;
            UserButton.Enabled = false;
        }

        //
        //
        // Кнопка "Отменить выбор назначаемой кнопки: NumDel+Num0"
        private void NumMinusButtonCancel_Click(object sender, EventArgs e)
        {
            NumMinusButtonCancel.Enabled = false;
            GroupButtonsOut.Enabled = false;
            LazyButton.Enabled = true;
            NumEnter.Enabled = true;
            NumPlus.Enabled = true;
            UserButton.Enabled = true;
        }

        //
        //
        // Кнопка "Подтвердить выбор назначаемой кнопки: Назначить свою"
        private void UserButtonButtonOK_Click(object sender, EventArgs e)
        {
            UserButtonButtonCancel.Enabled = true;
            GroupButtonsOut.Enabled = true;
            UserButtonTextBox.Enabled = false;
            LazyButton.Enabled = false;
            NumEnter.Enabled = false;
            NumPlus.Enabled = false;
            NumMinus.Enabled = false;
        }

        //
        //
        // Кнопка "Отменить выбор назначаемой кнопки: Назначить свою"
        private void UserButtonButtonCancel_Click(object sender, EventArgs e)
        {
            UserButtonButtonCancel.Enabled = false;
            GroupButtonsOut.Enabled = false;
            UserButtonTextBox.Enabled = true;
            LazyButton.Enabled = true;
            NumEnter.Enabled = true;
            NumPlus.Enabled = true;
            NumMinus.Enabled = true;
        }

        //
        //
        // ТекстБокс "на какую кнопку или сочетание клавиш назначить чет. UserButton"
        private void UserButtonTextBox_Click(object sender, EventArgs e)
        {
            
        }
        private void UserButtonTextBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            // очищаем поле
            UserButtonTextBox.Text = "";
            // проверяем нажата ли клавиша Ctrl: если да, то записаваем в поле слово Ctrl
            if (e.Control)
            {
                UserButtonTextBox.Text += "Ctrl+";
            }
            // проверяем нажата ли клавиша Shift: если да, то записаваем в поле слово Shift
            if (e.Shift)
            {
                UserButtonTextBox.Text += "Shift+";
            }
            // проверяем нажата ли клавиша Alt: если да, то записаваем в поле слово Alt
            if (e.Alt)
            {
                UserButtonTextBox.Text += "Alt+";
            }
            // копируем KeyData нажатой клавиши
            Keys key = e.KeyData;
            // извлекаем из данных о нажатой клавише коды системных кнопок, таких как Ctrl, Shift, Alt
            key &= ~Keys.Control;
            key &= ~Keys.Shift;
            key &= ~Keys.Alt;
            // выводим полученное словосочетание
            UserButtonTextBox.Text += key.ToString();
        }

        //
        //
        //!!!***   НИЖНАЯЯ ГРУППА   ***!!!\\\ 
        //
        //


        //
        //
        // GroupButtonsOut_Enter - Группа кнопок назначения клавиш.
        private void GroupButtonsOut_Enter(object sender, EventArgs e)
        {
            
        }


        //
        //
        // ТекстБокс "какую кнопку или сочетание клавиш назначить.  KeyboardFunction"
        private void KeyboardFunctionTextBox_Click(object sender, EventArgs e)
        {

        }
        private void KeyboardFunctionTextBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            // очищаем поле
            KeyboardFunctionTextBox.Text = "";
            // проверяем нажата ли клавиша Ctrl: если да, то записаваем в поле слово Ctrl
            if (e.Control)
            {
                KeyboardFunctionTextBox.Text += "Ctrl+";
            }
            // проверяем нажата ли клавиша Shift: если да, то записаваем в поле слово Shift
            if (e.Shift)
            {
                KeyboardFunctionTextBox.Text += "Shift+";
            }
            // проверяем нажата ли клавиша Alt: если да, то записаваем в поле слово Alt
            if (e.Alt)
            {
                KeyboardFunctionTextBox.Text += "Alt+";
            }
            // копируем KeyData нажатой клавиши
            Keys key = e.KeyData;
            // извлекаем из данных о нажатой клавише коды системных кнопок, таких как Ctrl, Shift, Alt
            key &= ~Keys.Control;
            key &= ~Keys.Shift;
            key &= ~Keys.Alt;
            // выводим полученное словосочетание
            KeyboardFunctionTextBox.Text += key.ToString();
        }




        //
        //
        // Кнопка в "Запуск программы" для указания файла, который нужно открыть.
        private void LaunchingTheProgramButtonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LaunchingTheProgramTextBox.Text = ofd.SafeFileName;
                LaunchingTheProgramFileWayTextBox.Text = ofd.FileName;
            }

        }

        private void ListGroupButtonsIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}