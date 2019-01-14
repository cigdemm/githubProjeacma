using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Marka> markalar;
        List<Telefon> telefonlar;
        List<Model> modeller;
        private void Form1_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            markalar = db.GetMarka();
            telefonlar = db.GetTelefonlar();
            modeller = db.GetModeller();

        }
 
        private void btnSorgu1_Click(object sender, EventArgs e)
        {
            //1- telefonları üretim yılına göre sıralayalım
            var result = from mdl in modeller
                         select new
                         {
                             TelefonAdi = mdl.ModelAdi,
                             UretimTarihi = mdl.UretimYili.Year
                         };
            dgvBilgiler.DataSource = result.OrderByDescending(y => y.UretimTarihi).ToList();
        }

        private void btnSorgu2_Click(object sender, EventArgs e)
        {
            //2 - Telefonları model ve markalarına göre sayıları ile gösterelim
            var result = from mrk in markalar
                         join tlf in telefonlar on mrk.MarkaID equals tlf.MarkaID
                         group tlf by mrk.MarkaAd 
                         into grp
                         select new
                         {
                             Markası = grp.Key,
                             Sayısı = grp.Count()
                         };

            dgvBilgiler.DataSource = result.ToList();
        }

        private void btnSorgu3_Click(object sender, EventArgs e)
        {
            //3 - 2000 yılından eski telefonların sayısını bulalım
            var result = from mdl in modeller
                         where mdl.UretimYili.Year < 2015
                         select mdl;

            dgvBilgiler.DataSource = result.ToList();
        }

        private void btnSorgu4_Click(object sender, EventArgs e)
        {
            //4-2017 yılından sonra üretilen ve modeli "Apple " olan telefonları listeleyelim
            var result = from mrk in markalar
                         join tlf in telefonlar on mrk.MarkaID equals tlf.MarkaID
                         join mdl in modeller on tlf.ModelID equals mdl.ModelID
                         where mdl.UretimYili.Year > 2017 && mrk.MarkaAd == "Apple"
                         select new
                         {
                             Markasi = mrk.MarkaAd,
                             TelefonAdlari = mdl.ModelAdi,
                             UretimTarih = mdl.UretimYili.Year,
                             Fiyat = mdl.Fiyati
                         };
            dgvBilgiler.DataSource = result.ToList();
        }

        private void btnSorgu5_Click(object sender, EventArgs e)
        {
            //5-Ortalama fiyatın üzerinde olan telefo isimlerini getirelim
            var result = from mdl in modeller
                         select mdl;

            dgvBilgiler.DataSource = result.Where(p => p.Fiyati > result.Average(pr => pr.Fiyati)).ToList(); ;

        }

        private void btnSorgu6_Click(object sender, EventArgs e)
        {
       
            //6 - hafızası 32gb dan büyük,pixeli 15px olan ve 2 yıl önce üretilmiş telefonları getirelim
            var result = from mdl in modeller
                         join tlf in telefonlar on mdl.ModelID equals tlf.ModelID
                         where tlf.HafızaBoyutu == "32 gb" && tlf.KameraMegapixel == "16 mgp" && mdl.UretimYili.Year > DateTime.Now.Year - 5
                         select new
                         {
                             ModelAdi=mdl.ModelAdi,
                         };
            dgvBilgiler.DataSource = result.ToList();

        }
    }
}
