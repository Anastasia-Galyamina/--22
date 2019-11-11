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
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="tube">Признак наличия трубы</param>        
        public MotorShip(int maxSpeed, float weight, Color mainColor, Color dopColor, bool tube) : base(maxSpeed, weight, mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Tube = tube;
        }    
        public void DrawTube(Graphics g)
        {            
            Brush brRed = new SolidBrush(Color.Red);
            g.FillRectangle(brRed, _startPosX + 100, _startPosY, 10, 20);

        }        
        /// <summary>
        /// Отрисовка корабля
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

