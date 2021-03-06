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
    public partial class FormShip : Form
    {
        private MotorShip ship;
        public FormShip()
        {
            InitializeComponent();
        }
       private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
            Graphics gr = Graphics.FromImage(bmp);
            
            ship.DrawCar(gr);
            pictureBoxShip.Image = bmp;
        }
        //Создаём корабль
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new MotorShip(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue,
           Color.Yellow, true);
            ship.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxShip.Width,
           pictureBoxShip.Height);
            Draw();
        }
        /// Обработка нажатия кнопок управления
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    ship.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    ship.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    ship.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    ship.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
