/*  */using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModiAlgoritmasi
{
    public partial class Form1 : Form
    {
        private int Sayac = 0;

        int counter = 0;
        int len = 0;
        string txt;
        int?[] U, V, d;
        int Str = 0, Stn = 0;
        TextBox[,] Matris;
        TextBox[] Arzlar;
        TextBox[] Talepler;
        TextBox[,] KucukKutu;
        Label[] Fabrika;
        Label[] Depo;
        Label Arz;
        Label Talep;
        int[,] BirinciDizi;
        int[,] IkinciDizi;
        Font myfont = new Font("Century Gothic", 12F);

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SeciliBir.Visible = false;
            SeciliIki.Visible = false;
            SeciliUc.Visible = false;
            Metin.Visible = false;
            secilidort.Visible = false;
            ModiAlgoRkran.Visible = false;
            OptimumlukEkrani.Visible = false;
            label2.Visible = false;

            txt = AnaText.Text;
            len = txt.Length;
            AnaText.Text = "";

        }
        private void OptimumlukKontrolu_Click_1(object sender, EventArgs e)
        {
            SeciliBir.Visible = false;
            SeciliIki.Visible = false;
            SeciliUc.Visible = true;
            OptimumlukEkrani.Visible = true;
            Metin.Visible = false;
            AnaEkran.Visible = false;
        }

        private void Ulastirma_Click_1(object sender, EventArgs e)
        {
            SeciliBir.Visible = true;
            SeciliIki.Visible = false;
            SeciliUc.Visible = false;
            AnaEkran.Visible = false;
            AnaText.Visible = false;
            Metin.Visible = true;
            ModiAlgoRkran.Visible = false;
            OptimumlukEkrani.Visible = false;
            Ekran_Temizle();

        }

        private void Modi_Click(object sender, EventArgs e)
        {
            SeciliBir.Visible = false;
            SeciliIki.Visible = true;
            SeciliUc.Visible = false;
            Metin.Visible = false;
            ModiAlgoRkran.Visible = true;
            AnaEkran.Visible = false;
            AnaText.Visible = false;
            OptimumlukEkrani.Visible = false;
            Ekran_Temizle();


        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Sayac++;
            if (Sayac == 6)
            {
                AnaEkran.Enabled = false;
                timer1.Stop();

            }

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            counter++;

            if (counter > len)
            {
                counter = 0;
                AnaText.Text = "";
            }

            else
            {
                AnaText.Text = txt.Substring(0, counter);

                if (AnaText.ForeColor == Color.Black)
                    AnaText.ForeColor = Color.Black;
                else
                    AnaText.ForeColor = Color.Black;
            }

            if (AnaText.Text == "MODİ Algoritması ile Optimumluk Kontrolü")
            {
                timer2.Stop();
            }

        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            Ekran_Temizle();

        }
        private void Ekran_Temizle()
        {
            Satir.Text = "";
            Sutun.Text = "";
            MatrisEkrani.Controls.Clear();
            Degerler.Text = "";
            Cozum.Text = "";
            ZMinDeger.Text = "";
            label2.Visible = false;


        }

        private void HataButonu_Click(object sender, EventArgs e)
        {
            HataMesaji.Visible = false;
        }

        Point Konum = new Point(0, 0);

        private void Hesapla_Click(object sender, EventArgs e)
        {
            MatrisYazimi();
        }

        private void HataButonuIki_Click(object sender, EventArgs e)
        {
            HataMesajiIki.Visible = false;
        }

        private void MatrisOlustur_Click(object sender, EventArgs e)
        {
            if (Satir.Text == "" || Sutun.Text == "")
            {
                HataMesaji.Visible = true;
            }
            else
            {

                Str = Convert.ToInt32(Satir.Text); //Satir bilgisin al
                Stn = Convert.ToInt32(Sutun.Text); //Sutun bilgisini al

                Matris = new TextBox[Str, Stn];
                Arzlar = new TextBox[Str + Stn];
                Talepler = new TextBox[Str + Stn];
                KucukKutu = new TextBox[Str, Stn];
                Fabrika = new Label[Str];
                Depo = new Label[Stn];


                U = new int?[Str];
                V = new int?[Stn];
                d = new int?[Str * Stn];

                BirinciDizi = new int[Str, Stn];
                IkinciDizi = new int[Str, Stn];
                int b = Konum.Y;
                int a = Konum.X + 30;

                //Formdaki Textboxlar oluşturuluyor

                for (int i = 0; i < Str; i++)//Satir
                {
                    a = Konum.X + 10;
                    b = b + 50;

                    for (int j = 0; j < Stn; j++)//Sutun
                    {

                        a = a + 120;

                        Matris[i, j] = new TextBox();
                        //Matris özellikleri 
                        Matris[i, j].BackColor = Color.WhiteSmoke;
                        Matris[i, j].Font = myfont;
                        Matris[i, j].ForeColor = Color.FromArgb(44, 41, 60);
                        Matris[i, j].BorderStyle = BorderStyle.FixedSingle;
                        Matris[i, j].TextAlign = HorizontalAlignment.Center;
                        Matris[i, j].Location = new Point(a, b + 30);
                        Matris[i, j].Width = 60;
                        Matris[i, j].Text = "";
                        MatrisEkrani.Controls.Add(Matris[i, j]);

                        KucukKutu[i, j] = new TextBox();
                        //Kucuk kutu özellikleri
                        KucukKutu[i, j].BackColor = Color.WhiteSmoke;
                        KucukKutu[i, j].Font = myfont;
                        KucukKutu[i, j].ForeColor = Color.FromArgb(44, 41, 60);
                        KucukKutu[i, j].BorderStyle = BorderStyle.FixedSingle;
                        KucukKutu[i, j].TextAlign = HorizontalAlignment.Center;
                        KucukKutu[i, j].Location = new Point(a + 70, b + 30);
                        KucukKutu[i, j].Width = 30;
                        KucukKutu[i, j].Text = "";
                        MatrisEkrani.Controls.Add(KucukKutu[i, j]);


                    }

                    //arz sütunu
                    Arzlar[i] = new TextBox();
                    Arzlar[i].BackColor = Color.WhiteSmoke;
                    Arzlar[i].Font = myfont;
                    Arzlar[i].ForeColor = Color.FromArgb(44, 41, 60);
                    Arzlar[i].BorderStyle = BorderStyle.FixedSingle;
                    Arzlar[i].TextAlign = HorizontalAlignment.Center;
                    Arzlar[i].Location = new Point(a + 120, b + 30);
                    Arzlar[i].Width = 60;
                    Arzlar[i].Text = "";
                    MatrisEkrani.Controls.Add(Arzlar[i]);

                    //Arz yazisi
                    Arz = new Label();
                    Arz.Font = myfont;
                    Arz.Text = "Arz";
                    Arz.ForeColor = Color.Black;
                    Arz.Location = new Point(Arzlar[0].Location.X, Arzlar[0].Location.Y - 35);
                    MatrisEkrani.Controls.Add(Arz);

                    //Fabrika yazisi
                    Fabrika[i] = new Label();
                    Fabrika[i].Font = myfont;
                    Fabrika[i].Text = "P" + (i + 1);
                    Fabrika[i].ForeColor = Color.Black;
                    Fabrika[i].Location = new Point(Matris[i, 0].Location.X - 50, Matris[i, 0].Location.Y);
                    MatrisEkrani.Controls.Add(Fabrika[i]);

                }
                Point top = new Point(0, Arzlar[Str - 1].Location.Y);

                int solKaydir = 130;

                //Talep satiri
                for (int i = 0; i < Stn + 1; i++)
                {


                    Talepler[i] = new TextBox();
                    Talepler[i].BackColor = Color.WhiteSmoke;
                    Talepler[i].Font = myfont;
                    Talepler[i].ForeColor = Color.FromArgb(44, 41, 60);
                    Talepler[i].BorderStyle = BorderStyle.FixedSingle;
                    Talepler[i].TextAlign = HorizontalAlignment.Center;
                    Talepler[i].Left = solKaydir;
                    Talepler[i].Top = top.Y + 50;
                    Talepler[i].Width = 60;
                    Talepler[i].Text = "";
                    MatrisEkrani.Controls.Add(Talepler[i]);

                    solKaydir += 120;

                    Talep = new Label();
                    Talep.Font = myfont;
                    Talep.Text = "Talep";
                    Talep.ForeColor = Color.Black;
                    Talep.Location = new Point(Talepler[0].Location.X - 60, Talepler[0].Location.Y);
                    MatrisEkrani.Controls.Add(Talep);

                }

                for (int i = 0; i < Stn; i++)
                {

                    //Fabrika yazisi
                    Depo[i] = new Label();
                    Depo[i].Font = myfont;
                    Depo[i].Text = "D" + (i + 1);
                    Depo[i].ForeColor = Color.Black;
                    Depo[i].Location = new Point(Matris[0, i].Location.X, Matris[0, i].Location.Y - 35);
                    MatrisEkrani.Controls.Add(Depo[i]);


                }

                DiziDoldur(Str, Stn);

            }

        }
        private void ZMinimumHesaplama()
        {
            int ZMin = 0;
            for (int i = 0; i < Str; i++)
            {
                for (int k = 0; k < Stn; k++)
                {
                    if (IkinciDizi[i, k] != -1)
                    {

                        ZMin += IkinciDizi[i, k] * BirinciDizi[i, k];
                    }
                    ZMinDeger.Text = Convert.ToString(ZMin);
                }
            }
        }

        private void ArzVeTalepToplam()
        {
            int ArzToplam = 0;
            int TalepToplam = 0;
            for (int i = 0; i < Str; i++)
            {
                ArzToplam += Convert.ToInt32(Arzlar[i].Text);
            }
            for (int i = 0; i < Stn; i++)
            {
                TalepToplam += Convert.ToInt32(Talepler[i].Text);
            }

            if (ArzToplam != TalepToplam)
            {
                //HataMesajiIki.Visible = true;
            }
            else
            {

            }

            Talepler[Stn].Text = Convert.ToString(ArzToplam);

        }

        private void OptimumlukHesabi()
        {
            U[0] = 0;


            for (int i = 0; i < Str; i++)
            {
                for (int k = 0; k < Stn; k++)
                {
                    if (IkinciDizi[i, k] != -1)
                    {

                        if (U[i] != null)
                        {
                            V[k] = BirinciDizi[i, k] - U[i];
                        }
                        if (V[k] != null)
                        {
                            U[i] = BirinciDizi[i, k] - V[k];


                        }


                    }
                }


            }

            for (int i = 0; i < Str; i++)
            {
                for (int k = 0; k < Stn; k++)
                {
                    if (IkinciDizi[i, k] != -1)
                    {

                        if (U[i] == null)
                        {
                            U[i] = BirinciDizi[i, k] - V[k];
                        }
                        if (V[k] == null)
                        {
                            V[k] = BirinciDizi[i, k] - U[i];


                        }

                    }
                }


            }


            for (int i = 0; i < Str; i++)
            {
                Degerler.Text = Degerler.Text + " U" + (i + 1) + ":" + U[i] + " ";
            }

            for (int i = 0; i < Stn; i++)
            {
                Degerler.Text = Degerler.Text + " V" + (i + 1) + ":" + V[i] + " ";
            }


            ArzVeTalepToplam();

            int a = 0;

            int NegatifSayi = 0;

            for (int i = 0; i < Str; i++)
            {
                for (int k = 0; k < Stn; k++)
                {
                    if (IkinciDizi[i, k] == -1)
                    {
                        d[a] = BirinciDizi[i, k] - (U[i] + V[k]);
                        if (d[a] < 0)
                        {
                            NegatifSayi++;
                        }
                        a++;
                    }
                }
            }

            for (int i = 0; i < a; i++)
            {
                Degerler.Text = Degerler.Text + " d" + (i + 1) + ":" + d[i] + " ";
            }

            ZMinimumHesaplama();


            if (NegatifSayi > 0)
            {
                Cozum.Text = "Bu çözüm optimum değildir. ";

            }
            else
            {
                Cozum.Text = "Bu çözüm optimumdur.";

            }

        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            secilidort.Visible = true;
            Application.Exit();

        }

        private void MatrisYazimi()
        {

            label2.Visible = true;

            for (int i = 0; i < Str; i++)
            {
                for (int k = 0; k < Stn; k++)
                {

                    if (Convert.ToString(Matris[i, k].Text).Length != 0)
                    {
                        BirinciDizi[i, k] = Convert.ToInt32(Matris[i, k].Text);
                    }
                    else
                    {
                        var LabelHataEksik = new Label();
                        LabelHataEksik.Left = 20;
                        LabelHataEksik.Top = 60;
                        LabelHataEksik.Width = 300;
                        LabelHataEksik.Text = "Eksik matris değerleri girdiniz! Bu şekilde kontrol edemezsiniz.";
                        this.Controls.Add(LabelHataEksik);

                    }
                    if (Convert.ToString(KucukKutu[i, k].Text).Length != 0)
                    {
                        IkinciDizi[i, k] = Convert.ToInt32(KucukKutu[i, k].Text);
                    }
                }
            }


            OptimumlukHesabi();

        }


        private void DiziDoldur(int a, int b)
        {
            for (int i = 0; i < a; i++)
            {
                for (int k = 0; k < b; k++)
                {
                    BirinciDizi[i, k] = -1;
                    IkinciDizi[i, k] = -1;
                }
            }

        }
    }
}

