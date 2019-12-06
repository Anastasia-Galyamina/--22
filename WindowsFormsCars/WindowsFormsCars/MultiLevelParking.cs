
using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCars
{
    class MultiLevelParking
    {
        private Logger logger;
        /// <summary>
        /// Список с уровнями парковки
        /// </summary>
        List<Parking<ITransport>> parkingStages;
        /// <summary>
        /// Сколько мест на каждом уровне
        /// </summary>   
        private const int countPlaces = 20;       
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int pictureHeight;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="countStages">Количество уровенй парковки</param>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<ITransport>>();
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth,
               pictureHeight));
            }
        }
        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Parking<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
        /// <summary>
        /// Сохранение информации в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                //Записываем количество уровней
                sw.WriteLine("CountLeveles:" + parkingStages.Count); 
                foreach (var level in parkingStages)
                {
                    //Начинаем уровень
                    sw.WriteLine("Level");
                    foreach (ITransport ship in level)
                    {
                        //Записываем тип мшаины
                        if (ship.GetType().Name == "Ship")
                        {
                            sw.Write(level.GetKey + ":Ship:");
                        }
                        if (ship.GetType().Name == "MotorShip")
                        {
                            sw.Write(level.GetKey + ":MotorShip:");
                        }
                        //Записываемые параметры
                        sw.WriteLine(ship);                  
                   }
                }
            }           
        }
        /// <summary>
        /// Метод записи информации в файл
        /// </summary>
        /// <param name="text">Строка, которую следует записать</param>
        /// <param name="stream">Поток для записи</param>
      private void WriteToFile(string text, FileStream stream)
      {
           byte[] info = new UTF8Encoding(true).GetBytes(text);
           stream.Write(info, 0, info.Length);
      }
        /// <summary>
        /// Загрузка нформации из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                logger.Error("Файл не найден");
                throw new FileNotFoundException();
                
            }            
            using (StreamReader sr = new StreamReader(filename))
            {
                //считываем количество уровней
                string str = sr.ReadLine();
                string[] st = str.Split(':');  
                int count = Convert.ToInt32(st[1]);    
                if (st.Contains("CountLeveles"))
                {
                    //считываем количество уровней                                    
                    if (parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<Parking<ITransport>>(count);
                }
                else
                {
                    //если нет такой записи, то это не те данные
                    logger.Error("Неверный формат файла");
                    throw new Exception("Неверный формат файла");
                    
                }
                ITransport ship = null;
                //идем по считанным записям  
                str = sr.ReadLine();                
                for (int i = 0; i < count; i++)
                {
                    parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));  
                    str = sr.ReadLine();
                    while (str != "Level" && str != null)
                    {
                                                
                        if (str.Split(':')[1] == "Ship")
                        {
                            ship = new Ship(str.Split(':')[2]);
                        }
                        else if (str.Split(':')[1] == "MotorShip")
                        {
                            ship = new MotorShip(str.Split(':')[2]);
                        }
                        parkingStages[i][Convert.ToInt32(str.Split(':')[0])] = ship;
                        str = sr.ReadLine();                        
                    }                             
                }  
            }
            return true;
        }
        /// <summary>
        /// Сортировка уровней
        /// </summary>
        public void Sort()
        {
            parkingStages.Sort();
        }
    }
}

