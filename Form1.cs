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

namespace Atividade_Olimpiadas___Manhã___POO_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        //Todas as informações foram retiradas do portal Estadão de noticias, link: https://esportes.estadao.com.br/olimpiada/2020/medalhas
        //Nesse app constam apenas os paises que ganharam pelo menos uma medalha

        private int medalhasOuro;
        private int medalhasPrata;
        private int medalhasBronze;
        private int medalhasTotal;
        
       
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case "Estados Unidos":
                    medalhasOuro = 39;
                    medalhasPrata = 41;
                    medalhasBronze = 33;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\estados-unidos.jpg";
                    break;


                case "China":
                    medalhasOuro = 38;
                    medalhasPrata = 32;
                    medalhasBronze = 18;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\china.jpg";
                    break;
                case "Japão":
                    medalhasOuro = 27;
                    medalhasPrata = 14;
                    medalhasBronze = 17;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\japao.jpg";
                    break;
                case "Grã-Bretanha":
                    medalhasOuro = 22;
                    medalhasPrata = 21;
                    medalhasBronze = 22;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\gra-bretanha.jpg";
                    break;
                case "Atletas da Russia":
                    medalhasOuro = 20;
                    medalhasPrata = 28;
                    medalhasBronze = 23;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\atletas-da-russia - Copia.jpg";
                    break;
                case "Austrália":
                    medalhasOuro = 17;
                    medalhasPrata = 7;
                    medalhasBronze = 22;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\australia.jpg";
                    break;
                case "Holanda":
                    medalhasOuro = 10;
                    medalhasPrata = 12;
                    medalhasBronze = 14;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\holanda.jpg";
                    break;
                case "França":
                    medalhasOuro = 10;
                    medalhasPrata = 12;
                    medalhasBronze = 11;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\franca.jpg";
                    break;
                case "Alemanha":
                    medalhasOuro = 10;
                    medalhasPrata = 11;
                    medalhasBronze = 16;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\alemanha - Copia.jpg";
                    break;
                case "Itália":
                    medalhasOuro = 10;
                    medalhasPrata = 10;
                    medalhasBronze = 20;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\italia.jpg";
                    break;
                case "Canadá":
                    medalhasOuro = 7;
                    medalhasPrata = 6;
                    medalhasBronze = 11;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\canada.jpg";
                    break;
                case "Brasil":
                    medalhasOuro = 7;
                    medalhasPrata = 6;
                    medalhasBronze = 8;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\brasil.jpg";
                    break;
                case "Nova Zêlandia":
                    medalhasOuro = 7;
                    medalhasPrata = 6;
                    medalhasBronze = 7;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\nova-zelandia.jpg";
                    break;
                case "Cuba":
                    medalhasOuro = 6;
                    medalhasPrata = 3;
                    medalhasBronze = 5;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\cuba.jpg";
                    break;
                case "Hungria":
                    medalhasOuro = 6;
                    medalhasPrata = 7;
                    medalhasBronze = 7;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\hungria.jpg";
                    break;
                case "Coreia do Sul":
                    medalhasOuro = 6;
                    medalhasPrata = 14;
                    medalhasBronze = 10;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\coreia-do-sul.jpg";
                    break;
                case "Polônia":
                    medalhasOuro = 4;
                    medalhasPrata = 5;
                    medalhasBronze = 5;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\polonia.jpg";
                    break;
                case "República Checa":
                    medalhasOuro = 4;
                    medalhasPrata = 4;
                    medalhasBronze = 3;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\republica-checa.jpg";
                    break;
                case "Quênia":
                    medalhasOuro = 4;
                    medalhasPrata = 4;
                    medalhasBronze = 2;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\quenia.jpg";
                    break;
                case "Noruega":
                    medalhasOuro = 4;
                    medalhasPrata = 2;
                    medalhasBronze = 2;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\noruega.jpg";
                    break;
                case "Jamaica":
                    medalhasOuro = 4;
                    medalhasPrata = 1;
                    medalhasBronze = 4;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\jamaica.jpg";
                    break;
                case "Espanha":
                    medalhasOuro = 3;
                    medalhasPrata = 8;
                    medalhasBronze = 6;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\espanha.jpg";
                    break;
                case "Suécia":
                    medalhasOuro = 3;
                    medalhasPrata = 6;
                    medalhasBronze = 0;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\suecia.jpg";
                    break;
                case "Suíça":
                    medalhasOuro = 3;
                    medalhasPrata = 4;
                    medalhasBronze = 6;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\suica.jpg";
                    break;
                case "Dinamarca":
                    medalhasOuro = 3;
                    medalhasPrata = 4;
                    medalhasBronze = 4;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\dinamarca.jpg";
                    break;
                case "Croácia":
                    medalhasOuro = 3;
                    medalhasPrata = 3;
                    medalhasBronze = 2;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\croacia.jpg";
                    break;
                case "Irã":
                    medalhasOuro = 3;
                    medalhasPrata = 2;
                    medalhasBronze = 2;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\ira.jpg";
                    break;
                case "Sérvia":
                    medalhasOuro = 3;
                    medalhasPrata = 1;
                    medalhasBronze = 5;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\servia.jpg";
                    break;
                case "Bélgica":
                    medalhasOuro = 3;
                    medalhasPrata = 1;
                    medalhasBronze = 3;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\belgica.jpg";
                    break;
                case "Bulgária":
                    medalhasOuro = 3;
                    medalhasPrata = 1;
                    medalhasBronze = 2;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\bulgaria.jpg";
                    break;
                case "Eslovênia":
                    medalhasOuro = 3;
                    medalhasPrata = 1;
                    medalhasBronze = 1;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\eslovenia.jpg";
                    break;
                case "Uzbequistão":
                    medalhasOuro = 3;
                    medalhasPrata = 0;
                    medalhasBronze = 2;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\uzbequistao.jpg";
                    break;
                case "Geórgia":
                    medalhasOuro = 2;
                    medalhasPrata = 5;
                    medalhasBronze = 1;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\georgia.jpg";
                    break;
                case "Taipei":
                    medalhasOuro = 2;
                    medalhasPrata = 4;
                    medalhasBronze = 6;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\taipei.jpg";
                    break;
                case "Turquia":
                    medalhasOuro = 2;
                    medalhasPrata = 2;
                    medalhasBronze = 9;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\turquia.jpg";
                    break;
                case "Grécia":
                    medalhasOuro = 2;
                    medalhasPrata = 1;
                    medalhasBronze = 1;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\grecia.jpg";
                    break;
                case "Uganda":
                    medalhasOuro = 2;
                    medalhasPrata = 1;
                    medalhasBronze = 1;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\uganda.jpg";
                    break;
                case "Equador":
                    medalhasOuro = 2;
                    medalhasPrata = 0;
                    medalhasBronze = 2;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\equador.jpg";
                    break;
                case "Qatar":
                    medalhasOuro = 2;
                    medalhasPrata = 0;
                    medalhasBronze = 1;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\qatar.jpg";
                    break;
                case "Bahamas":
                    medalhasOuro = 2;
                    medalhasPrata = 0;
                    medalhasBronze = 0;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\bahamas.jpg";
                    break;
                case "Kosovo":
                    medalhasOuro = 2;
                    medalhasPrata = 0;
                    medalhasBronze = 0;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\kosovo.jpg";
                    break;
                case "Ucrânia":
                    medalhasOuro = 1;
                    medalhasPrata = 6;
                    medalhasBronze = 12;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\ucrania.jpg";
                    break;
                case "Belarus":
                    medalhasOuro = 1;
                    medalhasPrata = 3;
                    medalhasBronze = 3;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\belarus.jpg";
                    break;
                case "Romênia":
                    medalhasOuro = 1;
                    medalhasPrata = 3;
                    medalhasBronze = 0;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\romenia (1).jpg";
                    break;
                case "Venezuela":
                    medalhasOuro = 1;
                    medalhasPrata = 3;
                    medalhasBronze = 0;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\venezuela.jpg";
                    break;
                case "Índia":
                    medalhasOuro = 1;
                    medalhasPrata = 2;
                    medalhasBronze = 4;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\india.jpg";
                    break;
                case "Hong Kong":
                    medalhasOuro = 1;
                    medalhasPrata = 2;
                    medalhasBronze = 3;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\hong-kong.jpg";
                    break;
                case "Eslováquia":
                    medalhasOuro = 1;
                    medalhasPrata = 2;
                    medalhasBronze = 1;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\eslovaquia1.jpg";
                    break;
                case "Filipinas":
                    medalhasOuro = 1;
                    medalhasPrata = 2;
                    medalhasBronze = 1;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\filipinas.jpg";
                    break;
                case "África do Sul":
                    medalhasOuro = 1;
                    medalhasPrata = 2;
                    medalhasBronze = 0;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\africa-do-sul.jpg";
                    break;
                case "Áustria":
                    medalhasOuro = 1;
                    medalhasPrata = 1;
                    medalhasBronze = 5;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\austria.jpg";
                    break;
                case "Egito":
                    medalhasOuro = 1;
                    medalhasPrata = 1;
                    medalhasBronze = 4;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\egito.jpg";
                    break;
                case "Indonésia":
                    medalhasOuro = 1;
                    medalhasPrata = 1;
                    medalhasBronze = 3;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\indonesia.jpg";
                    break;
                case "Etiópia":
                    medalhasOuro = 1;
                    medalhasPrata = 1;
                    medalhasBronze = 2;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\etiopia.jpg";
                    break;
                case "Portugal":
                    medalhasOuro = 1;
                    medalhasPrata = 1;
                    medalhasBronze = 2;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\portugal.jpg";
                    break;
                case "Tunísia":
                    medalhasOuro = 1;
                    medalhasPrata = 1;
                    medalhasBronze = 0;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\tunisia.jpg";
                    break;
                case "Estónia":
                    medalhasOuro = 1;
                    medalhasPrata = 0;
                    medalhasBronze = 1;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\estonia.jpg";
                    break;
                case "Fiji":
                    medalhasOuro = 1;
                    medalhasPrata = 0;
                    medalhasBronze = 1;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\fiji.jpg";
                    break;
                case "Letônia":
                    medalhasOuro = 1;
                    medalhasPrata = 0;
                    medalhasBronze = 1;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\letonia.jpg";
                    break;
                case "Tailândia":
                    medalhasOuro = 1;
                    medalhasPrata = 0;
                    medalhasBronze = 1;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\tailandia.jpg";
                    break;
                case "Bermudas":
                    medalhasOuro = 1;
                    medalhasPrata = 0;
                    medalhasBronze = 0;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\estonia.jpg";
                    break;
                case "Marrocos":
                    medalhasOuro = 1;
                    medalhasPrata = 0;
                    medalhasBronze = 0;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\marrocos.jpg";
                    break;
                case "Porto Rico":
                    medalhasOuro = 1;
                    medalhasPrata = 0;
                    medalhasBronze = 0;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\porto-rico.jpg";
                    break;
                case "Colômbia":
                    medalhasOuro = 0;
                    medalhasPrata = 4;
                    medalhasBronze = 1;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\colombia.jpg";
                    break;
                case "Azerbaijão":
                    medalhasOuro = 0;
                    medalhasPrata = 3;
                    medalhasBronze = 4;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\azerbaijao.jpg";
                    break;
                case "República Dominicana":
                    medalhasOuro = 0;
                    medalhasPrata = 3;
                    medalhasBronze = 2;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\republica-dominicana.jpg";
                    break;
                case "Armênia":
                    medalhasOuro = 0;
                    medalhasPrata = 2;
                    medalhasBronze = 2;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\armenia.jpg";
                    break;
                case "Quirguistão":
                    medalhasOuro = 0;
                    medalhasPrata = 2;
                    medalhasBronze = 1;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\quirguistao.jpg";
                    break;
                case "Mongólia":
                    medalhasOuro = 0;
                    medalhasPrata = 1;
                    medalhasBronze = 3;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\mongolia.jpg";
                    break;
                case "Argentina":
                    medalhasOuro = 0;
                    medalhasPrata = 1;
                    medalhasBronze = 2;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\argentina.jpg";
                    break;
                case "San Marino":
                    medalhasOuro = 0;
                    medalhasPrata = 1;
                    medalhasBronze = 2;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\san-marino.jpg";
                    break;
                case "Jordânia":
                    medalhasOuro = 0;
                    medalhasPrata = 1;
                    medalhasBronze = 1;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\jordania.jpg";
                    break;
                case "Malásia":
                    medalhasOuro = 0;
                    medalhasPrata = 1;
                    medalhasBronze = 1;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\malasia.jpg";
                    break;
                case "Nigéria":
                    medalhasOuro = 0;
                    medalhasPrata = 1;
                    medalhasBronze = 1;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\nigeria.jpg";
                    break;
                case "Arábia Saudita":
                    medalhasOuro = 0;
                    medalhasPrata = 1;
                    medalhasBronze = 0;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\arabia-saudita.jpg";
                    break;
                case "Bahrein":
                    medalhasOuro = 0;
                    medalhasPrata = 1;
                    medalhasBronze = 0;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\bahrein.jpg";
                    break;
                case "Lituânia":
                    medalhasOuro = 0;
                    medalhasPrata = 1;
                    medalhasBronze = 0;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\lituania.jpg";
                    break;
                case "Macedônia":
                    medalhasOuro = 0;
                    medalhasPrata = 1;
                    medalhasBronze = 0;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\macedonia.jpg";
                    break;
                case "Turquemenistão":
                    medalhasOuro = 0;
                    medalhasPrata = 1;
                    medalhasBronze = 0;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\turquemenistao.jpg";
                    break;
                case "Cazaquistão":
                    medalhasOuro = 0;
                    medalhasPrata = 0;
                    medalhasBronze = 8;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\cazaquistao.jpg";
                    break;
                case "México":
                    medalhasOuro = 0;
                    medalhasPrata = 0;
                    medalhasBronze = 4;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\mexico.jpg";
                    break;
                case "Finlândia":
                    medalhasOuro = 0;
                    medalhasPrata = 0;
                    medalhasBronze = 2;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\finlandia.jpg";
                    break;
                case "Botsuana":
                    medalhasOuro = 0;
                    medalhasPrata = 0;
                    medalhasBronze = 1;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\botsuana.jpg";
                    break;
                case "Burkina Faso":
                    medalhasOuro = 0;
                    medalhasPrata = 0;
                    medalhasBronze = 1;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\burkina-faso.jpg";
                    break;
                case "Costa do Marfim":
                    medalhasOuro = 0;
                    medalhasPrata = 0;
                    medalhasBronze = 1;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\costa-do-marfim.jpg";
                    break;
                case "Gana":
                    medalhasOuro = 0;
                    medalhasPrata = 0;
                    medalhasBronze = 1;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\gana.jpg";
                    break;
                case "Granada":
                    medalhasOuro = 0;
                    medalhasPrata = 0;
                    medalhasBronze = 1;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\granada.jpg";
                    break;
                case "Kuwait":
                    medalhasOuro = 0;
                    medalhasPrata = 0;
                    medalhasBronze = 1;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\kuwait.jpg";
                    break;
                case "Moldávia":
                    medalhasOuro = 0;
                    medalhasPrata = 0;
                    medalhasBronze = 1;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\moldavia.jpg";
                    break;
                case "Siria":
                    medalhasOuro = 0;
                    medalhasPrata = 0;
                    medalhasBronze = 1;
                    medalhasTotal = medalhasOuro + medalhasPrata + medalhasBronze;
                    pictureBox5.ImageLocation = @"D:\Projetos\C#\Atividade Olimpiadas - Manhã - POO II\Resources\siria.jpg";
                    break;


            }       
         


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbNaoMostraraBandeira_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNaoMostraraBandeira.Checked)
            {
                pictureBox5.Visible = false;
                 
            }
        }

        private void cbPrata_CheckedChanged(object sender, EventArgs e)
        {
            if(cbPrata.Checked)
            {
                string medalhadeprata = medalhasPrata.ToString();
                rtbPrata.AppendText(medalhadeprata);
            }
            else
            {
                rtbPrata.Text = "";
            }
        }

        private void cbOuro_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOuro.Checked)
            {
                string medalhadeouro = medalhasOuro.ToString();
                rtbOuro.AppendText(medalhadeouro);
            }
            else
            {
                rtbOuro.Text = "";
            }
        }

        private void rtbPrata_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbBronze_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBronze.Checked)
            {
                string medalhadebronze = medalhasBronze.ToString();
                rtbBronze.AppendText(medalhadebronze);
            }
            else
            {
                rtbBronze.Text = "";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string medalhasnototal = medalhasTotal.ToString();
                richTextBox1.AppendText(medalhasnototal);
            }
            else
            {
                richTextBox1.Text = "";
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void rbMostrarBanderias_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMostrarBanderias.Checked)
            {
                pictureBox5.Visible = true;
    
            }
        }

        private void gbMedalhas_Enter(object sender, EventArgs e)
        {

        }
    }
}
