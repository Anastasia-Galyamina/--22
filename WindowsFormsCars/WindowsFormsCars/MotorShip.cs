using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsCars
{
    class MotorShip
    {
        /// <summary>
        /// Левая координата отрисовки корабля
        /// </summary>
        private float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки корабля
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _pictureHeight;
        /// <summary>
        /// Ширина отрисовки корабля
        /// </summary>
        private const int carWidth = 100;
        /// <summary>
        /// Ширина отрисовки корабля
        /// </summary>
        private const int carHeight = 60;
        /// <summary>
        /// Наличие трубы
        /// </summary>         
        public bool Tube { private set; get; }
        /// <summary>
        /// Максимальная скорость
        /// </summary> 
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Вес автомобиля
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>
        /// Основной цвет 
        /// </summary>
        public Color MainColor { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }  
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес корабля</param>
        /// <param name="mainColor">Основной цвет корабля</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="tube">Признак наличия трубы</param>        
        public MotorShip(int maxSpeed, float weight, Color mainColor, Color dopColor,  bool tube)
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
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Отрисовка трубы
        /// </summary>              
        public void DrawTube(Graphics g)
        {            
            Brush brRed = new SolidBrush(Color.Red);
            g.FillRectangle(brRed, _startPosX + 100, _startPosY, 10, 20);
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        /// <summary>
        /// Отрисовка корабля
        /// </summary>
        /// <param name="g"></param>
        public void DrawCar(Graphics g)
        {
            //Нижняя палуба
            Pen pen = new Pen(Color.Black);            
            g.DrawRectangle(pen, _startPosX, _startPosY + 30, 150, 30);
            Brush br = new SolidBrush(MainColor);
            g.FillRectangle(br, _startPosX, _startPosY + 30, 150, 30);
            //Верхняя палуба
            g.DrawRectangle(pen, _startPosX + 40, _startPosY + 20, 80, 10);
            Brush spoiler = new SolidBrush(DopColor);
            g.FillRectangle(spoiler, _startPosX + 40, _startPosY + 20, 80, 10);
            //Труба
            if(Tube == true)
            DrawTube(g);
        }
    }
}

