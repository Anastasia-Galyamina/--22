using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsCars
{
    class MotorShip : Ship
    {
        
        public bool Tube { private set; get; }        
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия переднего спойлера
        /// </summary>

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="frontSpoiler">Признак наличия переднего спойлера</param>
        /// <param name="sideSpoiler">Признак наличия боковых спойлеров</param>
        /// <param name="backSpoiler">Признак наличия заднего спойлера</param>
        public MotorShip(int maxSpeed, float weight, Color mainColor, Color dopColor, bool tube) : base(maxSpeed, weight, mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Tube = tube;
        }
        /// <summary>
        /// Установка позиции автомобиля
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>

        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        /// 






        public void DrawTube(Graphics g)
        {
            //Pen pen = new Pen(Color.Black);
            //g.DrawLine(pen, _startPosX + 100, _startPosY + 20, _startPosX + 100, _startPosY);

            Brush brRed = new SolidBrush(Color.Red);
            g.FillRectangle(brRed, _startPosX + 100, _startPosY, 10, 20);

        }


        
        /// <summary>
        /// Отрисовка автомобиля
        /// </summary>
        /// <param name="g"></param>
        public override void DrawShip(Graphics g)
        {
            base.DrawShip(g);
           
            Brush spoiler = new SolidBrush(DopColor);
            g.FillRectangle(spoiler, _startPosX + 40, _startPosY + 20, 80, 10);

            if(Tube == true)
            DrawTube(g);

        }
    }


}

