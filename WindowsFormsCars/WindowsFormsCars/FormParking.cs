﻿using System;
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
    public partial class FormParking : Form
    {
        /// <summary>
        /// Объект от класса многоуровневой парковки
        /// </summary>
         MultiLevelParking parking;
        /// <summary>
        /// Количество уровней-парковок
        /// </summary>
        private const int countLevel = 5;
        public FormParking()
        {
            InitializeComponent();
            parking = new MultiLevelParking(countLevel, pictureBoxParking.Width,
            pictureBoxParking.Height);
            //заполнение listBox
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
           if (listBoxLevels.SelectedIndex > -1)
           {
            /*если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран
             и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)*/
            Bitmap bmp = new Bitmap(pictureBoxParking.Width,
            pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking[listBoxLevels.SelectedIndex].Draw(gr);
            pictureBoxParking.Image = bmp;
           }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать корабль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetShip_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                 ColorDialog dialog = new ColorDialog();
                 if (dialog.ShowDialog() == DialogResult.OK)
                 {
                     var car = new Car(100, 1000, dialog.Color);
                     int place = parking[listBoxLevels.SelectedIndex] + car;
                     if (place == -1)
                     {
                        MessageBox.Show("Нет свободных мест", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                     Draw();
                 }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать теплоход"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetMotorShip_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                     ColorDialog dialogDop = new ColorDialog();
                     if (dialogDop.ShowDialog() == DialogResult.OK)
                     {
                        var car = new SportCar(100, 1000, dialog.Color,
                        dialogDop.Color, true, true, true);
                        int place = parking[listBoxLevels.SelectedIndex] + car;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                     }
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Забрать корабль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeShip_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                 if (maskedTextBox.Text != "")
                 {
                     var car = parking[listBoxLevels.SelectedIndex] -
                     Convert.ToInt32(maskedTextBox.Text);
                     if (car != null)
                     {
                         Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width,
                         pictureBoxTakeCar.Height);
                         Graphics gr = Graphics.FromImage(bmp);
                         car.SetPosition(5, 5, pictureBoxTakeCar.Width,
                         pictureBoxTakeCar.Height);
                         car.DrawCar(gr);
                         pictureBoxTakeCar.Image = bmp;
                     }
                     else
                     {
                         Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width,
                         pictureBoxTakeCar.Height);
                         pictureBoxTakeCar.Image = bmp;
                     }
                     Draw();
                 }
             }
        } 
        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
