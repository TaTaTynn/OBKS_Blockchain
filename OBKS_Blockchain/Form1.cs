using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace OBKS_Blockchain
{
    public partial class Form1 : Form
    {
        private string[] paths = new string[5];     // Имена файлов
        private CheckBox[] ex_buttons, nons_buttons, chain_buttons; // Массивы эл-тов визуализации
        private string initial_dir = "initial";     // Имя директории с исходными файлами
        private string chain_dir = "chain";         // Имя директории с файлами цепочки
        private string[] ru_nums = new string[5] {"первый", "второй", "третий", "четвертый", "пятый"};
        // Строки для заполнения содержания исходных файлов в цикле
        private int num_zeros; // Количество нулей в начале хеша

        // Удалить исходные файлы
        private void button_delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < paths.Length; i++)
            {
                string path = initial_dir + "\\" + paths[i];
                FileInfo info = new FileInfo(path);
                if (info.Exists)
                {
                    Task cr = new Task(() => File.Delete(path));
                    cr.Start();
                    cr.Wait();
                }
                info = new FileInfo(path);
                ex_buttons[i].Checked = info.Exists;
            }
        }

        // Кнопка ОК
        private void button_ok_Click(object sender, EventArgs e)
        {
            // Снимаем чекбоксы определения нонсов
            for (int i = 0; i < nons_buttons.Length; i++)
                nons_buttons[i].Checked = false;

            num_zeros = (int)num_nulls.Value;
        }

        // Расчет нонсов файлов
        private void button_nons_Click(object sender, EventArgs e)
        {
            if (num_zeros == 0)
                MessageBox.Show("От хэшей не ожидаются нули, нонсы не будут посчитаны!");
            // Снимаем чекбоксы
            for (int i=0;i<nons_buttons.Length;i++)
                nons_buttons[i].Checked = false;

            // Копируем исходные файлы в папку с цепочкой
            for (int i = 0; i < paths.Length; i++)
            {
                string ini_path = initial_dir + "\\" + paths[i];
                string cha_path = chain_dir + "\\" + paths[i];
                FileInfo info = new FileInfo(ini_path);
                if (info.Exists)
                {
                    Task cr = new Task(() => info.CopyTo(cha_path, true));
                    cr.Start();
                    cr.Wait();
                }
            }

            // Считаем нонсы
            for (int i = 0; i < paths.Length; i++)
            {
                string path = initial_dir + "\\" + paths[i];
                FileInfo info = new FileInfo(path);
                string hash = "";
                if (info.Exists)
                {
                    hash = Compute_nons(paths[i], num_zeros);
                    if (hash.Length == 0)
                    {
                        MessageBox.Show("Не удалось вычислить нонс");
                        return;
                    }
                }
                if (i == paths.Length - 1)
                { nons_buttons[i].Checked = true; break; }
                // Пишем хэш текущего файла в конец следующего
                path = chain_dir + "\\" + paths[i+1];
                Task cr = new Task(() => File.AppendAllText(path, "\n" + hash, Encoding.Unicode));
                cr.Start();
                cr.Wait();
                info = new FileInfo(path);
                nons_buttons[i].Checked = info.Exists;
            }
        }

        // Расчет нонса для одного файла
        private string Compute_nons(string path, int num_zeros)
        {
            int non_i = 0;
            string non = "";
            string ini_path = initial_dir + "\\" + path;
            string cha_path = chain_dir + "\\" + path;

            string ini_text = File.ReadAllText(cha_path);
            while(!has_hash_zeros(cha_path, num_zeros))
            {
                // Копируем исходный файл с перезаписью
                FileInfo info = new FileInfo(ini_path);
                if (info.Exists)
                {
                    Task cr = new Task(() => info.CopyTo(cha_path, true));
                    cr.Start();
                    cr.Wait();
                }
                // Пишем нонс в начало файла
                info = new FileInfo(cha_path);
                if (info.Exists)
                {
                    non = non_i.ToString();
                    Task cr = new Task(() => File.WriteAllText(cha_path, non + ini_text));
                    cr.Start();
                    cr.Wait();
                }
                if (non_i == int.MaxValue)
                    return "";
                non_i++;
            }

            //Возвращаем хэш
            return get_hash(cha_path);
        }

        // Проверить количество нулей в хэше файла
        private bool has_hash_zeros(string path, int num_zeros)
        {
            bool result = true;
            string hash = get_hash(path);
            for(int i=0; i<num_zeros; i++)
            {
                if (hash[i] != '0')
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        
        // Получить хэш от файла
        private string get_hash(string path)
        {
            using (FileStream fs = System.IO.File.OpenRead(path))
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] fileData = new byte[fs.Length];
                fs.Read(fileData, 0, (int)fs.Length);
                byte[] checkSum = md5.ComputeHash(fileData);
                string result = BitConverter.ToString(checkSum).Replace("-", String.Empty);
                Console.WriteLine(result + "\n");
                return result;
            }
        }

        // Удалить файлы цепочки
        private void button_delete_chain_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < paths.Length; i++)
            {
                string path = chain_dir + "\\" + paths[i];
                FileInfo info = new FileInfo(path);
                if (info.Exists)
                {
                    Task cr = new Task(() => File.Delete(path));
                    cr.Start();
                    cr.Wait();
                }
                info = new FileInfo(path);
                nons_buttons[i].Checked = info.Exists;
            }
        }

        // Проверить целостность цепочки
        private void button_check_chain_Click(object sender, EventArgs e)
        {
            bool result = false;
            for (int i = 1; i < paths.Length; i++)
            {
                string path = chain_dir + "\\" + paths[i];
                string path_prev = chain_dir + "\\" + paths[i-1];
                FileInfo info = new FileInfo(path);
                if (info.Exists)
                {
                    string[] content = File.ReadAllLines(path);
                    result = content[content.Length - 1] == get_hash(path_prev);
                    if (!result)
                        MessageBox.Show("Нарушена связь файлов\n" + paths[i-1] + "\n и \n" + paths[i]);
                }
                chain_buttons[i - 1].Checked = result;
            }
        }

        // Создать исходные файлы
        private void button_create_Click(object sender, EventArgs e)
        {
            // Снимаем чекбоксы
            for (int i = 0; i < ex_buttons.Length; i++)
                ex_buttons[i].Checked = false;

            // Создание и заполнение файлов
            for (int i = 0; i < paths.Length; i++)
            {
                string path = initial_dir + "\\" + paths[i];
                FileInfo info = new FileInfo(path);
                if (!info.Exists)
                {
                    Task cr = new Task(() => File.Create(path).Close());
                    cr.Start();
                    cr.Wait();
                    string text = "\nЭто " + ru_nums[i] + " файл \nХеш предыдущего:";
                    if (i == 0)
                        text += "\n  ---";
                    File.WriteAllText(path, text, Encoding.Unicode);
                }
                info = new FileInfo(path);
                ex_buttons[i].Checked = info.Exists;
            }
        }

        public Form1()
        {
            InitializeComponent();
            // Созданы ли исходные файлы
            ex_buttons = new CheckBox[5] {check_ex_1, check_ex_2, 
                check_ex_3, check_ex_4, check_ex_5 };
            // Посчитаны ли нонсы
            nons_buttons = new CheckBox[5] { check_non_1, check_non_2, 
                check_non_3, check_non_4, check_non_5 };
            // Корректна ли цепочка
            chain_buttons = new CheckBox[4] { check_chain_2,
                check_chain_3, check_chain_4, check_chain_5 };

            // Существуют ли директории для файлов
            if (!Directory.Exists(initial_dir))
                Directory.CreateDirectory(initial_dir);
            if (!Directory.Exists(chain_dir))
                Directory.CreateDirectory(chain_dir);

            // Созданы ли исходные файлы
            for (int i = 0; i < paths.Length; i++)
            {
                paths[i] = (i + 1).ToString() + @".txt";
                FileInfo info = new FileInfo(initial_dir + "\\" + paths[i]);
                if (ex_buttons[i] != null)
                    ex_buttons[i].Checked = info.Exists;
            }
        }
    }
}
