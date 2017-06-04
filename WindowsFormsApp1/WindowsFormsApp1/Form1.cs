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

//1) Нужно посмотреть момент с блокировкой переходов по TabPage при нажании кнопки "подтвердить" и разблокировкой этого же, при "отменить"
//2) Посмотреть момент со считыванием клавиш при вводе в "назначить свою". чтобы не дублировался shiftKey\altkey\controlkey (с If поиграть)

namespace LazyButton
{
    public partial class Form1 : MetroForm //"Form" было изначально, а не "MetroForm"
    {
        /*
        // Поле для сохранения позиции окна - Field for saving window position
        private Rectangle m_rcWindow;

        // Поле для хранения регистров - Field for registy storage
        private string m_strRegKey = "Software\\RandyRants\\LazyButton";

        // Hashtable для отслеживания текста для сканирования кодов - Hashtable for tracking text to scan codes
        private Hashtable m_hashKeys = null;

        // флаг (для просмотра дорожки, если сопоставления сохранены) - Dirty flag (to see track if mappings have been saved)
        private bool m_bDirty = false;
        */



        //Для работы с клавой.
        [DllImport("USER32.DLL")]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("USER32.DLL")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        //для вызова функции LockWorkStation - блокировка компа = смена пользователя = Win + L
        [DllImport("user32.dll")]
        private static extern void LockWorkStation();
        //щелкаем мышкой
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
            ShowInTaskbar = false; // скрывает значка формы на панели задач. Если свернул - то можно вызвать только Alt+Tab
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
            DefaultTextBox1.Text = "ничего не назначено";


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
            DefaultTextBox1.Text = "";
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
            DefaultTextBox1.Text = "Num Enter";
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
            DefaultTextBox1.Text = "";
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
            DefaultTextBox1.Text = "Num +";
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
            DefaultTextBox1.Text = "";
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
            DefaultTextBox1.Text = "Num -";
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
            DefaultTextBox1.Text = "";
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
            DefaultTextBox1.Text = UserButtonTextBox.Text;
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
            DefaultTextBox1.Text = "";
            UserButtonTextBox.Text = "";
        }

        //
        //
        // ТекстБокс "на какую кнопку или сочетание клавиш назначить чет. UserButton"
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


       
        private static void KeybordToMouse_event(object sender, KeyPressEventArgs eee)
        {            
            if (eee.KeyChar == 'q')
            {
                mouse_event(MouseEventF_LeftDown, 0, 0, 0, UIntPtr.Zero);
                mouse_event(MouseEventF_LeftUp, 0, 0, 0, UIntPtr.Zero);
            }
        }

        private void MouseFunctionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(MouseFunctionComboBox.SelectedItem.ToString() == "Щелчок")
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
            LockWorkStation(); // блокировка компа = смена пользователя = Win + L
            
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

        
    }
}