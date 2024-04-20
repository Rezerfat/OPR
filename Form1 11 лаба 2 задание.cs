using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Задание_2
{
    public partial class STUDENT : Form
    {
        public STUDENT()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {

         


        Запись ЗаписьG(int i)
            {
                Запись запись = new Запись();

                string[] surname_ = { "Смирнов", "Иванова", "Сидоров", "Попкова", "Козлова", "Новиков", "Волкова" };
                string[] name_ = { "Е.К. гр. ", "А.Н. гр.", "М.У. гр.", "З.А. гр.", "М.О. гр.", "К.П. гр.", "А.С. гр." };
                int[] group_ = {7, 1, 2, 3, 4, 5, 6};
                int[] R1_ = {4, 5,3,2,};
                int[] R2_ = {4, 5,3,2 };
                int[] R3_ = {5, 4, 3, 2};
                int[] R4_ = { 3, 4, 5, 2 };
                int[] R5_ = {2, 3, 4, 5 };

                Random surnameG = new Random(i + 12213);
                Random nameG = new Random(i + 14212);
                Random groupG = new Random(i + 235);
                Random R1G = new Random(i + 434);
                Random R2G = new Random(i + 321);
                Random R3G = new Random(R1G.Next() + i);
                Random R4G = new Random(6564 + i);
                Random R5G = new Random(342 + i);


                запись.surname = surname_[surnameG.Next(surname_.Length)];
                запись.name = name_[nameG.Next(name_.Length)];
                запись.group = group_[groupG.Next(group_.Length)];
                запись.R1 = R1_[R1G.Next(R1_.Length)];
                запись.R2 = R2_[R2G.Next(R2_.Length)];
                запись.R3 = R3_[R3G.Next(R3_.Length)];
                запись.R4 = R4_[R4G.Next(R4_.Length)];
                запись.R5 = R5_[R5G.Next(R5_.Length)];

                return запись;
            }


            string[] mas = new string[10];
            List<string> mas_abs = new List<string>();

            Запись запись1 = new Запись();

            for (int i = 0; i <= 9; i++)
            {
                запись1 = ЗаписьG(i);
                mas[i] = $"{запись1.group}" + запись1.ToString();
                double r = запись1.R1 + запись1.R2 + запись1.R3 + запись1.R4 + запись1.R5;
                if (r / 5 > 4)
                {

                    mas_abs.Add( $"{запись1.group}" + $"{запись1.surname}" + " " + $"{запись1.group}".ToString());
                }
            }




            for (var i = 1; i < 10; i++)
            {
                for (var j = 0; j < 10 - i; j++)
                {
                    if (mas[j][0] > mas[j + 1][0])
                    {
                        var t = mas[j + 1];
                        mas[j  + 1] = mas[j];
                        mas[j] = t;
                    }
                }
            }

            for (var i = 1; i < mas_abs.Count; i++)
            {
                for (var j = 0; j < mas_abs.Count - i; j++)
                {
                    
                        if (mas_abs[j][0] > mas_abs[j + 1][0])
                        {
                            var t = mas_abs[j + 1];
                            mas_abs[j + 1] = mas_abs[j];
                            mas_abs[j] = t;
                        }
                    
                }
            }


            for (int i = 0; i < 10; i++)
            {
                string s = mas[i];
                s = s.Remove(0, 1);
                mas[i] = s;
                
            }

            for (int i = 0; i < mas_abs.Count; i++)
            {
                string s = mas_abs[i];
                s = s.Remove(0, 1);
                mas_abs[i] = s;

            }

            using (StreamWriter streamWriter = File.CreateText("Файл1.txt"))
            {
                for (int i = 0; i < 10; i++)
                {
                    streamWriter.WriteLine(mas[i]);
                }
                streamWriter.Close();
            }

            using (StreamWriter streamWriter = File.CreateText("Файл2.txt"))
            {
                for (int i = 0; i < mas_abs.Count; i++)
                {
                    streamWriter.WriteLine(mas_abs[i]);
                }
                streamWriter.Close();
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

            string[] mas = new string[10];
            using (StreamReader streamReader = File.OpenText("Файл1.txt"))
            {

                //string[] mas = new string[10];
                int i = 0;
                string input = null;
                while ((input = streamReader.ReadLine()) !=
                null)
                {
                    mas[i] = input;
                    i++;
                }
                streamReader.Close();

                Array1.Lines = mas;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] mas = new string[10];
            using (StreamReader streamReader = File.OpenText("Файл2.txt"))
            {

                //string[] mas = new string[10];
                int i = 0;
                string input = null;
                while ((input = streamReader.ReadLine()) !=
                null)
                {
                    mas[i] = input;
                    i++;
                }
                streamReader.Close();

                if (mas[0] == null) {
                    mas[0] = "Учеников, со средним баллом выше 4 нет";
                    Array2.Text = mas[0];
                  //  Array2.Text = "Учеников, со средним баллом выше 4 нет";
                }
              
                Array2.Lines = mas;
            }
        }
    }
}


