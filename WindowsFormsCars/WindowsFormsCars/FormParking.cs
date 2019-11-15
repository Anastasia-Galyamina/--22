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
    public partial class FormParking : Form
    {
        /// <summary>
        /// Объект от класса многоуровневой парковки
        /// </summary>
         MultiLevelParking parking;        
        /// <summary>
        /// Форма для добавления
        /// </summary>
        FormShipConfig form;
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
                     var ship = parking[listBoxLevels.SelectedIndex] -
                     Convert.ToInt32(maskedTextBox.Text);
                     if (ship != null)
                     {
                         Bitmap bmp = new Bitmap(pictureBoxTakeShip.Width,
                         pictureBoxTakeShip.Height);
                         Graphics gr = Graphics.FromImage(bmp);
                         ship.SetPosition(5, 5, pictureBoxTakeShip.Width,
                         pictureBoxTakeShip.Height);
                         ship.DrawShip(gr);
                         pictureBoxTakeShip.Image = bmp;
                     }
                     else
                     {
                         Bitmap bmp = new Bitmap(pictureBoxTakeShip.Width,
                         pictureBoxTakeShip.Height);
                         pictureBoxTakeShip.Image = bmp;
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
        /// <summary>
        /// Обработка нажатия кнопки "Добавить автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetShip_Click(object sender, EventArgs e)
        {
            form = new FormShipConfig();
            form.AddEvent(AddCar);
            form.Show();
        }
        /// <summary>
        /// Метод добавления машины
        /// </summary>
        /// <param name="car"></param>
        private void AddCar(ITransport ship)
        {
            if (ship != null && listBoxLevels.SelectedIndex > -1)
            {
                int place = parking[listBoxLevels.SelectedIndex] + ship;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Корабль не удалось поставить");
                }
            }
        }

    }
}
