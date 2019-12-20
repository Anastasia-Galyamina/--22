using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCars
{
    public partial class FormShipConfig : Form
    {
        /// <summary>
        /// Переменная-выбранный корабль
        /// </summary>
        ITransport ship = null;
        /// <summary>
        /// Событие
        /// </summary>
        private event shipDelegate eventAddShip;

        public FormShipConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        /// <summary>
        /// Отрисовать корабль
        /// </summary>
        private void DrawShip()
        {
            if (ship != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ship.SetPosition(5, 5, pictureBoxShip.Width, pictureBoxShip.Height);
                ship.DrawShip(gr);
                pictureBoxShip.Image = bmp;
            }
        }
        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(shipDelegate ev)
        {
            if (eventAddShip == null)
            {
                eventAddShip = new shipDelegate(ev);
            }
            else
            {
                eventAddShip += ev;
            }
        }
        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelShip_MouseDown(object sender, MouseEventArgs e)
        {
            labelShip.DoDragDrop(labelShip.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }
        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelMotorShip_MouseDown(object sender, MouseEventArgs e)
        {
            labelMotorShip.DoDragDrop(labelMotorShip.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelCar_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelCar_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Корабль":
                    ship = new Ship(100, 500, Color.White);
                    break;
                case "Теплоход":
                    ship = new MotorShip(100, 500, Color.White, Color.Black, true);
                    break;
            }
            DrawShip();
        }
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
           DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Принимаем основной цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                ship.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawShip();
            }
        }
        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                if (ship is MotorShip)
                {
                    (ship as MotorShip).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawShip();
                }
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddShip?.Invoke(ship);
            Close();
        }

    }
}
