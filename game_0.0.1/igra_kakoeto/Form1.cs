using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace igra_kakoeto
{
    public partial class Form1 : Form
	{
		static int cell_size = 30; // размер клетки мира 
		static int x_wrld_size = 45; // ширина мира 
		static int y_wrld_size = 27; // высота мира 
		int[,] obj_array = new int[y_wrld_size, x_wrld_size]; // массив карты 
		int[,] obj_array_sravn = new int[10, 10]; //массив для сравнения яейки
		int[,] obj_array_wall = new int[10, 10]; //массив c оригиналом ячейки 
		int[,] obj_array_door = new int[10, 10];
		Rectangle screenSize = System.Windows.Forms.Screen.PrimaryScreen.Bounds; //считывание размера экрана
		int k, r, g, b, wall,door,old_cell;
		int y_obj = 8; // y позиция персоонажа 
		int	x_obj = 12; // y позиция персоонажа 
		Bitmap map_bm = new Bitmap(x_wrld_size*cell_size, y_wrld_size * cell_size);
		Bitmap player_bm = new Bitmap(cell_size,cell_size);
		Bitmap land = new Bitmap(@"lvls\\mapone.jpg");

		public Form1()   //главная форма 
		{
			InitializeComponent();
			base_load();
			settings_status(false);
			save_list_status(false);
			menu_poz();

			Image newImage = Image.FromFile(@"lvls\\mapone.jpg");
			int z1 = newImage.Width; //Ширина загруженного изображения
			int z2 = newImage.Height; //Высота загруженного изображения
			//MessageBox.Show(Convert.ToString(z1)+"х" +Convert.ToString(z2));

			old_cell = obj_array[y_obj, x_obj];
			window_size_box.Items.Add("1920x1080");
			window_size_box.SelectedItem = ("1920x1080");
			window_type_box.Items.Add("на весь экран");
			window_type_box.SelectedItem = ("на весь экран");
		}
		string path_obj(int pic_obj) // функция выдающая ячейку карты
		{
			string path;
			path = @"img\\obj_" + Convert.ToString(pic_obj) + ".bmp";
			return path;
		}
		public void base_load()
		{

			//label1.Visible = false;
			world_map.Visible = false;
			player_box.Visible = false;
			this.Width = screenSize.Size.Width;
			this.Height = screenSize.Size.Height;
			world_map.Width = screenSize.Size.Width;
			world_map.Height = screenSize.Size.Height;
			world_map.Top = 0;
			world_map.Left = 0;
			
		}

		public void menu_poz()
		{
			Mailn_lbl.Top = screenSize.Size.Height / 10;
			Start_Game_butt.Top = screenSize.Size.Height / 10 + 100;
			Contin_butt.Top = screenSize.Size.Height / 10 + 100*2;
			Settings_butt.Top = screenSize.Size.Height / 10 + 100*3;
			Exit_butt.Top = screenSize.Size.Height / 10 + 100*4;

			Mailn_lbl.Left = screenSize.Size.Width / 2 - 112;			
			Start_Game_butt.Left = screenSize.Size.Width / 2 - 75;			
			Contin_butt.Left = screenSize.Size.Width / 2 - 75;			
			Settings_butt.Left = screenSize.Size.Width / 2 - 75;
			Exit_butt.Left = screenSize.Size.Width / 2-75;
		}
		private void Start_Game_butt_Click(object sender, EventArgs e)
		{
			map_create();   // тут задается скелет карты
			first_draw();   // тут рисуется карта 
			menu_status(false);  // тут выключаеться меню 
			world_map.Visible = true;
			player_box.Visible = true;			
		}
		private void Exit_butt_Click(object sender, EventArgs e)  // выход
		{
			Application.Exit();
		}
		private void Contin_butt_Click(object sender, EventArgs e) // продолжение 
		{
			menu_status(false); // тут выключаеться меню 
			save_list_status(true);
		}
		private void Settings_butt_Click(object sender, EventArgs e)   // настройки 
		{
			menu_status(false);  // тут выключаеться меню 
			settings_status(true); // тут открываються настройки 
		}
		public void settings_status(bool activ)
		{

			window_size_box.Enabled = activ;
			window_size_box.Visible = activ;
			window_type_box.Enabled = activ;
			window_type_box.Visible = activ;
			setting_lbl.Visible = activ;
			form_lbl.Visible = activ;
			size_lbl.Visible = activ;
			accept_set_butt.Enabled = activ;
			accept_set_butt.Visible = activ;
			back_sett_but.Visible = activ;
			back_sett_but.Enabled = activ;

		}
		public void menu_status(bool activ)    // открытие меню 
		{
			Start_Game_butt.Enabled = activ;
			Start_Game_butt.Visible = activ;
			Exit_butt.Enabled = activ;
			Exit_butt.Visible = activ;
			Contin_butt.Enabled = activ;
			Contin_butt.Visible = activ;
			Settings_butt.Enabled = activ;
			Settings_butt.Visible = activ;
			Mailn_lbl.Visible = activ;
		}
		public void save_list_status(bool activ)
		{
			save_lbl.Visible = activ;
			one_save_butt.Enabled = activ;
			one_save_butt.Visible = activ;
			two_save_butt.Enabled = activ;
			two_save_butt.Visible = activ;
			tree_save_butt.Enabled = activ;
			tree_save_butt.Visible = activ;
			four_save_butt.Enabled = activ;
			four_save_butt.Visible = activ; 
			five_save_butt.Enabled = activ;
			five_save_butt.Visible = activ;
			back_load_butt.Enabled = activ;
			back_load_butt.Visible = activ;
		}
		private void accept_set_butt_Click(object sender, EventArgs e)
		{

		}
		private void back_load_butt_Click(object sender, EventArgs e)
		{
			menu_status(true);
			save_list_status(false);
		}
		private void back_sett_but_Click(object sender, EventArgs e)
		{
			settings_status(false);
			menu_status(true);
		}		
		public void first_draw() // тут рисуется карта 
		{
			Graphics graph_map_bm = Graphics.FromImage(map_bm);
			for (int i = 0; i < y_wrld_size; i++)
				for (int j = 0; j < x_wrld_size; j++)
				{
					k = obj_array[i, j];

					//if (k == 3) k = 1;


					Image obj_img = Image.FromFile(path_obj(k));
					Bitmap obj_bm = new Bitmap(obj_img);
					graph_map_bm.DrawImage(obj_bm, j * cell_size, cell_size * i, cell_size, cell_size);


				}
			graph_map_bm.Dispose();
			world_map.Image = map_bm;
			
			obj_array[y_obj, x_obj] = 4;
			k = 4;
			player_box.Image = Image.FromFile(path_obj(k));
			player_box.SizeMode = PictureBoxSizeMode.StretchImage;

			player_box.Top = y_obj * cell_size;
			player_box.Left = x_obj * cell_size;
			player_box.Width = cell_size;
			player_box.Height = cell_size;
		}	
		public void map_create()    // тут задается скелет карты 
		{
			obj_array_wall = new int[,]   //массив клетки стены 
					{{1,1,1,1,1,1,1,1,1,1},
					 {1,0,0,0,0,0,0,0,0,1},
					 {1,0,0,0,0,0,0,0,0,1},
					 {1,0,0,0,0,0,0,0,0,1},
					 {1,0,0,0,0,0,0,0,0,1},
					 {1,0,0,0,0,0,0,0,0,1},
					 {1,0,0,0,0,0,0,0,0,1},
					 {1,0,0,0,0,0,0,0,0,1},
					 {1,0,0,0,0,0,0,0,0,1},
					 {1,1,1,1,1,1,1,1,1,1}};
			obj_array_door = new int[,]   //массив клетки стены 
					{{1,1,1,1,1,1,1,1,1,1},
					 {1,0,0,0,0,0,0,0,0,1},
					 {1,0,0,1,0,0,1,0,0,1},
					 {1,0,0,1,0,0,1,0,0,1},
					 {1,0,0,1,0,0,1,0,0,1},
					 {1,0,0,1,0,0,1,0,0,1},
					 {1,0,0,1,0,0,1,0,0,1},
					 {1,0,0,1,0,0,1,0,0,1},
					 {1,0,0,0,0,0,0,0,0,1},
					 {1,1,1,1,1,1,1,1,1,1}};

			for (int i = 0; i < y_wrld_size; i++)
			{
				for (int j = 0; j < x_wrld_size; j++)
				{
					for (int t = 0; t < 10; t++)  // начала цикла сравнения 
					{
						for (int z = 0; z < 10; z++)
						{
							Color pixelColor = land.GetPixel(j * 9 + t, i * 9 + z);
							r = Convert.ToInt32(pixelColor.R);
							g = Convert.ToInt32(pixelColor.G);
							b = Convert.ToInt32(pixelColor.B);
							if (r <= 40 && g <= 40 && b <= 40)
							{
								obj_array_sravn[z, t] = 1;
							}
							else
							{
								obj_array_sravn[z, t] = 0;
							}
						}
					}
					for (int jp = 0; jp < 10; jp++)
					{
						for (int pp = 0; pp < 10; pp++)
						{
							if (obj_array_sravn[jp, pp] == obj_array_wall[jp, pp])
							{
								wall++;
							}
							if (obj_array_sravn[jp, pp] == obj_array_door[jp, pp])
							{
								door++;
							}
						}
					}
					if (wall == 100)
					{
						obj_array[i, j] = 1;
						wall = 0;
						door = 0;
					}
					else if (door == 100)
					{
						obj_array[i, j] = 2;
						door = 0;
						wall = 0;
					}
					else 
					{
						obj_array[i, j] = 0;
						wall = 0;
						door = 0;
					}
				}
			}
		}
		public void player_move(int side_x, int side_y)
		{
			player_box.Image = Image.FromFile(path_obj(k));
			obj_array[y_obj, x_obj] = old_cell;
			x_obj = x_obj + side_x;
			y_obj = y_obj + side_y;
			old_cell = obj_array[y_obj, x_obj];
			obj_array[y_obj, x_obj] = 4;
		}
		public void use_activ(int y_viev,int x_viev)
		{
			if ((y_obj + y_viev >= 0) && (y_obj + y_viev <= y_wrld_size - 1) && (x_obj + x_viev >= 0) && (x_obj + x_viev <= x_wrld_size - 1))
			{
				if (obj_array[y_obj + y_viev, x_obj + x_viev] == 2 || obj_array[y_obj + y_viev, x_obj + x_viev] == 3)
				{
					Image obj_img = Image.FromFile(path_obj(2));
					if (obj_array[y_obj + y_viev, x_obj + x_viev] == 2)
					{
						obj_array[y_obj + y_viev, x_obj + x_viev] = 3;
						obj_img = Image.FromFile(path_obj(obj_array[y_obj + y_viev, x_obj + x_viev]));
					}
					else if (obj_array[y_obj + y_viev, x_obj + x_viev] == 3)
					{

						obj_array[y_obj + y_viev, x_obj + x_viev] = 2;
						obj_img = Image.FromFile(path_obj(obj_array[y_obj + y_viev, x_obj + x_viev]));
					}
					Bitmap obj_bm = new Bitmap(obj_img);

					Graphics graph_map_bm = Graphics.FromImage(map_bm);
					graph_map_bm.DrawImage(obj_bm, (x_obj + x_viev) * cell_size, cell_size * (y_obj + y_viev), cell_size, cell_size);
					graph_map_bm.Dispose();
					world_map.Image = map_bm;
				}
			}
		}
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case (Keys.Escape):
					{
						menu_status(true);
						break;
					}
				case (Keys.W):
					{
						e.SuppressKeyPress = true;
						k = 5;
						player_box.Image = Image.FromFile(path_obj(k));
						if ((y_obj - 1 >= 0) && ((obj_array[y_obj - 1, x_obj] == 0) || (obj_array[y_obj - 1, x_obj] == 3)))
						{
							player_move(0, -1);
							player_box.Top = player_box.Top - cell_size;
						}
						break;
					}
					
				case (Keys.S):
					{
						e.SuppressKeyPress = true;
						k = 6;
						player_box.Image = Image.FromFile(path_obj(k));
						if ((y_obj + 1 < y_wrld_size) && ((obj_array[y_obj + 1, x_obj] == 0) || (obj_array[y_obj + 1, x_obj] == 3)))
						{
							player_move(0, 1);
							player_box.Top = player_box.Top + cell_size;
						}
						break;
					}
				case (Keys.A):
					{
						e.SuppressKeyPress = true;
						k = 7;
						player_box.Image = Image.FromFile(path_obj(k));
						if ((x_obj - 1 >= 0) && ((obj_array[y_obj, x_obj - 1] == 0) || (obj_array[y_obj, x_obj - 1] == 3)))
						{
							player_move(-1,0);
							player_box.Left = player_box.Left - cell_size;
						}
						break;
					}
				case (Keys.D):
					{
						e.SuppressKeyPress = true;
						k = 8;
						player_box.Image = Image.FromFile(path_obj(k));
						if ((x_obj + 1 < x_wrld_size) && ((obj_array[y_obj, x_obj + 1] == 0) || (obj_array[y_obj, x_obj + 1] == 3)))
						{
							player_move(+1,0);
							player_box.Left = player_box.Left + cell_size;
						}
						break;
					}
				case (Keys.Up):
					{
						k = 5;
						player_box.Image = Image.FromFile(path_obj(k));
						break;
					}
				case (Keys.Down):
					{
						k = 6;
						player_box.Image = Image.FromFile(path_obj(k));
						break;
					}
				case (Keys.Left):
					{
						k = 7;
						player_box.Image = Image.FromFile(path_obj(k));
						break;
					}
				case (Keys.Right):
					{
						k = 8;
						player_box.Image = Image.FromFile(path_obj(k));
						break;
					}
				case (Keys.E):
					{
						e.SuppressKeyPress = true;
						switch (k)
						{
							case (5):
								use_activ(-1, 0);
								break;
							case (6):
								use_activ(1, 0);
								break;
							case (7):
								use_activ(0, -1);
								break;
							case (8):
								use_activ(0, 1);
								break;
						}
						break;
					}
					

			}

		}
	}
}
