using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components; //для работы метро
using MetroFramework.Forms; //для работы метро
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Collections;
using System.Diagnostics;
using Shell32;

//1) Нужно посмотреть момент с блокировкой переходов по TabPage при нажании кнопки "подтвердить" и разблокировкой этого же, при "отменить"
//2) Посмотреть момент со считыванием клавиш при вводе в "назначить свою". чтобы не дублировался shiftKey\altkey\controlkey (с If поиграть)

namespace LazyButton
{
    public partial class Form1 : MetroForm //"Form" было изначально, а не "MetroForm"
    {
        // Для работы с клавой.
        [DllImport("USER32.DLL")]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("USER32.DLL")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        // Для вызова функции LockWorkStation - блокировка компа = смена пользователя = Win + L.
        [DllImport("user32.dll")]
        private static extern void LockWorkStation();
        // Щелкаем мышкой.
        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, UIntPtr dwExtraInfo);
        const int MouseEventF_Move = 0x0001;
        const int MouseEventF_LeftDown = 0x0002;
        const int MouseEventF_LeftUp = 0x0004;
        const int MouseEventF_RightDown = 0x0008;
        const int MouseEventF_RightUp = 0x0010;
        const int MouseEventF_Absolute = 0x8000;
        
        public Form1()
        {
            InitializeComponent();
           // ShowInTaskbar = false; // скрывает значка формы на панели задач. Если свернул - то можно вызвать только Alt+Tab.
        }
                
        private void Form1_Load(object sender, EventArgs e)
        {
           // Cursor = Cursors.WaitCursor;

        }               
        //
        //
        // Код для кнопки F.A.Q. 
        private void FAQ_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this,
                "1) Выбери один из стандартных вариантов сочетаний клавиш или введи свою.\n2) Назначь стандартную операцию или выбери свою.\n3) Нажми ''Сохранить'' и будь счатлив(а)!\nУдачи! :)\n\nP.S.: Если потеряли приложение - жми Alt+Tab.",
                "А собственно как это?", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        //
        //
        // Вывод запроса при закрытии формы
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Вы уверены, что хотите выйти из программы?\nЕсли вы закроете программу все назначенные назначения 'слетят'!",
                                "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No)
            {
                e.Cancel = true;
            }
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
        // Кнопка "Подтвердить выбор назначаемой кнопки: LazyButton".
        private void LazyButtonButtonОК_Click(object sender, EventArgs e)
        {
            LazyButtonButtonCancel.Enabled = true;
            LazyButtonButtonОК.Enabled = false;
            GroupButtonsOut.Enabled = true;
            NumMultiply.Enabled = false;
            NumPlus.Enabled = false;
            NumMinus.Enabled = false;
            UserButton.Enabled = false;
            DefaultTextBox1.Text = "ничего не назначено";


            //SelectedIndexChanded = 
            //if (LazyButtonButtonCancel.Enabled == true)  КАК СДЕЛАТЬ ТАК, ЧТОБЫ TABPAGES ЗАБЛОКИРОВАЛИСЬ ПРИ НАЖАТИИ "ПОДТВЕРДИТЬ"
        }

        //
        //
        // Кнопка "Отменить выбор назначаемой кнопки: LazyButton".
        private void LazyButtonButtonCancel_Click(object sender, EventArgs e)
        {
            LazyButtonButtonCancel.Enabled = false;
            LazyButtonButtonОК.Enabled = true;
            GroupButtonsOut.Enabled = false;
            NumMultiply.Enabled = true;
            NumPlus.Enabled = true;
            NumMinus.Enabled = true;
            UserButton.Enabled = true;
            DefaultTextBox1.Text = "";
            KeyboardFunctionTextBox.Text = "";
            MouseFunctionComboBox.SelectedItem = "---";
            WINDOWSKeyCombinationComboBox.SelectedIndex = 0;
            LaunchingTheProgramTextBox.Text = "";
            LaunchingTheProgramFileWayTextBox.Text = "";
            //ListGroupButtonsIn.Enabled = true;
        }

        //
        //
        // Кнопка "Подтвердить выбор назначаемой кнопки: NumMultiply".
        private void NumMultiplyButtonOK_Click(object sender, EventArgs e)
        {
            NumMultiplyButtonCancel.Enabled = true;
            NumMultiplyButtonOK.Enabled = false;
            GroupButtonsOut.Enabled = true;
            LazyButton.Enabled = false;
            NumPlus.Enabled = false;
            NumMinus.Enabled = false;
            UserButton.Enabled = false;
            DefaultTextBox1.Text = "Num Multiply";
        }

        //
        //
        // Кнопка "Отменить выбор назначаемой кнопки: Num Multiply".
        private void NumMultiplyButtonCancel_Click(object sender, EventArgs e)
        {
            NumMultiplyButtonCancel.Enabled = false;
            NumMultiplyButtonOK.Enabled = true;
            GroupButtonsOut.Enabled = false;
            LazyButton.Enabled = true;
            NumPlus.Enabled = true;
            NumMinus.Enabled = true;
            UserButton.Enabled = true;
            DefaultTextBox1.Text = "";
            KeyboardFunctionTextBox.Text = "";
            MouseFunctionComboBox.SelectedItem = "---";
            WINDOWSKeyCombinationComboBox.SelectedIndex = 0;
            LaunchingTheProgramTextBox.Text = "";
            LaunchingTheProgramFileWayTextBox.Text = "";
        }

        // 
        //
        //Кнопка "Подтвердить выбор назначаемой кнопки: NumPlus".
        private void NumPlusButtonOK_Click(object sender, EventArgs e)
        {
            NumPlusButtonCancel.Enabled = true;
            NumPlusButtonOK.Enabled = false;
            GroupButtonsOut.Enabled = true;
            LazyButton.Enabled = false;
            NumMultiply.Enabled = false;
            NumMinus.Enabled = false;
            UserButton.Enabled = false;
            DefaultTextBox1.Text = "Num +";
        }

        //
        //
        // Кнопка "Отменить выбор назначаемой кнопки: NumPlus".
        private void NumPlusButtonCancel_Click(object sender, EventArgs e)
        {
            NumPlusButtonCancel.Enabled = false;
            NumPlusButtonOK.Enabled = true;
            GroupButtonsOut.Enabled = false;
            LazyButton.Enabled = true;
            NumMultiply.Enabled = true;
            NumMinus.Enabled = true;
            UserButton.Enabled = true;
            DefaultTextBox1.Text = "";
            KeyboardFunctionTextBox.Text = "";
            MouseFunctionComboBox.SelectedItem = "---";
            WINDOWSKeyCombinationComboBox.SelectedIndex = 0;
            LaunchingTheProgramTextBox.Text = "";
            LaunchingTheProgramFileWayTextBox.Text = "";
        }

        //
        //
        // Кнопка "Подтвердить выбор назначаемой кнопки: NumMinus".
        private void NumMinusButtonOK_Click(object sender, EventArgs e)
        {
            NumMinusButtonCancel.Enabled = true;
            NumMinusButtonOK.Enabled = false;
            GroupButtonsOut.Enabled = true;
            LazyButton.Enabled = false;
            NumMultiply.Enabled = false;
            NumPlus.Enabled = false;
            UserButton.Enabled = false;
            DefaultTextBox1.Text = "Num -";
        }

        //
        //
        // Кнопка "Отменить выбор назначаемой кнопки: NumMinus".
        private void NumMinusButtonCancel_Click(object sender, EventArgs e)
        {
            NumMinusButtonCancel.Enabled = false;
            NumMinusButtonOK.Enabled = true;
            GroupButtonsOut.Enabled = false;
            LazyButton.Enabled = true;
            NumMultiply.Enabled = true;
            NumPlus.Enabled = true;
            UserButton.Enabled = true;
            DefaultTextBox1.Text = "";            
            KeyboardFunctionTextBox.Text = "";
            MouseFunctionComboBox.SelectedItem = "---";
            WINDOWSKeyCombinationComboBox.SelectedIndex = 0;
            LaunchingTheProgramTextBox.Text = "";
            LaunchingTheProgramFileWayTextBox.Text = "";
        }

        //
        //
        // Кнопка "Подтвердить выбор назначаемой кнопки: Назначить свою".
        private void UserButtonButtonOK_Click(object sender, EventArgs e)
        {
            UserButtonButtonCancel.Enabled = true;
            UserButtonButtonOK.Enabled = false;
            GroupButtonsOut.Enabled = true;
            UserButtonTextBox.Enabled = false;
            LazyButton.Enabled = false;
            NumMultiply.Enabled = false;
            NumPlus.Enabled = false;
            NumMinus.Enabled = false;
            DefaultTextBox1.Text = UserButtonTextBox.Text;
        }
        //
        //
        // Кнопка "Отменить выбор назначаемой кнопки: Назначить свою".
        private void UserButtonButtonCancel_Click(object sender, EventArgs e)
        {
            UserButtonButtonCancel.Enabled = false;
            UserButtonButtonOK.Enabled = true;
            GroupButtonsOut.Enabled = false;
            UserButtonTextBox.Enabled = true;
            LazyButton.Enabled = true;
            NumMultiply.Enabled = true;
            NumPlus.Enabled = true;
            NumMinus.Enabled = true;
            DefaultTextBox1.Text = "";
            UserButtonTextBox.Text = "";
            KeyboardFunctionTextBox.Text = "";
            MouseFunctionComboBox.SelectedItem = "---";
            WINDOWSKeyCombinationComboBox.SelectedIndex = 0;
            LaunchingTheProgramTextBox.Text = "";
            LaunchingTheProgramFileWayTextBox.Text = "";
        }

        //
        //
        // ТекстБокс "на какую кнопку или сочетание клавиш назначить чет. UserButton".
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
        // По умолчанию.
        // Кнопка "сохранить" по умолчанию.      
        private void DefaultButtonSave_Click(object sender, EventArgs e)
        {
            KeyboardFunctionTextBox.Text = "";
            MouseFunctionComboBox.SelectedItem = "---";
            WINDOWSKeyCombinationComboBox.SelectedIndex = 0;
            LaunchingTheProgramTextBox.Text = "";
            LaunchingTheProgramFileWayTextBox.Text = "";
            GroupButtonsOut.Enabled = false;
        }

        //
        // Функция клавиатуры.
        // ТекстБокс "какую кнопку или сочетание клавиш назначить.  KeyboardFunction".              
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
        // Функция клавиатуры.
        // Кнопка "сохранить" функцию клавиатуры.  
        private void KeyboardFunctionButtonSave_Click(object sender, EventArgs e)
        {
            DefaultTextBox1.Text = "";
            MouseFunctionComboBox.SelectedItem = "---";
            WINDOWSKeyCombinationComboBox.SelectedIndex = 0;
            LaunchingTheProgramTextBox.Text = "";
            LaunchingTheProgramFileWayTextBox.Text = "";
            GroupButtonsOut.Enabled = false;                       
        }

        //
        // Функция мыши.
        // Кнопка "сохранить" функцию мыши.
        private void MouseFunctionButtonSave_Click(object sender, EventArgs e)
        {
            DefaultTextBox1.Text = "";
            KeyboardFunctionTextBox.Text = "";
            WINDOWSKeyCombinationComboBox.SelectedIndex = 0;
            LaunchingTheProgramTextBox.Text = "";
            LaunchingTheProgramFileWayTextBox.Text = "";
            GroupButtonsOut.Enabled = false;
        }

        //
        // Сочетание клавиш Windows.
        // Кнопка "сохранить" сочетание клавиш Windows.
        private void WINDOWSKeyCombinationButtonSave_Click(object sender, EventArgs e)
        {
            DefaultTextBox1.Text = "";
            KeyboardFunctionTextBox.Text = "";
            MouseFunctionComboBox.SelectedItem = "---";
            LaunchingTheProgramTextBox.Text = "";
            LaunchingTheProgramFileWayTextBox.Text = "";
            GroupButtonsOut.Enabled = false;
        }

        //
        // Запуск программы.
        // Кнопка "сохранить" запуск программы.
        private void LaunchingTheProgramButtonSave_Click(object sender, EventArgs e)
        {
            DefaultTextBox1.Text = "";
            KeyboardFunctionTextBox.Text = "";
            MouseFunctionComboBox.SelectedItem = "---";
            WINDOWSKeyCombinationComboBox.SelectedIndex = 0;
            GroupButtonsOut.Enabled = false;
        }
        //
        //
        // Серия циклов по:
        // 1) Реализация назначения Запуска программы по нажатию клавиши.
        // 2) Реализация назначения Функции мыши.
        // 3) Реализация назначения Сочетания клавиш Windows.
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyData;            
            KeysConverter converter = new KeysConverter();
            string text = converter.ConvertToString(e.KeyCode);
            // 1) Реализация назначения Запуска программы по нажатию клавиши.
            // Цикл запуска программы на нажание Num Multiply.
            if (e.KeyCode == Keys.Multiply && NumMultiplyButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false) //e.KeyCode == SendKeys.Equals()
            {
                if (LaunchingTheProgramFileWayTextBox.Text == "")
                {

                }
                else
                {
                    Process note = Process.Start(LaunchingTheProgramFileWayTextBox.Text);
                }
            }
            // Цикл запуска программы на нажатие Num Plus.
            if (e.KeyCode == Keys.Add && NumPlusButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false) //e.KeyCode == SendKeys.Equals()
            {
                if (LaunchingTheProgramFileWayTextBox.Text == "")
                {

                }
                else
                {
                    Process note = Process.Start(LaunchingTheProgramFileWayTextBox.Text);
                }
            }
            // Цикл запуска программы на нажатие Num Minus.
            if (e.KeyCode == Keys.Subtract && NumMinusButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false) //e.KeyCode == SendKeys.Equals()
            {
                if (LaunchingTheProgramFileWayTextBox.Text == "")
                {

                }
                else
                {
                    Process note = Process.Start(LaunchingTheProgramFileWayTextBox.Text);
                }
            }
            // Цикл запуска программы на назначенную пользователем клавишу.
            if (((object)text).Equals((object)UserButtonTextBox.Text) && UserButtonButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false) //e.KeyCode == SendKeys.Equals()
            {
                if (LaunchingTheProgramFileWayTextBox.Text == "")
                {

                }
                else
                {
                    Process note = Process.Start(LaunchingTheProgramFileWayTextBox.Text);                    
                }                
            }

            // Все эти "варнинги" вылезли из-за торго, что не написано у меня .ToString() после каждого Item'a. но если написать - исключение не проработано. НУЖНО ПРОРАБОТАТЬ!
            // 2) Реализация назначения Функции мыши.
            // Цикл запуска Щелчка мыши на нажание Num Multiply.
            if (MouseFunctionComboBox.SelectedItem == "Щелчок" && e.KeyCode == Keys.Multiply && NumMultiplyButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false)
            {
                mouse_event(MouseEventF_LeftDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_LeftUp, 0, 0, 0, UIntPtr.Zero);
            }
            // Цикл запуска Щелчка мыши на нажание Num Plus.
            if (MouseFunctionComboBox.SelectedItem == "Щелчок" && e.KeyCode == Keys.Add && NumPlusButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false)
            {
                mouse_event(MouseEventF_LeftDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_LeftUp, 0, 0, 0, UIntPtr.Zero);
            }
            // Цикл запуска Щелчка мыши на нажание Num Minus.
            if (MouseFunctionComboBox.SelectedItem == "Щелчок" && e.KeyCode == Keys.Subtract && NumMinusButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false)
            {
                mouse_event(MouseEventF_LeftDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_LeftUp, 0, 0, 0, UIntPtr.Zero);
            }
            // Цикл запуска Щелчка мыши на назначенную пользователем клавишу.
            if (MouseFunctionComboBox.SelectedItem == "Щелчок" && ((object)text).Equals((object)UserButtonTextBox.Text) && UserButtonButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false)
            {
                mouse_event(MouseEventF_LeftDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_LeftUp, 0, 0, 0, UIntPtr.Zero);

            }
            // Цикл запуска Двойного щелчка мыши на нажание Num Multiply.
            if (MouseFunctionComboBox.SelectedItem == "Двойной щелчок" && e.KeyCode == Keys.Multiply && NumMultiplyButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false)
            {
                mouse_event(MouseEventF_LeftDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_LeftUp, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_LeftDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_LeftUp, 0, 0, 0, UIntPtr.Zero);
            }
            // Цикл запуска Двойного щелчка мыши на нажание Num Plus.
            if (MouseFunctionComboBox.SelectedItem == "Двойной щелчок" && e.KeyCode == Keys.Add && NumPlusButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false)
            {
                mouse_event(MouseEventF_LeftDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_LeftUp, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_LeftDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_LeftUp, 0, 0, 0, UIntPtr.Zero);
            }
            // Цикл запуска Двойного щелчка мыши на нажание Num Minus.
            if (MouseFunctionComboBox.SelectedItem == "Двойной щелчок" && e.KeyCode == Keys.Subtract && NumMinusButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false)
            {
                mouse_event(MouseEventF_LeftDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_LeftUp, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_LeftDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_LeftUp, 0, 0, 0, UIntPtr.Zero);
            }
            // Цикл запуска Двойного щелчка мыши на назначенную пользователем клавишу.
            if (MouseFunctionComboBox.SelectedItem == "Двойной щелчок" && ((object)text).Equals((object)UserButtonTextBox.Text) && UserButtonButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false)
            {
                mouse_event(MouseEventF_LeftDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_LeftUp, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_LeftDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_LeftUp, 0, 0, 0, UIntPtr.Zero);

            }
            // Цикл запуска Меню мыши на нажание Num Multiply.
            if (MouseFunctionComboBox.SelectedItem == "Меню" && e.KeyCode == Keys.Multiply && NumMultiplyButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false)
            {
                mouse_event(MouseEventF_RightDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_RightUp, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_RightDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_RightUp, 0, 0, 0, UIntPtr.Zero);
            }
            // Цикл запуска Меню мыши на нажание Num Plus.
            if (MouseFunctionComboBox.SelectedItem == "Меню" && e.KeyCode == Keys.Add && NumPlusButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false)
            {
                mouse_event(MouseEventF_RightDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_RightUp, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_RightDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_RightUp, 0, 0, 0, UIntPtr.Zero);
            }
            // Цикл запуска Меню мыши на нажание Num Minus.
            if (MouseFunctionComboBox.SelectedItem == "Меню" && e.KeyCode == Keys.Subtract && NumMinusButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false)
            {
                mouse_event(MouseEventF_RightDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_RightUp, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_RightDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_RightUp, 0, 0, 0, UIntPtr.Zero);
            }
            // Цикл запуска Меню мыши на назначенную пользователем клавишу.
            if (MouseFunctionComboBox.SelectedItem == "Меню" && ((object)text).Equals((object)UserButtonTextBox.Text) && UserButtonButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false)
            {
                mouse_event(MouseEventF_RightDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_RightUp, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_RightDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_RightUp, 0, 0, 0, UIntPtr.Zero);

            }

            // 3) Реализация назначения Сочетания клавиш Windows.
            // Цикл запуска Сочетания клавиш Windows: "LockWorkStation" на нажание Num Multiply.
            if (WINDOWSKeyCombinationComboBox.SelectedItem == "LockWorkStation" && e.KeyCode == Keys.Multiply && NumMultiplyButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false) //e.KeyCode == SendKeys.Equals()
            {
                LockWorkStation();
            }
            // Цикл запуска Сочетания клавиш Windows: "LockWorkStation" на нажатие Num Plus.
            if (WINDOWSKeyCombinationComboBox.SelectedItem == "LockWorkStation" && e.KeyCode == Keys.Add && NumPlusButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false) //e.KeyCode == SendKeys.Equals()
            {
                LockWorkStation();
            }
            // Цикл запуска Сочетания клавиш Windows: "LockWorkStation" на нажатие Num Minus.
            if (WINDOWSKeyCombinationComboBox.SelectedItem == "LockWorkStation" && e.KeyCode == Keys.Subtract && NumMinusButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false) //e.KeyCode == SendKeys.Equals()
            {
                LockWorkStation();
            }
            // Цикл запуска Сочетания клавиш Windows: "LockWorkStation" на назначенную пользователем клавишу.
            if (WINDOWSKeyCombinationComboBox.SelectedItem == "LockWorkStation" && ((object)text).Equals((object)UserButtonTextBox.Text) && UserButtonButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false) //e.KeyCode == SendKeys.Equals()
            {
                LockWorkStation();
            }
            // Цикл запуска Сочетания клавиш Windows: "Свернуть все окна" на нажание Num Multiply.
            Shell32.Shell shell = new Shell32.Shell();
            if (WINDOWSKeyCombinationComboBox.SelectedItem == "Свернуть все окна" && e.KeyCode == Keys.Multiply && NumMultiplyButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false) //e.KeyCode == SendKeys.Equals()
            {
                shell.MinimizeAll();
            }
            // Цикл запуска Сочетания клавиш Windows: "Свернуть все окна" на нажатие Num Plus.
            if (WINDOWSKeyCombinationComboBox.SelectedItem == "Свернуть все окна" && e.KeyCode == Keys.Add && NumPlusButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false) //e.KeyCode == SendKeys.Equals()
            {
                shell.MinimizeAll();
            }
            // Цикл запуска Сочетания клавиш Windows: "Свернуть все окна" на нажатие Num Minus.
            if (WINDOWSKeyCombinationComboBox.SelectedItem == "Свернуть все окна" && e.KeyCode == Keys.Subtract && NumMinusButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false) //e.KeyCode == SendKeys.Equals()
            {
                shell.MinimizeAll();
            }
            // Цикл запуска Сочетания клавиш Windows: "Свернуть все окна" на назначенную пользователем клавишу.
            if (WINDOWSKeyCombinationComboBox.SelectedItem == "Свернуть все окна" && ((object)text).Equals((object)UserButtonTextBox.Text) && UserButtonButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false) //e.KeyCode == SendKeys.Equals()
            {
                shell.MinimizeAll();
            }
            // Цикл запуска Сочетания клавиш Windows: "Alt + TAB" на нажание Num Multiply.
            if (WINDOWSKeyCombinationComboBox.SelectedItem == "Alt + TAB" && e.KeyCode == Keys.Multiply && NumMultiplyButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false) //e.KeyCode == SendKeys.Equals()
            {
                SendKeys.Send("%{TAB}");                
            }
            // Цикл запуска Сочетания клавиш Windows: "Alt + TAB" на нажатие Num Plus.
            if (WINDOWSKeyCombinationComboBox.SelectedItem == "Alt + TAB" && e.KeyCode == Keys.Add && NumPlusButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false) //e.KeyCode == SendKeys.Equals()
            {
                SendKeys.Send("%{TAB}");
            }
            // Цикл запуска Сочетания клавиш Windows: "Alt + TAB" на нажатие Num Minus.
            if (WINDOWSKeyCombinationComboBox.SelectedItem == "Alt + TAB" && e.KeyCode == Keys.Subtract && NumMinusButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false) //e.KeyCode == SendKeys.Equals()
            {
                SendKeys.Send("%{TAB}");
            }
            // Цикл запуска Сочетания клавиш Windows: "Alt + TAB" на назначенную пользователем клавишу.
            if (WINDOWSKeyCombinationComboBox.SelectedItem == "Alt + TAB" && ((object)text).Equals((object)UserButtonTextBox.Text) && UserButtonButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false) //e.KeyCode == SendKeys.Equals()
            {
                SendKeys.Send("%{TAB}");
            }            
            /*
            // Доделать это. после разбора с глобальной работой приложения. ибо закрывать свое же приложение так, когда есть "крестик" - бесмыссленно.
            // Из коллекции комбоБокса "Закрыть приложение ( Alt +F4)" - удален до обновлений.
            // Аналогично для "Вырезать", "Копировать", "Вставить", "Альт + Принскрин".
            // Цикл запуска Сочетания клавиш Windows: "Закрыть приложение ( Alt +F4)" на нажание Num Multiply.
            if (WINDOWSKeyCombinationComboBox.SelectedItem == "Закрыть приложение (Alt +F4)" && e.KeyCode == Keys.Multiply && NumMultiplyButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false) //e.KeyCode == SendKeys.Equals()
            {
                SendKeys.Send("%{F4}");
            }
            // Цикл запуска Сочетания клавиш Windows: "Закрыть приложение ( Alt +F4)" на нажатие Num Plus.
            if (WINDOWSKeyCombinationComboBox.SelectedItem == "Закрыть приложение (Alt +F4)" && e.KeyCode == Keys.Add && NumPlusButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false) //e.KeyCode == SendKeys.Equals()
            {
                SendKeys.Send("%{F4}");
            }
            // Цикл запуска Сочетания клавиш Windows: "Закрыть приложение ( Alt +F4)" на нажатие Num Minus.
            if (WINDOWSKeyCombinationComboBox.SelectedItem == "Закрыть приложение (Alt +F4)" && e.KeyCode == Keys.Subtract && NumMinusButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false) //e.KeyCode == SendKeys.Equals()
            {
                SendKeys.Send("%{F4}");
            }
            // Цикл запуска Сочетания клавиш Windows: "Закрыть приложение ( Alt +F4)" на назначенную пользователем клавишу.
            if (WINDOWSKeyCombinationComboBox.SelectedItem == "Закрыть приложение (Alt +F4)" && ((object)text).Equals((object)UserButtonTextBox.Text) && UserButtonButtonCancel.Enabled == true && GroupButtonsOut.Enabled == false) //e.KeyCode == SendKeys.Equals()
            {
                SendKeys.Send("%{F4}");
            }
            //альт+принскрин. без % - просто принскрин
            //SendKeys.Send("%{PRTSC}");       
            */
        }





        //
        //
        // Функция мышки. при нажатии пробела курсор переходит на "пуск" и тыкает по нему
        private void KeybordToMouse_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (e.KeyChar == ' ')
            {
                mouse_event(MouseEventF_Move | MouseEventF_Absolute, 400, 65000, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_LeftDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_LeftUp, 0, 0, 0, UIntPtr.Zero);
            }
        }


        //
        //
        // Функция мышки
        private void MouseFunctionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Цикл запуска Щелчка мыши на нажание Num Multiply.
            if (MouseFunctionComboBox.SelectedItem.ToString() == "Щелчок")
            {
                // KeybordToMouse_event();
                //e.KeyCode == Keys.Enter;
            }


            /*
             *  const int MouseEventF_Move = 0x0001;
                const int MouseEventF_LeftDown = 0x0002;
                const int MouseEventF_LeftUp = 0x0004;
                const int MouseEventF_RightDown = 0x0008;
                const int MouseEventF_RightUp = 0x0010;
                const int MouseEventF_Absolute = 0x8000;
             * 
             * 
             * 
             * 
            MessageBox.Show("Selected Item Text: " + MouseFunctionComboBox.SelectedItem.ToString() + "\n" +
                    "Index: " + MouseFunctionComboBox.SelectedIndex.ToString());
            */
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



        //
        //
        // Это типа кнопка на ардуино
        private void TestButton_Click(object sender, EventArgs e)
        {
            //Process.Start("mspaint"); // запуск Paint
            //WindowState = FormWindowState.Minimized; //сворачивание окна приложения
            //LockWorkStation(); // блокировка компа = смена пользователя = Win + L

            // свернуть все окна
            //Shell32.Shell shell = new Shell32.Shell();
            //shell.MinimizeAll();
            
            /* щелчок мыши по пуску
            mouse_event(MouseEventF_Move | MouseEventF_Absolute, 400, 65000, 0, UIntPtr.Zero);
            mouse_event(MouseEventF_LeftDown, 0, 0, 0, UIntPtr.Zero);
            mouse_event(MouseEventF_LeftUp, 0, 0, 0, UIntPtr.Zero);
            */


            /*
            //запуск указанной проги
            if (LaunchingTheProgramFileWayTextBox.Text == "")
            {

            }
            else
            {
                Process note = Process.Start(LaunchingTheProgramFileWayTextBox.Text);
                //note.WaitForInputIdle(); //блок на др действия, пока заданное приложение не запустится 
            }
            */

            /*
            // ввод в блокнот текста
            IntPtr notepadHandle = FindWindow(null, "Блокнот");

            SetForegroundWindow(notepadHandle);
            SendKeys.SendWait("C# ");
            SendKeys.SendWait(" Народные советы");
            SendKeys.SendWait("~");
            SendKeys.SendWait("    Обалдеть!");
            */
        }
    }
}